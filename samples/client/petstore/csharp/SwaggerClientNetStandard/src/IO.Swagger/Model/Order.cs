/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Order
    /// </summary>
    [DataContract]
    public partial class Order :  IEquatable<Order>
    {
        /// <summary>
        /// Order Status
        /// </summary>
        /// <value>Order Status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Placed for value: placed
            /// </summary>
            [EnumMember(Value = "placed")]
            Placed = 1,
            
            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 2,
            
            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered = 3
        }

        /// <summary>
        /// Order Status
        /// </summary>
        /// <value>Order Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="PetId">PetId.</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="ShipDate">ShipDate.</param>
        /// <param name="Status">Order Status.</param>
        /// <param name="Complete">Complete (default to false).</param>
        public Order(long? Id = default(long?), long? PetId = default(long?), int? Quantity = default(int?), DateTime? ShipDate = default(DateTime?), StatusEnum? Status = default(StatusEnum?), bool? Complete = false)
        {
            this.Id = Id;
            this.PetId = PetId;
            this.Quantity = Quantity;
            this.ShipDate = ShipDate;
            this.Status = Status;
            // use default value if no "Complete" provided
            if (Complete == null)
            {
                this.Complete = false;
            }
            else
            {
                this.Complete = Complete;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets PetId
        /// </summary>
        [DataMember(Name="petId", EmitDefaultValue=false)]
        public long? PetId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets ShipDate
        /// </summary>
        [DataMember(Name="shipDate", EmitDefaultValue=false)]
        public DateTime? ShipDate { get; set; }


        /// <summary>
        /// Gets or Sets Complete
        /// </summary>
        [DataMember(Name="complete", EmitDefaultValue=false)]
        public bool? Complete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PetId: ").Append(PetId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="input">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PetId == input.PetId ||
                    (this.PetId != null &&
                    this.PetId.Equals(input.PetId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.ShipDate == input.ShipDate ||
                    (this.ShipDate != null &&
                    this.ShipDate.Equals(input.ShipDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Complete == input.Complete ||
                    (this.Complete != null &&
                    this.Complete.Equals(input.Complete))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PetId != null)
                    hashCode = hashCode * 59 + this.PetId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.ShipDate != null)
                    hashCode = hashCode * 59 + this.ShipDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Complete != null)
                    hashCode = hashCode * 59 + this.Complete.GetHashCode();
                return hashCode;
            }
        }
    }

}
