// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmInstanceConfigAlertRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Chinese</para>
        /// </description></item>
        /// <item><description><para>en-US: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>A list of alert configurations.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<UpdateCloudGtmInstanceConfigAlertRequestAlertConfig> AlertConfig { get; set; }
        public class UpdateCloudGtmInstanceConfigAlertRequestAlertConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable DingTalk notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled. When an alert is triggered, a DingTalk message is sent.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DingtalkNotice")]
            [Validation(Required=false)]
            public bool? DingtalkNotice { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable email notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled. When an alert is triggered, an email is sent.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EmailNotice")]
            [Validation(Required=false)]
            public bool? EmailNotice { get; set; }

            /// <summary>
            /// <para>The type of alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>addr_alert: The address is unavailable.</para>
            /// </description></item>
            /// <item><description><para>addr_resume: The address has recovered.</para>
            /// </description></item>
            /// <item><description><para>addr_pool_unavailable: The address pool is unavailable.</para>
            /// </description></item>
            /// <item><description><para>addr_pool_available: The address pool has recovered.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>addr_alert</para>
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public string NoticeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable text message notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled. When an alert is triggered, a text message is sent.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>Note: Text message notifications are supported only on the China site (aliyun.com).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SmsNotice")]
            [Validation(Required=false)]
            public bool? SmsNotice { get; set; }

        }

        /// <summary>
        /// <para>A list of alert notification groups.</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public List<string> AlertGroup { get; set; }

        /// <summary>
        /// <para>The alert configuration mode for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>global: The instance inherits the global alert configuration.</para>
        /// </description></item>
        /// <item><description><para>instance_config: The instance uses a custom alert configuration.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("AlertMode")]
        [Validation(Required=false)]
        public string AlertMode { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request. The client must generate a unique value for this parameter. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the domain name instance configuration. A GTM instance can have two configurations for the same access domain name if you configure both A and AAAA records. The ConfigId uniquely identifies a configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000**11</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the Global Traffic Manager (GTM) 3.0 instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-zz11t58**0s</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
