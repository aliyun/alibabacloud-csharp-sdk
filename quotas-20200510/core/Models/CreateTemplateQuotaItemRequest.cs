// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateTemplateQuotaItemRequest : TeaModel {
        /// <summary>
        /// <para>The requested value of the quota.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can specify DesireValue based on the values of <c>TotalUsage</c> and <c>ApplicableRange</c> in the response to the <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a> operation.</para>
        /// </description></item>
        /// <item><description><para>Applications are reviewed by the technical support team for each cloud service. To increase the success rate of your application, specify a reasonable quota value and a detailed reason.</para>
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
        /// <para>The quota dimensions.</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<CreateTemplateQuotaItemRequestDimensions> Dimensions { get; set; }
        public class CreateTemplateQuotaItemRequestDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the dimension.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.</para>
            /// </description></item>
            /// <item><description><para>This parameter is required if you set the <c>ProductCode</c> parameter to <c>ecs</c>, <c>ecs-spec</c>, <c>actiontrail</c>, or <c>ess</c>.</para>
            /// </description></item>
            /// </list>
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
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.</para>
            /// </description></item>
            /// <item><description><para>This parameter is required if you set the <c>ProductCode</c> parameter to <c>ecs</c>, <c>ecs-spec</c>, <c>actiontrail</c>, or <c>ess</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The start time of the validity period of the quota. Specify the value in UTC. This parameter is valid only if you set the QuotaCategory parameter to WhiteListLabel.</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, the quota takes effect immediately.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-19T09:25:56Z</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The language of the quota alert notification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh (default value): Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("EnvLanguage")]
        [Validation(Required=false)]
        public string EnvLanguage { get; set; }

        /// <summary>
        /// <para>The end time of the validity period of the quota. Specify the value in UTC. This parameter is valid only if you set the QuotaCategory parameter to WhiteListLabel.</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, no end time is specified.</para>
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
        /// <item><description>0 (default value): no</description></item>
        /// <item><description>3: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NoticeType")]
        [Validation(Required=false)]
        public long? NoticeType { get; set; }

        /// <summary>
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// <remarks>
        /// <para> To query the abbreviation of an Alibaba Cloud service name, call the <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a> operation and check the value of <c>ProductCode</c> in the response.</para>
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
        /// <para> To obtain the quota ID of an Alibaba Cloud service, call the <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a> operation and check the value of <c>QuotaActionCode</c> in the response.</para>
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
        /// <para>The quota type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CommonQuota: general quota</description></item>
        /// <item><description>WhiteListLabel: privilege</description></item>
        /// <item><description>FlowControl: API rate limit</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonQuota</para>
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

    }

}
