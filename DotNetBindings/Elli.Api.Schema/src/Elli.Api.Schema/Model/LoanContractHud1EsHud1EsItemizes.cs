/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Schema
 *
 * Represents schema operations on Loan.
 *
 * OpenAPI spec version: 1.4.0
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
using SwaggerDateConverter = Elli.Api.Schema.Client.SwaggerDateConverter;

namespace Elli.Api.Schema.Model
{
    /// <summary>
    /// LoanContractHud1EsHud1EsItemizes
    /// </summary>
    [DataContract]
    public partial class LoanContractHud1EsHud1EsItemizes :  IEquatable<LoanContractHud1EsHud1EsItemizes>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets EscrowPaymentBalance
        /// </summary>
        [DataMember(Name="escrowPaymentBalance", EmitDefaultValue=false)]
        public double? EscrowPaymentBalance { get; set; }

        /// <summary>
        /// Gets or Sets EscrowPaymentDescription
        /// </summary>
        [DataMember(Name="escrowPaymentDescription", EmitDefaultValue=false)]
        public string EscrowPaymentDescription { get; set; }

        /// <summary>
        /// Gets or Sets EscrowPaymentFrom
        /// </summary>
        [DataMember(Name="escrowPaymentFrom", EmitDefaultValue=false)]
        public double? EscrowPaymentFrom { get; set; }

        /// <summary>
        /// Gets or Sets EscrowPaymentTo
        /// </summary>
        [DataMember(Name="escrowPaymentTo", EmitDefaultValue=false)]
        public double? EscrowPaymentTo { get; set; }

        /// <summary>
        /// Gets or Sets Hud1EsItemizeIndex
        /// </summary>
        [DataMember(Name="hud1EsItemizeIndex", EmitDefaultValue=false)]
        public int? Hud1EsItemizeIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractHud1EsHud1EsItemizes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  EscrowPaymentBalance: ").Append(EscrowPaymentBalance).Append("\n");
            sb.Append("  EscrowPaymentDescription: ").Append(EscrowPaymentDescription).Append("\n");
            sb.Append("  EscrowPaymentFrom: ").Append(EscrowPaymentFrom).Append("\n");
            sb.Append("  EscrowPaymentTo: ").Append(EscrowPaymentTo).Append("\n");
            sb.Append("  Hud1EsItemizeIndex: ").Append(Hud1EsItemizeIndex).Append("\n");
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
            return this.Equals(input as LoanContractHud1EsHud1EsItemizes);
        }

        /// <summary>
        /// Returns true if LoanContractHud1EsHud1EsItemizes instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractHud1EsHud1EsItemizes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractHud1EsHud1EsItemizes input)
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
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.EscrowPaymentBalance == input.EscrowPaymentBalance ||
                    (this.EscrowPaymentBalance != null &&
                    this.EscrowPaymentBalance.Equals(input.EscrowPaymentBalance))
                ) && 
                (
                    this.EscrowPaymentDescription == input.EscrowPaymentDescription ||
                    (this.EscrowPaymentDescription != null &&
                    this.EscrowPaymentDescription.Equals(input.EscrowPaymentDescription))
                ) && 
                (
                    this.EscrowPaymentFrom == input.EscrowPaymentFrom ||
                    (this.EscrowPaymentFrom != null &&
                    this.EscrowPaymentFrom.Equals(input.EscrowPaymentFrom))
                ) && 
                (
                    this.EscrowPaymentTo == input.EscrowPaymentTo ||
                    (this.EscrowPaymentTo != null &&
                    this.EscrowPaymentTo.Equals(input.EscrowPaymentTo))
                ) && 
                (
                    this.Hud1EsItemizeIndex == input.Hud1EsItemizeIndex ||
                    (this.Hud1EsItemizeIndex != null &&
                    this.Hud1EsItemizeIndex.Equals(input.Hud1EsItemizeIndex))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.EscrowPaymentBalance != null)
                    hashCode = hashCode * 59 + this.EscrowPaymentBalance.GetHashCode();
                if (this.EscrowPaymentDescription != null)
                    hashCode = hashCode * 59 + this.EscrowPaymentDescription.GetHashCode();
                if (this.EscrowPaymentFrom != null)
                    hashCode = hashCode * 59 + this.EscrowPaymentFrom.GetHashCode();
                if (this.EscrowPaymentTo != null)
                    hashCode = hashCode * 59 + this.EscrowPaymentTo.GetHashCode();
                if (this.Hud1EsItemizeIndex != null)
                    hashCode = hashCode * 59 + this.Hud1EsItemizeIndex.GetHashCode();
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