// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VerifyMaterialResponseBody : TeaModel {
        /// <summary>
        /// <para>The comparison score between the facial photo submitted during verification and the authoritative data. Value range: <b>0</b> to <b>100</b>.</para>
        /// <para>Confidence thresholds for reference:</para>
        /// <list type="bullet">
        /// <item><description>At a false acceptance rate of 0.001%, the corresponding threshold is 95.</description></item>
        /// <item><description>At a false acceptance rate of 0.01%, the corresponding threshold is 90.</description></item>
        /// <item><description>At a false acceptance rate of 0.1%, the corresponding threshold is 80.</description></item>
        /// <item><description>At a false acceptance rate of 1%, the corresponding threshold is 60.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field only represents the comparison result between the face and the authoritative data and serves as a reference score. We do not recommend using this score alone as the pass/fail criterion. For the comprehensive verification result, refer to the <b>VerifyStatus</b> field. The <b>VerifyStatus</b> result combines the face-to-authoritative-data comparison with multiple other strategies to improve the security level.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>97</para>
        /// </summary>
        [NameInMap("AuthorityComparisionScore")]
        [Validation(Required=false)]
        public float? AuthorityComparisionScore { get; set; }

        /// <summary>
        /// <para>The comparison score between the facial photo submitted during verification and the face on the portrait side of the ID card. Value range: <b>0</b> to <b>100</b>.</para>
        /// <para>Confidence thresholds for reference:</para>
        /// <list type="bullet">
        /// <item><description>At a false acceptance rate of 0.001%, the corresponding threshold is 95.</description></item>
        /// <item><description>At a false acceptance rate of 0.01%, the corresponding threshold is 90.</description></item>
        /// <item><description>At a false acceptance rate of 0.1%, the corresponding threshold is 80.</description></item>
        /// <item><description>At a false acceptance rate of 1%, the corresponding threshold is 60.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>97</para>
        /// </summary>
        [NameInMap("IdCardFaceComparisonScore")]
        [Validation(Required=false)]
        public float? IdCardFaceComparisonScore { get; set; }

        /// <summary>
        /// <para>The verification materials.</para>
        /// </summary>
        [NameInMap("Material")]
        [Validation(Required=false)]
        public VerifyMaterialResponseBodyMaterial Material { get; set; }
        public class VerifyMaterialResponseBodyMaterial : TeaModel {
            /// <summary>
            /// <para>The global camera image captured by the ID Verification SDK.</para>
            /// <remarks>
            /// <para>This parameter takes effect only after configuration. If you need to use this parameter, <a href="https://selfservice.console.aliyun.com/ticket/category/cloudauth/today">submit a ticket</a> to contact us.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/face-global-example.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/face-global-example.jpg</a></para>
            /// </summary>
            [NameInMap("FaceGlobalUrl")]
            [Validation(Required=false)]
            public string FaceGlobalUrl { get; set; }

            /// <summary>
            /// <para>The HTTP or HTTPS URL of the front-facing facial photo, corresponding to the request parameter <b>FaceImageUrl</b>. The URL is valid for 5 minutes. Save the image to your own storage to avoid access issues.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</a></para>
            /// </summary>
            [NameInMap("FaceImageUrl")]
            [Validation(Required=false)]
            public string FaceImageUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether the face is wearing a mask. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A mask is detected.</description></item>
            /// <item><description><b>false</b>: No mask is detected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FaceMask")]
            [Validation(Required=false)]
            public string FaceMask { get; set; }

            /// <summary>
            /// <para>The quality of the front-facing facial photo. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UNQUALIFIED</b>: poor quality</description></item>
            /// <item><description><b>LOW</b>: low quality</description></item>
            /// <item><description><b>NORMAL</b>: moderate quality</description></item>
            /// <item><description><b>HIGH</b>: high quality.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("FaceQuality")]
            [Validation(Required=false)]
            public string FaceQuality { get; set; }

            /// <summary>
            /// <para>The OCR result of the ID card information.</para>
            /// <remarks>
            /// <para>If the front and back photos of the ID card are not provided during verification, the OCR result of the ID card information is not returned. Even if both photos are provided, not all information on the ID card is guaranteed to be returned. OCR may fail to recognize certain information due to issues such as poor photo quality. We recommend that your business logic does not strictly depend on the ID card OCR information.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("IdCardInfo")]
            [Validation(Required=false)]
            public VerifyMaterialResponseBodyMaterialIdCardInfo IdCardInfo { get; set; }
            public class VerifyMaterialResponseBodyMaterialIdCardInfo : TeaModel {
                /// <summary>
                /// <para>The address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙江省杭州市余杭区文一西路969号</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The issuing authority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市公安局</para>
                /// </summary>
                [NameInMap("Authority")]
                [Validation(Required=false)]
                public string Authority { get; set; }

                /// <summary>
                /// <para>The HTTP or HTTPS URL of the national emblem side of the ID card. The URL is valid for 5 minutes. Save the image to your own storage to avoid access issues.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example3.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example3.jpg</a></para>
                /// </summary>
                [NameInMap("BackImageUrl")]
                [Validation(Required=false)]
                public string BackImageUrl { get; set; }

                /// <summary>
                /// <para>The date of birth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19900101</para>
                /// </summary>
                [NameInMap("Birth")]
                [Validation(Required=false)]
                public string Birth { get; set; }

                /// <summary>
                /// <para>The expiration date of the ID card. Format: yyyymmdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20201101</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>The HTTP or HTTPS URL of the portrait side of the ID card. The URL is valid for 5 minutes. Save the image to your own storage to avoid access issues.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example2.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example2.jpg</a></para>
                /// </summary>
                [NameInMap("FrontImageUrl")]
                [Validation(Required=false)]
                public string FrontImageUrl { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ethnicity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>汉</para>
                /// </summary>
                [NameInMap("Nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// <para>The ID card number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02343218901123****</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>The start date of the ID card validity period. Format: yyyymmdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20201101</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

            /// <summary>
            /// <para>The name, corresponding to the request parameter <b>Name</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("IdCardName")]
            [Validation(Required=false)]
            public string IdCardName { get; set; }

            /// <summary>
            /// <para>The ID card number, corresponding to the request parameter <b>IdCardNumber</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02343218901123****</para>
            /// </summary>
            [NameInMap("IdCardNumber")]
            [Validation(Required=false)]
            public string IdCardNumber { get; set; }

        }

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
        /// <para>The verification status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Verification passed.</description></item>
        /// <item><description><b>2</b> to <b>n</b>: Verification failed due to various reasons. For detailed descriptions, see <b>Verification status description</b> below.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VerifyStatus")]
        [Validation(Required=false)]
        public int? VerifyStatus { get; set; }

        /// <summary>
        /// <para>The token for this verification, used to correlate the various operations within a verification request. The token is valid for 30 minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c302c0797679457685410ee51a5ba375</para>
        /// </summary>
        [NameInMap("VerifyToken")]
        [Validation(Required=false)]
        public string VerifyToken { get; set; }

    }

}
