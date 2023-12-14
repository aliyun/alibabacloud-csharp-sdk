// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListImportedLogsByProdResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListImportedLogsByProdResponseBodyData> Data { get; set; }
        public class ListImportedLogsByProdResponseBodyData : TeaModel {
            [NameInMap("AutoImported")]
            [Validation(Required=false)]
            public int? AutoImported { get; set; }

            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            [NameInMap("Imported")]
            [Validation(Required=false)]
            public int? Imported { get; set; }

            [NameInMap("ImportedUserCount")]
            [Validation(Required=false)]
            public int? ImportedUserCount { get; set; }

            [NameInMap("LogCode")]
            [Validation(Required=false)]
            public string LogCode { get; set; }

            [NameInMap("LogMdsCode")]
            [Validation(Required=false)]
            public string LogMdsCode { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("ProdCode")]
            [Validation(Required=false)]
            public string ProdCode { get; set; }

            [NameInMap("TotalUserCount")]
            [Validation(Required=false)]
            public int? TotalUserCount { get; set; }

            [NameInMap("UnImportedUserCount")]
            [Validation(Required=false)]
            public int? UnImportedUserCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
