// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKnowledgeBaseFileShardsResponseBody : TeaModel {
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
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3E5CD764-xxxx-xxxx-xxxx-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Shards")]
        [Validation(Required=false)]
        public List<DescribeKnowledgeBaseFileShardsResponseBodyShards> Shards { get; set; }
        public class DescribeKnowledgeBaseFileShardsResponseBodyShards : TeaModel {
            [NameInMap("Headings")]
            [Validation(Required=false)]
            public List<string> Headings { get; set; }

            [NameInMap("PageNumbers")]
            [Validation(Required=false)]
            public List<string> PageNumbers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ShardContent")]
            [Validation(Required=false)]
            public string ShardContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShardIndex")]
            [Validation(Required=false)]
            public int? ShardIndex { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
