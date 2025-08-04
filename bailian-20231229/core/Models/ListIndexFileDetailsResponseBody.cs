// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListIndexFileDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIndexFileDetailsResponseBodyData Data { get; set; }
        public class ListIndexFileDetailsResponseBodyData : TeaModel {
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<ListIndexFileDetailsResponseBodyDataDocuments> Documents { get; set; }
            public class ListIndexFileDetailsResponseBodyDataDocuments : TeaModel {
                [NameInMap("ChunkMode")]
                [Validation(Required=false)]
                public string ChunkMode { get; set; }

                [NameInMap("ChunkSize")]
                [Validation(Required=false)]
                public string ChunkSize { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("DocumentType")]
                [Validation(Required=false)]
                public string DocumentType { get; set; }

                [NameInMap("EnableHeaders")]
                [Validation(Required=false)]
                public string EnableHeaders { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OverlapSize")]
                [Validation(Required=false)]
                public string OverlapSize { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

            }

            [NameInMap("IndexId")]
            [Validation(Required=false)]
            public string IndexId { get; set; }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Required parameter(%s) missing or invalid, please check the request parameters.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>35A267BF-xxxx-54DB-8394-AA3B0742D833</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
