/* 
 * Brainrex API Explorer
 *
 * Welcome to the Brainrex API explorer, we make analytics tools for crypto and blockchain. Our currently propiertary models offer sentiment analysis, market making, blockchain monitoring and face-id verification. This AI models can be consumed from this API. We also offer integrations to open data and propietary data providers, as well as free test data we collect. There is a collection of data transformation tools. Join our Telegram group to get the latest news and ask questions [https://t.me/brainrex, #brainrex](https://t.me/brainrex). More about Brainrex at [https://brainrex.com](http://brainrex.com). Full Documentation can be found at [https://brainrexapi.github.io/docs](https://brainrexapi.github.io/docs)
 *
 * OpenAPI spec version: 0.1.1
 * Contact: support@brainrex.com
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// InlineResponse201
    /// </summary>
    [DataContract]
    public partial class InlineResponse201 :  IEquatable<InlineResponse201>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse201" /> class.
        /// </summary>
        /// <param name="startDate">Start date in YYYY/MM/DD.</param>
        /// <param name="endDate">End date in YYYY/MM/DD.</param>
        /// <param name="open">Opening price quote of the time frame with two decimal points.</param>
        /// <param name="close">Closing price quote of the time frame with two decimal points.</param>
        /// <param name="high">Highest price of the time frame with two decimal points.</param>
        /// <param name="vol">Volume of currency exchanged in the time frame with two decimal points.</param>
        public InlineResponse201(DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), float? open = default(float?), float? close = default(float?), float? high = default(float?), float? vol = default(float?))
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Open = open;
            this.Close = close;
            this.High = high;
            this.Vol = vol;
        }
        
        /// <summary>
        /// Start date in YYYY/MM/DD
        /// </summary>
        /// <value>Start date in YYYY/MM/DD</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date in YYYY/MM/DD
        /// </summary>
        /// <value>End date in YYYY/MM/DD</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Opening price quote of the time frame with two decimal points
        /// </summary>
        /// <value>Opening price quote of the time frame with two decimal points</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public float? Open { get; set; }

        /// <summary>
        /// Closing price quote of the time frame with two decimal points
        /// </summary>
        /// <value>Closing price quote of the time frame with two decimal points</value>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public float? Close { get; set; }

        /// <summary>
        /// Highest price of the time frame with two decimal points
        /// </summary>
        /// <value>Highest price of the time frame with two decimal points</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public float? High { get; set; }

        /// <summary>
        /// Volume of currency exchanged in the time frame with two decimal points
        /// </summary>
        /// <value>Volume of currency exchanged in the time frame with two decimal points</value>
        [DataMember(Name="vol", EmitDefaultValue=false)]
        public float? Vol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse201 {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Vol: ").Append(Vol).Append("\n");
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
            return this.Equals(input as InlineResponse201);
        }

        /// <summary>
        /// Returns true if InlineResponse201 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse201 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse201 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) && 
                (
                    this.Close == input.Close ||
                    (this.Close != null &&
                    this.Close.Equals(input.Close))
                ) && 
                (
                    this.High == input.High ||
                    (this.High != null &&
                    this.High.Equals(input.High))
                ) && 
                (
                    this.Vol == input.Vol ||
                    (this.Vol != null &&
                    this.Vol.Equals(input.Vol))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.Close != null)
                    hashCode = hashCode * 59 + this.Close.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Vol != null)
                    hashCode = hashCode * 59 + this.Vol.GetHashCode();
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
