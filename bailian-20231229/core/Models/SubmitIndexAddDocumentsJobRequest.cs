// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class SubmitIndexAddDocumentsJobRequest : TeaModel {
        /// <summary>
        /// <para>A list of category IDs.</para>
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The custom chunking mode. This setting applies only to the documents added in the current job. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a>. Valid values (you can specify only one value):</para>
        /// <list type="bullet">
        /// <item><description><para><b>length</b>: Splits the text by a fixed length. The chunking strictly follows the specified <c>ChunkSize</c> and <c>OverlapSize</c>. If you do not specify these parameters, the system uses the default values: a <c>ChunkSize</c> of 500 and an <c>OverlapSize</c> of 100. This mode ignores the <c>Separator</c> parameter.</para>
        /// </description></item>
        /// <item><description><para><b>page</b>: Splits the text by page. If <c>ChunkSize</c> is specified, its value is also applied during chunking. If <c>ChunkSize</c> is not set, a default value of 500 is used. This mode ignores the <c>OverlapSize</c> and <c>Separator</c> parameters.</para>
        /// </description></item>
        /// <item><description><para><b>h1</b>: Splits the text by level-1 headings. If <c>ChunkSize</c> is specified, its value is also applied during chunking. If <c>ChunkSize</c> is not set, a default value of 500 is used. This mode ignores the <c>OverlapSize</c> and <c>Separator</c> parameters.</para>
        /// </description></item>
        /// <item><description><para><b>h2</b>: Splits the text by level-2 headings. If <c>ChunkSize</c> is specified, its value is also applied during chunking. If <c>ChunkSize</c> is not set, a default value of 500 is used. This mode ignores the <c>OverlapSize</c> and <c>Separator</c> parameters.</para>
        /// </description></item>
        /// <item><description><para><b>regex</b>: Splits the text by using a regular expression. The <c>Separator</c> parameter is required for this mode. If <c>ChunkSize</c> is specified, its value is also applied during chunking. If <c>ChunkSize</c> is not set, a default value of 500 is used. This mode ignores the <c>OverlapSize</c> parameter.</para>
        /// </description></item>
        /// </list>
        /// <para>If this parameter is not set, intelligent chunking is used by default.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not specify it.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>length</para>
        /// </summary>
        [NameInMap("ChunkMode")]
        [Validation(Required=false)]
        public string ChunkMode { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The chunk size. Specifies the maximum number of characters for each text chunk. This setting applies only to the documents added in the current job. If a text segment exceeds this size, the behavior depends on the chunking mode:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Intelligent chunking</b> (if <c>ChunkMode</c> is not set): The text may be truncated.</para>
        /// </description></item>
        /// <item><description><para><b>Custom chunking</b> (if <c>ChunkMode</c> is set): The text is forcibly split.</para>
        /// </description></item>
        /// </list>
        /// <para>The value must be in the range of [1, 6000]. Defaults to 500 if not specified.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a>.</para>
        /// <remarks>
        /// <para>If you specify a <c>ChunkSize</c> less than 100, you must also specify the <c>OverlapSize</c> parameter. You can also omit both parameters to use the system defaults.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not specify it.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// <para>A list of file IDs.</para>
        /// </summary>
        [NameInMap("DocumentIds")]
        [Validation(Required=false)]
        public List<string> DocumentIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to include Excel file headers. If set to <c>true</c>, the knowledge base treats the first row of all .xlsx and .xls files as the header and automatically prepends it to each text chunk (data row). This prevents the large language model (LLM) from misinterpreting the header as a regular data row.</para>
        /// <remarks>
        /// <para>Enable this parameter only if all imported documents are Excel files that contain a header.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableHeaders")]
        [Validation(Required=false)]
        public bool? EnableHeaders { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public SubmitIndexAddDocumentsJobRequestExtra Extra { get; set; }
        public class SubmitIndexAddDocumentsJobRequestExtra : TeaModel {
            [NameInMap("uniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

        }

        /// <summary>
        /// <para>The knowledge base ID. This is the <c>Data.Id</c> returned by the <b>CreateIndex</b> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>Specifies the number of overlapping characters between adjacent text chunks. This setting applies only to the documents added in the current job. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a>. The value must be in the range of [0, 1024].</para>
        /// <para>Defaults to 100 if not specified.</para>
        /// <remarks>
        /// <para>The value of <c>OverlapSize</c> must be less than the value of <c>ChunkSize</c>. Otherwise, the chunking process may fail.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not specify it.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("OverlapSize")]
        [Validation(Required=false)]
        public int? OverlapSize { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The separator for chunking. This parameter is used only when <c>ChunkMode</c> is set to <b>regex</b>. You can specify a single regular expression (multiple expressions are not supported) to split the file into smaller text chunks. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a>.</para>
        /// <para>When you use intelligent chunking (when <c>ChunkMode</c> is not specified), leave this parameter empty.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not available. Do not specify it.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>(?&lt;=。)</para>
        /// </summary>
        [NameInMap("Separator")]
        [Validation(Required=false)]
        public string Separator { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DATA_CENTER_CATEGORY: Imports all documents from specified categories in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">application data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">application data</a>. You can import documents from multiple categories.</para>
        /// </description></item>
        /// <item><description><para>DATA_CENTER_FILE: Imports specified files from &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">application data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">application data</a>. You can import multiple files.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to <c>DATA_CENTER_CATEGORY</c>, you must specify the <c>CategoryIds</c> parameter. If you set this parameter to <c>DATA_CENTER_FILE</c>, you must specify the <c>DocumentIds</c> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATA_CENTER_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
