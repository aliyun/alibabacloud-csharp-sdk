// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetClassRecordResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// API请求的返回结果结构体。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetClassRecordResponseBodyResult Result { get; set; }
        public class GetClassRecordResponseBodyResult : TeaModel {
            [NameInMap("PlaybackUrlMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> PlaybackUrlMap { get; set; }
        };

    }

}
