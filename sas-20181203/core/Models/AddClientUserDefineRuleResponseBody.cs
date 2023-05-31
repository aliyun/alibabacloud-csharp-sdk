// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddClientUserDefineRuleResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The identifier of the custom defense rule.
        /// </summary>
        [NameInMap("UserDefineRuleAddResult")]
        [Validation(Required=false)]
        public AddClientUserDefineRuleResponseBodyUserDefineRuleAddResult UserDefineRuleAddResult { get; set; }
        public class AddClientUserDefineRuleResponseBodyUserDefineRuleAddResult : TeaModel {
            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The type of the operating system. Valid values:
            /// 
            /// *   **windows**: Windows
            /// *   **linux**: Linux
            /// *   **all**: all types
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// The switch ID of the custom defense rule.
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

    }

}
