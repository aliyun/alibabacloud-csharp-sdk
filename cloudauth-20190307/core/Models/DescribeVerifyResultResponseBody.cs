// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>97</para>
        /// </summary>
        [NameInMap("AuthorityComparisionScore")]
        [Validation(Required=false)]
        public float? AuthorityComparisionScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>97</para>
        /// </summary>
        [NameInMap("FaceComparisonScore")]
        [Validation(Required=false)]
        public float? FaceComparisonScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>97</para>
        /// </summary>
        [NameInMap("IdCardFaceComparisonScore")]
        [Validation(Required=false)]
        public float? IdCardFaceComparisonScore { get; set; }

        [NameInMap("Material")]
        [Validation(Required=false)]
        public DescribeVerifyResultResponseBodyMaterial Material { get; set; }
        public class DescribeVerifyResultResponseBodyMaterial : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/face-global-example.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/face-global-example.jpg</a></para>
            /// </summary>
            [NameInMap("FaceGlobalUrl")]
            [Validation(Required=false)]
            public string FaceGlobalUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/face-image-example.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/face-image-example.jpg</a></para>
            /// </summary>
            [NameInMap("FaceImageUrl")]
            [Validation(Required=false)]
            public string FaceImageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FaceMask")]
            [Validation(Required=false)]
            public bool? FaceMask { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("FaceQuality")]
            [Validation(Required=false)]
            public string FaceQuality { get; set; }

            [NameInMap("IdCardInfo")]
            [Validation(Required=false)]
            public DescribeVerifyResultResponseBodyMaterialIdCardInfo IdCardInfo { get; set; }
            public class DescribeVerifyResultResponseBodyMaterialIdCardInfo : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Authority")]
                [Validation(Required=false)]
                public string Authority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example3.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example3.jpg</a></para>
                /// </summary>
                [NameInMap("BackImageUrl")]
                [Validation(Required=false)]
                public string BackImageUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19900101</para>
                /// </summary>
                [NameInMap("Birth")]
                [Validation(Required=false)]
                public string Birth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20201101</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example2.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example2.jpg</a></para>
                /// </summary>
                [NameInMap("FrontImageUrl")]
                [Validation(Required=false)]
                public string FrontImageUrl { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>02343218901123****</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20201101</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

            [NameInMap("IdCardName")]
            [Validation(Required=false)]
            public string IdCardName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>02343218901123****</para>
            /// </summary>
            [NameInMap("IdCardNumber")]
            [Validation(Required=false)]
            public string IdCardNumber { get; set; }

            [NameInMap("VideoUrls")]
            [Validation(Required=false)]
            public List<string> VideoUrls { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VerifyStatus")]
        [Validation(Required=false)]
        public int? VerifyStatus { get; set; }

    }

}
