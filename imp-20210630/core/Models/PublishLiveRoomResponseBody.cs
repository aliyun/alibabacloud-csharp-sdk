// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class PublishLiveRoomResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 创建场景化直播返回的结果。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public PublishLiveRoomResponseBodyResult Result { get; set; }
        public class PublishLiveRoomResponseBodyResult : TeaModel {
            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }
            [NameInMap("LiveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }
            [NameInMap("PushUrl")]
            [Validation(Required=false)]
            public string PushUrl { get; set; }
        };

    }

}
