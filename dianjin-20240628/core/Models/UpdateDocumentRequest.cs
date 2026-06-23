// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class UpdateDocumentRequest : TeaModel {
        /// <summary>
        /// <para>Document ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("docId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>Document library ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc123</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// <para>Document metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;businessId&quot;: &quot;12321&quot;
        ///     }</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public Dictionary<string, object> Meta { get; set; }

        /// <summary>
        /// <para>Document title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
