// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListEventAlgorithmResultsResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ExtendValue")]
        [Validation(Required=true)]
        public string ExtendValue { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListEventAlgorithmResultsResponseData Data { get; set; }
        public class ListEventAlgorithmResultsResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=true)]
            public int? TotalPage { get; set; }
            [NameInMap("Records")]
            [Validation(Required=true)]
            public List<ListEventAlgorithmResultsResponseDataRecords> Records { get; set; }
            public class ListEventAlgorithmResultsResponseDataRecords : TeaModel {
                public string CapStyle { get; set; }
                public string CorpId { get; set; }
                public string DataSourceId { get; set; }
                public string EventType { get; set; }
                public string FaceCount { get; set; }
                public string PicUrlPath { get; set; }
                public string ShotTime { get; set; }
                public string TargetPicUrlPath { get; set; }
                public string RecordId { get; set; }
                public string ExtendValue { get; set; }
                public string ExtendValueTwo { get; set; }
                public string ExtendValueThree { get; set; }
            }
        };

    }

}
