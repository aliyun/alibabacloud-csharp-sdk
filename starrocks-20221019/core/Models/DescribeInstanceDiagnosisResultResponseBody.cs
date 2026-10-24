// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeInstanceDiagnosisResultResponseBody : TeaModel {
        /// <summary>
        /// <para>AccessDeniedDetail</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;sr:xxx&quot;   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeInstanceDiagnosisResultResponseBodyData> Data { get; set; }
        public class DescribeInstanceDiagnosisResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The best practices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("BestPractice")]
            [Validation(Required=false)]
            public string BestPractice { get; set; }

            /// <summary>
            /// <para>The diagnosis item description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unreasonable partitioning and bucketing</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The evaluation dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_analysis</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public string Dimension { get; set; }

            /// <summary>
            /// <para>The evaluation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-08T02:12:32Z</para>
            /// </summary>
            [NameInMap("EvaluationTime")]
            [Validation(Required=false)]
            public long? EvaluationTime { get; set; }

            /// <summary>
            /// <para>The full score of the evaluation item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("FullScore")]
            [Validation(Required=false)]
            public double? FullScore { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-b25e21e243889XXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The evaluation item introduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>for autotest</para>
            /// </summary>
            [NameInMap("Introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            /// <summary>
            /// <para>The evaluation item ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02cf887a</para>
            /// </summary>
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// <para>The evaluation item name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unreasonable partitioning and bucketing</para>
            /// </summary>
            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            /// <summary>
            /// <para>The report date in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-08</para>
            /// </summary>
            [NameInMap("ReportDate")]
            [Validation(Required=false)]
            public string ReportDate { get; set; }

            /// <summary>
            /// <para>The diagnosis score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public double? Score { get; set; }

            /// <summary>
            /// <para>The status list. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>healthy</para>
            /// </description></item>
            /// <item><description><para>info</para>
            /// </description></item>
            /// <item><description><para>medium</para>
            /// </description></item>
            /// <item><description><para>critical</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The diagnosis suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No bucket exceeds 5 GB in size. The evaluation result is healthy</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE74XXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
