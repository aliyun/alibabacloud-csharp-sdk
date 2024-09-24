// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInterceptionRulePageResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of information about the defense rules.</para>
        /// </summary>
        [NameInMap("InterceptionRuleList")]
        [Validation(Required=false)]
        public List<ListInterceptionRulePageResponseBodyInterceptionRuleList> InterceptionRuleList { get; set; }
        public class ListInterceptionRulePageResponseBodyInterceptionRuleList : TeaModel {
            /// <summary>
            /// <para>The destination network object.</para>
            /// </summary>
            [NameInMap("DstTarget")]
            [Validation(Required=false)]
            public ListInterceptionRulePageResponseBodyInterceptionRuleListDstTarget DstTarget { get; set; }
            public class ListInterceptionRulePageResponseBodyInterceptionRuleListDstTarget : TeaModel {
                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>console</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>An array that consists of the affected images.</para>
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
                /// <para>An array that consists of information about the ports used by the destination server.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<string> Ports { get; set; }

                /// <summary>
                /// <para>The type of the defense rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>suggest</b>: intelligently recommended rule</description></item>
                /// <item><description><b>customize</b>: custom rule</description></item>
                /// <item><description><b>system</b>: system rule</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>customize</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>An array that consists of tags added to the destination network object.</para>
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
            /// <item><description><b>0</b>: monitor</description></item>
            /// <item><description><b>1</b>: block</description></item>
            /// <item><description><b>2</b>: alert</description></item>
            /// <item><description><b>3</b>: allow</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InterceptType")]
            [Validation(Required=false)]
            public long? InterceptType { get; set; }

            /// <summary>
            /// <para>The order in which the entries are sorted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OrderIndex")]
            [Validation(Required=false)]
            public long? OrderIndex { get; set; }

            /// <summary>
            /// <para>The ID of the defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The status of the defense rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled</description></item>
            /// <item><description><b>0</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public int? RuleSwitch { get; set; }

            /// <summary>
            /// <para>The type of the defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customize</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The source network object.</para>
            /// </summary>
            [NameInMap("SrcTarget")]
            [Validation(Required=false)]
            public ListInterceptionRulePageResponseBodyInterceptionRuleListSrcTarget SrcTarget { get; set; }
            public class ListInterceptionRulePageResponseBodyInterceptionRuleListSrcTarget : TeaModel {
                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ack-jenkins-lawr****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>An array that consists of the images of the network object.</para>
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
                /// <para>The type of the defense rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>suggest</b>: intelligently recommended rule</description></item>
                /// <item><description><b>customize</b>: custom rule</description></item>
                /// <item><description><b>system</b>: system rule</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>customize</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>An array that consists of tags added to the source network object.</para>
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
                /// <para>The type of the affected assets.</para>
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
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListInterceptionRulePageResponseBodyPageInfo PageInfo { get; set; }
        public class ListInterceptionRulePageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACF97412-FD09-4D1F-994F-34DF12BR****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
