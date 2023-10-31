// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class GetEnterpriseDataChunkResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetEnterpriseDataChunkResponseBodyData> Data { get; set; }
        public class GetEnterpriseDataChunkResponseBodyData : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("TitlePath")]
            [Validation(Required=false)]
            public string TitlePath { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
