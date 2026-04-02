// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListChunksResponseBody : TeaModel {
        [NameInMap("Chunks")]
        [Validation(Required=false)]
        public ListChunksResponseBodyChunks Chunks { get; set; }
        public class ListChunksResponseBodyChunks : TeaModel {
            [NameInMap("chunks")]
            [Validation(Required=false)]
            public List<ListChunksResponseBodyChunksChunks> Chunks { get; set; }
            public class ListChunksResponseBodyChunksChunks : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LoaderMetadata")]
                [Validation(Required=false)]
                public string LoaderMetadata { get; set; }

                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public long? PageIndex { get; set; }

                [NameInMap("Vector")]
                [Validation(Required=false)]
                public ListChunksResponseBodyChunksChunksVector Vector { get; set; }
                public class ListChunksResponseBodyChunksChunksVector : TeaModel {
                    [NameInMap("vector")]
                    [Validation(Required=false)]
                    public List<double?> Vector { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public long? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>34b32a0a-08ef-4a87-b6be-cdd9f56fc3ad</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
