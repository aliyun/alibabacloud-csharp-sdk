// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GenerateOssUrlResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GenerateOssUrlResponseBodyData> Data { get; set; }
        public class GenerateOssUrlResponseBodyData : TeaModel {
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
