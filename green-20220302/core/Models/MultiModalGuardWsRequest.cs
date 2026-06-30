// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalGuardWsRequest : TeaModel {
        /// <summary>
        /// <para>The model type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LLM</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LLM</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OpenAI</description></item>
        /// <item><description>DashScope</description></item>
        /// <item><description>Anthropic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DashScope</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The moderation service category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>query_security_check_pro: AI input content security detection (pro edition).</description></item>
        /// <item><description>response_security_check_pro: AI-generated content security detection (pro edition).</description></item>
        /// <item><description>img_query_security_check: AIGC input image security detection.</description></item>
        /// <item><description>img_response_security_check: AIGC output image security detection.</description></item>
        /// <item><description>text_img_mix_guard: Multimodal (text + image) hybrid security detection.</description></item>
        /// <item><description>file_security_sync_check: AIGC input or output file security detection.</description></item>
        /// <item><description>text_file_sec_sync_check: Multimodal (text + file) real-time security detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>query_security_check_pro</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameter set required by the moderation service, in JSON string format. The input parameter for text content is content (String), the input parameter for image content is imageUrls (JSONArray), and the input parameter for file content is fileUrls (JSONArray).</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description><para>文本：
        /// {
        /// &quot;content&quot;: &quot;test&quot;
        /// }</para>
        /// </description></item>
        /// <item><description><para>图片：
        /// {
        /// &quot;imageUrls&quot;: [&quot;<a href="https://example.com/image.png%22%5D">https://example.com/image.png&quot;]</a>
        /// }</para>
        /// </description></item>
        /// <item><description><para>文件：
        /// {
        /// &quot;fileUrls&quot;: [&quot;<a href="https://example.com/file.pdf%22%5D">https://example.com/file.pdf&quot;]</a>
        /// }</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
