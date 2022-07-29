#!/bin/bash -x

# **************************************************************************$
#  Copyright 2020 VMware, Inc.$
#  SPDX-License-Identifier: Apache-2.0$
# **************************************************************************
SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null 2>&1 && pwd )"

PACKER_BUILDER_TYPE="$1" | tr '[:upper:]' '[:lower:]' # second argument to lower case

pushd $SCRIPT_DIR

echo "Building Script Runtime Service OVA Appliance ..."
rm -rf ./output-vmware-iso

echo "Applying packer build to photon.json ..."
if [ "$PACKER_BUILDER_TYPE" = "vsphere" ];then
	packer build -var-file=photon-builder-vsphere.json -var-file=photon-version.json photon-vsphere.json
else
	packer build -var-file=photon-builder.json -var-file=photon-version.json photon.json
fi

popd
