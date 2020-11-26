// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyResultResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("VerifyStatus")]
        [Validation(Required=true)]
        public int? VerifyStatus { get; set; }

        [NameInMap("AuthorityComparisionScore")]
        [Validation(Required=true)]
        public float? AuthorityComparisionScore { get; set; }

        [NameInMap("FaceComparisonScore")]
        [Validation(Required=true)]
        public float? FaceComparisonScore { get; set; }

        [NameInMap("IdCardFaceComparisonScore")]
        [Validation(Required=true)]
        public float? IdCardFaceComparisonScore { get; set; }

        [NameInMap("Material")]
        [Validation(Required=true)]
        public DescribeVerifyResultResponseMaterial Material { get; set; }
        public class DescribeVerifyResultResponseMaterial : TeaModel {
            [NameInMap("FaceImageUrl")]
            [Validation(Required=true)]
            public string FaceImageUrl { get; set; }
            [NameInMap("IdCardName")]
            [Validation(Required=true)]
            public string IdCardName { get; set; }
            [NameInMap("IdCardNumber")]
            [Validation(Required=true)]
            public string IdCardNumber { get; set; }
            [NameInMap("FaceQuality")]
            [Validation(Required=true)]
            public string FaceQuality { get; set; }
            [NameInMap("FaceGlobalUrl")]
            [Validation(Required=true)]
            public string FaceGlobalUrl { get; set; }
            [NameInMap("FaceMask")]
            [Validation(Required=true)]
            public bool? FaceMask { get; set; }
            [NameInMap("IdCardInfo")]
            [Validation(Required=true)]
            public DescribeVerifyResultResponseMaterialIdCardInfo IdCardInfo { get; set; }
            public class DescribeVerifyResultResponseMaterialIdCardInfo : TeaModel {
                [NameInMap("Number")]
                [Validation(Required=true)]
                public string Number { get; set; }

                [NameInMap("Address")]
                [Validation(Required=true)]
                public string Address { get; set; }

                [NameInMap("Nationality")]
                [Validation(Required=true)]
                public string Nationality { get; set; }

                [NameInMap("EndDate")]
                [Validation(Required=true)]
                public string EndDate { get; set; }

                [NameInMap("FrontImageUrl")]
                [Validation(Required=true)]
                public string FrontImageUrl { get; set; }

                [NameInMap("Authority")]
                [Validation(Required=true)]
                public string Authority { get; set; }

                [NameInMap("Sex")]
                [Validation(Required=true)]
                public string Sex { get; set; }

                [NameInMap("Name")]
                [Validation(Required=true)]
                public string Name { get; set; }

                [NameInMap("Birth")]
                [Validation(Required=true)]
                public string Birth { get; set; }

                [NameInMap("BackImageUrl")]
                [Validation(Required=true)]
                public string BackImageUrl { get; set; }

                [NameInMap("StartDate")]
                [Validation(Required=true)]
                public string StartDate { get; set; }

            }
            [NameInMap("VideoUrls")]
            [Validation(Required=true)]
            public List<string> VideoUrls { get; set; }
        };

    }

}
