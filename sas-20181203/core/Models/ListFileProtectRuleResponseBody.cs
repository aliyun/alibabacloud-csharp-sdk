// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListFileProtectRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned data.</para>
        /// </summary>
        [NameInMap("FileProtectList")]
        [Validation(Required=false)]
        public List<ListFileProtectRuleResponseBodyFileProtectList> FileProtectList { get; set; }
        public class ListFileProtectRuleResponseBodyFileProtectList : TeaModel {
            /// <summary>
            /// <para>The action of the rule on the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pass: allow</description></item>
            /// <item><description>alert: alert</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The alert notification level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: No alert.</para>
            /// </description></item>
            /// <item><description><para>1: Reminder.</para>
            /// </description></item>
            /// <item><description><para>2: Suspicious.</para>
            /// </description></item>
            /// <item><description><para>3: High-risk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public string AlertLevel { get; set; }

            /// <summary>
            /// <para>The total number of affected assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("EffectInstanceCount")]
            [Validation(Required=false)]
            public long? EffectInstanceCount { get; set; }

            /// <summary>
            /// <para>The list of operations performed on files.</para>
            /// </summary>
            [NameInMap("FileOps")]
            [Validation(Required=false)]
            public List<string> FileOps { get; set; }

            /// <summary>
            /// <para>The list of monitored file paths. Wildcards are supported.</para>
            /// </summary>
            [NameInMap("FilePaths")]
            [Validation(Required=false)]
            public List<string> FilePaths { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1682304179000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The most recent modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1682304179000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1412511</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The operating system type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b>: Windows</description></item>
            /// <item><description><b>linux</b>: Linux</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The list of monitored process paths. Wildcards are supported.</para>
            /// </summary>
            [NameInMap("ProcPaths")]
            [Validation(Required=false)]
            public List<string> ProcPaths { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test11</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: disabled</description></item>
            /// <item><description>1: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The switch ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FILE_PROTECT_RULE_SWITCH_TYPE_1693474122927</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

        /// <summary>
        /// <para>The paging information for the query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListFileProtectRuleResponseBodyPageInfo PageInfo { get; set; }
        public class ListFileProtectRuleResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the current page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paging query.</para>
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
            /// <para>253</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FBBEB173-1F43-505F-A876-C03ECDF6CE4C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
