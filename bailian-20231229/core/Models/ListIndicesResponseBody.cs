// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListIndicesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIndicesResponseBodyData Data { get; set; }
        public class ListIndicesResponseBodyData : TeaModel {
            [NameInMap("Indices")]
            [Validation(Required=false)]
            public List<ListIndicesResponseBodyDataIndices> Indices { get; set; }
            public class ListIndicesResponseBodyDataIndices : TeaModel {
                [NameInMap("ChunkSize")]
                [Validation(Required=false)]
                public int? ChunkSize { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DocumentIds")]
                [Validation(Required=false)]
                public List<string> DocumentIds { get; set; }

                [NameInMap("EmbeddingModelName")]
                [Validation(Required=false)]
                public string EmbeddingModelName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OverlapSize")]
                [Validation(Required=false)]
                public int? OverlapSize { get; set; }

                [NameInMap("RerankMinScore")]
                [Validation(Required=false)]
                public string RerankMinScore { get; set; }

                [NameInMap("RerankModelName")]
                [Validation(Required=false)]
                public string RerankModelName { get; set; }

                [NameInMap("Separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

                [NameInMap("SinkInstanceId")]
                [Validation(Required=false)]
                public string SinkInstanceId { get; set; }

                [NameInMap("SinkRegion")]
                [Validation(Required=false)]
                public string SinkRegion { get; set; }

                [NameInMap("SinkType")]
                [Validation(Required=false)]
                public string SinkType { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("StructureType")]
                [Validation(Required=false)]
                public string StructureType { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
