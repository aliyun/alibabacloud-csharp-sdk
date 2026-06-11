// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class QueryMemoryListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMemoryListResponseBodyData Data { get; set; }
        public class QueryMemoryListResponseBodyData : TeaModel {
            [NameInMap("MemoryNodes")]
            [Validation(Required=false)]
            public List<QueryMemoryListResponseBodyDataMemoryNodes> MemoryNodes { get; set; }
            public class QueryMemoryListResponseBodyDataMemoryNodes : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                [NameInMap("MemoryNodeId")]
                [Validation(Required=false)]
                public string MemoryNodeId { get; set; }

                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public Dictionary<string, object> MetaData { get; set; }

                [NameInMap("MetaDataJson")]
                [Validation(Required=false)]
                public string MetaDataJson { get; set; }

                [NameInMap("OldContent")]
                [Validation(Required=false)]
                public string OldContent { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public string PageNum { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public string Total { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
