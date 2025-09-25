// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VerifyMaterialResponseBody : TeaModel {
        /// <summary>
        /// <para>Comparison score between the facial photo submitted during the authentication process and authoritative data, with a range of <b>0</b>~<b>100</b>.</para>
        /// <para>Confidence threshold references:</para>
        /// <list type="bullet">
        /// <item><description>False recognition rate 0.001% corresponds to a threshold of 95.</description></item>
        /// <item><description>False recognition rate 0.01% corresponds to a threshold of 90.</description></item>
        /// <item><description>False recognition rate 0.1% corresponds to a threshold of 80.</description></item>
        /// <item><description>False recognition rate 1% corresponds to a threshold of 60.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field only indicates the comparison result between the face and authoritative data, serving as a reference score. It is generally not recommended to use this score alone as the pass/fail criterion. For the comprehensive authentication result, please refer to the <b>VerifyStatus</b> field. The <b>VerifyStatus</b> result integrates the face-to-authoritative data comparison and other various strategies, enhancing security levels.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>97</para>
        /// </summary>
        [NameInMap("AuthorityComparisionScore")]
        [Validation(Required=false)]
        public float? AuthorityComparisionScore { get; set; }

        /// <summary>
        /// <para>Comparison score between the facial photo submitted during the authentication process and the face on the portrait side of the ID card image, with a range of <b>0</b>~<b>100</b>.</para>
        /// <para>Confidence threshold references:</para>
        /// <list type="bullet">
        /// <item><description>False recognition rate 0.001% corresponds to a threshold of 95.</description></item>
        /// <item><description>False recognition rate 0.01% corresponds to a threshold of 90.</description></item>
        /// <item><description>False recognition rate 0.1% corresponds to a threshold of 80.</description></item>
        /// <item><description>False recognition rate 1% corresponds to a threshold of 60.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>97</para>
        /// </summary>
        [NameInMap("IdCardFaceComparisonScore")]
        [Validation(Required=false)]
        public float? IdCardFaceComparisonScore { get; set; }

        /// <summary>
        /// <para>Authentication materials.</para>
        /// </summary>
        [NameInMap("Material")]
        [Validation(Required=false)]
        public VerifyMaterialResponseBodyMaterial Material { get; set; }
        public class VerifyMaterialResponseBodyMaterial : TeaModel {
            /// <summary>
            /// <para>Global camera image captured by the real-person authentication SDK.</para>
            /// <remarks>
            /// <para>This parameter will take effect after configuration. If you need to use this parameter, please submit a <a href="https://selfservice.console.aliyun.com/ticket/category/cloudauth/today">ticket</a> to contact us.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/face-global-example.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/face-global-example.jpg</a></para>
            /// </summary>
            [NameInMap("FaceGlobalUrl")]
            [Validation(Required=false)]
            public string FaceGlobalUrl { get; set; }

            /// <summary>
            /// <para>HTTP or HTTPS link to the frontal face image, corresponding to the request parameter <b>FaceImageUrl</b>. The link is valid for 5 minutes, and it is recommended to store it in your business to avoid affecting usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</a></para>
            /// </summary>
            [NameInMap("FaceImageUrl")]
            [Validation(Required=false)]
            public string FaceImageUrl { get; set; }

            /// <summary>
            /// <para>Whether the face is wearing a mask. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Wearing a mask</description></item>
            /// <item><description><b>false</b>: Not wearing a mask</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FaceMask")]
            [Validation(Required=false)]
            public string FaceMask { get; set; }

            /// <summary>
            /// <para>The quality of the frontal face image. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><b>UNQUALIFIED</b>: Poor quality</description></item>
            /// <item><description><b>LOW</b>: Low</description></item>
            /// <item><description><b>NORMAL</b>: Average</description></item>
            /// <item><description><b>HIGH</b>: High</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("FaceQuality")]
            [Validation(Required=false)]
            public string FaceQuality { get; set; }

            /// <summary>
            /// <para>OCR result of the ID card information.</para>
            /// <remarks>
            /// <para>If there is no front or back of the ID card during the verification process, the OCR result of the ID card information will not be returned. Even if the front and back of the ID card are present during the verification process, it does not guarantee that all the information on the ID card will be returned. Due to issues such as poor ID card photography, the OCR may fail to recognize some information, leading to incomplete OCR results. It is recommended that the business side does not heavily rely on the ID card OCR information.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("IdCardInfo")]
            [Validation(Required=false)]
            public VerifyMaterialResponseBodyMaterialIdCardInfo IdCardInfo { get; set; }
            public class VerifyMaterialResponseBodyMaterialIdCardInfo : TeaModel {
                /// <summary>
                /// <para>Address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙江省杭州市余杭区文一西路969号</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>Issuing authority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市公安局</para>
                /// </summary>
                [NameInMap("Authority")]
                [Validation(Required=false)]
                public string Authority { get; set; }

                /// <summary>
                /// <para>HTTP or HTTPS link to the national emblem side of the ID card. The link is valid for 5 minutes. It is recommended to store it in your business system to avoid any impact on usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example3.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example3.jpg</a></para>
                /// </summary>
                [NameInMap("BackImageUrl")]
                [Validation(Required=false)]
                public string BackImageUrl { get; set; }

                /// <summary>
                /// <para>Date of birth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19900101</para>
                /// </summary>
                [NameInMap("Birth")]
                [Validation(Required=false)]
                public string Birth { get; set; }

                /// <summary>
                /// <para>End date of the document\&quot;s validity period. Format: yyyymmdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20201101</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>HTTP or HTTPS link to the portrait side of the ID card. The link is valid for 5 minutes. It is recommended to store it in your business system to avoid any impact on usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example2.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example2.jpg</a></para>
                /// </summary>
                [NameInMap("FrontImageUrl")]
                [Validation(Required=false)]
                public string FrontImageUrl { get; set; }

                /// <summary>
                /// <para>Name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Nationality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>汉</para>
                /// </summary>
                [NameInMap("Nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// <para>ID number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02343218901123****</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>Start date of the document\&quot;s validity period. Format: yyyymmdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20201101</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

            /// <summary>
            /// <para>Name, corresponding to the request parameter <b>Name</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("IdCardName")]
            [Validation(Required=false)]
            public string IdCardName { get; set; }

            /// <summary>
            /// <para>ID number, corresponding to the request parameter <b>IdCardNumber</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02343218901123****</para>
            /// </summary>
            [NameInMap("IdCardNumber")]
            [Validation(Required=false)]
            public string IdCardNumber { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Authentication status. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Authentication passed.</description></item>
        /// <item><description><b>2</b>~<b>n</b>: Authentication failed due to various reasons. For detailed descriptions, see the <b>Authentication Status Explanation</b> below.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VerifyStatus")]
        [Validation(Required=false)]
        public int? VerifyStatus { get; set; }

        /// <summary>
        /// <para>Token for this authentication, used to link various interfaces in the authentication request, valid for 30 minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c302c0797679457685410ee51a5ba375</para>
        /// </summary>
        [NameInMap("VerifyToken")]
        [Validation(Required=false)]
        public string VerifyToken { get; set; }

    }

}
