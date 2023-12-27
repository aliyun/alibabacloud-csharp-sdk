// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchSetDcdnDomainConfigsRequest : TeaModel {
        /// <summary>
        /// The accelerated domain names. Specify multiple accelerated domain names with commas (,).
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// The features that you want to configure. Format:
        /// 
        /// *   **functionName**: The name of the feature. Separate multiple values with commas (,). For more information, see [A list of features](~~410622~~).
        /// 
        /// *   **argName**: The feature parameters for **functionName**.
        /// *   **argValue**: The parameter values set for **functionName**.
        /// 
        /// ````[
        ///  {
        ///    "functionArgs": [
        ///     {
        ///      "argName": "Parameter A", 
        ///      "argValue": Value of parameter A"
        ///     }, 
        ///   {
        ///     "argName": "Parameter B", 
        ///     "argValue": "Value of Parameter B"
        ///      }
        ///  ], 
        ///  "functionName": "Feature name"
        ///     }
        /// ]```
        /// ````
        /// </summary>
        [NameInMap("Functions")]
        [Validation(Required=false)]
        public string Functions { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
