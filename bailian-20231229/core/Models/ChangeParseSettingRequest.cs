// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ChangeParseSettingRequest : TeaModel {
        /// <summary>
        /// <para>The category ID, which is the <c>CategoryId</c> returned by <b>AddCategory</b>. To view the category ID, click the ID icon next to the category name on the Unstructured Data tab of the <a href="https://bailian.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The file type. Valid values: pdf, docx, and doc.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdf</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The parser code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DOCMIND (Intelligent parsing)</description></item>
        /// <item><description>DOCMIND_DIGITAL (Digital parsing)</description></item>
        /// <item><description>DOCMIND_LLM_VERSION (LLM parsing)</description></item>
        /// <item><description>DASH_QWEN_VL_PARSER (Qwen VL parsing)</description></item>
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
        /// <para>The parser configuration. Currently, this is available only for Qwen VL parsing.</para>
        /// </summary>
        [NameInMap("ParserConfig")]
        [Validation(Required=false)]
        public ChangeParseSettingRequestParserConfig ParserConfig { get; set; }
        public class ChangeParseSettingRequestParserConfig : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>qwen-vl-max</description></item>
            /// <item><description>qwen-vl-plus</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-vl-max</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The prompt used for parsing.</para>
            /// </summary>
            [NameInMap("modelPrompt")]
            [Validation(Required=false)]
            public string ModelPrompt { get; set; }

        }

    }

}
