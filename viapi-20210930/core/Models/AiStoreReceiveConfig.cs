// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi20210930.Models
{
    public class AiStoreReceiveConfig : TeaModel {
        [NameInMap("Custom")]
        [Validation(Required=false)]
        public string Custom { get; set; }

        [NameInMap("DingTalk")]
        [Validation(Required=false)]
        public AiStoreReceiveConfigDingTalk DingTalk { get; set; }
        public class AiStoreReceiveConfigDingTalk : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("Secret")]
            [Validation(Required=false)]
            public string Secret { get; set; }

        }

        [NameInMap("EventBridge")]
        [Validation(Required=false)]
        public AiStoreReceiveConfigEventBridge EventBridge { get; set; }
        public class AiStoreReceiveConfigEventBridge : TeaModel {
            [NameInMap("EventBus")]
            [Validation(Required=false)]
            public string EventBus { get; set; }

            [NameInMap("EventRule")]
            [Validation(Required=false)]
            public string EventRule { get; set; }

        }

        [NameInMap("Http")]
        [Validation(Required=false)]
        public AiStoreReceiveConfigHttp Http { get; set; }
        public class AiStoreReceiveConfigHttp : TeaModel {
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("Https")]
        [Validation(Required=false)]
        public AiStoreReceiveConfigHttps Https { get; set; }
        public class AiStoreReceiveConfigHttps : TeaModel {
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("Mns")]
        [Validation(Required=false)]
        public AiStoreReceiveConfigMns Mns { get; set; }
        public class AiStoreReceiveConfigMns : TeaModel {
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

        }

        [NameInMap("RocketMQ")]
        [Validation(Required=false)]
        public AiStoreReceiveConfigRocketMQ RocketMQ { get; set; }
        public class AiStoreReceiveConfigRocketMQ : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

    }

}
