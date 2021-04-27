// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceFileResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceFileResponseBodyData Data { get; set; }
        public class QueryDeviceFileResponseBodyData : TeaModel {
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }
            [NameInMap("UtcCreatedOn")]
            [Validation(Required=false)]
            public string UtcCreatedOn { get; set; }
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }
        };

    }

}
