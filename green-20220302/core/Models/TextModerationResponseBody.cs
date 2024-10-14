// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class TextModerationResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The moderation results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TextModerationResponseBodyData Data { get; set; }
        public class TextModerationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>Labels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>porn</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

            /// <summary>
            /// <para>The JSON string used to locate the cause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;detectedLanguage\&quot;:\&quot;ar\&quot;,\&quot;riskTips\&quot;:\&quot;sexuality_Suggestive\&quot;,\&quot;riskWords\&quot;:\&quot;pxxxxy\&quot;,\&quot;translatedContent\&quot;:\&quot;pxxxxy sxxxx\&quot;}</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned in response to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
