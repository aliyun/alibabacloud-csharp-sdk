// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 for success, others for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6163397-15C5-419C-9ACC-B7C83E0B4C10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CredentialVerifyResponseBodyResultObject ResultObject { get; set; }
        public class CredentialVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Additional information in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{</para>
            /// <para>&quot;sameBackgroundDetail&quot;: {</para>
            /// <para>// 相似背景对于的原始图请求RequestId</para>
            /// <para>&quot;originalRequestId&quot;: &quot;130A2C10-B9EE-4D84-88E3-5384FF03****&quot;;</para>
            /// <para>// 相似背景对于的原始图请求商户ID</para>
            /// <para>&quot;originalMerchantId&quot;: &quot;xxxxxxxx&quot;</para>
            /// <para>}</para>
            /// <para>}</para>
            /// </summary>
            [NameInMap("MaterialInfo")]
            [Validation(Required=false)]
            public string MaterialInfo { get; set; }

            /// <summary>
            /// <para>OCR recognition result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///    &quot;certNo&quot;:&quot;20216*********&quot;,
            ///   &quot;certType&quot;:&quot;小学教师资格&quot;,
            ///    &quot;gender&quot;:&quot;男&quot;,
            ///    &quot;subject&quot;:&quot;美术&quot;,
            ///     &quot;name&quot;:&quot;李**&quot;,
            ///     &quot;ext_info&quot;:&quot;{}&quot;,
            ///     &quot;birthDate&quot;:&quot;1998-07-28&quot;,
            ///     &quot;idNo&quot;:&quot;620************&quot;,
            ///     &quot;certOrg&quot;:&quot;&quot;
            /// }</para>
            /// </summary>
            [NameInMap("OcrInfo")]
            [Validation(Required=false)]
            public string OcrInfo { get; set; }

            /// <summary>
            /// <para>Risk result</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Low risk</description></item>
            /// <item><description><b>1</b>: High risk</description></item>
            /// <item><description><b>2</b>: Suspicious</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>Risk score map.</para>
            /// </summary>
            [NameInMap("RiskScore")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskScore { get; set; }

            /// <summary>
            /// <para>Risk tags, separated by commas (,), including:</para>
            /// <list type="bullet">
            /// <item><description><b>PS</b>: Image manipulation.</description></item>
            /// <item><description><b>SCREEN_PHOTO</b>: Screen recapture.</description></item>
            /// <item><description><b>SCREENSHOT</b>: Screenshot.</description></item>
            /// <item><description><b>WATERMARK</b>: Watermark.</description></item>
            /// <item><description><b>SAME_BACKGROUND</b>: Similar background.</description></item>
            /// <item><description><b>ORIGINAL_PHOTO</b>: Not the original image</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PS,SCREEN_PHOTO</para>
            /// </summary>
            [NameInMap("RiskTag")]
            [Validation(Required=false)]
            public string RiskTag { get; set; }

            /// <summary>
            /// <para>Authority verification details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**</para>
            /// </summary>
            [NameInMap("VerifyDetail")]
            [Validation(Required=false)]
            public string VerifyDetail { get; set; }

            /// <summary>
            /// <para>The verification result.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

            /// <summary>
            /// <para>Qwen interpretation.</para>
            /// </summary>
            [NameInMap("VlResult")]
            [Validation(Required=false)]
            public CredentialVerifyResponseBodyResultObjectVlResult VlResult { get; set; }
            public class CredentialVerifyResponseBodyResultObjectVlResult : TeaModel {
                /// <summary>
                /// <para>Indicates whether the call was successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The call was successful.</description></item>
                /// <item><description><b>false</b>: The call failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// <para>Image understanding result:</para>
                /// <list type="bullet">
                /// <item><description><para>When PromptModel is DEFAULT, the output format refers to the example on the right.</para>
                /// </description></item>
                /// <item><description><para>When PromptModel is CUSTOM, the output format follows the agreed format of the Prompt.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;这张图有没有明显的PS特征\&quot;:0,\&quot;图片是否为正常经营照片\&quot;:1,\&quot;图片中有没有58、美团、大众点评字样\&quot;:0,\&quot;这张图有没有网站信息\&quot;:0,\&quot;图片经营的场景是否为酒店\&quot;:0}</para>
                /// </summary>
                [NameInMap("VlContent")]
                [Validation(Required=false)]
                public string VlContent { get; set; }

            }

        }

    }

}
