// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateDownloadDataJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDownloadDataJobResponseBodyData Data { get; set; }
        public class CreateDownloadDataJobResponseBodyData : TeaModel {
            [NameInMap("AsyncExecute")]
            [Validation(Required=false)]
            public bool? AsyncExecute { get; set; }

            [NameInMap("CsvFileName")]
            [Validation(Required=false)]
            public string CsvFileName { get; set; }

            [NameInMap("CsvUrl")]
            [Validation(Required=false)]
            public string CsvUrl { get; set; }

            [NameInMap("LongJobId")]
            [Validation(Required=false)]
            public string LongJobId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
