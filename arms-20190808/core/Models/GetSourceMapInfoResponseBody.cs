// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSourceMapInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceMapList")]
        [Validation(Required=false)]
        public List<GetSourceMapInfoResponseBodySourceMapList> SourceMapList { get; set; }
        public class GetSourceMapInfoResponseBodySourceMapList : TeaModel {
            [NameInMap("Fid")]
            [Validation(Required=false)]
            public string Fid { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
