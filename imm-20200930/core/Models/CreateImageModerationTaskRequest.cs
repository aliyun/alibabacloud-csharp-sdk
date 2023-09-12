// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateImageModerationTaskRequest : TeaModel {
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        [NameInMap("MaxFrames")]
        [Validation(Required=false)]
        public long? MaxFrames { get; set; }

        /// <summary>
        /// 消息通知配置，支持使用MNS、RocketMQ接收异步消息通知。
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Scenes")]
        [Validation(Required=false)]
        public List<string> Scenes { get; set; }

        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
