// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddFilesFromAuthorizedOssRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the target category for file import. This is the <c>CategoryId</c> returned by the AddCategory operation. You can also obtain the category ID from the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> - Files tab&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> - Files tab by clicking the ID icon next to the category name. You can also pass in default, which uses the system-created &quot;Default Category&quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>Category type. Optional. The default value is UNSTRUCTURED. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UNSTRUCTURED: Category used for building knowledge base scenarios.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>This operation does not support importing SESSION_FILE used for agent application <a href="https://help.aliyun.com/zh/model-studio/user-guide/file-interaction">session interaction</a>. Please use the <b>AddFile</b> operation to upload SESSION_FILE from local.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNSTRUCTURED</para>
        /// </summary>
        [NameInMap("CategoryType")]
        [Validation(Required=false)]
        public string CategoryType { get; set; }

        /// <summary>
        /// <para>The list of files to import. Up to 10 files can be uploaded at a time.</para>
        /// <remarks>
        /// <para>Up to 10 files can be uploaded at a time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileDetails")]
        [Validation(Required=false)]
        public List<AddFilesFromAuthorizedOssRequestFileDetails> FileDetails { get; set; }
        public class AddFilesFromAuthorizedOssRequestFileDetails : TeaModel {
            /// <summary>
            /// <para>The name of the file to import. Note that the suffix must include the file format type.</para>
            /// <list type="bullet">
            /// <item><description>Supported formats: pdf, docx, doc, txt, md, pptx, ppt, xlsx, xls, html, png, jpg, jpeg, bmp, gif.</description></item>
            /// <item><description>The file name length is limited to 4-128 characters.</description></item>
            /// <item><description>For file upload requirements and limits, see <a href="https://help.aliyun.com/document_detail/2880605.html">Knowledge base quotas and limits</a>.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: When the imported file name duplicates an existing file name in the knowledge base, the operation still returns <c>Status</c> as <c>SUCCESS</c>, but the file will not actually be imported into the knowledge base, and the existing file with the same name remains unchanged. Please ensure that each imported file name is unique.
            /// To add a new data table and upload data, please use the Alibaba Cloud Model Studio console; the API does not support this.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this_is_temp_xxxx.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The key name (Key) of the imported file in the OSS Bucket. For details, see <a href="https://help.aliyun.com/document_detail/273129.html">Object naming</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root/path/this_is_temp_xxxx.pdf</para>
            /// </summary>
            [NameInMap("OssKey")]
            [Validation(Required=false)]
            public string OssKey { get; set; }

            /// <summary>
            /// <para>Parser type. Possible values include:</para>
            /// <list type="bullet">
            /// <item><description>DOCMIND (Intelligent document parsing)</description></item>
            /// <item><description>DOCMIND_DIGITAL (Digital document parsing)</description></item>
            /// <item><description>DOCMIND_LLM_VERSION (LLM-based document parsing)</description></item>
            /// <item><description>DASH_QWEN_VL_PARSER (Qwen VL parsing)</description></item>
            /// <item><description>DOCMIND_LLM_VERSION_MEDIA (Audio/video parsing)</description></item>
            /// <item><description>AUTO_SELECT (Automatically select parser)</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;
            /// <note>The currently configured parser will be used to parse your uploaded files. If AUTO_SELECT is entered, the parser configured for the corresponding category will be used.</note></para>
            /// <para>&lt;props=&quot;china&quot;&gt;
            /// <note>When CategoryType is UNSTRUCTURED, the parser parses your uploaded files according to the data parsing settings of the current category.</note>
            /// <note>When CategoryType is SESSION_FILE, the system uses the default method (not changeable) to parse file content.</note></para>
            /// 
            /// <b>Example:</b>
            /// <para>AUTO_SELECT</para>
            /// </summary>
            [NameInMap("Parser")]
            [Validation(Required=false)]
            public string Parser { get; set; }

            /// <summary>
            /// <para>Parser configuration. Required only when the parser type is set to Qwen VL parsing.</para>
            /// </summary>
            [NameInMap("ParserConfig")]
            [Validation(Required=false)]
            public AddFilesFromAuthorizedOssRequestFileDetailsParserConfig ParserConfig { get; set; }
            public class AddFilesFromAuthorizedOssRequestFileDetailsParserConfig : TeaModel {
                /// <summary>
                /// <para>Model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-vl-max</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The prompt used when invoking Qwen VL parsing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#角色
                /// 你是一个专业的图片内容标注人员，擅长识别并描述出图片中的内容。</para>
                /// <h1>任务目标</h1>
                /// <para>请结合输入图片，详细描述图片中的内容。</para>
                /// </summary>
                [NameInMap("ModelPrompt")]
                [Validation(Required=false)]
                public string ModelPrompt { get; set; }

            }

        }

        /// <summary>
        /// <para>The OSS Bucket name. For details, see <a href="https://help.aliyun.com/document_detail/177682.html">Buckets</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucketNamexxxxx</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The region ID of the OSS Bucket. For how to obtain it, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS regions and endpoints</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OssRegionId")]
        [Validation(Required=false)]
        public string OssRegionId { get; set; }

        /// <summary>
        /// <para>Whether to overwrite the same file in the category by OssKey. The default value is false, meaning no overwrite.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OverWriteFileByOssKey")]
        [Validation(Required=false)]
        public bool? OverWriteFileByOssKey { get; set; }

        /// <summary>
        /// <para>The list of tags associated with the file. The default is empty, meaning the file is not associated with any tags. Up to 10 tags can be passed in.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
