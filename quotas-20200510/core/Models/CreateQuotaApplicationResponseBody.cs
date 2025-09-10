// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d314d6ae-867d-484c-9009-3d421a80****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The time when the application was submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-19T09:25:56Z</para>
        /// </summary>
        [NameInMap("ApplyTime")]
        [Validation(Required=false)]
        public string ApplyTime { get; set; }

        /// <summary>
        /// <para>The quota value that is approved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>804</para>
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
        /// <para>The requested value of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("DesireValue")]
        [Validation(Required=false)]
        public int? DesireValue { get; set; }

        /// <summary>
        /// <para>The quota dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public Dictionary<string, object> Dimension { get; set; }

        /// <summary>
        /// <para>The time when the new quota value takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-19T09:25:56Z</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The time when the new quota expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-20T09:25:56Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the notification about the application result is sent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The notification is not sent.</description></item>
        /// <item><description>3: The notification is sent.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("NoticeType")]
        [Validation(Required=false)]
        public long? NoticeType { get; set; }

        /// <summary>
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-spec</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c5.large</para>
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:quotas:cn-hangzhou:*:quota/ecs/ecs.m2.medium/prepaid/classic/instancetype/cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("QuotaArn")]
        [Validation(Required=false)]
        public string QuotaArn { get; set; }

        /// <summary>
        /// <para>The description of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c5.large</para>
        /// </summary>
        [NameInMap("QuotaDescription")]
        [Validation(Required=false)]
        public string QuotaDescription { get; set; }

        /// <summary>
        /// <para>The name of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c5.large</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <para>The unit of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AMOUNT</para>
        /// </summary>
        [NameInMap("QuotaUnit")]
        [Validation(Required=false)]
        public string QuotaUnit { get; set; }

        /// <summary>
        /// <para>The reason for the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scale Out</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D47B3A10-CDAC-5412-B2EE-EC9A3DBE9053</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The approval state of the quota increase application.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Cancel: The application is canceled.</description></item>
        /// <item><description>Agree: The application is approved.</description></item>
        /// <item><description>Process: The application is in review.</description></item>
        /// <item><description>Disagree: The application is rejected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Process</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
