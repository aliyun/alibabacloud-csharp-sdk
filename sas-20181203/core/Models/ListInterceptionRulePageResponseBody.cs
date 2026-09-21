// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInterceptionRulePageResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of queried rules.</para>
        /// </summary>
        [NameInMap("InterceptionRuleList")]
        [Validation(Required=false)]
        public List<ListInterceptionRulePageResponseBodyInterceptionRuleList> InterceptionRuleList { get; set; }
        public class ListInterceptionRulePageResponseBodyInterceptionRuleList : TeaModel {
            /// <summary>
            /// <para>The destination object.</para>
            /// </summary>
            [NameInMap("DstTarget")]
            [Validation(Required=false)]
            public ListInterceptionRulePageResponseBodyInterceptionRuleListDstTarget DstTarget { get; set; }
            public class ListInterceptionRulePageResponseBodyInterceptionRuleListDstTarget : TeaModel {
                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>console</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The list of affected images.</para>
                /// </summary>
                [NameInMap("ImageList")]
                [Validation(Required=false)]
                public List<string> ImageList { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The port information of the destination server.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<string> Ports { get; set; }

                /// <summary>
                /// <para>The rule type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>suggest</b>: intelligent recommendation</description></item>
                /// <item><description><b>customize</b>: user-defined</description></item>
                /// <item><description><b>system</b>: system</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>customize</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>The list of destination tags for the network object.</para>
                /// </summary>
                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<string> TagList { get; set; }

                /// <summary>
                /// <para>The ID of the network object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>302001</para>
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public int? TargetId { get; set; }

                /// <summary>
                /// <para>The name of the network object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo4****</para>
                /// </summary>
                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                /// <summary>
                /// <para>The type of the network object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IMAGE</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// <para>The interception mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: monitor mode</description></item>
            /// <item><description><b>1</b>: Block Mode</description></item>
            /// <item><description><b>2</b>: alert mode</description></item>
            /// <item><description><b>3</b>: allow mode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InterceptType")]
            [Validation(Required=false)]
            public long? InterceptType { get; set; }

            /// <summary>
            /// <para>The sort order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OrderIndex")]
            [Validation(Required=false)]
            public long? OrderIndex { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The switch status of the scheduling rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public int? RuleSwitch { get; set; }

            /// <summary>
            /// <para>The rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customize</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The source object.</para>
            /// </summary>
            [NameInMap("SrcTarget")]
            [Validation(Required=false)]
            public ListInterceptionRulePageResponseBodyInterceptionRuleListSrcTarget SrcTarget { get; set; }
            public class ListInterceptionRulePageResponseBodyInterceptionRuleListSrcTarget : TeaModel {
                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ack-jenkins-lawr****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The list of associated images.</para>
                /// </summary>
                [NameInMap("ImageList")]
                [Validation(Required=false)]
                public List<string> ImageList { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jenkins</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The rule type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>suggest</b>: intelligent recommendation</description></item>
                /// <item><description><b>customize</b>: user-defined</description></item>
                /// <item><description><b>system</b>: system</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>customize</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>The list of source tags for the network object.</para>
                /// </summary>
                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<string> TagList { get; set; }

                /// <summary>
                /// <para>The ID of the network object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40****</para>
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public int? TargetId { get; set; }

                /// <summary>
                /// <para>The name of the network object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mhh-te****</para>
                /// </summary>
                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                /// <summary>
                /// <para>The type of the affected asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>containerId</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        /// <summary>
        /// <para>The pagination information of the query result.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListInterceptionRulePageResponseBodyPageInfo PageInfo { get; set; }
        public class ListInterceptionRulePageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page when using paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page when using paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page when using paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records in the query result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for this request. You can use it to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACF97412-FD09-4D1F-994F-34DF12BR****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
