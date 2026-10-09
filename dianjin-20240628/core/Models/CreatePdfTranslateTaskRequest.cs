// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreatePdfTranslateTaskRequest : TeaModel {
        /// <summary>
        /// <para>The document ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>873648346573245</para>
        /// </summary>
        [NameInMap("docId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>The domain knowledge referenced during translation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Net Profit
        /// English: Net Profit
        /// Chinese: Net profit (typically refers to the profit after deducting all expenses and taxes)</para>
        /// </summary>
        [NameInMap("knowledge")]
        [Validation(Required=false)]
        public string Knowledge { get; set; }

        /// <summary>
        /// <para>The document library ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cjshcxxxx</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// <para>The model ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The target language. Default value: Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chinese</para>
        /// </summary>
        [NameInMap("translateTo")]
        [Validation(Required=false)]
        public string TranslateTo { get; set; }

    }

}
