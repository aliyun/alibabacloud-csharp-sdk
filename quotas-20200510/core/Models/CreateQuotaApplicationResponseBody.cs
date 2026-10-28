// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The ID of the quota increase request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d314d6ae-867d-484c-9009-3d421a80****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The time when the quota increase request was submitted. The time is in ISO 8601 format and in UTC. The value ends with Z.</para>
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
        /// <para>804</para>
        /// </summary>
        [NameInMap("ApproveValue")]
        [Validation(Required=false)]
        public float? ApproveValue { get; set; }

        /// <summary>
        /// <para>The review comments on the quota increase request.</para>
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
        /// <para>The quota dimensions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public Dictionary<string, object> Dimension { get; set; }

        /// <summary>
        /// <para>The effective period of the quota. The time is in ISO 8601 format and in UTC. The value ends with Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-19T09:25:56Z</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The time when the quota expires. The time is in ISO 8601 format and in UTC. The value ends with Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-20T09:25:56Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether a notification is sent about the request result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: no notification is sent.</para>
        /// </description></item>
        /// <item><description><para>3: a notification is sent.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:quotas::141339776561****:quota/ecs/q_security-groups</para>
        /// </summary>
        [NameInMap("QuotaArn")]
        [Validation(Required=false)]
        public string QuotaArn { get; set; }

        /// <summary>
        /// <para>The description of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The maximum number of security groups that can be owned by the current account.</para>
        /// </summary>
        [NameInMap("QuotaDescription")]
        [Validation(Required=false)]
        public string QuotaDescription { get; set; }

        /// <summary>
        /// <para>The name of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Maximum Number of Security Groups</para>
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
        /// <para>The reason for the quota increase request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scale Out</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

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
        /// <para>The approval status of the quota increase request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Process</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

