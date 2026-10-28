// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaApplicationResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The details of the quota increase application.</para>
        /// </summary>
        [NameInMap("QuotaApplication")]
        [Validation(Required=false)]
        public GetQuotaApplicationResponseBodyQuotaApplication QuotaApplication { get; set; }
        public class GetQuotaApplicationResponseBodyQuotaApplication : Darabonba.Model {
            /// <summary>
            /// <para>The ID of the quota increase application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d314d6ae-867d-484c-9009-3d421a80****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The time when the quota increase application was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-19T09:25:56Z</para>
            /// </summary>
            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            /// <summary>
            /// <para>The approved quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ApproveValue")]
            [Validation(Required=false)]
            public float? ApproveValue { get; set; }

            /// <summary>
            /// <para>The review comments for the quota increase application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agree</para>
            /// </summary>
            [NameInMap("AuditReason")]
            [Validation(Required=false)]
            public string AuditReason { get; set; }

            /// <summary>
            /// <para>The requested quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>804</para>
            /// </summary>
            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public int? DesireValue { get; set; }

            /// <summary>
            /// <para>The quota dimension.</para>
            /// <para>Format: <c>{&quot;regionId&quot;:&quot;region&quot;}</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;cn-shanghai&quot;,&quot;cn-hangzhou&quot;]</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimension { get; set; }

            /// <summary>
            /// <para>The effective period of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-19 15:30:00</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The time when the quota expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-29 15:30:00</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The notification type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no notification</description></item>
            /// <item><description>1: email notification</description></item>
            /// <item><description>2: SMS notification</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public long? NoticeType { get; set; }

            /// <summary>
            /// <para>The abbreviation of the cloud service name.</para>
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
            /// <para>q_security-groups</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <para>The ARN of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:quotas:cn-hangzhou:120886317861****:quota/ecs/q_security-groups/</para>
            /// </summary>
            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }

            /// <summary>
            /// <para>The quota category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CommonQuota: general quota</description></item>
            /// <item><description>FlowControl: API rate limit</description></item>
            /// <item><description>WhiteListLabel: privilege</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CommonQuota</para>
            /// </summary>
            [NameInMap("QuotaCategory")]
            [Validation(Required=false)]
            public string QuotaCategory { get; set; }

            /// <summary>
            /// <para>The quota description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The maximum number of security groups that can be owned by the current account.</para>
            /// </summary>
            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }

            /// <summary>
            /// <para>The quota name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Maximum Number of Security Groups</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <para>The quota unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AMOUNT</para>
            /// </summary>
            [NameInMap("QuotaUnit")]
            [Validation(Required=false)]
            public string QuotaUnit { get; set; }

            /// <summary>
            /// <para>The reason for the quota increase application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scale Out</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The approval status of the quota increase application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Disagree: Rejected.</para>
            /// </description></item>
            /// <item><description><para>Agree: Approved.</para>
            /// </description></item>
            /// <item><description><para>Process: Under review.</para>
            /// </description></item>
            /// <item><description><para>Cancel: Closed.</para>
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
        /// <para>7BBD1D37-094C-4485-8B7D-64682F82BC18</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

