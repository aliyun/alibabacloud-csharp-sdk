// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class SubmitIndexAddDocumentsJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of category IDs.</para>
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public string CategoryIdsShrink { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// Enables custom chunking (applies only to files appended in this request). For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>. Valid values (only one value can be specified at a time):</para>
        /// <list type="bullet">
        /// <item><description><b>length</b>: chunk by length. Strictly chunks according to the specified <c>ChunkSize</c> and <c>OverlapSize</c>. If these two parameters are not specified, the system uses default values (<c>ChunkSize</c> of 500 and <c>OverlapSize</c> of 100). Chunking by length does not support <c>Separator</c> (even if specified, it does not take effect).</description></item>
        /// <item><description><b>page</b>: chunk by page. If <c>ChunkSize</c> is specified, it is also considered during chunking (if not specified, the default value of 500 is used). Chunking by page does not support <c>OverlapSize</c> or <c>Separator</c> (even if specified, they do not take effect).</description></item>
        /// <item><description><b>h1</b>~<b>h5</b>: chunk by headings at the corresponding level (<c>h1</c> is the first-level heading, and so on, with support up to <c>h5</c> fifth-level heading). If <c>ChunkSize</c> is specified, it is also considered during chunking (if not specified, the default value of 500 is used). Chunking by heading does not support <c>OverlapSize</c> or <c>Separator</c> (even if specified, they do not take effect).</description></item>
        /// <item><description><b>regex</b>: chunk by regular expression. The <c>Separator</c> parameter must be specified. If <c>ChunkSize</c> is specified, it is also considered during chunking (if not specified, the default value of 500 is used). Chunking by regex does not support <c>OverlapSize</c> (even if specified, it does not take effect).</description></item>
        /// </list>
        /// <para>Default value: empty, which uses intelligent chunking.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>length</para>
        /// </summary>
        [NameInMap("ChunkMode")]
        [Validation(Required=false)]
        public string ChunkMode { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// The chunk length, which is the maximum number of characters per text chunk (applies only to files appended in this request). When this length is exceeded:</para>
        /// <list type="bullet">
        /// <item><description><b>Intelligent chunking</b> (without specifying <c>chunkMode</c>): the text is likely to be truncated.</description></item>
        /// <item><description><b>Custom chunking</b> (with <c>chunkMode</c> specified): the text is forcibly split.</description></item>
        /// </list>
        /// <para>Valid values: 1 to 6000. If this parameter is not specified, the default value of 500 is used.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>.</para>
        /// <remarks>
        /// <para>If you specify <c>ChunkSize</c> with a value less than 100, you must also specify <c>OverlapSize</c>. You can also leave both parameters unspecified (the system uses default values).</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// <para>The list of file IDs.</para>
        /// </summary>
        [NameInMap("DocumentIds")]
        [Validation(Required=false)]
        public string DocumentIdsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable header assembly for Excel files. When enabled, the knowledge base treats the first row of all xlsx and xls files as headers and automatically appends them to each text chunk (data row), preventing the large language model from treating headers as regular data rows.</para>
        /// <remarks>
        /// <para>Enable this feature only when all imported files are in xlsx or xls format and contain headers. Otherwise, leave it disabled.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
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
        public string ExtraShrink { get; set; }

        /// <summary>
        /// <para>The knowledge base ID, which is the <c>Data.Id</c> returned by the <b>CreateIndex</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// The chunk overlap length (applies only to files appended in this request). It indicates the number of overlapping characters between the current text chunk and the previous text chunk. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>. Valid values: 0 to 1024.</para>
        /// <para>If this parameter is not specified, the default value of 100 is used.</para>
        /// <remarks>
        /// <para>The value of <c>OverlapSize</c> must be less than the value of <c>ChunkSize</c>. Otherwise, chunking exceptions may occur.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("OverlapSize")]
        [Validation(Required=false)]
        public int? OverlapSize { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// The sentence separator, which takes effect only when <c>chunkMode</c> is set to <b>regex</b> (otherwise, it does not take effect even if specified). You can specify a regular expression (only one is supported) to split the file into small text chunks. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>.</para>
        /// <para>When using intelligent chunking (without specifying <c>chunkMode</c>), keep the default empty value.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not yet available. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>(?&lt;=。)</para>
        /// </summary>
        [NameInMap("Separator")]
        [Validation(Required=false)]
        public string Separator { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATA_CENTER_CATEGORY: category type. Imports all documents under specified categories in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>. Multiple categories are supported.</description></item>
        /// <item><description>DATA_CENTER_FILE: document type. Imports specified files from &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>. Multiple files are supported.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to DATA_CENTER_CATEGORY, you must specify the <c>CategoryIds</c> parameter. If this parameter is set to DATA_CENTER_FILE, you must specify the <c>DocumentIds</c> parameter.</para>
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
