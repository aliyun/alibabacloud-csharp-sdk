// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalGuardRequest : TeaModel {
        /// <summary>
        /// <para>The type of the moderation service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>query_security_check: AI input content moderation.</para>
        /// </description></item>
        /// <item><description><para>response_security_check: AI-generated content moderation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>query_security_check_pro</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The set of parameters required for the moderation service. The value must be a JSON string.</para>
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
