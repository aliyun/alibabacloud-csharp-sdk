// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebPreciseAccessRuleRequest : TeaModel {
        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query all domain names.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The validity period of the rule. Unit: seconds. This parameter takes effect only when **action** of a rule is **block**. Access requests that match the rule are blocked within the specified validity period of the rule. If you do not specify this parameter, this rule takes effect all the time.
        /// </summary>
        [NameInMap("Expires")]
        [Validation(Required=false)]
        public int? Expires { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The settings of the accurate access control rule. This parameter is a JSON string. The following list describes the fields in the value of the parameter:
        /// 
        /// *   **action**: the action that is performed if the rule is matched. This field is required and must be of the string type. Valid values:
        /// 
        ///     *   **accept**: allows the requests that match the rule.
        ///     *   **block**: blocks the requests that match the rule.
        ///     *   **challenge**: implements a CAPTCHA for the requests that match the rule.
        /// 
        /// *   **name**: the name of the rule. This field is required and must be of the string type.
        /// 
        /// *   **condition**: the match conditions. This field is required and must be of the map type. A match condition contains the following parameters.
        /// 
        ///     **
        /// 
        ///     **Note**The AND logical operator is used to define the relationship among multiple match conditions.
        /// 
        ///     *   **field**: the match field. This parameter is required and must be of the string type.
        /// 
        ///     *   **match_method**: the logical relation. This parameter is required and must be of the string type.
        /// 
        ///         **
        /// 
        ///         **Note**For information about the mappings between the **field** and **match_method** parameters, see the Mappings between the field and match_method parameters table in this topic.
        /// 
        ///     *   **content**: the match content. This parameter is required and must be of the string type.
        /// 
        /// *   **header_name**: the HTTP header. This parameter is optional and must be of the string type. This parameter takes effect only when **field** is **header**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

    }

}
