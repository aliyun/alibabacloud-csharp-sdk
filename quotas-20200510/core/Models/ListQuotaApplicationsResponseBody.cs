// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records that are returned for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the position at which the query ends. An empty value indicates that all data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The details of the quota increase applications.</para>
        /// </summary>
        [NameInMap("QuotaApplications")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationsResponseBodyQuotaApplications> QuotaApplications { get; set; }
        public class ListQuotaApplicationsResponseBodyQuotaApplications : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b926571d-cc09-4711-b547-58a615f0****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The time when the application was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-15T09:13:53Z</para>
            /// </summary>
            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            /// <summary>
            /// <para>The quota value that is approved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("ApproveValue")]
            [Validation(Required=false)]
            public float? ApproveValue { get; set; }

            /// <summary>
            /// <para>The result of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agree</para>
            /// </summary>
            [NameInMap("AuditReason")]
            [Validation(Required=false)]
            public string AuditReason { get; set; }

            /// <summary>
            /// <para>The remarks of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The quota value that is approved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public float? DesireValue { get; set; }

            /// <summary>
            /// <para>The dimension of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimension { get; set; }

            /// <summary>
            /// <para>The time when the application took effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-15T11:46:25Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The time when the application expired.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-17T11:46:25Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether Quota Center sends a notification about the application result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: A notification about the application result is not sent.</description></item>
            /// <item><description>3: A notification about the application result is sent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public int? NoticeType { get; set; }

            /// <summary>
            /// <para>The calculation cycle of the quota.</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public ListQuotaApplicationsResponseBodyQuotaApplicationsPeriod Period { get; set; }
            public class ListQuotaApplicationsResponseBodyQuotaApplicationsPeriod : TeaModel {
                /// <summary>
                /// <para>The unit of the calculation cycle. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>second</description></item>
                /// <item><description>minute</description></item>
                /// <item><description>hour</description></item>
                /// <item><description>day</description></item>
                /// <item><description>week</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>second</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The value of the calculation cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodValue")]
                [Validation(Required=false)]
                public long? PeriodValue { get; set; }

            }

            /// <summary>
            /// <para>The abbreviation of the Alibaba Cloud service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>csk</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q_i5uzm3</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:quotas:<em>:120886317861</em>***:quota/csk/q_i5uzm3</para>
            /// </summary>
            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }

            /// <summary>
            /// <para>The quota type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CommonQuota (default): general quota.</description></item>
            /// <item><description>WhiteListLabel: whitelist quota.</description></item>
            /// <item><description>FlowControl: API rate limit.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CommonQuota</para>
            /// </summary>
            [NameInMap("QuotaCategory")]
            [Validation(Required=false)]
            public string QuotaCategory { get; set; }

            /// <summary>
            /// <para>The description of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The maximum number of nodes in a cluster</para>
            /// </summary>
            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }

            /// <summary>
            /// <para>The name of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Maximum Number of Nodes</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <para>The unit of the new quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node</para>
            /// </summary>
            [NameInMap("QuotaUnit")]
            [Validation(Required=false)]
            public string QuotaUnit { get; set; }

            /// <summary>
            /// <para>The reason for the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business expansion</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Disagree: The application is rejected.</description></item>
            /// <item><description>Agree: The application is approved.</description></item>
            /// <item><description>Process: The application is being reviewed.</description></item>
            /// <item><description>Cancel: The application is canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Agree</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>730925FB-0BD0-40AC-AF3A-A6C6E9716879</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
