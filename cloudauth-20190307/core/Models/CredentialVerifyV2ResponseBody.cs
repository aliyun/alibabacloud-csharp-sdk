// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialVerifyV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success. Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CredentialVerifyV2ResponseBodyResultObject ResultObject { get; set; }
        public class CredentialVerifyV2ResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The additional information in JSON format.</para>
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
            /// <para>The OCR recognition result.</para>
            /// <remarks>
            /// <para>Danger: Deprecated.</para>
            /// </remarks>
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
            /// <para>The risk result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Low risk.</description></item>
            /// <item><description>1: High risk.</description></item>
            /// <item><description>2: Suspicious.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The risk score map.</para>
            /// </summary>
            [NameInMap("RiskScore")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskScore { get; set; }

            /// <summary>
            /// <para>The risk tags, separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PS: image manipulation.</description></item>
            /// <item><description>SCREEN_PHOTO: screen recapture.</description></item>
            /// <item><description>SCREENSHOT: screenshot.</description></item>
            /// <item><description>WATERMARK: watermark.</description></item>
            /// <item><description>SAME_BACKGROUND: similar background.</description></item>
            /// <item><description>ORIGINAL_PHOTO: non-original image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PS,SCREEN_PHOTO</para>
            /// </summary>
            [NameInMap("RiskTag")]
            [Validation(Required=false)]
            public string RiskTag { get; set; }

            /// <summary>
            /// <para>The authoritative verification details.</para>
            /// <remarks>
            /// <para>Danger: Deprecated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>**</para>
            /// </summary>
            [NameInMap("VerifyDetail")]
            [Validation(Required=false)]
            public string VerifyDetail { get; set; }

            /// <summary>
            /// <para>The authoritative verification result.</para>
            /// <remarks>
            /// <para>Danger: Deprecated.</para>
            /// </remarks>
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
            /// <para>This feature is offline. This parameter no longer takes effect.</para>
            /// </summary>
            [NameInMap("VlResult")]
            [Validation(Required=false)]
            public CredentialVerifyV2ResponseBodyResultObjectVlResult VlResult { get; set; }
            public class CredentialVerifyV2ResponseBodyResultObjectVlResult : TeaModel {
                /// <summary>
                /// <para>This feature is offline. This parameter no longer takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// <para>This feature is offline. This parameter no longer takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("VlContent")]
                [Validation(Required=false)]
                public string VlContent { get; set; }

            }

        }

    }

}
