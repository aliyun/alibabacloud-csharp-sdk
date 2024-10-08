// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetFilterDocumentListRequest : TeaModel {
        [NameInMap("and")]
        [Validation(Required=false)]
        public List<GetFilterDocumentListRequestAnd> And { get; set; }
        public class GetFilterDocumentListRequestAnd : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("boost")]
            [Validation(Required=false)]
            public float? Boost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>company</para>
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
            /// <para>alibaba</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("docIdList")]
        [Validation(Required=false)]
        public List<string> DocIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cjshcxxxx</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        [NameInMap("or")]
        [Validation(Required=false)]
        public List<GetFilterDocumentListRequestOr> Or { get; set; }
        public class GetFilterDocumentListRequestOr : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("boost")]
            [Validation(Required=false)]
            public float? Boost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>company</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

    }

}
