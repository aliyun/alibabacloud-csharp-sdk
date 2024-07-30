// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmInstanceConfigAlertRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh-CN: Chinese
        /// *   en-US: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The alert configurations.
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<UpdateCloudGtmInstanceConfigAlertRequestAlertConfig> AlertConfig { get; set; }
        public class UpdateCloudGtmInstanceConfigAlertRequestAlertConfig : TeaModel {
            /// <summary>
            /// Specifies whether to configure DingTalk notifications. Valid values:
            /// 
            /// *   true: DingTalk notifications are configured. DingTalk notifications are sent when alerts are triggered.
            /// *   false: DingTalk notifications are not configured.
            /// </summary>
            [NameInMap("DingtalkNotice")]
            [Validation(Required=false)]
            public bool? DingtalkNotice { get; set; }

            /// <summary>
            /// Specifies whether to configure email notifications. Valid values:
            /// 
            /// *   true: Email notifications are configured. Emails are sent when alerts are triggered.
            /// *   false: Email notifications are not configured.
            /// </summary>
            [NameInMap("EmailNotice")]
            [Validation(Required=false)]
            public bool? EmailNotice { get; set; }

            /// <summary>
            /// The type of the alert event. Valid values:
            /// 
            /// *   addr_alert: The address is unavailable.
            /// *   addr_resume: The address becomes available.
            /// *   addr_pool_unavailable: The address pool is unavailable.
            /// *   addr_pool_available: The address pool becomes available.
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public string NoticeType { get; set; }

            /// <summary>
            /// Specifies whether to configure text message notifications. Valid values:
            /// 
            /// *   true: Text message notifications are configured. Text messages are sent when alerts are triggered.
            /// *   false: Text message notifications are not configured.
            /// 
            /// Only the China site (aliyun.com) supports text message notifications.
            /// </summary>
            [NameInMap("SmsNotice")]
            [Validation(Required=false)]
            public bool? SmsNotice { get; set; }

        }

        /// <summary>
        /// The alert contact groups.
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public List<string> AlertGroup { get; set; }

        /// <summary>
        /// The alert configuration mode of the instance. Valid values:
        /// 
        /// *   global: global alert configuration
        /// *   instance_config: custom alert configuration
        /// </summary>
        [NameInMap("AlertMode")]
        [Validation(Required=false)]
        public string AlertMode { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The configuration ID of the access domain name. Two configuration IDs exist when an A record and an AAAA record are configured for the access domain name that is bound to the GTM instance. This ID uniquely identifies a configuration.
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// The ID of the Global Traffic Manager (GTM) 3.0 instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
