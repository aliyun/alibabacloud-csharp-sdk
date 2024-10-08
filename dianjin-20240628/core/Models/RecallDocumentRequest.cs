// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RecallDocumentRequest : TeaModel {
        [NameInMap("filters")]
        [Validation(Required=false)]
        public List<RecallDocumentRequestFilters> Filters { get; set; }
        public class RecallDocumentRequestFilters : TeaModel {
            [NameInMap("and")]
            [Validation(Required=false)]
            public List<RecallDocumentRequestFiltersAnd> And { get; set; }
            public class RecallDocumentRequestFiltersAnd : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("boost")]
                [Validation(Required=false)]
                public float? Boost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>docType</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>contains</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Text</para>
            /// </summary>
            [NameInMap("chunkType")]
            [Validation(Required=false)]
            public string ChunkType { get; set; }

            [NameInMap("docIdList")]
            [Validation(Required=false)]
            public List<string> DocIdList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sdbjhvs</para>
            /// </summary>
            [NameInMap("libraryId")]
            [Validation(Required=false)]
            public string LibraryId { get; set; }

            [NameInMap("or")]
            [Validation(Required=false)]
            public List<RecallDocumentRequestFiltersOr> Or { get; set; }
            public class RecallDocumentRequestFiltersOr : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("boost")]
                [Validation(Required=false)]
                public float? Boost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>researcher</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public List<string> Status { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("rearrangement")]
        [Validation(Required=false)]
        public bool? Rearrangement { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("topK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

    }

}
