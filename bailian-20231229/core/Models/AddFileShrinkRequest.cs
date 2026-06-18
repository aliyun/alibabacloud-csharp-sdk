// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddFileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>CategoryType</c> is set to <c>UNSTRUCTURED</c>, you must specify the ID of the category to which the file belongs. This is the <c>CategoryId</c> returned by the <b>AddCategory</b> API. You can also obtain the category ID by navigating to the \<em>\<em>Application data\</em>\</em> &gt; \<em>\<em>Files\</em>\</em> tab and clicking the ID icon next to the category name. You can specify <c>default</c> to use the default category.</para>
        /// </description></item>
        /// <item><description><para>If <c>CategoryType</c> is set to <c>SESSION_FILE</c>, specify <c>default</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The ID of the category to which the file belongs. This is the <c>CategoryId</c> returned by the <b>AddCategory</b> API. You can also obtain the category ID by navigating to the \<em>\<em>Application data\</em>\</em> &gt; \<em>\<em>Files\</em>\</em> tab and clicking the ID icon next to the category name. You can specify <c>default</c> to use the default category.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The type of category. This parameter is optional. Default value: <c>UNSTRUCTURED</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>UNSTRUCTURED</c>: A category used for building a knowledge base.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><c>SESSION_FILE</c>: A file used for interactions within an agent <a href="https://help.aliyun.com/zh/model-studio/user-guide/file-interaction">session</a>.<remarks>
        /// <para>If you set this parameter to <c>SESSION_FILE</c>, you must also set the <c>CategoryType</c> parameter to <c>SESSION_FILE</c> when you call the ApplyFileUploadLease API.
        /// Files of this type are valid only for the current session and expire after the session is closed, with a maximum validity of 7 days. These files are not intended for long-term storage.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UNSTRUCTURED</para>
        /// </summary>
        [NameInMap("CategoryType")]
        [Validation(Required=false)]
        public string CategoryType { get; set; }

        /// <summary>
        /// <para>The upload lease ID. This value maps to the <c>FileUploadLeaseId</c> returned by the <b>ApplyFileUploadLease</b> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68abd1dea7b6404d8f7d7b9f7fbd332d.17166xxxxxxxx</para>
        /// </summary>
        [NameInMap("LeaseId")]
        [Validation(Required=false)]
        public string LeaseId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The URL of the file. The system records this link when building a <a href="https://help.aliyun.com/document_detail/2807740.html">document retrieval-based knowledge base</a>. When you interact with an <a href="https://help.aliyun.com/document_detail/2842749.html">agent</a> in the Alibaba Cloud Model Studio console, this URL is returned with the retrieval results for the file in the <c>docUrl</c> field.</para>
        /// <remarks>
        /// <para>For this parameter to take effect, the <b>knowledge base</b> feature must be enabled for the agent, and the <b>display the source of the answer</b> option must be enabled.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The URL of the file. The system records this link when building a <a href="https://help.aliyun.com/document_detail/2807740.html">document retrieval-based knowledge base</a>. When you interact with an <a href="https://help.aliyun.com/document_detail/2842749.html">agent</a> in the Alibaba Cloud Model Studio console, this URL is returned with the retrieval results for the file in the <c>docUrl</c> field.</para>
        /// <remarks>
        /// <para>For this parameter to take effect, the <b>knowledge base</b> feature must be enabled for the agent, and the <b>display the source of the answer</b> option must be enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.test.com/111.docx">www.test.com/111.docx</a></para>
        /// </summary>
        [NameInMap("OriginalFileUrl")]
        [Validation(Required=false)]
        public string OriginalFileUrl { get; set; }

        /// <summary>
        /// <para>The type of parser. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DOCMIND: Intelligent Document Parsing</para>
        /// </description></item>
        /// <item><description><para>DOCMIND_DIGITAL: Digital Document Parsing</para>
        /// </description></item>
        /// <item><description><para>DOCMIND_LLM_VERSION: Large Language Model-based Document Parsing</para>
        /// </description></item>
        /// <item><description><para>DASH_QWEN_VL_PARSER: Qwen-VL Parsing</para>
        /// </description></item>
        /// <item><description><para>DOCMIND_LLM_VERSION_MEDIA: Audio and Video Parsing</para>
        /// </description></item>
        /// <item><description><para>AUTO_SELECT: Automatic Parser Selection</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>The system uses the specified parser to parse the uploaded file. If you set this parameter to <c>AUTO_SELECT</c>, the parser configured for the category is used.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>If <c>CategoryType</c> is set to <c>UNSTRUCTURED</c>, the parser parses your uploaded file based on the category’s data parsing settings.
        /// If <c>CategoryType</c> is set to <c>SESSION_FILE</c>, the system uses a default parsing method that cannot be changed.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO_SELECT</para>
        /// </summary>
        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// <para>The parser configuration. This parameter is required only if you set <c>Parser</c> to <c>DASH_QWEN_VL_PARSER</c>.</para>
        /// </summary>
        [NameInMap("ParserConfig")]
        [Validation(Required=false)]
        public string ParserConfigShrink { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>A list of tags for the file. You can specify up to 100 tags. The total length of all tags cannot exceed 700 characters.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not specified, no tags are added.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
