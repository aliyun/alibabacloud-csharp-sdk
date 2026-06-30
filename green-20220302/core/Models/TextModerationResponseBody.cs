// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class TextModerationResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The moderation result data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TextModerationResponseBodyData Data { get; set; }
        public class TextModerationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The \<c>accountId\\</c> specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The data ID of the moderated object.</para>
            /// <remarks>
            /// <para>If you specify the dataId parameter in the request, its value is returned in this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>text1234</para>
            /// </summary>
            [NameInMap("dataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The description of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>疑似广告内容</para>
            /// </summary>
            [NameInMap("descriptions")]
            [Validation(Required=false)]
            public string Descriptions { get; set; }

            /// <summary>
            /// <para>The \<c>deviceId\\</c> specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>Auxiliary reference information for the text.</para>
            /// </summary>
            [NameInMap("ext")]
            [Validation(Required=false)]
            public TextModerationResponseBodyDataExt Ext { get; set; }
            public class TextModerationResponseBodyDataExt : TeaModel {
                /// <summary>
                /// <para>The output from the Large Language Model (LLM).</para>
                /// </summary>
                [NameInMap("llmContent")]
                [Validation(Required=false)]
                public TextModerationResponseBodyDataExtLlmContent LlmContent { get; set; }
                public class TextModerationResponseBodyDataExtLlmContent : TeaModel {
                    /// <summary>
                    /// <para>The output content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>正常。文本中无风险内容。</para>
                    /// </summary>
                    [NameInMap("outputText")]
                    [Validation(Required=false)]
                    public string OutputText { get; set; }

                }

            }

            /// <summary>
            /// <para>The moderation labels. If multiple labels are returned, they are separated by commas (,). Valid values: ad: advertisement profanity: profanity contraband: contraband sexual_content: sexual content violence: violent and terrorist content nonsense: meaningless content spam: spam negative_content: undesirable content cyberbullying: cyberbullying C_customized: A match in a custom library</para>
            /// 
            /// <b>Example:</b>
            /// <para>porn</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

            /// <summary>
            /// <para>The ID of the manual review task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx-xxxxx</para>
            /// </summary>
            [NameInMap("manualTaskId")]
            [Validation(Required=false)]
            public string ManualTaskId { get; set; }

            /// <summary>
            /// <para>A JSON string that contains the reason for the moderation result. The string includes the following fields:</para>
            /// <ol>
            /// <item><description><para>riskTips: The sub-labels.</para>
            /// </description></item>
            /// <item><description><para>riskWords: The detected risk words.</para>
            /// </description></item>
            /// <item><description><para>adNums: The detected ad-related numbers.</para>
            /// </description></item>
            /// <item><description><para>customizedWords: The detected custom words.</para>
            /// </description></item>
            /// <item><description><para>customizedLibs: The names of the custom libraries that contain a match.</para>
            /// </description></item>
            /// <item><description><para>riskLevel: The risk level, which is recommended by the system. Valid values:</para>
            /// </description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>high: high risk</para>
            /// </description></item>
            /// <item><description><para>medium: medium risk</para>
            /// </description></item>
            /// <item><description><para>low: low risk</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;riskLevel\&quot;:\&quot;high\&quot;,\&quot;riskTips\&quot;:\&quot;色情_低俗词\&quot;,\&quot;riskWords\&quot;:\&quot;色情服务\&quot;}</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// <para>The response message for the request.</para>
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
