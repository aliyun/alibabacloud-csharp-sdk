// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreatePdfTranslateTaskRequest : TeaModel {
        /// <summary>
        /// <para>Document ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>873648346573245</para>
        /// </summary>
        [NameInMap("docId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>Domain knowledge used as reference during translation</para>
        /// 
        /// <b>Example:</b>
        /// <para>净利润 (Net Profit)
        /// 英文：Net Profit
        /// 中文：净利润（通常指扣除所有费用和税后的利润）</para>
        /// </summary>
        [NameInMap("knowledge")]
        [Validation(Required=false)]
        public string Knowledge { get; set; }

        /// <summary>
        /// <para>Document library ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cjshcxxxx</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// <para>Model ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>Target language. Default is Chinese</para>
        /// 
        /// <b>Example:</b>
        /// <para>中文</para>
        /// </summary>
        [NameInMap("translateTo")]
        [Validation(Required=false)]
        public string TranslateTo { get; set; }

    }

}
