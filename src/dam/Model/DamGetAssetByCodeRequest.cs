/*
 * Dam Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = dam.Client.OpenAPIDateConverter;

namespace dam.Model
{
    /// <summary>
    /// DamGetAssetByCodeRequest
    /// </summary>
    [DataContract(Name = "damGetAssetByCodeRequest")]
    public partial class DamGetAssetByCodeRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DamGetAssetByCodeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DamGetAssetByCodeRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DamGetAssetByCodeRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="code">code (required).</param>
        public DamGetAssetByCodeRequest(string tenantId = default(string), string code = default(string))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for DamGetAssetByCodeRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for DamGetAssetByCodeRequest and cannot be null");
            }
            this.Code = code;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DamGetAssetByCodeRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
