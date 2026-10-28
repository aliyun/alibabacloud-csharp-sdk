// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ModifyTemplateQuotaItemRequest : Darabonba.Model {
        /// <summary>
        /// <para>The value of the quota that you want to apply for.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can set this parameter based on the <c>TotalUsage</c> (quota usage) and <c>ApplicableRange</c> (the range of values for the quota) parameters of the target quota in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
        /// </description></item>
        /// <item><description><para>The quota application is reviewed by the technical support of each Alibaba Cloud service. To increase the success rate of your application, you must specify a reasonable quota value and a detailed reason when you submit the application.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
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
        public List<ModifyTemplateQuotaItemRequestDimensions> Dimensions { get; set; }
        public class ModifyTemplateQuotaItemRequestDimensions : Darabonba.Model {
            /// <summary>
            /// <para>The key of the quota dimension.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>The value of N depends on the number of dimensions that are supported by the Alibaba Cloud service.</para>
            /// </description></item>
            /// <item><description><para>If you set <c>ProductCode</c> to a value such as <c>ecs</c>, <c>ecs-spec</c>, <c>actiontrail</c>, or <c>ess</c>, you must specify both the key and value of the quota dimension.</para>
            /// </description></item>
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
            /// <item><description><para>The value of N depends on the number of dimensions that are supported by the Alibaba Cloud service.</para>
            /// </description></item>
            /// <item><description><para>If you set <c>ProductCode</c> to a value such as <c>ecs</c>, <c>ecs-spec</c>, <c>actiontrail</c>, or <c>ess</c>, you must specify both the key and value of the quota dimension.</para>
            /// </description></item>
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
        /// <para>The UTC time when the quota takes effect.
        /// This parameter is applicable only to privileges (WhiteListLabel).</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the quota takes effect immediately.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-19T09:25:56Z</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The language of the notification for a quota alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh (default): Chinese.</para>
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
        /// <para>The UTC time when the quota expires.
        /// This parameter is applicable only to privileges (WhiteListLabel).</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the quota does not expire.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-20T09:25:56Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the quota template.
        /// For more information about how to obtain the ID of a quota template, see <a href="https://help.aliyun.com/document_detail/450403.html">ListQuotaApplicationTemplates</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Specifies whether to send a notification about the application result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 (default): no.</para>
        /// </description></item>
        /// <item><description><para>3: yes.</para>
        /// </description></item>
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
        /// <para>For more information about how to obtain the abbreviation of an Alibaba Cloud service name, see the <c>ProductCode</c> parameter in <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a>.</para>
        /// </remarks>
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
        /// <para>For more information about how to obtain the quota ID of an Alibaba Cloud service, see the <c>QuotaActionCode</c> parameter in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
        /// </remarks>
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
        /// <item><description><para>CommonQuota (default): general quota.</para>
        /// </description></item>
        /// <item><description><para>WhiteListLabel: privilege.</para>
        /// </description></item>
        /// <item><description><para>FlowControl: API rate limit.</para>
        /// </description></item>
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

