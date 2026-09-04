// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddFileRequest : TeaModel {
        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>When CategoryType is set to UNSTRUCTURED, specify the category ID to which the uploaded file belongs. This is the <c>CategoryId</c> returned by the <b>AddCategory</b> operation. You can also go to <a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> &gt; Files tab and click the ID icon next to the category name to obtain the category ID. You can set this parameter to default to use the system-created default category.</para>
        /// </description></item>
        /// <item><description><para>When CategoryType is set to SESSION_FILE, set this parameter to &quot;default&quot;.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>Specify the category ID to which the uploaded file belongs. This is the <c>CategoryId</c> returned by the <b>AddCategory</b> operation. You can also go to <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> &gt; Files tab and click the ID icon next to the category name to obtain the category ID. You can set this parameter to default to use the system-created default category.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The category type. This parameter is optional. Default value: UNSTRUCTURED. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UNSTRUCTURED: Category. Used for knowledge base scenarios.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>SESSION_FILE: A file used for <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/file-interaction">conversation interaction</a> in agent applications.
        /// <note>When using <c>SESSION_FILE</c>, set the CategoryType parameter to <c>SESSION_FILE</c> when calling the ApplyFileUploadLease operation as well.</note>
        /// <note>The file is valid only for the current user session. After the user closes the session, the file expires (maximum validity period is 7 days) and cannot be retained for long-term storage.</note></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UNSTRUCTURED</para>
        /// </summary>
        [NameInMap("CategoryType")]
        [Validation(Required=false)]
        public string CategoryType { get; set; }

        /// <summary>
        /// <para>The upload lease ID, which corresponds to the <c>FileUploadLeaseId</c> returned by the <b>ApplyFileUploadLease</b> operation.</para>
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
        /// <para>Adds a URL to the file. The system records this link when building a <a href="https://help.aliyun.com/document_detail/2807740.html">document search knowledge base</a>. When you use the Alibaba Cloud Model Studio console to chat with an <a href="https://help.aliyun.com/document_detail/2842749.html">agent application</a>, this link is returned with the file retrieval results through the <c>docUrl</c> field.</para>
        /// <remarks>
        /// <para>The agent application must have <b>Knowledge Base</b> enabled and the <b>Display answer sources</b> feature turned on. Otherwise, this parameter does not take effect.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>Adds a URL to the file. The system records this link when building a <a href="https://help.aliyun.com/document_detail/2807740.html">document search knowledge base</a>. When you use the Alibaba Cloud Model Studio console to chat with an <a href="https://help.aliyun.com/document_detail/2842749.html">agent application</a>, this link is returned with the file retrieval results through the <c>docUrl</c> field.</para>
        /// <remarks>
        /// <para>The agent application must have <b>Knowledge Base</b> enabled and the <b>Display answer sources</b> feature turned on. Otherwise, this parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.test.com/111.docx">www.test.com/111.docx</a></para>
        /// </summary>
        [NameInMap("OriginalFileUrl")]
        [Validation(Required=false)]
        public string OriginalFileUrl { get; set; }

        /// <summary>
        /// <para>The parser type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DOCMIND: Intelligent document parsing.</description></item>
        /// <item><description>DOCMIND_DIGITAL: Electronic document parsing.</description></item>
        /// <item><description>DOCMIND_LLM_VERSION: Large language model (LLM) document parsing.</description></item>
        /// <item><description>DASH_QWEN_VL_PARSER: Qwen VL parsing.</description></item>
        /// <item><description>DOCMIND_LLM_VERSION_MEDIA: Audio and video parsing.</description></item>
        /// <item><description>AUTO_SELECT: Automatic parser selection.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;
        /// <note>The file you upload is parsed by using the currently specified parser. If you set this parameter to AUTO_SELECT, the parser configured for the category is used.</note></para>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// <note>When CategoryType is set to UNSTRUCTURED, the parser parses the uploaded file based on the data parsing settings of the current category.</note>
        /// <note>When CategoryType is set to SESSION_FILE, the system parses the file content by using the default method, which cannot be changed.</note></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO_SELECT</para>
        /// </summary>
        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// <para>The parser configuration. This parameter is required only when the parser type is set to Qwen VL parsing.</para>
        /// </summary>
        [NameInMap("ParserConfig")]
        [Validation(Required=false)]
        public AddFileRequestParserConfig ParserConfig { get; set; }
        public class AddFileRequestParserConfig : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-vl-max</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The prompt used when calling Qwen VL parsing.</para>
            /// 
            /// <b>Example:</b>
            /// <h1>Role</h1>
            /// <para>You are a professional image content annotator who excels at identifying and describing the content in images.</para>
            /// <h1>Task objective</h1>
            /// <para>Based on the input image, describe the content in the image in detail</para>
            /// </summary>
            [NameInMap("ModelPrompt")]
            [Validation(Required=false)]
            public string ModelPrompt { get; set; }

        }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The list of tags associated with the file. You can specify up to 100 tags, and the total character length of all tags cannot exceed 700.</description></item>
        /// <item><description>Default value: empty, which means no tags are set.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
