// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAegisContainerPluginRuleRequest : TeaModel {
        /// <summary>
        /// The ID of the defense rule against container escapes.
        /// 
        /// >  You can call the [ListAegisContainerPluginRule](~~ListAegisContainerPluginRule~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The type of the rule. Valid values:
        /// 
        /// *   **0**: custom rule
        /// *   **1**: system rule
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

    }

}
