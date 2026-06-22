// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListFileProtectClientRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned data.</para>
        /// </summary>
        [NameInMap("FileProtectList")]
        [Validation(Required=false)]
        public List<ListFileProtectClientRuleResponseBodyFileProtectList> FileProtectList { get; set; }
        public class ListFileProtectClientRuleResponseBodyFileProtectList : TeaModel {
            /// <summary>
            /// <para>The alert notification level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: no alert</para>
            /// </description></item>
            /// <item><description><para>1: reminder</para>
            /// </description></item>
            /// <item><description><para>2: suspicious</para>
            /// </description></item>
            /// <item><description><para>3: high-risk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public int? AlertLevel { get; set; }

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
            /// <para>The list of excluded users.</para>
            /// </summary>
            [NameInMap("ExcludeUsers")]
            [Validation(Required=false)]
            public List<string> ExcludeUsers { get; set; }

            /// <summary>
            /// <para>The operations performed on files.</para>
            /// </summary>
            [NameInMap("FileOps")]
            [Validation(Required=false)]
            public List<string> FileOps { get; set; }

            /// <summary>
            /// <para>The monitored file paths.</para>
            /// </summary>
            [NameInMap("FilePaths")]
            [Validation(Required=false)]
            public List<string> FilePaths { get; set; }

            /// <summary>
            /// <para>The list of protected file types.</para>
            /// </summary>
            [NameInMap("FileTypes")]
            [Validation(Required=false)]
            public List<string> FileTypes { get; set; }

            /// <summary>
            /// <para>The time when the rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1682304179000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the rule was last modified.</para>
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
            /// <item><description><b>linux</b>: Linux.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The list of monitored process paths.</para>
            /// </summary>
            [NameInMap("ProcPaths")]
            [Validation(Required=false)]
            public List<string> ProcPaths { get; set; }

            /// <summary>
            /// <para>The action that the rule performs on the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>monitor: alert</para>
            /// </description></item>
            /// <item><description><para>block: block</para>
            /// </description></item>
            /// <item><description><para>pass: allow.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

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
            /// <item><description>1: enabled.</description></item>
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
            /// <para>FILE_PROTECT_RULE_SWITCH_TYPE_******</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

        /// <summary>
        /// <para>The paging information for the paged query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListFileProtectClientRuleResponseBodyPageInfo PageInfo { get; set; }
        public class ListFileProtectClientRuleResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA674E4B-00CF-5DEA-8B92-360862FB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
