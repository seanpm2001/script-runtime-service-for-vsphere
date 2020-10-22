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
    /// Specification for DNS related configurations in resolver configuration file (&#x60;resolv.conf&#x60;).
    /// </summary>
    [DataContract]
    public partial class TaskSpecContainerSpecDNSConfig :  IEquatable<TaskSpecContainerSpecDNSConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSpecContainerSpecDNSConfig" /> class.
        /// </summary>
        /// <param name="nameservers">The IP addresses of the name servers..</param>
        /// <param name="search">A search list for host-name lookup..</param>
        /// <param name="options">A list of internal resolver variables to be modified (e.g., &#x60;debug&#x60;, &#x60;ndots:3&#x60;, etc.)..</param>
        public TaskSpecContainerSpecDNSConfig(List<string> nameservers = default(List<string>), List<string> search = default(List<string>), List<string> options = default(List<string>))
        {
            this.Nameservers = nameservers;
            this.Search = search;
            this.Options = options;
        }
        
        /// <summary>
        /// The IP addresses of the name servers.
        /// </summary>
        /// <value>The IP addresses of the name servers.</value>
        [DataMember(Name="Nameservers", EmitDefaultValue=false)]
        public List<string> Nameservers { get; set; }

        /// <summary>
        /// A search list for host-name lookup.
        /// </summary>
        /// <value>A search list for host-name lookup.</value>
        [DataMember(Name="Search", EmitDefaultValue=false)]
        public List<string> Search { get; set; }

        /// <summary>
        /// A list of internal resolver variables to be modified (e.g., &#x60;debug&#x60;, &#x60;ndots:3&#x60;, etc.).
        /// </summary>
        /// <value>A list of internal resolver variables to be modified (e.g., &#x60;debug&#x60;, &#x60;ndots:3&#x60;, etc.).</value>
        [DataMember(Name="Options", EmitDefaultValue=false)]
        public List<string> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskSpecContainerSpecDNSConfig {\n");
            sb.Append("  Nameservers: ").Append(Nameservers).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as TaskSpecContainerSpecDNSConfig);
        }

        /// <summary>
        /// Returns true if TaskSpecContainerSpecDNSConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskSpecContainerSpecDNSConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskSpecContainerSpecDNSConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nameservers == input.Nameservers ||
                    this.Nameservers != null &&
                    this.Nameservers.SequenceEqual(input.Nameservers)
                ) && 
                (
                    this.Search == input.Search ||
                    this.Search != null &&
                    this.Search.SequenceEqual(input.Search)
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.Nameservers != null)
                    hashCode = hashCode * 59 + this.Nameservers.GetHashCode();
                if (this.Search != null)
                    hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
