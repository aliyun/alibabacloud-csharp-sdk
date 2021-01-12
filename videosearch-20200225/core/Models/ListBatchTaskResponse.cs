// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videosearch20200225.Models
{
    public class ListBatchTaskResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListBatchTaskResponseData Data { get; set; }
        public class ListBatchTaskResponseData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=true)]
            public long? Count { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public long? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public long? PageSize { get; set; }
            [NameInMap("List")]
            [Validation(Required=true)]
            public List<ListBatchTaskResponseDataList> List { get; set; }
            public class ListBatchTaskResponseDataList : TeaModel {
                public long? TaskId { get; set; }
                public int? Status { get; set; }
                public int? TaskType { get; set; }
                public string RegionId { get; set; }
                public string BucketName { get; set; }
                public string DataPath { get; set; }
                public string MetaFile { get; set; }
                public long? ModifiedTime { get; set; }
                public string ProcessMessage { get; set; }
            }
        };

    }

}
