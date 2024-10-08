// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreatePdfTranslateTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>873648346573245</para>
        /// </summary>
        [NameInMap("docId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        [NameInMap("knowledge")]
        [Validation(Required=false)]
        public string Knowledge { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cjshcxxxx</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中文</para>
        /// </summary>
        [NameInMap("translateTo")]
        [Validation(Required=false)]
        public string TranslateTo { get; set; }

    }

}
