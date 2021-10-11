// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi20210930.Models
{
    public class AiStoreReceiveConfig : TeaModel {
        /// <summary>
        /// 事件总线
        /// </summary>
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
        };

        /// <summary>
        /// MNS消息
        /// </summary>
        [NameInMap("Mns")]
        [Validation(Required=false)]
        public AiStoreReceiveConfigMns Mns { get; set; }
        public class AiStoreReceiveConfigMns : TeaModel {
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }
        };

    }

}
