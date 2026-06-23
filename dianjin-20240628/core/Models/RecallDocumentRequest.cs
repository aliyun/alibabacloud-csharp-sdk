// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RecallDocumentRequest : TeaModel {
        /// <summary>
        /// <para>Metadata filter conditions.</para>
        /// </summary>
        [NameInMap("filters")]
        [Validation(Required=false)]
        public List<RecallDocumentRequestFilters> Filters { get; set; }
        public class RecallDocumentRequestFilters : TeaModel {
            /// <summary>
            /// <para>AND expression, used to filter documents/document chunks.</para>
            /// </summary>
            [NameInMap("and")]
            [Validation(Required=false)]
            public List<RecallDocumentRequestFiltersAnd> And { get; set; }
            public class RecallDocumentRequestFiltersAnd : TeaModel {
                /// <summary>
                /// <para>Keyword weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("boost")]
                [Validation(Required=false)]
                public float? Boost { get; set; }

                /// <summary>
                /// <para>The key of the metadata in the document library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>docType</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The relationship between the value stored in the document library metadata key and the value you enter.</para>
                /// <list type="bullet">
                /// <item><description><para>eq: The value stored in the document library metadata key equals the value you enter.</para>
                /// </description></item>
                /// <item><description><para>lte: The value stored in the document library metadata key is less than or equal to the value you enter.</para>
                /// </description></item>
                /// <item><description><para>gte: The value stored in the document library metadata key is greater than or equal to the value you enter.</para>
                /// </description></item>
                /// <item><description><para>lt: The value stored in the document library metadata key is less than the value you enter.</para>
                /// </description></item>
                /// <item><description><para>gt: The value stored in the document library metadata key is greater than the value you enter.</para>
                /// </description></item>
                /// <item><description><para>contains: The list of values stored in the document library metadata key contains the value you enter.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>contains</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The value of the metadata you enter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>策略报告</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Document chunk type, used to filter document chunks, such as: Text, Graph, Table, FAQ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Text</para>
            /// </summary>
            [NameInMap("chunkType")]
            [Validation(Required=false)]
            public string ChunkType { get; set; }

            /// <summary>
            /// <para>Document ID list, used to filter documents/document chunks.</para>
            /// </summary>
            [NameInMap("docIdList")]
            [Validation(Required=false)]
            public List<string> DocIdList { get; set; }

            /// <summary>
            /// <para>Document library ID, used to filter documents/document chunks.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sdbjhvs</para>
            /// </summary>
            [NameInMap("libraryId")]
            [Validation(Required=false)]
            public string LibraryId { get; set; }

            /// <summary>
            /// <para>OR expression, used to filter documents/document chunks.</para>
            /// </summary>
            [NameInMap("or")]
            [Validation(Required=false)]
            public List<RecallDocumentRequestFiltersOr> Or { get; set; }
            public class RecallDocumentRequestFiltersOr : TeaModel {
                /// <summary>
                /// <para>Keyword weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("boost")]
                [Validation(Required=false)]
                public float? Boost { get; set; }

                /// <summary>
                /// <para>The key of the metadata in the document library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>researcher</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The relationship between the value stored in the document library metadata key and the value you enter.</para>
                /// <list type="bullet">
                /// <item><description><para>eq: The value stored in the document library metadata key equals the value you enter.</para>
                /// </description></item>
                /// <item><description><para>lte: The value stored in the document library metadata key is less than or equal to the value you enter.</para>
                /// </description></item>
                /// <item><description><para>gte: The value stored in the document library metadata key is greater than or equal to the value you enter.</para>
                /// </description></item>
                /// <item><description><para>lt: The value stored in the document library metadata key is less than the value you enter.</para>
                /// </description></item>
                /// <item><description><para>gt: The value stored in the document library metadata key is greater than the value you enter.</para>
                /// </description></item>
                /// <item><description><para>contains: The list of values stored in the document library metadata key contains the value you enter.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The value of the metadata you enter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Document status list, used to filter documents.</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public List<string> Status { get; set; }

        }

        /// <summary>
        /// <para>Text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>欧洲杯历史上有哪些球队因为球员的适应新文化而受益</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Enable parent-child document chunk retrieval.</para>
        /// <list type="bullet">
        /// <item><description>Parent-child document chunks: During document parsing, a complete semantic block, such as a paragraph or a section, might split into multiple document chunks. This depends on your chunking strategy. When you enable parent-child document retrieval, the system attempts to complete the semantic block of the retrieved document chunk. This makes the corpus more semantically complete when constructing prompts, improving answer completeness and accuracy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("rearrangement")]
        [Validation(Required=false)]
        public bool? Rearrangement { get; set; }

        /// <summary>
        /// <para>The number of document chunks to retrieve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("topK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

    }

}
