// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInterceptionRulePageResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of information about the defense rules.
        /// </summary>
        [NameInMap("InterceptionRuleList")]
        [Validation(Required=false)]
        public List<ListInterceptionRulePageResponseBodyInterceptionRuleList> InterceptionRuleList { get; set; }
        public class ListInterceptionRulePageResponseBodyInterceptionRuleList : TeaModel {
            /// <summary>
            /// The destination network object.
            /// </summary>
            [NameInMap("DstTarget")]
            [Validation(Required=false)]
            public ListInterceptionRulePageResponseBodyInterceptionRuleListDstTarget DstTarget { get; set; }
            public class ListInterceptionRulePageResponseBodyInterceptionRuleListDstTarget : TeaModel {
                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// An array that consists of the affected images.
                /// </summary>
                [NameInMap("ImageList")]
                [Validation(Required=false)]
                public List<string> ImageList { get; set; }

                /// <summary>
                /// The namespace.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// An array that consists of information about the ports used by the destination server.
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<string> Ports { get; set; }

                /// <summary>
                /// The type of the defense rule. Valid values:
                /// 
                /// *   **suggest**: intelligently recommended rule
                /// *   **customize**: custom rule
                /// *   **system**: system rule
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// An array that consists of tags added to the destination network object.
                /// </summary>
                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<string> TagList { get; set; }

                /// <summary>
                /// The ID of the network object.
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public int? TargetId { get; set; }

                /// <summary>
                /// The name of the network object.
                /// </summary>
                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                /// <summary>
                /// The type of the network object.
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// The interception mode. Valid values:
            /// 
            /// *   **0**: monitor
            /// *   **1**: block
            /// *   **2**: alert
            /// *   **3**: allow
            /// </summary>
            [NameInMap("InterceptType")]
            [Validation(Required=false)]
            public long? InterceptType { get; set; }

            /// <summary>
            /// The order in which the entries are sorted.
            /// </summary>
            [NameInMap("OrderIndex")]
            [Validation(Required=false)]
            public long? OrderIndex { get; set; }

            /// <summary>
            /// The ID of the defense rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// The name of the defense rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The status of the defense rule. Valid values:
            /// 
            /// *   **1**: enabled
            /// *   **0**: disabled
            /// </summary>
            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public int? RuleSwitch { get; set; }

            /// <summary>
            /// The type of the defense rule.
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// The source network object.
            /// </summary>
            [NameInMap("SrcTarget")]
            [Validation(Required=false)]
            public ListInterceptionRulePageResponseBodyInterceptionRuleListSrcTarget SrcTarget { get; set; }
            public class ListInterceptionRulePageResponseBodyInterceptionRuleListSrcTarget : TeaModel {
                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// An array that consists of the images of the network object.
                /// </summary>
                [NameInMap("ImageList")]
                [Validation(Required=false)]
                public List<string> ImageList { get; set; }

                /// <summary>
                /// The namespace.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The type of the defense rule. Valid values:
                /// 
                /// *   **suggest**: intelligently recommended rule
                /// *   **customize**: custom rule
                /// *   **system**: system rule
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// An array that consists of tags added to the source network object.
                /// </summary>
                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<string> TagList { get; set; }

                /// <summary>
                /// The ID of the network object.
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public int? TargetId { get; set; }

                /// <summary>
                /// The name of the network object.
                /// </summary>
                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                /// <summary>
                /// The type of the affected assets.
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListInterceptionRulePageResponseBodyPageInfo PageInfo { get; set; }
        public class ListInterceptionRulePageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

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

    }

}
