// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceFileResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDeviceFileResponseData Data { get; set; }
        public class QueryDeviceFileResponseData : TeaModel {
            [NameInMap("DownloadUrl")]
            [Validation(Required=true)]
            public string DownloadUrl { get; set; }

            [NameInMap("FileId")]
            [Validation(Required=true)]
            public string FileId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("Size")]
            [Validation(Required=true)]
            public string Size { get; set; }

            [NameInMap("UtcCreatedOn")]
            [Validation(Required=true)]
            public string UtcCreatedOn { get; set; }

        }

    }

}
