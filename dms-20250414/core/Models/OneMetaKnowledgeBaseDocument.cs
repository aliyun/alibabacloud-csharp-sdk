// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaKnowledgeBaseDocument : TeaModel {
        /// <summary>
        /// <para>The document description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The number of chunks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DocsCount")]
        [Validation(Required=false)]
        public int? DocsCount { get; set; }

        /// <summary>
        /// <para>The name of the document loader.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADBPGLoader</para>
        /// </summary>
        [NameInMap("DocumentLoaderName")]
        [Validation(Required=false)]
        public string DocumentLoaderName { get; set; }

        /// <summary>
        /// <para>The file extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md</para>
        /// </summary>
        [NameInMap("FileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        /// <summary>
        /// <para>The file size, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20307</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>When the document was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-22 22:59:35</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>When the document was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-24 21:22:53</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The knowledge base ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-***</para>
        /// </summary>
        [NameInMap("KbUuid")]
        [Validation(Required=false)]
        public string KbUuid { get; set; }

        /// <summary>
        /// <para>Keywords extracted from the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;test&quot;,&quot;abc&quot;]</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <para>The document name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.md</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The document status. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Complete.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: Unprocessed.</para>
        /// </description></item>
        /// <item><description><para><b>-2</b>: Parsing.</para>
        /// </description></item>
        /// <item><description><para><b>-3</b>: Failed.</para>
        /// </description></item>
        /// <item><description><para><b>-4</b>: Canceled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

        /// <summary>
        /// <para>The summary of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test document.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The name of the text splitter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChineseRecursiveTextSplitter</para>
        /// </summary>
        [NameInMap("TextSplitterName")]
        [Validation(Required=false)]
        public string TextSplitterName { get; set; }

    }

}
