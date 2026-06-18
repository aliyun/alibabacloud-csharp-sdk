// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ChangeParseSettingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. This is the <c>CategoryId</c> returned by the <b>AddCategory</b> operation. You can also obtain the ID from the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> - File tab&lt;props=&quot;intl&quot;&gt;<a href="https://bailian.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> - Unstructured Data tab by clicking the ID icon next to the category name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The file type, specified by its extension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>doc</para>
        /// </description></item>
        /// <item><description><para>docx</para>
        /// </description></item>
        /// <item><description><para>ppt</para>
        /// </description></item>
        /// <item><description><para>pptx</para>
        /// </description></item>
        /// <item><description><para>xls</para>
        /// </description></item>
        /// <item><description><para>xlsx</para>
        /// </description></item>
        /// <item><description><para>md</para>
        /// </description></item>
        /// <item><description><para>txt</para>
        /// </description></item>
        /// <item><description><para>pdf</para>
        /// </description></item>
        /// <item><description><para>png</para>
        /// </description></item>
        /// <item><description><para>jpg</para>
        /// </description></item>
        /// <item><description><para>jpeg</para>
        /// </description></item>
        /// <item><description><para>bmp</para>
        /// </description></item>
        /// <item><description><para>gif</para>
        /// </description></item>
        /// <item><description><para>html</para>
        /// </description></item>
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
        /// <para>The identifier for the parser. Different parsers are suitable for different scenarios. For more information, refer to the knowledge base. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DOCMIND (intelligent document parsing)</para>
        /// </description></item>
        /// <item><description><para>DOCMIND_DIGITAL (digital document parsing)</para>
        /// </description></item>
        /// <item><description><para>DOCMIND_LLM_VERSION (LLM-based document parsing)</para>
        /// </description></item>
        /// <item><description><para>DASH_QWEN_VL_PARSER (Qwen VL Parser)</para>
        /// </description></item>
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
        /// <para>The parser configuration. This parameter is required only when the <c>Parser</c> parameter is set to <c>DASH_QWEN_VL_PARSER</c>.</para>
        /// </summary>
        [NameInMap("ParserConfig")]
        [Validation(Required=false)]
        public string ParserConfigShrink { get; set; }

    }

}
