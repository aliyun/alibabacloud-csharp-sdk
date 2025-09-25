// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The comparison score between the face photo submitted during the authentication process and the authoritative data, with a value range of <b>0</b> to <b>100</b>.
        /// Confidence threshold references:</para>
        /// <list type="bullet">
        /// <item><description>When the false acceptance rate is 0.001%, the corresponding threshold is 95. - When the false acceptance rate is 0.01%, the corresponding threshold is 90. - When the false acceptance rate is 0.1%, the corresponding threshold is 80. - When the false acceptance rate is 1%, the corresponding threshold is 60.<remarks>
        /// <para>This field only indicates the comparison result between the face and the authoritative data, for your reference only. It is generally not recommended to use this value alone as the standard for whether the authentication passes. For a comprehensive authentication result, please refer to the <b>VerifyStatus</b> field. The <b>VerifyStatus</b> result integrates the comparison of the face with the authoritative data and various other strategies, which can enhance security levels.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>97</para>
        /// </summary>
        [NameInMap("AuthorityComparisionScore")]
        [Validation(Required=false)]
        public float? AuthorityComparisionScore { get; set; }

        /// <summary>
        /// <para>The comparison score between the face photo submitted during the authentication process and the face in the retained face image. The value range is <b>0</b>~<b>100</b>.</para>
        /// <para>Confidence threshold reference:</para>
        /// <list type="bullet">
        /// <item><description>When the false recognition rate is 0.001%, the corresponding threshold is 95.</description></item>
        /// <item><description>When the false recognition rate is 0.01%, the corresponding threshold is 90.</description></item>
        /// <item><description>When the false recognition rate is 0.1%, the corresponding threshold is 80.</description></item>
        /// <item><description>When the false recognition rate is 1%, the corresponding threshold is 60.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>97</para>
        /// </summary>
        [NameInMap("FaceComparisonScore")]
        [Validation(Required=false)]
        public float? FaceComparisonScore { get; set; }

        /// <summary>
        /// <para>The comparison score between the face photo submitted during the authentication process and the face on the ID card\&quot;s face side. The value range is <b>0</b>~<b>100</b>.</para>
        /// <para>Confidence threshold reference:</para>
        /// <list type="bullet">
        /// <item><description>When the false recognition rate is 0.001%, the corresponding threshold is 95.</description></item>
        /// <item><description>When the false recognition rate is 0.01%, the corresponding threshold is 90.</description></item>
        /// <item><description>When the false recognition rate is 0.1%, the corresponding threshold is 80.</description></item>
        /// <item><description>When the false recognition rate is 1%, the corresponding threshold is 60.</description></item>
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
        public DescribeVerifyResultResponseBodyMaterial Material { get; set; }
        public class DescribeVerifyResultResponseBodyMaterial : TeaModel {
            /// <summary>
            /// <para>The global camera image captured by the real-person authentication SDK.</para>
            /// <remarks>
            /// <para>This parameter will only take effect after configuration. If you need to use this parameter, please submit a <a href="https://selfservice.console.aliyun.com/ticket/category/cloudauth/today">ticket</a> to contact us.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/face-global-example.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/face-global-example.jpg</a></para>
            /// </summary>
            [NameInMap("FaceGlobalUrl")]
            [Validation(Required=false)]
            public string FaceGlobalUrl { get; set; }

            /// <summary>
            /// <para>The HTTP or HTTPS link to the frontal face image. The link is valid for 5 minutes, and it is recommended to store it elsewhere to avoid any impact on usage.</para>
            /// <remarks>
            /// <para>If the HTTP or HTTPS link to the frontal face image expires, you can call <a href="https://help.aliyun.com/document_detail/154606.html">DescribeVerifyResult</a> again to get the link.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/face-image-example.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/face-image-example.jpg</a></para>
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
            public bool? FaceMask { get; set; }

            /// <summary>
            /// <para>The quality of the frontal face image. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>UNQUALIFIED</b>: Poor quality</description></item>
            /// <item><description><b>LOW</b>: Low</description></item>
            /// <item><description><b>NORMAL</b>: Normal</description></item>
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
            /// <para>OCR results of the ID card information.</para>
            /// <remarks>
            /// <para>If there is no front and back information of the ID card during the authentication process, the real-person authentication service will not return the OCR results of the ID card. Even if there is front and back information of the ID card during the authentication process, the real-person authentication service does not guarantee to return all the information on the ID card. Due to issues with ID card photography, the OCR may fail to recognize some information, resulting in incomplete OCR information. It is recommended that your business does not strongly rely on the ID card OCR information.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("IdCardInfo")]
            [Validation(Required=false)]
            public DescribeVerifyResultResponseBodyMaterialIdCardInfo IdCardInfo { get; set; }
            public class DescribeVerifyResultResponseBodyMaterialIdCardInfo : TeaModel {
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
                /// <para>HTTP/HTTPS link to the image of the back side (national emblem side) of the ID card. The link is valid for 5 minutes, and it is recommended to store it for business use to avoid any impact.</para>
                /// <remarks>
                /// <para>If the HTTP/HTTPS link to the front-facing portrait image expires, you can call DescribeVerifyResult again to get the link.</para>
                /// </remarks>
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
                /// <para>The end date of the document\&quot;s validity period. Format: yyyymmdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20201101</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>HTTP/HTTPS link to the image of the front side (portrait side) of the ID card. The link is valid for 5 minutes, and it is recommended to store it for business use to avoid any impact.</para>
                /// <remarks>
                /// <para>If the HTTP/HTTPS link to the front-facing portrait image expires, you can call DescribeVerifyResult again to get the link.</para>
                /// </remarks>
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
                /// <para>ID card number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02343218901123****</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>Start date of the document\&quot;s validity. Format: yyyymmdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20201101</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

            /// <summary>
            /// <para>Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("IdCardName")]
            [Validation(Required=false)]
            public string IdCardName { get; set; }

            /// <summary>
            /// <para>ID number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02343218901123****</para>
            /// </summary>
            [NameInMap("IdCardNumber")]
            [Validation(Required=false)]
            public string IdCardNumber { get; set; }

            /// <summary>
            /// <para>The URL addresses of the recorded videos returned by the historical RPH5BioOnly solution.</para>
            /// </summary>
            [NameInMap("VideoUrls")]
            [Validation(Required=false)]
            public List<string> VideoUrls { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Authentication status, values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: Not authenticated - <b>1</b>: Authentication passed - <b>2</b> to <b>n</b>: Authentication failed for various reasons. For detailed descriptions, see the authentication status explanation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VerifyStatus")]
        [Validation(Required=false)]
        public int? VerifyStatus { get; set; }

    }

}
