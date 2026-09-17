// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKnowledgeBaseFileShardsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E5CD764-xxxx-xxxx-xxxx-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The shard information.</para>
        /// </summary>
        [NameInMap("Shards")]
        [Validation(Required=false)]
        public List<DescribeKnowledgeBaseFileShardsResponseBodyShards> Shards { get; set; }
        public class DescribeKnowledgeBaseFileShardsResponseBodyShards : TeaModel {
            /// <summary>
            /// <para>The list of figure or table captions associated with the shard.</para>
            /// </summary>
            [NameInMap("Captions")]
            [Validation(Required=false)]
            public List<string> Captions { get; set; }

            /// <summary>
            /// <para>The list of Docling source document structured element references associated with the shard. You can use these references to precisely locate original document elements.</para>
            /// </summary>
            [NameInMap("DocItems")]
            [Validation(Required=false)]
            public List<string> DocItems { get; set; }

            /// <summary>
            /// <para>The chain of section headings to which the shard belongs.</para>
            /// </summary>
            [NameInMap("Headings")]
            [Validation(Required=false)]
            public List<string> Headings { get; set; }

            /// <summary>
            /// <para>The list of image resources referenced by the shard.</para>
            /// </summary>
            [NameInMap("ImageResources")]
            [Validation(Required=false)]
            public List<DescribeKnowledgeBaseFileShardsResponseBodyShardsImageResources> ImageResources { get; set; }
            public class DescribeKnowledgeBaseFileShardsResponseBodyShardsImageResources : TeaModel {
                /// <summary>
                /// <para>The index of the source document to which the image belongs, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DocumentIndex")]
                [Validation(Required=false)]
                public int? DocumentIndex { get; set; }

                /// <summary>
                /// <para>The unique ID of the image resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>document-0/pictures/1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The element reference of the image in the Docling source document structure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#/pictures/1</para>
                /// </summary>
                [NameInMap("ItemRef")]
                [Validation(Required=false)]
                public string ItemRef { get; set; }

                /// <summary>
                /// <para>The media type of the image resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image/png</para>
                /// </summary>
                [NameInMap("MimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

                /// <summary>
                /// <para>The OSS URI of the image resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://my-bucket/results/my-space/doc-001/artifacts/image-1.png</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <para>The list of page numbers to which the shard belongs.</para>
            /// </summary>
            [NameInMap("PageNumbers")]
            [Validation(Required=false)]
            public List<string> PageNumbers { get; set; }

            /// <summary>
            /// <para>The text content of the shard.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ShardContent")]
            [Validation(Required=false)]
            public string ShardContent { get; set; }

            /// <summary>
            /// <para>The index of the shard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShardIndex")]
            [Validation(Required=false)]
            public int? ShardIndex { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
