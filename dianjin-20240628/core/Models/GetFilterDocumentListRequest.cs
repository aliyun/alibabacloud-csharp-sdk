// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetFilterDocumentListRequest : TeaModel {
        /// <summary>
        /// <para>AND expression to filter documents or document chunks.</para>
        /// </summary>
        [NameInMap("and")]
        [Validation(Required=false)]
        public List<GetFilterDocumentListRequestAnd> And { get; set; }
        public class GetFilterDocumentListRequestAnd : TeaModel {
            /// <summary>
            /// <para>Weight of the value in the text retrieval engine. Default is 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("boost")]
            [Validation(Required=false)]
            public float? Boost { get; set; }

            /// <summary>
            /// <para>Metadata key in the document library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>company</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <h3>Relationship between the stored metadata value and your input value</h3>
            /// <list type="bullet">
            /// <item><description><para>eq: The stored metadata value equals your input value.</para>
            /// </description></item>
            /// <item><description><para>contains: The stored metadata value list contains your input value.</para>
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
            /// <para>Input metadata value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>List of document IDs to filter documents or document chunks.</para>
        /// </summary>
        [NameInMap("docIdList")]
        [Validation(Required=false)]
        public List<string> DocIdList { get; set; }

        /// <summary>
        /// <para>Document library ID to filter documents or document chunks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cjshcxxxx</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// <para>OR expression to filter documents or document chunks.</para>
        /// </summary>
        [NameInMap("or")]
        [Validation(Required=false)]
        public List<GetFilterDocumentListRequestOr> Or { get; set; }
        public class GetFilterDocumentListRequestOr : TeaModel {
            /// <summary>
            /// <para>Weight of the value in the text retrieval engine. Default is 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("boost")]
            [Validation(Required=false)]
            public float? Boost { get; set; }

            /// <summary>
            /// <para>Metadata key in the document library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>company</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <h3>Relationship between the stored metadata value and your input value</h3>
            /// <list type="bullet">
            /// <item><description><para>eq: The stored metadata value equals your input value.</para>
            /// </description></item>
            /// <item><description><para>contains: The stored metadata value list contains your input value.</para>
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
            /// <para>Input metadata value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Page number for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>Number of records per page for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>List of document statuses to filter documents.</para>
        /// <h3>Document parsing status codes</h3>
        /// <para><em>Status codes: WaitRefresh, InQueue, FetchingData, Embedding, Completed, FormatError, Error</em></para>
        /// <list type="bullet">
        /// <item><description><para>Completed: Active. Document parsing completed.</para>
        /// </description></item>
        /// <item><description><para>Error: Inactive. Document parsing failed.</para>
        /// </description></item>
        /// <item><description><para>FormatError: File format error. Re-upload the file in the correct format if it is encrypted or incomplete.</para>
        /// </description></item>
        /// <item><description><para>InQueue: Pending. Document is waiting for parsing.</para>
        /// </description></item>
        /// <item><description><para>Parsed: Parsing completed.</para>
        /// </description></item>
        /// <item><description><para>Other statuses are internal system states. For example, WaitRefresh means the task is scheduled. FetchingData means parsing is in progress. Embedding means index building is in progress.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

    }

}
