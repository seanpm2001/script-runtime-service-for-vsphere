/* 
 * Docker Engine API
 *
 * The Engine API is an HTTP API served by Docker Engine. It is the API the Docker client uses to communicate with the Engine, so everything the Docker client can do can be done with the API.  Most of the client's commands map directly to API endpoints (e.g. `docker ps` is `GET /containers/json`). The notable exception is running containers, which consists of several API calls.  # Errors  The API uses standard HTTP status codes to indicate the success or failure of the API call. The body of the response will be JSON in the following format:  ``` {   \"message\": \"page not found\" } ```  # Versioning  The API is usually changed in each release, so API calls are versioned to ensure that clients don't break. To lock to a specific version of the API, you prefix the URL with its version, for example, call `/v1.30/info` to use the v1.30 version of the `/info` endpoint. If the API version specified in the URL is not supported by the daemon, a HTTP `400 Bad Request` error message is returned.  If you omit the version-prefix, the current version of the API (v1.39) is used. For example, calling `/info` is the same as calling `/v1.39/info`. Using the API without a version-prefix is deprecated and will be removed in a future release.  Engine releases in the near future should support this version of the API, so your client will continue to work even if it is talking to a newer Engine.  The API uses an open schema model, which means server may add extra properties to responses. Likewise, the server will ignore any extra query parameters and request body properties. When you write clients, you need to ignore additional properties in responses to ensure they do not break when talking to newer daemons.   # Authentication  Authentication for registries is handled client side. The client has to send authentication details to various endpoints that need to communicate with registries, such as `POST /images/(name)/push`. These are sent as `X-Registry-Auth` header as a Base64 encoded (JSON) string with the following structure:  ``` {   \"username\": \"string\",   \"password\": \"string\",   \"email\": \"string\",   \"serveraddress\": \"string\" } ```  The `serveraddress` is a domain/IP without a protocol. Throughout this structure, double quotes are required.  If you have already got an identity token from the [`/auth` endpoint](#operation/SystemAuth), you can just pass this instead of credentials:  ``` {   \"identitytoken\": \"9cbaf023786cd7...\" } ``` 
 *
 * OpenAPI spec version: 1.39
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = VMware.ScriptRuntimeService.Docker.Bindings.Client.SwaggerDateConverter;

namespace VMware.ScriptRuntimeService.Docker.Bindings.Model
{
    /// <summary>
    /// Container spec for the service.  &lt;p&gt;&lt;br /&gt;&lt;/p&gt;  &gt; **Note**: ContainerSpec, NetworkAttachmentSpec, and PluginSpec are &gt; mutually exclusive. PluginSpec is only used when the Runtime field &gt; is set to &#x60;plugin&#x60;. NetworkAttachmentSpec is used when the Runtime &gt; field is set to &#x60;attachment&#x60;. 
    /// </summary>
    [DataContract]
    public partial class TaskSpecContainerSpec :  IEquatable<TaskSpecContainerSpec>, IValidatableObject
    {
        /// <summary>
        /// Isolation technology of the containers running the service. (Windows only)
        /// </summary>
        /// <value>Isolation technology of the containers running the service. (Windows only)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IsolationEnum
        {
            
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,
            
            /// <summary>
            /// Enum Process for value: process
            /// </summary>
            [EnumMember(Value = "process")]
            Process = 2,
            
            /// <summary>
            /// Enum Hyperv for value: hyperv
            /// </summary>
            [EnumMember(Value = "hyperv")]
            Hyperv = 3
        }

        /// <summary>
        /// Isolation technology of the containers running the service. (Windows only)
        /// </summary>
        /// <value>Isolation technology of the containers running the service. (Windows only)</value>
        [DataMember(Name="Isolation", EmitDefaultValue=false)]
        public IsolationEnum? Isolation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSpecContainerSpec" /> class.
        /// </summary>
        /// <param name="image">The image name to use for the container.</param>
        /// <param name="labels">User-defined key/value data..</param>
        /// <param name="command">The command to be run in the image..</param>
        /// <param name="args">Arguments to the command..</param>
        /// <param name="hostname">The hostname to use for the container, as a valid RFC 1123 hostname..</param>
        /// <param name="env">A list of environment variables in the form &#x60;VAR&#x3D;value&#x60;..</param>
        /// <param name="dir">The working directory for commands to run in..</param>
        /// <param name="user">The user inside the container..</param>
        /// <param name="groups">A list of additional groups that the container process will run as..</param>
        /// <param name="privileges">privileges.</param>
        /// <param name="tTY">Whether a pseudo-TTY should be allocated..</param>
        /// <param name="openStdin">Open &#x60;stdin&#x60;.</param>
        /// <param name="readOnly">Mount the container&#39;s root filesystem as read only..</param>
        /// <param name="mounts">Specification for mounts to be added to containers created as part of the service..</param>
        /// <param name="stopSignal">Signal to stop the container..</param>
        /// <param name="stopGracePeriod">Amount of time to wait for the container to terminate before forcefully killing it..</param>
        /// <param name="healthCheck">healthCheck.</param>
        /// <param name="hosts">A list of hostname/IP mappings to add to the container&#39;s &#x60;hosts&#x60; file. The format of extra hosts is specified in the [hosts(5)](http://man7.org/linux/man-pages/man5/hosts.5.html) man page:      IP_address canonical_hostname [aliases...] .</param>
        /// <param name="dNSConfig">dNSConfig.</param>
        /// <param name="secrets">Secrets contains references to zero or more secrets that will be exposed to the service..</param>
        /// <param name="configs">Configs contains references to zero or more configs that will be exposed to the service..</param>
        /// <param name="isolation">Isolation technology of the containers running the service. (Windows only).</param>
        /// <param name="init">Run an init inside the container that forwards signals and reaps processes. This field is omitted if empty, and the default (as configured on the daemon) is used..</param>
        public TaskSpecContainerSpec(string image = default(string), Dictionary<string, string> labels = default(Dictionary<string, string>), List<string> command = default(List<string>), List<string> args = default(List<string>), string hostname = default(string), List<string> env = default(List<string>), string dir = default(string), string user = default(string), List<string> groups = default(List<string>), TaskSpecContainerSpecPrivileges privileges = default(TaskSpecContainerSpecPrivileges), bool? tTY = default(bool?), bool? openStdin = default(bool?), bool? readOnly = default(bool?), List<Mount> mounts = default(List<Mount>), string stopSignal = default(string), long? stopGracePeriod = default(long?), HealthConfig healthCheck = default(HealthConfig), List<string> hosts = default(List<string>), TaskSpecContainerSpecDNSConfig dNSConfig = default(TaskSpecContainerSpecDNSConfig), List<TaskSpecContainerSpecSecrets> secrets = default(List<TaskSpecContainerSpecSecrets>), List<TaskSpecContainerSpecConfigs> configs = default(List<TaskSpecContainerSpecConfigs>), IsolationEnum? isolation = default(IsolationEnum?), bool? init = default(bool?))
        {
            this.Image = image;
            this.Labels = labels;
            this.Command = command;
            this.Args = args;
            this.Hostname = hostname;
            this.Env = env;
            this.Dir = dir;
            this.User = user;
            this.Groups = groups;
            this.Privileges = privileges;
            this.TTY = tTY;
            this.OpenStdin = openStdin;
            this.ReadOnly = readOnly;
            this.Mounts = mounts;
            this.StopSignal = stopSignal;
            this.StopGracePeriod = stopGracePeriod;
            this.HealthCheck = healthCheck;
            this.Hosts = hosts;
            this.DNSConfig = dNSConfig;
            this.Secrets = secrets;
            this.Configs = configs;
            this.Isolation = isolation;
            this.Init = init;
        }
        
        /// <summary>
        /// The image name to use for the container
        /// </summary>
        /// <value>The image name to use for the container</value>
        [DataMember(Name="Image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// User-defined key/value data.
        /// </summary>
        /// <value>User-defined key/value data.</value>
        [DataMember(Name="Labels", EmitDefaultValue=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The command to be run in the image.
        /// </summary>
        /// <value>The command to be run in the image.</value>
        [DataMember(Name="Command", EmitDefaultValue=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// Arguments to the command.
        /// </summary>
        /// <value>Arguments to the command.</value>
        [DataMember(Name="Args", EmitDefaultValue=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// The hostname to use for the container, as a valid RFC 1123 hostname.
        /// </summary>
        /// <value>The hostname to use for the container, as a valid RFC 1123 hostname.</value>
        [DataMember(Name="Hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// A list of environment variables in the form &#x60;VAR&#x3D;value&#x60;.
        /// </summary>
        /// <value>A list of environment variables in the form &#x60;VAR&#x3D;value&#x60;.</value>
        [DataMember(Name="Env", EmitDefaultValue=false)]
        public List<string> Env { get; set; }

        /// <summary>
        /// The working directory for commands to run in.
        /// </summary>
        /// <value>The working directory for commands to run in.</value>
        [DataMember(Name="Dir", EmitDefaultValue=false)]
        public string Dir { get; set; }

        /// <summary>
        /// The user inside the container.
        /// </summary>
        /// <value>The user inside the container.</value>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// A list of additional groups that the container process will run as.
        /// </summary>
        /// <value>A list of additional groups that the container process will run as.</value>
        [DataMember(Name="Groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// Gets or Sets Privileges
        /// </summary>
        [DataMember(Name="Privileges", EmitDefaultValue=false)]
        public TaskSpecContainerSpecPrivileges Privileges { get; set; }

        /// <summary>
        /// Whether a pseudo-TTY should be allocated.
        /// </summary>
        /// <value>Whether a pseudo-TTY should be allocated.</value>
        [DataMember(Name="TTY", EmitDefaultValue=false)]
        public bool? TTY { get; set; }

        /// <summary>
        /// Open &#x60;stdin&#x60;
        /// </summary>
        /// <value>Open &#x60;stdin&#x60;</value>
        [DataMember(Name="OpenStdin", EmitDefaultValue=false)]
        public bool? OpenStdin { get; set; }

        /// <summary>
        /// Mount the container&#39;s root filesystem as read only.
        /// </summary>
        /// <value>Mount the container&#39;s root filesystem as read only.</value>
        [DataMember(Name="ReadOnly", EmitDefaultValue=false)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Specification for mounts to be added to containers created as part of the service.
        /// </summary>
        /// <value>Specification for mounts to be added to containers created as part of the service.</value>
        [DataMember(Name="Mounts", EmitDefaultValue=false)]
        public List<Mount> Mounts { get; set; }

        /// <summary>
        /// Signal to stop the container.
        /// </summary>
        /// <value>Signal to stop the container.</value>
        [DataMember(Name="StopSignal", EmitDefaultValue=false)]
        public string StopSignal { get; set; }

        /// <summary>
        /// Amount of time to wait for the container to terminate before forcefully killing it.
        /// </summary>
        /// <value>Amount of time to wait for the container to terminate before forcefully killing it.</value>
        [DataMember(Name="StopGracePeriod", EmitDefaultValue=false)]
        public long? StopGracePeriod { get; set; }

        /// <summary>
        /// Gets or Sets HealthCheck
        /// </summary>
        [DataMember(Name="HealthCheck", EmitDefaultValue=false)]
        public HealthConfig HealthCheck { get; set; }

        /// <summary>
        /// A list of hostname/IP mappings to add to the container&#39;s &#x60;hosts&#x60; file. The format of extra hosts is specified in the [hosts(5)](http://man7.org/linux/man-pages/man5/hosts.5.html) man page:      IP_address canonical_hostname [aliases...] 
        /// </summary>
        /// <value>A list of hostname/IP mappings to add to the container&#39;s &#x60;hosts&#x60; file. The format of extra hosts is specified in the [hosts(5)](http://man7.org/linux/man-pages/man5/hosts.5.html) man page:      IP_address canonical_hostname [aliases...] </value>
        [DataMember(Name="Hosts", EmitDefaultValue=false)]
        public List<string> Hosts { get; set; }

        /// <summary>
        /// Gets or Sets DNSConfig
        /// </summary>
        [DataMember(Name="DNSConfig", EmitDefaultValue=false)]
        public TaskSpecContainerSpecDNSConfig DNSConfig { get; set; }

        /// <summary>
        /// Secrets contains references to zero or more secrets that will be exposed to the service.
        /// </summary>
        /// <value>Secrets contains references to zero or more secrets that will be exposed to the service.</value>
        [DataMember(Name="Secrets", EmitDefaultValue=false)]
        public List<TaskSpecContainerSpecSecrets> Secrets { get; set; }

        /// <summary>
        /// Configs contains references to zero or more configs that will be exposed to the service.
        /// </summary>
        /// <value>Configs contains references to zero or more configs that will be exposed to the service.</value>
        [DataMember(Name="Configs", EmitDefaultValue=false)]
        public List<TaskSpecContainerSpecConfigs> Configs { get; set; }


        /// <summary>
        /// Run an init inside the container that forwards signals and reaps processes. This field is omitted if empty, and the default (as configured on the daemon) is used.
        /// </summary>
        /// <value>Run an init inside the container that forwards signals and reaps processes. This field is omitted if empty, and the default (as configured on the daemon) is used.</value>
        [DataMember(Name="Init", EmitDefaultValue=false)]
        public bool? Init { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskSpecContainerSpec {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Env: ").Append(Env).Append("\n");
            sb.Append("  Dir: ").Append(Dir).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Privileges: ").Append(Privileges).Append("\n");
            sb.Append("  TTY: ").Append(TTY).Append("\n");
            sb.Append("  OpenStdin: ").Append(OpenStdin).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  Mounts: ").Append(Mounts).Append("\n");
            sb.Append("  StopSignal: ").Append(StopSignal).Append("\n");
            sb.Append("  StopGracePeriod: ").Append(StopGracePeriod).Append("\n");
            sb.Append("  HealthCheck: ").Append(HealthCheck).Append("\n");
            sb.Append("  Hosts: ").Append(Hosts).Append("\n");
            sb.Append("  DNSConfig: ").Append(DNSConfig).Append("\n");
            sb.Append("  Secrets: ").Append(Secrets).Append("\n");
            sb.Append("  Configs: ").Append(Configs).Append("\n");
            sb.Append("  Isolation: ").Append(Isolation).Append("\n");
            sb.Append("  Init: ").Append(Init).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskSpecContainerSpec);
        }

        /// <summary>
        /// Returns true if TaskSpecContainerSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskSpecContainerSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskSpecContainerSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Command == input.Command ||
                    this.Command != null &&
                    this.Command.SequenceEqual(input.Command)
                ) && 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    this.Args.SequenceEqual(input.Args)
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.Env == input.Env ||
                    this.Env != null &&
                    this.Env.SequenceEqual(input.Env)
                ) && 
                (
                    this.Dir == input.Dir ||
                    (this.Dir != null &&
                    this.Dir.Equals(input.Dir))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Privileges == input.Privileges ||
                    (this.Privileges != null &&
                    this.Privileges.Equals(input.Privileges))
                ) && 
                (
                    this.TTY == input.TTY ||
                    (this.TTY != null &&
                    this.TTY.Equals(input.TTY))
                ) && 
                (
                    this.OpenStdin == input.OpenStdin ||
                    (this.OpenStdin != null &&
                    this.OpenStdin.Equals(input.OpenStdin))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.Mounts == input.Mounts ||
                    this.Mounts != null &&
                    this.Mounts.SequenceEqual(input.Mounts)
                ) && 
                (
                    this.StopSignal == input.StopSignal ||
                    (this.StopSignal != null &&
                    this.StopSignal.Equals(input.StopSignal))
                ) && 
                (
                    this.StopGracePeriod == input.StopGracePeriod ||
                    (this.StopGracePeriod != null &&
                    this.StopGracePeriod.Equals(input.StopGracePeriod))
                ) && 
                (
                    this.HealthCheck == input.HealthCheck ||
                    (this.HealthCheck != null &&
                    this.HealthCheck.Equals(input.HealthCheck))
                ) && 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    this.Hosts.SequenceEqual(input.Hosts)
                ) && 
                (
                    this.DNSConfig == input.DNSConfig ||
                    (this.DNSConfig != null &&
                    this.DNSConfig.Equals(input.DNSConfig))
                ) && 
                (
                    this.Secrets == input.Secrets ||
                    this.Secrets != null &&
                    this.Secrets.SequenceEqual(input.Secrets)
                ) && 
                (
                    this.Configs == input.Configs ||
                    this.Configs != null &&
                    this.Configs.SequenceEqual(input.Configs)
                ) && 
                (
                    this.Isolation == input.Isolation ||
                    (this.Isolation != null &&
                    this.Isolation.Equals(input.Isolation))
                ) && 
                (
                    this.Init == input.Init ||
                    (this.Init != null &&
                    this.Init.Equals(input.Init))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.Env != null)
                    hashCode = hashCode * 59 + this.Env.GetHashCode();
                if (this.Dir != null)
                    hashCode = hashCode * 59 + this.Dir.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Privileges != null)
                    hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                if (this.TTY != null)
                    hashCode = hashCode * 59 + this.TTY.GetHashCode();
                if (this.OpenStdin != null)
                    hashCode = hashCode * 59 + this.OpenStdin.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.Mounts != null)
                    hashCode = hashCode * 59 + this.Mounts.GetHashCode();
                if (this.StopSignal != null)
                    hashCode = hashCode * 59 + this.StopSignal.GetHashCode();
                if (this.StopGracePeriod != null)
                    hashCode = hashCode * 59 + this.StopGracePeriod.GetHashCode();
                if (this.HealthCheck != null)
                    hashCode = hashCode * 59 + this.HealthCheck.GetHashCode();
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.DNSConfig != null)
                    hashCode = hashCode * 59 + this.DNSConfig.GetHashCode();
                if (this.Secrets != null)
                    hashCode = hashCode * 59 + this.Secrets.GetHashCode();
                if (this.Configs != null)
                    hashCode = hashCode * 59 + this.Configs.GetHashCode();
                if (this.Isolation != null)
                    hashCode = hashCode * 59 + this.Isolation.GetHashCode();
                if (this.Init != null)
                    hashCode = hashCode * 59 + this.Init.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
