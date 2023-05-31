// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClientUserDefineRulesResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListClientUserDefineRulesResponseBodyPageInfo PageInfo { get; set; }
        public class ListClientUserDefineRulesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the rules.
        /// </summary>
        [NameInMap("UserDefineRuleList")]
        [Validation(Required=false)]
        public List<ListClientUserDefineRulesResponseBodyUserDefineRuleList> UserDefineRuleList { get; set; }
        public class ListClientUserDefineRulesResponseBodyUserDefineRuleList : TeaModel {
            /// <summary>
            /// The action of the rule. Valid values:
            /// 
            /// *   **0**: allow
            /// *   **1**: block
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
            /// The switch ID of the rule.
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// The type of the rule. Valid values:
            /// 
            /// *   **1**: Process hash
            /// *   **2**: Command line
            /// *   **3**: Process Network
            /// *   **4**: File Read and Write
            /// *   **5**: Operation on Registry
            /// *   **6**: Dynamic-link Library Loading
            /// *   **7**: File Renaming
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
