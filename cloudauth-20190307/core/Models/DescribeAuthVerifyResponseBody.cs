// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeAuthVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
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
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAuthVerifyResponseBodyResult Result { get; set; }
        public class DescribeAuthVerifyResponseBodyResult : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description>Card information read by OCR (ocrIdCardInfo)</description></item>
            /// <item><description>Card information photo edited by the client (ocrIdEditInfo)</description></item>
            /// <item><description>OSS storage location and link of the OCR photo (ocrPictureFront).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;ocrIdCardInfo&quot;: {
            ///     &quot;certName&quot;: &quot;张先生&quot;,
            ///     &quot;sex&quot;: &quot;男&quot;,
            ///     &quot;nationality&quot;: &quot;汉&quot;,
            ///     &quot;birth&quot;: &quot;20010213&quot;,
            ///     &quot;address&quot;: &quot;XXX省XX市XXX区XX街道X号&quot;,
            ///     &quot;certNo&quot;: &quot;4<b><b><b><b><b><b><b><b>X&quot;,
            ///     &quot;authority&quot;: &quot;XXX公安局XXX分局&quot;,
            ///     &quot;startDate&quot;: &quot;20250523&quot;,
            ///     &quot;endDate&quot;: &quot;20450523&quot;
            ///   },
            /// &quot;ocrIdEditInfo&quot;: {
            ///     &quot;certName&quot;: &quot;张先生&quot;,
            ///     &quot;sex&quot;: &quot;男&quot;,
            ///     &quot;nationality&quot;: &quot;汉&quot;,
            ///     &quot;birth&quot;: &quot;20010213&quot;,
            ///     &quot;address&quot;: &quot;XXX省XX市XXX区XX街道X号&quot;,
            ///     &quot;certNo&quot;: &quot;4</b></b></b></b></b></b></b></b>X&quot;,
            ///     &quot;authority&quot;: &quot;XXX公安局XXX分局&quot;,
            ///     &quot;startDate&quot;: &quot;20250523&quot;,
            ///     &quot;endDate&quot;: &quot;20450523&quot;
            ///   },
            ///   &quot;ocrPictureFront&quot;: {
            ///     &quot;ossBucketName&quot;: &quot;cn-shanghai-aliyun-cloudauth-12********&quot;,
            ///     &quot;ossIdFaceObjectName&quot;: &quot;verify/1234567890/f7ed1ef80ad1234fdsd95c<b><b><b><b>cd_ocridface_b749.jpeg&quot;,
            ///     &quot;ossIdFaceUrl&quot;: &quot;<a href="http://cn-shanghai-aliyun-cloudauth-1234567890.oss-cn-shanghai.aliyuncs.com/verify/1234567890/f7ed1ef80ad1234fdsd95c66d83340cd_ocridface_b749.jpeg?security-token=CAISjdfgeJ1q6F">http://cn-shanghai-aliyun-cloudauth-1234567890.oss-cn-shanghai.aliyuncs.com/verify/1234567890/f7ed1ef80ad1234fdsd95c66d83340cd_ocridface_b749.jpeg?security-token=CAISjdfgeJ1q6F</a>...&quot;,
            ///     &quot;ossIdNationalEmblemObjectName&quot;: &quot;verify/1234567890/f7ed1ef80ad1234fdsd95c</b></b></b></b>cd_ocridnationalemblem_a3hf.jpeg&quot;,
            ///     &quot;ossIdNationalEmblemUrl&quot;: &quot;<a href="http://cn-shanghai-aliyun-cloudauth-1234567890.oss-cn-shanghai.aliyuncs.com/verify/1234567890/f7ed1ef80ad1234fdsd95c66d83340cd_ocridnationalemblem_a3hf.jpeg?security-token=CAISjgJ1q6">http://cn-shanghai-aliyun-cloudauth-1234567890.oss-cn-shanghai.aliyuncs.com/verify/1234567890/f7ed1ef80ad1234fdsd95c66d83340cd_ocridnationalemblem_a3hf.jpeg?security-token=CAISjgJ1q6</a>...&quot;
            ///   }</para>
            /// </summary>
            [NameInMap("MaterialInfo")]
            [Validation(Required=false)]
            public string MaterialInfo { get; set; }

            /// <summary>
            /// <para>The anti-spoofing detection result for the back side of the document, including the risk determination result and risk type:</para>
            /// <remarks>
            /// <para>- 
            /// Card front anti-spoofing detection is enabled only when IdSpoof = Y is set in the Initialize operation. Otherwise, spoofRiskResult returns N by default, and spoofType is empty.</para>
            /// </remarks>
            /// <para>spoofRiskResult:</para>
            /// <list type="bullet">
            /// <item><description>Y: Risk detected.</description></item>
            /// <item><description>N: No risk detected.</description></item>
            /// </list>
            /// <para>spoofType:</para>
            /// <list type="bullet">
            /// <item><description>SCREEN_REMARK: Recaptured photo.</description></item>
            /// <item><description>PHOTO_COPY: Photocopy.</description></item>
            /// <item><description>TAMPER: Digitally tampered.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This is an algorithm prediction result. This field may not be returned. Avoid setting a mandatory dependency on this field in your business logic.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>spoofRiskResult：Y
            /// spoofType：SCREEN_REMARK</para>
            /// </summary>
            [NameInMap("SpoofBackInfo")]
            [Validation(Required=false)]
            public string SpoofBackInfo { get; set; }

            /// <summary>
            /// <para>The anti-spoofing detection result for the front side of the document, including the risk determination result and risk type:</para>
            /// <remarks>
            /// <para>- 
            /// Card front anti-spoofing detection is enabled only when IdSpoof = Y is set in the Initialize operation. Otherwise, spoofRiskResult returns N by default, and spoofType is empty.</para>
            /// </remarks>
            /// <para>spoofRiskResult:</para>
            /// <list type="bullet">
            /// <item><description>Y: Risk detected.</description></item>
            /// <item><description>N: No risk detected.</description></item>
            /// </list>
            /// <para>spoofType:</para>
            /// <list type="bullet">
            /// <item><description>SCREEN_REMARK: Recaptured photo.</description></item>
            /// <item><description>PHOTO_COPY: Photocopy.</description></item>
            /// <item><description>TAMPER: Digitally tampered.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This is an algorithm prediction result. This field may not be returned. Avoid setting a mandatory dependency on this field in your business logic.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>spoofRiskResult：Y
            /// spoofType：SCREEN_REMARK</para>
            /// </summary>
            [NameInMap("SpoofInfo")]
            [Validation(Required=false)]
            public string SpoofInfo { get; set; }

            /// <summary>
            /// <para>The result description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

        }

    }

}
