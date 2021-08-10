// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetHotspotSceneDataResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHotspotSceneDataResponseBodyData Data { get; set; }
        public class GetHotspotSceneDataResponseBodyData : TeaModel {
            [NameInMap("SceneType")]
            [Validation(Required=false)]
            public string SceneType { get; set; }
            [NameInMap("PreviewToken")]
            [Validation(Required=false)]
            public string PreviewToken { get; set; }
            [NameInMap("PreviewData")]
            [Validation(Required=false)]
            public string PreviewData { get; set; }
            [NameInMap("ModelToken")]
            [Validation(Required=false)]
            public string ModelToken { get; set; }
        };

    }

}
