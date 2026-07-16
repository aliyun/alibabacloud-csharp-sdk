// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ChangeParseSettingRequest : TeaModel {
        /// <summary>
        /// <para>The category ID, which is the <c>CategoryId</c> returned by the <b>AddCategory</b> operation. You can also obtain it by clicking the ID icon next to the category name on the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> - Files tab&lt;props=&quot;intl&quot;&gt;<a href="https://bailian.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> - Unstructured Data tab.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The file type (extension). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>doc</description></item>
        /// <item><description>docx</description></item>
        /// <item><description>ppt</description></item>
        /// <item><description>pptx</description></item>
        /// <item><description>xls</description></item>
        /// <item><description>xlsx</description></item>
        /// <item><description>md</description></item>
        /// <item><description>txt</description></item>
        /// <item><description>pdf</description></item>
        /// <item><description>png</description></item>
        /// <item><description>jpg</description></item>
        /// <item><description>jpeg</description></item>
        /// <item><description>bmp</description></item>
        /// <item><description>gif</description></item>
        /// <item><description>html</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdf</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The parser identifier code. Different parsers are applicable to different scenarios. For more information, see &quot;Knowledge Base&quot;. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DOCMIND (Intelligent Document Parsing)</description></item>
        /// <item><description>DOCMIND_DIGITAL (Electronic Document Parsing)</description></item>
        /// <item><description>DOCMIND_LLM_VERSION (Large Model Document Parsing)</description></item>
        /// <item><description>DASH_QWEN_VL_PARSER (Qwen VL Parsing)</description></item>
        /// <item><description>DOCMIND_LLM_VERSION_MEDIA (Audio/Video Parsing)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOCMIND</para>
        /// </summary>
        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// <para>The parser configuration. This parameter is required only when the parser is set to Qwen VL Parsing.</para>
        /// </summary>
        [NameInMap("ParserConfig")]
        [Validation(Required=false)]
        public ChangeParseSettingRequestParserConfig ParserConfig { get; set; }
        public class ChangeParseSettingRequestParserConfig : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-vl-max</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The prompt used when calling Qwen VL Parsing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>#角色
            /// 你是一个专业的图片内容标注人员，擅长识别并描述出图片中的内容。</para>
            /// <h1>任务目标</h1>
            /// <para>请结合输入图片，详细描述图片中的内容。</para>
            /// </summary>
            [NameInMap("modelPrompt")]
            [Validation(Required=false)]
            public string ModelPrompt { get; set; }

        }

    }

}
