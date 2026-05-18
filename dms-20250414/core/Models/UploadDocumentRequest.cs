// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UploadDocumentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ChunkOverlap")]
        [Validation(Required=false)]
        public long? ChunkOverlap { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>250</para>
        /// </summary>
        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public long? ChunkSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ADBPGLoader</para>
        /// </summary>
        [NameInMap("DocumentLoaderName")]
        [Validation(Required=false)]
        public string DocumentLoaderName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.md</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-***</para>
        /// </summary>
        [NameInMap("KbUuid")]
        [Validation(Required=false)]
        public string KbUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("Separators")]
        [Validation(Required=false)]
        public List<string> Separators { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen3-8b</para>
        /// </summary>
        [NameInMap("SplitterModel")]
        [Validation(Required=false)]
        public string SplitterModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ChineseRecursiveTextSplitter</para>
        /// </summary>
        [NameInMap("TextSplitterName")]
        [Validation(Required=false)]
        public string TextSplitterName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VlEnhance")]
        [Validation(Required=false)]
        public bool? VlEnhance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZhTitleEnhance")]
        [Validation(Required=false)]
        public bool? ZhTitleEnhance { get; set; }

    }

}
