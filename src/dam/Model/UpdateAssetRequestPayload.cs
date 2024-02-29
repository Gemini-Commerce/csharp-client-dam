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
    /// UpdateAssetRequestPayload
    /// </summary>
    [DataContract(Name = "UpdateAssetRequestPayload")]
    public partial class UpdateAssetRequestPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetRequestPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAssetRequestPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetRequestPayload" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="origin">origin (required).</param>
        /// <param name="metadata">metadata.</param>
        public UpdateAssetRequestPayload(string code = default(string), DamAssetOrigin origin = default(DamAssetOrigin), List<AssetMetadata> metadata = default(List<AssetMetadata>))
        {
            // to ensure "origin" is required (not null)
            if (origin == null)
            {
                throw new ArgumentNullException("origin is a required property for UpdateAssetRequestPayload and cannot be null");
            }
            this.Origin = origin;
            this.Code = code;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name = "origin", IsRequired = true, EmitDefaultValue = true)]
        public DamAssetOrigin Origin { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public List<AssetMetadata> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateAssetRequestPayload {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
