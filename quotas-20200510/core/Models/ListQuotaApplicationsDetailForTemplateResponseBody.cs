// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsDetailForTemplateResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The maximum number of records returned for the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the position from which the next query starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>A list of quota application details.</para>
        /// </summary>
        [NameInMap("QuotaApplications")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationsDetailForTemplateResponseBodyQuotaApplications> QuotaApplications { get; set; }
        public class ListQuotaApplicationsDetailForTemplateResponseBodyQuotaApplications : Darabonba.Model {
            /// <summary>
            /// <para>The Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>175376458581****</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <para>The ID of the quota increase request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b926571d-cc09-4711-b547-58a615f0****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The UTC time when the quota increase request was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-15T09:13:53Z</para>
            /// </summary>
            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            /// <summary>
            /// <para>The approved quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("ApproveValue")]
            [Validation(Required=false)]
            public double? ApproveValue { get; set; }

            /// <summary>
            /// <para>The reason for the approval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agree</para>
            /// </summary>
            [NameInMap("AuditReason")]
            [Validation(Required=false)]
            public string AuditReason { get; set; }

            /// <summary>
            /// <para>The ID of the quota application batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d314d6ae-867d-484c-9009-3d421a80****</para>
            /// </summary>
            [NameInMap("BatchQuotaApplicationId")]
            [Validation(Required=false)]
            public string BatchQuotaApplicationId { get; set; }

            /// <summary>
            /// <para>The requested quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public double? DesireValue { get; set; }

            /// <summary>
            /// <para>The UTC time when the new quota value takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-15T11:46:25Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The language of the alert notification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>zh: Chinese.</para>
            /// </description></item>
            /// <item><description><para>en: English.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("EnvLanguage")]
            [Validation(Required=false)]
            public string EnvLanguage { get; set; }

            /// <summary>
            /// <para>The UTC time when the new quota value expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-17T11:46:25Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether a notification is sent for the quota increase request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: No.</para>
            /// </description></item>
            /// <item><description><para>3: Yes.</para>
            /// </description></item>
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
            public ListQuotaApplicationsDetailForTemplateResponseBodyQuotaApplicationsPeriod Period { get; set; }
            public class ListQuotaApplicationsDetailForTemplateResponseBodyQuotaApplicationsPeriod : Darabonba.Model {
                /// <summary>
                /// <para>The unit of the calculation cycle.</para>
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
                public int? PeriodValue { get; set; }

            }

            /// <summary>
            /// <para>The abbreviation of the Alibaba Cloud service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The quota ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.n1.large</para>
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
            /// <item><description><para>CommonQuota (default): General quota.</para>
            /// </description></item>
            /// <item><description><para>WhiteListLabel: Privilege quota.</para>
            /// </description></item>
            /// <item><description><para>FlowControl: API rate limit quota.</para>
            /// </description></item>
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
            /// <para>The quota dimensions.</para>
            /// </summary>
            [NameInMap("QuotaDimension")]
            [Validation(Required=false)]
            public Dictionary<string, string> QuotaDimension { get; set; }

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
            /// <para>The unit of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GiB</para>
            /// </summary>
            [NameInMap("QuotaUnit")]
            [Validation(Required=false)]
            public string QuotaUnit { get; set; }

            /// <summary>
            /// <para>The reason for the quota increase request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Maximum Number of Nodes</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The approval status of the quota increase request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Disagree: The request is rejected.</para>
            /// </description></item>
            /// <item><description><para>Agree: The request is approved.</para>
            /// </description></item>
            /// <item><description><para>Process: The request is in review.</para>
            /// </description></item>
            /// <item><description><para>Cancel: The request is closed.</para>
            /// </description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D47B3A10-CDAC-5412-B2EE-EC9A3DBE9053</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

