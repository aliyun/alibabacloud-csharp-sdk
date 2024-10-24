// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateWebofficeTokenRequest : TeaModel {
        [NameInMap("CachePreview")]
        [Validation(Required=false)]
        public bool? CachePreview { get; set; }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("ExternalUploaded")]
        [Validation(Required=false)]
        public bool? ExternalUploaded { get; set; }

        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("Hidecmb")]
        [Validation(Required=false)]
        public bool? Hidecmb { get; set; }

        /// <summary>
        /// 消息通知配置，支持使用MNS、RocketMQ接收异步消息通知。
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Permission")]
        [Validation(Required=false)]
        public WebofficePermission Permission { get; set; }

        [NameInMap("PreviewPages")]
        [Validation(Required=false)]
        public long? PreviewPages { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Referer")]
        [Validation(Required=false)]
        public string Referer { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public WebofficeUser User { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public WebofficeWatermark Watermark { get; set; }

    }

}
