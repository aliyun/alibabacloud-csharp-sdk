// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListSceneParametersResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public ListSceneParametersResponseBodyResult Result { get; set; }
        public class ListSceneParametersResponseBodyResult : TeaModel {
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public List<string> SceneId { get; set; }

            [NameInMap("traceId")]
            [Validation(Required=false)]
            public List<string> TraceId { get; set; }

        }

    }

}
