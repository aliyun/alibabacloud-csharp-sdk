// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalAgentSSERequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the whiteboard application. To obtain the whiteboard application ID, see <a href="https://help.aliyun.com/document_detail/204234.html">CreateApp</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>txt_check_pro_agent_01</para>
        /// </summary>
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        /// <summary>
        /// <para>The parameter set required by the moderation service, in JSON string format. The input parameter for text content is content (String), the custom data ID is DataId (String), and the cache type is CacheType (String, valid value: ephemeral).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;content&quot;: &quot;这里待审核的文本内容&quot;,
        ///     &quot;DataId&quot;: &quot;data123***&quot;,
        ///     &quot;CacheType&quot;:&quot;ephemeral&quot;
        ///     }</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

        /// <summary>
        /// <para>Specifies whether to use streaming output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

    }

}
