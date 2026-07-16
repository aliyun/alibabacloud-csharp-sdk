// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddChunkShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The knowledge base ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc_xxx</para>
        /// </summary>
        [NameInMap("dataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        /// <summary>
        /// <para>The chunk content to insert, passed as key-value pairs. For document search knowledge bases, use the following fixed key list:</para>
        /// <list type="bullet">
        /// <item><description>content (<b>String</b>): <b>Required</b>. The body content of the chunk.</description></item>
        /// <item><description>title (<b>String</b>): <b>Optional</b>. The title of the chunk.</description></item>
        /// <item><description>image_urls (<b>Array</b>): <b>Optional</b>. Image URLs contained in the chunk. A maximum of 10 images are supported.</description></item>
        /// </list>
        /// <para>For data query and image Q&amp;A knowledge bases, the keys are not fixed and are determined by the data source spreadsheet of the knowledge base. The key is the Excel column header, and the value is the corresponding column value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;content&quot;: &quot;The Bailian platform supports parsing multiple document formats including PDF, Word, and PPT.&quot;,
        ///   &quot;title&quot;: &quot;Document Parsing and Chunking&quot;,
        ///   &quot;image_urls&quot;: [
        /// &quot;<a href="https://example.com/images/chunk-flow.png">https://example.com/images/chunk-flow.png</a>&quot;,
        ///   &quot;<a href="https://example.com/images/parsing-result.png">https://example.com/images/parsing-result.png</a>&quot;
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("field")]
        [Validation(Required=false)]
        public string FieldShrink { get; set; }

    }

}
