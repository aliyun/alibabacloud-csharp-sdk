// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListEventAlgorithmResultsResponseBody : TeaModel {
        [NameInMap("ExtendValue")]
        [Validation(Required=false)]
        public string ExtendValue { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEventAlgorithmResultsResponseBodyData Data { get; set; }
        public class ListEventAlgorithmResultsResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListEventAlgorithmResultsResponseBodyDataRecords> Records { get; set; }
            public class ListEventAlgorithmResultsResponseBodyDataRecords : TeaModel {
                public string ExtendValueTwo { get; set; }
                public string RecordId { get; set; }
                public string PicUrlPath { get; set; }
                public string DataSourceId { get; set; }
                public string ExtendValue { get; set; }
                public string ExtendValueThree { get; set; }
                public string FaceCount { get; set; }
                public string TargetPicUrlPath { get; set; }
                public string EventType { get; set; }
                public string CorpId { get; set; }
                public string ShotTime { get; set; }
                public string CapStyle { get; set; }
                public string TagCode { get; set; }
                public string TagCodeReliability { get; set; }
                public string UuidCode { get; set; }
            }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
