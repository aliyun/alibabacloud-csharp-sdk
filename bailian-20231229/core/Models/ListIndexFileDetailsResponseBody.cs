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
                /// <summary>
                /// <b>Example:</b>
                /// <para>DashSplitter</para>
                /// </summary>
                [NameInMap("ChunkMode")]
                [Validation(Required=false)]
                public string ChunkMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("ChunkSize")]
                [Validation(Required=false)]
                public string ChunkSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>110002</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("DocumentType")]
                [Validation(Required=false)]
                public string DocumentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableHeaders")]
                [Validation(Required=false)]
                public string EnableHeaders { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1744856423000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>doc_c134aa2073204a5d936d870bf960f56axxxxxxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>check fileUrlKey[file_path] / fileNameKey[null] / fileExtensionKey[file_extension] is invalid</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OverlapSize")]
                [Validation(Required=false)]
                public string OverlapSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>996764</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cate_21a407a3372c4ba7aedc649709143f0cxxxxxxxx</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot; &quot;</para>
                /// </summary>
                [NameInMap("separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>79c0alxxxx</para>
            /// </summary>
            [NameInMap("IndexId")]
            [Validation(Required=false)]
            public string IndexId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
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
