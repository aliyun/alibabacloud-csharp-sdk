// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dop20221130.Models
{
    public class GetOssMetaListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOssMetaListResponseBodyData> Data { get; set; }
        public class GetOssMetaListResponseBodyData : TeaModel {
            [NameInMap("ds")]
            [Validation(Required=false)]
            public string Ds { get; set; }

            [NameInMap("fileNames")]
            [Validation(Required=false)]
            public List<string> FileNames { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            [NameInMap("rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
