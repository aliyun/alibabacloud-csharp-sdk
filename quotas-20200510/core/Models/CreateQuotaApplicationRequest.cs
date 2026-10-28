// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationRequest : Darabonba.Model {
        /// <summary>
        /// <remarks>
        /// <para>Notice: This parameter is deprecated and is not recommended.</para>
        /// </remarks>
        /// <para>The quota review mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sync</para>
        /// </summary>
        [NameInMap("AuditMode")]
        [Validation(Required=false)]
        public string AuditMode { get; set; }

        /// <summary>
        /// <para>The requested quota value.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Set the requested quota value based on the <c>TotalUsage</c> (quota usage) and <c>ApplicableRange</c> (applicable range of the quota) of the target quota in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</description></item>
        /// <item><description>Quota increase requests are reviewed by the technical support of each cloud service. To increase the chances of approval, provide a reasonable requested value and a detailed reason when you submit the request.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>804</para>
        /// </summary>
        [NameInMap("DesireValue")]
        [Validation(Required=false)]
        public float? DesireValue { get; set; }

        /// <summary>
        /// <para>The quota dimensions.
        /// The dimensions are attributes of the quota. The combination of dimensions (Dimensions) and quota ID (QuotaActionCode) uniquely identifies a quota.</para>
        /// <remarks>
        /// <para>Some cloud services require dimensions. You can call <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> to query the quota dimensions supported by a cloud service. The <c>Requisite</c> response parameter indicates whether a dimension is required.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<CreateQuotaApplicationRequestDimensions> Dimensions { get; set; }
        public class CreateQuotaApplicationRequestDimensions : Darabonba.Model {
            /// <summary>
            /// <para>The key of the quota dimension.</para>
            /// <remarks>
            /// <para><c>Dimensions.N.Key</c> and <c>Dimensions.N.Value</c> must be specified together. The valid values of N depend on the number of dimensions supported by the cloud service. You can call <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> to query the quota dimensions supported by a cloud service. The length of the returned array is the value of N.</para>
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
            /// <para><c>Dimensions.N.Key</c> and <c>Dimensions.N.Value</c> must be specified together. The valid values of N depend on the number of dimensions supported by the cloud service. You can call <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> to query the quota dimensions supported by a cloud service. The length of the returned array is the value of N.</para>
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
        /// <para>The UTC time when the quota takes effect.
        /// This parameter is applicable only to privileges (WhiteListLabel). </para>
        /// <remarks>
        /// <para>If you do not specify an effective period, the default value is 99 years from the start time of the current quota.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-19T09:25:56Z</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The language of the quota alert notification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("EnvLanguage")]
        [Validation(Required=false)]
        public string EnvLanguage { get; set; }

        /// <summary>
        /// <para>The UTC time when the quota expires.
        /// This parameter is applicable only to privileges (WhiteListLabel). </para>
        /// <remarks>
        /// <para>If you do not specify an expiration time, the default value is the submission time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-20T09:25:56Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to send a notification about the request result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): does not send a notification.</description></item>
        /// <item><description>3: sends a notification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NoticeType")]
        [Validation(Required=false)]
        public int? NoticeType { get; set; }

        /// <summary>
        /// <para>The abbreviation of the cloud service name.</para>
        /// <remarks>
        /// <para>For information about how to obtain the abbreviation of a cloud service name, see <c>ProductCode</c> in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// <remarks>
        /// <para>For information about how to obtain the quota ID of a cloud service, see <c>QuotaActionCode</c> in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>q_security-groups</para>
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// <para>The quota type.</para>
        /// <para>Default value: CommonQuota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CommonQuota</para>
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// <para>The reason for the quota increase request.</para>
        /// <remarks>
        /// <para>Quota increase requests are reviewed by the technical support of each cloud service. To increase the chances of approval, provide a reasonable requested value and a detailed reason when you submit the request.</para>
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

