// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKnowledgeBasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of knowledge bases.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeKnowledgeBasesResponseBodyItems> Items { get; set; }
        public class DescribeKnowledgeBasesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The number of AI applications bound to the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BindingAppCount")]
            [Validation(Required=false)]
            public int? BindingAppCount { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-25T09:37:10Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDesc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The unique identifier of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pkb-xxxxxx</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The ID of the knowledge space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pks-xxxxxx</para>
            /// </summary>
            [NameInMap("KnowledgeSpaceId")]
            [Validation(Required=false)]
            public string KnowledgeSpaceId { get; set; }

            /// <summary>
            /// <para>The name of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Activation</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total number of documents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalDocs")]
            [Validation(Required=false)]
            public int? TotalDocs { get; set; }

            /// <summary>
            /// <para>The total size in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231984</para>
            /// </summary>
            [NameInMap("TotalSizeBytes")]
            [Validation(Required=false)]
            public long? TotalSizeBytes { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>Default value: <b>30</b>.</para>
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
        /// <para>CDB3258F-B5DE-43C4-8935-CBA0CA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
