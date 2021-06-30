// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20201112.Models
{
    public class VerifyMaterialResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public VerifyMaterialResponseBodyResultObject ResultObject { get; set; }
        public class VerifyMaterialResponseBodyResultObject : TeaModel {
            [NameInMap("AuthorityComparisionScore")]
            [Validation(Required=false)]
            public float? AuthorityComparisionScore { get; set; }
            [NameInMap("VerifyStatus")]
            [Validation(Required=false)]
            public int? VerifyStatus { get; set; }
            [NameInMap("VerifyToken")]
            [Validation(Required=false)]
            public string VerifyToken { get; set; }
            [NameInMap("IdCardFaceComparisonScore")]
            [Validation(Required=false)]
            public float? IdCardFaceComparisonScore { get; set; }
            [NameInMap("Material")]
            [Validation(Required=false)]
            public VerifyMaterialResponseBodyResultObjectMaterial Material { get; set; }
            public class VerifyMaterialResponseBodyResultObjectMaterial : TeaModel {
                [NameInMap("IdCardNumber")]
                [Validation(Required=false)]
                public string IdCardNumber { get; set; }

                [NameInMap("FaceGlobalUrl")]
                [Validation(Required=false)]
                public string FaceGlobalUrl { get; set; }

                [NameInMap("FaceImageUrl")]
                [Validation(Required=false)]
                public string FaceImageUrl { get; set; }

                [NameInMap("FaceMask")]
                [Validation(Required=false)]
                public string FaceMask { get; set; }

                [NameInMap("IdCardName")]
                [Validation(Required=false)]
                public string IdCardName { get; set; }

                [NameInMap("FaceQuality")]
                [Validation(Required=false)]
                public string FaceQuality { get; set; }

                [NameInMap("IdCardInfo")]
                [Validation(Required=false)]
                public VerifyMaterialResponseBodyResultObjectMaterialIdCardInfo IdCardInfo { get; set; }
                public class VerifyMaterialResponseBodyResultObjectMaterialIdCardInfo : TeaModel {
                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }
                    [NameInMap("EndDate")]
                    [Validation(Required=false)]
                    public string EndDate { get; set; }
                    [NameInMap("Authority")]
                    [Validation(Required=false)]
                    public string Authority { get; set; }
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }
                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }
                    [NameInMap("StartDate")]
                    [Validation(Required=false)]
                    public string StartDate { get; set; }
                    [NameInMap("BackImageUrl")]
                    [Validation(Required=false)]
                    public string BackImageUrl { get; set; }
                    [NameInMap("Nationality")]
                    [Validation(Required=false)]
                    public string Nationality { get; set; }
                    [NameInMap("Birth")]
                    [Validation(Required=false)]
                    public string Birth { get; set; }
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                    [NameInMap("FrontImageUrl")]
                    [Validation(Required=false)]
                    public string FrontImageUrl { get; set; }
                };

            }
        };

    }

}
