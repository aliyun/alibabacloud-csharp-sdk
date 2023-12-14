// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAllProdsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAllProdsResponseBodyData Data { get; set; }
        public class ListAllProdsResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("ProdList")]
            [Validation(Required=false)]
            public List<ListAllProdsResponseBodyDataProdList> ProdList { get; set; }
            public class ListAllProdsResponseBodyDataProdList : TeaModel {
                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                [NameInMap("ImportedLogCount")]
                [Validation(Required=false)]
                public int? ImportedLogCount { get; set; }

                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                [NameInMap("ProdCode")]
                [Validation(Required=false)]
                public string ProdCode { get; set; }

                [NameInMap("TotalLogCount")]
                [Validation(Required=false)]
                public int? TotalLogCount { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
