// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class DescribeStreamPredictResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("StreamPredictDatas")]
        [Validation(Required=false)]
        public List<DescribeStreamPredictResultResponseBodyStreamPredictDatas> StreamPredictDatas { get; set; }
        public class DescribeStreamPredictResultResponseBodyStreamPredictDatas : TeaModel {
            [NameInMap("PredictId")]
            [Validation(Required=false)]
            public string PredictId { get; set; }

            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            [NameInMap("DataUrl")]
            [Validation(Required=false)]
            public string DataUrl { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("PredictTime")]
            [Validation(Required=false)]
            public string PredictTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("PredictResult")]
            [Validation(Required=false)]
            public string PredictResult { get; set; }

        }

    }

}
