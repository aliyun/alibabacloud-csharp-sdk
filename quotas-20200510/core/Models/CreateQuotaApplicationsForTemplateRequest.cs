// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationsForTemplateRequest : Darabonba.Model {
        /// <summary>
        /// <para>The list of Alibaba Cloud accounts that belong to the resource directory members for which you want to apply for quotas.</para>
        /// <remarks>
        /// <para>You can apply for quota increases for a maximum of 50 members at a time. For more information about the members of a resource directory, see <a href="https://help.aliyun.com/document_detail/604207.html">ListAccounts</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AliyunUids")]
        [Validation(Required=false)]
        public List<string> AliyunUids { get; set; }

        /// <summary>
        /// <para>The requested quota value.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Set the requested quota value based on the <c>TotalUsage</c> (quota usage) and <c>ApplicableRange</c> (applicable range for quota application) of the target quota in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</description></item>
        /// <item><description>Quota applications are reviewed and approved by the technical support team of each cloud service. To increase the approval rate, specify a reasonable requested value and provide a detailed reason when you submit a quota application.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("DesireValue")]
        [Validation(Required=false)]
        public double? DesireValue { get; set; }

        /// <summary>
        /// <para>The quota dimensions.</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<CreateQuotaApplicationsForTemplateRequestDimensions> Dimensions { get; set; }
        public class CreateQuotaApplicationsForTemplateRequestDimensions : Darabonba.Model {
            /// <summary>
            /// <para>The key of the quota dimension.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The value range of N depends on the number of dimensions supported by the cloud service.</description></item>
            /// <item><description>When <c>ProductCode</c> is set to <c>ecs</c>, <c>ecs-spec</c>, <c>actiontrail</c>, or <c>ess</c>, you must specify both the key and the value of the quota dimension.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the quota dimension.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The value range of N depends on the number of dimensions supported by the cloud service.</description></item>
            /// <item><description>When <c>ProductCode</c> is set to <c>ecs</c>, <c>ecs-spec</c>, <c>actiontrail</c>, or <c>ess</c>, you must specify both the key and the value of the quota dimension.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The UTC time when the quota takes effect. This parameter applies only to privileges (WhiteListLabel).</para>
        /// <remarks>
        /// <para>If you do not specify an effective period for the current account, the commit time is used by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-19T09:25:56Z</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The language of the notification for the quota application result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh (default): Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("EnvLanguage")]
        [Validation(Required=false)]
        public string EnvLanguage { get; set; }

        /// <summary>
        /// <para>The UTC time when the quota expires. This parameter applies only to privileges (WhiteListLabel). </para>
        /// <remarks>
        /// <para>If you do not specify an expiration time for the current account, the expiration time is set to 99 years after the effective period of the current quota.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-20T09:25:56Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to send notifications for quota application results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): no.</description></item>
        /// <item><description>3: yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NoticeType")]
        [Validation(Required=false)]
        public int? NoticeType { get; set; }

        /// <summary>
        /// <para>The abbreviated name of the cloud service.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the abbreviated name of a cloud service, see <c>ProductCode</c> in <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-spec</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the quota ID of a cloud service, see <c>QuotaActionCode</c> in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.2xlarge</para>
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// <para>The quota type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CommonQuota: general quota.</description></item>
        /// <item><description>FlowControl: API rate limit.</description></item>
        /// <item><description>WhiteListLabel: privilege.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CommonQuota</para>
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// <para>The reason for the quota application.</para>
        /// <remarks>
        /// <para>Quota applications are reviewed and approved by the technical support team of each cloud service. To increase the approval rate, specify a reasonable requested value and provide a detailed reason when you submit a quota application.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scale Out</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}

