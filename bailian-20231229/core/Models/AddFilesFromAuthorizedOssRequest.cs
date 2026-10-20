// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddFilesFromAuthorizedOssRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the destination category for the imported files. This is the CategoryId returned by the AddCategory operation. You can also obtain the category ID by clicking the ID icon next to the category name on the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> &gt; Files tab&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> &gt; Files tab. You can set this parameter to default to use the default category created by the system.</para>
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
        /// <item><description>UNSTRUCTURED: category, used for building knowledge bases.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>This operation does not support importing SESSION_FILE for <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/file-interaction">session interaction</a> in agent applications. Use the <b>AddFile</b> operation to upload SESSION_FILE from your local machine.</para>
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
        /// <para>The list of files to import. You can upload up to 10 files at a time.</para>
        /// <remarks>
        /// <para>You can upload up to 10 files at a time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileDetails")]
        [Validation(Required=false)]
        public List<AddFilesFromAuthorizedOssRequestFileDetails> FileDetails { get; set; }
        public class AddFilesFromAuthorizedOssRequestFileDetails : TeaModel {
            /// <summary>
            /// <para>The name of the file to import. Make sure that the file name extension is included.</para>
            /// <list type="bullet">
            /// <item><description>Supported formats: pdf, docx, doc, txt, md, pptx, ppt, xlsx, xls, html, png, jpg, jpeg, bmp, and gif.</description></item>
            /// <item><description>The file name must be 4 to 128 characters in length.</description></item>
            /// <item><description>For more information about the limits on file uploads, see <a href="https://help.aliyun.com/document_detail/2880605.html">Knowledge base quotas and limits</a>.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: If the name of the imported file is the same as the name of an existing file in the knowledge base, the operation still returns SUCCESS for Status, but the file is not actually imported into the knowledge base and the existing file with the same name remains unchanged. Make sure that the name of each imported file is unique.</notice>
            /// To add a data table and upload data, use the Alibaba Cloud Model Studio console. This is not supported by the API.</para>
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
            /// <para>The key of the imported file in the OSS bucket. For more information, see <a href="https://help.aliyun.com/document_detail/273129.html">Object naming</a>.</para>
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
            /// <item><description>DOCMIND (Intelligent document parsing)</description></item>
            /// <item><description>DOCMIND_DIGITAL (Electronic document parsing)</description></item>
            /// <item><description>DOCMIND_LLM_VERSION (Large model document parsing)</description></item>
            /// <item><description>DASH_QWEN_VL_PARSER (Qwen VL parsing)</description></item>
            /// <item><description>DOCMIND_LLM_VERSION_MEDIA (Audio and video parsing)</description></item>
            /// <item><description>AUTO_SELECT (Automatic parser selection)</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;
            /// <note>The uploaded file is parsed by using the specified parser. If you set this parameter to AUTO_SELECT, the parser configured for the category is used.</note></para>
            /// <para>&lt;props=&quot;china&quot;&gt;
            /// <note>If CategoryType is set to UNSTRUCTURED, the file is parsed based on the data parsing settings of the current category.</note>
            /// <note>If CategoryType is set to SESSION_FILE, the system parses the file content by using the default method, which cannot be changed.</note></para>
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
                /// <h1>Role</h1>
                /// <para>You are a professional image content annotator, skilled at identifying and describing the content in images.</para>
                /// <h1>Task objective</h1>
                /// <para>Based on the input image, describe the content in the image in detail</para>
                /// </summary>
                [NameInMap("ModelPrompt")]
                [Validation(Required=false)]
                public string ModelPrompt { get; set; }

            }

        }

        /// <summary>
        /// <para>The name of the OSS bucket. For more information, see <a href="https://help.aliyun.com/document_detail/177682.html">Buckets</a>. Before you import data from OSS for the first time, you must complete the authorization as prompted in the Model Studio console and add a tag with the key bailian-datahub-access and the value read to the destination bucket. You must also authorize the OSS service-linked role as prompted in the Model Studio console (service name: datahub.sfm.aliyuncs.com).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucketNamexxxxx</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The region ID of the OSS bucket. For more information about how to obtain the ID, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS regions and endpoints</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OssRegionId")]
        [Validation(Required=false)]
        public string OssRegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite identical files in the category based on the OssKey. Default value: false, which means identical files are not overwritten.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OverWriteFileByOssKey")]
        [Validation(Required=false)]
        public bool? OverWriteFileByOssKey { get; set; }

        /// <summary>
        /// <para>The list of tags associated with the file. Default value: empty, which means the file is not associated with any tags. You can specify up to 10 tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
