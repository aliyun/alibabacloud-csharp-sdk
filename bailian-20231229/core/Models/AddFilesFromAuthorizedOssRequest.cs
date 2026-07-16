// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddFilesFromAuthorizedOssRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the category to which the files are imported. This is the <c>CategoryId</c> returned by the AddCategory operation. You can also obtain the category ID by clicking the ID icon next to the category name on the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> - Files tab&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> - Files tab. You can pass in <c>default</c> to use the system-created default category.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The category type. Optional. Default value: UNSTRUCTURED. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UNSTRUCTURED: category for building knowledge base scenarios.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>This operation does not support importing SESSION_FILE for agent application <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/file-interaction">conversation interaction</a>. Use the <b>AddFile</b> operation to upload SESSION_FILE from a local source.</para>
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
        /// <para>The list of files to import. A maximum of 10 files can be uploaded at a time.</para>
        /// <remarks>
        /// <para>A maximum of 10 files can be uploaded at a time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileDetails")]
        [Validation(Required=false)]
        public List<AddFilesFromAuthorizedOssRequestFileDetails> FileDetails { get; set; }
        public class AddFilesFromAuthorizedOssRequestFileDetails : TeaModel {
            /// <summary>
            /// <para>The name of the file to import. The file name must include the file format extension.</para>
            /// <list type="bullet">
            /// <item><description>Supported formats: pdf, docx, doc, txt, md, pptx, ppt, xlsx, xls, html, png, jpg, jpeg, bmp, and gif.</description></item>
            /// <item><description>The file name must be 4 to 128 characters in length.</description></item>
            /// <item><description>For file upload requirements and limits, see <a href="https://help.aliyun.com/document_detail/2880605.html">Knowledge base quotas and limits</a>.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: If the name of the imported file is the same as an existing file in the knowledge base, the operation still returns a <c>Status</c> of <c>SUCCESS</c>, but the file is not actually imported. The existing file with the same name remains unchanged. Make sure that each imported file name is unique.
            /// To create a data table and upload data, use the Model Studio console. This is not supported through the API.</para>
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
            /// <para>The key of the file in the OSS bucket. For more information, see <a href="https://help.aliyun.com/document_detail/273129.html">Object naming conventions</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root/path/this_is_temp_xxxx.pdf</para>
            /// </summary>
            [NameInMap("OssKey")]
            [Validation(Required=false)]
            public string OssKey { get; set; }

            /// <summary>
            /// <para>The parser type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DOCMIND: intelligent document parsing.</description></item>
            /// <item><description>DOCMIND_DIGITAL: electronic document parsing.</description></item>
            /// <item><description>DOCMIND_LLM_VERSION: LLM-based document parsing.</description></item>
            /// <item><description>DASH_QWEN_VL_PARSER: Qwen VL parsing.</description></item>
            /// <item><description>DOCMIND_LLM_VERSION_MEDIA: audio and video parsing.</description></item>
            /// <item><description>AUTO_SELECT: automatic parser selection.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;
            /// <note>The uploaded file is parsed by using the specified parser. If you set this parameter to AUTO_SELECT, the parser configured for the category is used.</note></para>
            /// <para>&lt;props=&quot;china&quot;&gt;
            /// <note>When CategoryType is UNSTRUCTURED, the parser parses the uploaded file based on the data parsing settings of the current category.</note>
            /// <note>When CategoryType is SESSION_FILE, the system uses the default method (which cannot be changed) to parse the file content.</note></para>
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
            public AddFilesFromAuthorizedOssRequestFileDetailsParserConfig ParserConfig { get; set; }
            public class AddFilesFromAuthorizedOssRequestFileDetailsParserConfig : TeaModel {
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
        /// <para>The name of the OSS bucket. For more information, see <a href="https://help.aliyun.com/document_detail/177682.html">Buckets</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucketNamexxxxx</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The region ID of the OSS bucket. For more information, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS regions and endpoints</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OssRegionId")]
        [Validation(Required=false)]
        public string OssRegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite files with the same OssKey in the category. Default value: false, which means files are not overwritten.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OverWriteFileByOssKey")]
        [Validation(Required=false)]
        public bool? OverWriteFileByOssKey { get; set; }

        /// <summary>
        /// <para>The list of tags associated with the file. Default value: empty, which means the file is not associated with any tags. A maximum of 10 tags can be specified.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
