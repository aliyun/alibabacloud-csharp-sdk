// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class AssociateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business space key. If not specified, the default business space is accessed. Obtain the key value from the business management page of the primary account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The unique identifier of the robot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-mp90s2lrk00050</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The perspective code, which is used to call answers from different perspectives under the same knowledge title. When assembling request parameters, pass the parameter in the format Perspective={perspective code}. For example: &amp;Perspective=[&quot;FZJBY3raWr&quot;]. When using the SDK, use the parameters defined in the SDK. Currently, only one perspective answer can be called.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;qyzzVfyFfa&quot;]</para>
        /// </summary>
        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public string PerspectiveShrink { get; set; }

        /// <summary>
        /// <para>The number of recommended questions, ranging from 1 to 10. This parameter takes effect only when recommendations are returned. The number of returned recommended questions is less than or equal to RecommendNum.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("RecommendNum")]
        [Validation(Required=false)]
        public long? RecommendNum { get; set; }

        /// <summary>
        /// <para>The session ID, which is used to identify a visitor\&quot;s session and maintain context information. For a new visitor, you do not need to pass this field when calling the Chat operation for the first time. The robot starts a session and returns the SessionId of the session in the response of the Chat operation. For subsequent conversation turns of the visitor, pass the SessionId of the current session when calling the Chat operation so that the robot can continue the conversation based on the SessionId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c3cec23cc8940bc9db4a318c8f4f0aa</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The user utterance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Housing fund withdrawal</para>
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

    }

}
