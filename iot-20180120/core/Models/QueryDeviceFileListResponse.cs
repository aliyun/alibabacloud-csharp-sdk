// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceFileListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDeviceFileListResponseData Data { get; set; }
        public class QueryDeviceFileListResponseData : TeaModel {
            [NameInMap("FileSummary")]
            [Validation(Required=true)]
            public List<QueryDeviceFileListResponseDataFileSummary> FileSummary { get; set; }
            public class QueryDeviceFileListResponseDataFileSummary : TeaModel {
                public string FileId { get; set; }
                public string Name { get; set; }
                public string Size { get; set; }
                public string UtcCreatedOn { get; set; }
            }
        };

    }

}
