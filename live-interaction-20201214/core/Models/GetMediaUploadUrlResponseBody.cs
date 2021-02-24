// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetMediaUploadUrlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 调用返回值
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetMediaUploadUrlResponseBodyResult Result { get; set; }
        public class GetMediaUploadUrlResponseBodyResult : TeaModel {
            [NameInMap("UploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }
        };

    }

}
