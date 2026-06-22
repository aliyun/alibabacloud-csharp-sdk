// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInterceptionHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The container firewall interception records.</para>
        /// </summary>
        [NameInMap("InterceptionHistoryList")]
        [Validation(Required=false)]
        public List<ListInterceptionHistoryResponseBodyInterceptionHistoryList> InterceptionHistoryList { get; set; }
        public class ListInterceptionHistoryResponseBodyInterceptionHistoryList : TeaModel {
            /// <summary>
            /// <para>The ID of the container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c556c8133b5ad4378b7fc533ddbda****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>opa-terway-nonet****</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The destination application name configured in the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-web****</para>
            /// </summary>
            [NameInMap("DstAppName")]
            [Validation(Required=false)]
            public string DstAppName { get; set; }

            /// <summary>
            /// <para>The destination namespace configured in the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service****</para>
            /// </summary>
            [NameInMap("DstNamespace")]
            [Validation(Required=false)]
            public string DstNamespace { get; set; }

            /// <summary>
            /// <para>The destination port number configured in the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public long? DstPort { get; set; }

            /// <summary>
            /// <para>The destination target object name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-web****</para>
            /// </summary>
            [NameInMap("DstRuleTargetName")]
            [Validation(Required=false)]
            public string DstRuleTargetName { get; set; }

            /// <summary>
            /// <para>The timestamp of the first occurrence on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639718858000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>The ID of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1126</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The alert name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>异常访问。</para>
            /// </summary>
            [NameInMap("InterceptionName")]
            [Validation(Required=false)]
            public long? InterceptionName { get; set; }

            /// <summary>
            /// <para>The processing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: observe</description></item>
            /// <item><description><b>1</b>: block</description></item>
            /// <item><description><b>2</b>: alert</description></item>
            /// <item><description><b>3</b>: allow.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InterceptionType")]
            [Validation(Required=false)]
            public int? InterceptionType { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest occurrence on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639731078000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The destination application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-service****</para>
            /// </summary>
            [NameInMap("RealDstAppName")]
            [Validation(Required=false)]
            public string RealDstAppName { get; set; }

            /// <summary>
            /// <para>The destination image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-servi****</para>
            /// </summary>
            [NameInMap("RealDstImageName")]
            [Validation(Required=false)]
            public string RealDstImageName { get; set; }

            /// <summary>
            /// <para>The destination namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service****</para>
            /// </summary>
            [NameInMap("RealDstNamespace")]
            [Validation(Required=false)]
            public string RealDstNamespace { get; set; }

            /// <summary>
            /// <para>The destination pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-web-84cc7dd9****</para>
            /// </summary>
            [NameInMap("RealDstPodName")]
            [Validation(Required=false)]
            public string RealDstPodName { get; set; }

            /// <summary>
            /// <para>The actual processing type that was matched. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: observe</description></item>
            /// <item><description><b>1</b>: block</description></item>
            /// <item><description><b>2</b>: alert</description></item>
            /// <item><description><b>3</b>: allow.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RealInterceptionType")]
            [Validation(Required=false)]
            public int? RealInterceptionType { get; set; }

            /// <summary>
            /// <para>The source application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-service****</para>
            /// </summary>
            [NameInMap("RealSrcAppName")]
            [Validation(Required=false)]
            public string RealSrcAppName { get; set; }

            /// <summary>
            /// <para>The source image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-servi****</para>
            /// </summary>
            [NameInMap("RealSrcImageName")]
            [Validation(Required=false)]
            public string RealSrcImageName { get; set; }

            /// <summary>
            /// <para>The source namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service****</para>
            /// </summary>
            [NameInMap("RealSrcNamespace")]
            [Validation(Required=false)]
            public string RealSrcNamespace { get; set; }

            /// <summary>
            /// <para>The source pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-service-757b9d****</para>
            /// </summary>
            [NameInMap("RealSrcPodName")]
            [Validation(Required=false)]
            public string RealSrcPodName { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: unknown</description></item>
            /// <item><description><b>0</b>: none</description></item>
            /// <item><description><b>1</b>: low</description></item>
            /// <item><description><b>2</b>: medium</description></item>
            /// <item><description><b>3</b>: high.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public long? RiskLevel { get; set; }

            /// <summary>
            /// <para>The ID of the corresponding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>136</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all****</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The source application name configured in the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-web****</para>
            /// </summary>
            [NameInMap("SrcAppName")]
            [Validation(Required=false)]
            public string SrcAppName { get; set; }

            /// <summary>
            /// <para>The namespace of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service****</para>
            /// </summary>
            [NameInMap("SrcNamespace")]
            [Validation(Required=false)]
            public string SrcNamespace { get; set; }

            /// <summary>
            /// <para>The source target object name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-web****</para>
            /// </summary>
            [NameInMap("SrcRuleTargetName")]
            [Validation(Required=false)]
            public string SrcRuleTargetName { get; set; }

            /// <summary>
            /// <para>The processing status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: unprocessed</description></item>
            /// <item><description><b>1</b>: processed</description></item>
            /// <item><description><b>2</b>: manually processed</description></item>
            /// <item><description><b>3</b>: ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The number of attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34</para>
            /// </summary>
            [NameInMap("TryCount")]
            [Validation(Required=false)]
            public int? TryCount { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListInterceptionHistoryResponseBodyPageInfo PageInfo { get; set; }
        public class ListInterceptionHistoryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of records on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

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
            /// <para>The maximum number of entries per page for a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for this request. You can use it to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D81DD78E-E006-5C65-A171-C8CB0904****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
