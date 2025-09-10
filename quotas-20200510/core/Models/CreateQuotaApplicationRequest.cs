// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para> This parameter is deprecated and is not recommended.</para>
        /// </remarks>
        /// <para>The mode in which you want the application to be reviewed.</para>
        /// <para>Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Async</description></item>
        /// <item><description>Sync</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Sync</para>
        /// </summary>
        [NameInMap("AuditMode")]
        [Validation(Required=false)]
        public string AuditMode { get; set; }

        /// <summary>
        /// <para>The requested value of the quota.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can specify the DesireValue parameter based on the values of the <c>TotalUsage</c> and <c>ApplicableRange</c> parameters that are returned by the <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a> operation.</para>
        /// </description></item>
        /// <item><description><para>Applications are reviewed by the technical support team of each Alibaba Cloud service. To increase the success rate of your application, you must specify a reasonable quota value and detailed reasons when you submit an application to increase the value of the quota.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>804</para>
        /// </summary>
        [NameInMap("DesireValue")]
        [Validation(Required=false)]
        public float? DesireValue { get; set; }

        /// <summary>
        /// <para>The quota dimensions. A quota item is uniquely determined by the values of Dimensions and QuotaActionCode.</para>
        /// <remarks>
        /// <para> Some dimensions are required. You can call the <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> operation to query the quota dimensions that are supported by an Alibaba Cloud service. The value of <c>Requisite</c> in the response indicates whether a dimension is required.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<CreateQuotaApplicationRequestDimensions> Dimensions { get; set; }
        public class CreateQuotaApplicationRequestDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the dimension.</para>
            /// <remarks>
            /// <para> You must configure <c>Dimensions.N.Key</c> and <c>Dimensions.N.Value</c> at the same time. The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service. You can call the <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> operation to query the dimensions that are supported by an Alibaba Cloud service. The number of elements in the returned array is N.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the dimension.</para>
            /// <remarks>
            /// <para> You must configure <c>Dimensions.N.Key</c> and <c>Dimensions.N.Value</c> at the same time. The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service. You can call the <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> operation to query the dimensions that are supported by an Alibaba Cloud service. The number of elements in the returned array is N.</para>
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
        /// <para>The end time of the validity period of the quota. Specify the value in UTC. This parameter is valid only if you set the QuotaCategory parameter to WhiteListLabel.</para>
        /// <remarks>
        /// <para> If you do not specify an end time, the default end time is 99 years after the quota application is submitted.</para>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en: English</description></item>
        /// <item><description>zh: Chinese</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("EnvLanguage")]
        [Validation(Required=false)]
        public string EnvLanguage { get; set; }

        /// <summary>
        /// <para>The start time of the validity period of the quota. Specify the value in UTC. This parameter is valid only if you set the QuotaCategory parameter to WhiteListLabel.</para>
        /// <remarks>
        /// <para> If you do not specify a start time, the default start time is the time when the quota application is submitted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-20T09:25:56Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to send a notification about the application result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): no</description></item>
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
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// <remarks>
        /// <para> To query the abbreviation of an Alibaba Cloud service name, check the <c>ProductCode</c> parameter that is described in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
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
        /// <para> To query the quota ID of an Alibaba Cloud service, check the <c>QuotaActionCode</c> parameter that is described in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
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
        /// <para>The type of the quota. Valid values:</para>
        /// <para>Default value: CommonQuota.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FlowControl: API rate limit</description></item>
        /// <item><description>WhiteListLabel: whitelist quota</description></item>
        /// <item><description>CommonQuota: general quota</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonQuota</para>
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// <para>The reason for the application.</para>
        /// <remarks>
        /// <para>Applications are reviewed by the technical support team of each Alibaba Cloud service. To increase the success rate of your application, you must specify a reasonable quota value and detailed reasons when you submit an application to increase the value of the quota.</para>
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
