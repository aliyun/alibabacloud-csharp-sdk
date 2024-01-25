// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20211130.Models
{
    public class GetComputeResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetComputeResultResponseBodyData Data { get; set; }
        public class GetComputeResultResponseBodyData : TeaModel {
            [NameInMap("bcId")]
            [Validation(Required=false)]
            public long? BcId { get; set; }

            [NameInMap("billedNum")]
            [Validation(Required=false)]
            public long? BilledNum { get; set; }

            [NameInMap("code10000Num")]
            [Validation(Required=false)]
            public long? Code10000Num { get; set; }

            [NameInMap("code108Num")]
            [Validation(Required=false)]
            public long? Code108Num { get; set; }

            [NameInMap("code109Num")]
            [Validation(Required=false)]
            public long? Code109Num { get; set; }

            [NameInMap("exportFileName")]
            [Validation(Required=false)]
            public string ExportFileName { get; set; }

            [NameInMap("fileLineNumber")]
            [Validation(Required=false)]
            public long? FileLineNumber { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

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
