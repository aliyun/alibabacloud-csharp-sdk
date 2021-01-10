// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class ListMyAlgorithmResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMyAlgorithmResponseBodyData Data { get; set; }
        public class ListMyAlgorithmResponseBodyData : TeaModel {
            [NameInMap("AlgorithmList")]
            [Validation(Required=false)]
            public List<ListMyAlgorithmResponseBodyDataAlgorithmList> AlgorithmList { get; set; }
            public class ListMyAlgorithmResponseBodyDataAlgorithmList : TeaModel {
                public string AlgorithmName { get; set; }
                public string DeployRegion { get; set; }
                public int? CurrentMonthCount { get; set; }
                public string AlgorithmCode { get; set; }
                public string ApiDocUrl { get; set; }
                public int? YesterdayCount { get; set; }
                public int? AlgorithmOrder { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
