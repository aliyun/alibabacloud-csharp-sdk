// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetCdnDomainStagingConfigRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. You can specify only one domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The features that you want to configure. Format:
        /// 
        /// > *   **functionName**: The name of the feature. Separate multiple values with commas (,). For more information, see [A list of features](~~388460~~).
        /// >*   **argName**: The feature parameters for **functionName**.
        /// >*   **argValue**: The parameter values set for **functionName**.
        /// 
        ///         [
        ///          {
        ///            "functionArgs": [
        ///             {
        ///              "argName": "Parameter A", 
        ///              "argValue": "Value of Parameter A"
        ///             }, 
        ///           {
        ///             "argName": "Parameter B", 
        ///             "argValue": "Value of Parameter B"
        ///              }
        ///          ], 
        ///          "functionName": "Feature name"
        ///             }
        ///         ]
        /// </summary>
        [NameInMap("Functions")]
        [Validation(Required=false)]
        public string Functions { get; set; }

    }

}
