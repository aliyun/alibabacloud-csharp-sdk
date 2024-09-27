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
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The alert configurations.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<UpdateCloudGtmInstanceConfigAlertRequestAlertConfig> AlertConfig { get; set; }
        public class UpdateCloudGtmInstanceConfigAlertRequestAlertConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to configure DingTalk notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: configures DingTalk notifications. DingTalk notifications are sent when alerts are triggered.</description></item>
            /// <item><description>false: does not configure DingTalk notifications.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DingtalkNotice")]
            [Validation(Required=false)]
            public bool? DingtalkNotice { get; set; }

            /// <summary>
            /// <para>Specifies whether to configure email notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: configures email notifications. Emails are sent when alerts are triggered.</description></item>
            /// <item><description>false: does not configure email notifications.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EmailNotice")]
            [Validation(Required=false)]
            public bool? EmailNotice { get; set; }

            /// <summary>
            /// <para>The type of the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>addr_alert: The address is unavailable.</description></item>
            /// <item><description>addr_resume: The address becomes available.</description></item>
            /// <item><description>addr_pool_unavailable: The address pool is unavailable.</description></item>
            /// <item><description>addr_pool_available: The address pool becomes available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>addr_alert</para>
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public string NoticeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to configure text message notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: configures text message notifications. Text messages are sent when alerts are triggered.</description></item>
            /// <item><description>false: does not configure text message notifications.</description></item>
            /// </list>
            /// <para>Only the China site (aliyun.com) supports text message notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SmsNotice")]
            [Validation(Required=false)]
            public bool? SmsNotice { get; set; }

        }

        /// <summary>
        /// <para>The alert contact groups.</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public List<string> AlertGroup { get; set; }

        /// <summary>
        /// <para>The alert configuration mode of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>global: global alert configuration</description></item>
        /// <item><description>instance_config: custom alert configuration</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("AlertMode")]
        [Validation(Required=false)]
        public string AlertMode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configuration ID of the access domain name. Two configuration IDs exist when an A record and an AAAA record are configured for the access domain name that is bound to the GTM instance. This ID uniquely identifies a configuration.</para>
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
