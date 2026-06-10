// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class AssociateRequest : TeaModel {
        /// <summary>
        /// <para>The workspace key. If this parameter is not specified, the service uses the default workspace. You can obtain the key from the workspace management page of your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-mp90s2lrk00050</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The code for a perspective. Use this to retrieve answers from different perspectives that share the same knowledge title. When constructing the request, pass the value in the &quot;Perspective={perspective_code}&quot; format, for example, \&amp;Perspective=[&quot;FZJBY3raWr&quot;]. If you use an SDK, pass the parameter as defined by the SDK. You can specify only one perspective in each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;qyzzVfyFfa&quot;]</para>
        /// </summary>
        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public List<string> Perspective { get; set; }

        /// <summary>
        /// <para>The number of recommended FAQs to return. The value must be an integer from 1 to 10. This parameter takes effect only when recommendations are generated. The number of FAQs returned is less than or equal to the value you specify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("RecommendNum")]
        [Validation(Required=false)]
        public long? RecommendNum { get; set; }

        /// <summary>
        /// <para>The session ID that identifies a conversation and maintains context. For the first request from a new user, you can omit this parameter. The service automatically starts a session and returns a session ID in the response. To continue the conversation, you must include the session ID in subsequent requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c3cec23cc8940bc9db4a318c8f4f0aa</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The user\&quot;s utterance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>公积金提取</para>
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

    }

}
