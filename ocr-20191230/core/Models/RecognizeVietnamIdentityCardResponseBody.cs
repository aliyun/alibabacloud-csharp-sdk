// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeVietnamIdentityCardResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeVietnamIdentityCardResponseBodyData Data { get; set; }
        public class RecognizeVietnamIdentityCardResponseBodyData : TeaModel {
            [NameInMap("AddressFirstLine")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataAddressFirstLine AddressFirstLine { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataAddressFirstLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataAddressFirstLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataAddressFirstLineKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("AddressSecondLine")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataAddressSecondLine AddressSecondLine { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataAddressSecondLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataAddressSecondLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataAddressSecondLineKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("BirthDate")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataBirthDate BirthDate { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataBirthDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataBirthDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataBirthDateKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("CardBox")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataCardBox CardBox { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataCardBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataCardBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataCardBoxKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("DriveClass")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataDriveClass DriveClass { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataDriveClass : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataDriveClassKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataDriveClassKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("ExpiryDate")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataExpiryDate ExpiryDate { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataExpiryDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataExpiryDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataExpiryDateKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("FullName")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataFullName FullName { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataFullName : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataFullNameKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataFullNameKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("IdNumber")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataIdNumber IdNumber { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataIdNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataIdNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataIdNumberKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("Nationality")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataNationality Nationality { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataNationality : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataNationalityKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataNationalityKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("OriginPlaceFirstLine")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataOriginPlaceFirstLine OriginPlaceFirstLine { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataOriginPlaceFirstLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataOriginPlaceFirstLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataOriginPlaceFirstLineKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("OriginPlaceSecondLine")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataOriginPlaceSecondLine OriginPlaceSecondLine { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataOriginPlaceSecondLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataOriginPlaceSecondLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataOriginPlaceSecondLineKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("PortraitBox")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataPortraitBox PortraitBox { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataPortraitBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataPortraitBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataPortraitBoxKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("ResidencePlaceFirstLine")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataResidencePlaceFirstLine ResidencePlaceFirstLine { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataResidencePlaceFirstLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataResidencePlaceFirstLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataResidencePlaceFirstLineKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("ResidencePlaceSecondLine")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataResidencePlaceSecondLine ResidencePlaceSecondLine { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataResidencePlaceSecondLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataResidencePlaceSecondLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataResidencePlaceSecondLineKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("Sex")]
            [Validation(Required=false)]
            public RecognizeVietnamIdentityCardResponseBodyDataSex Sex { get; set; }
            public class RecognizeVietnamIdentityCardResponseBodyDataSex : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeVietnamIdentityCardResponseBodyDataSexKeyPoints> KeyPoints { get; set; }
                public class RecognizeVietnamIdentityCardResponseBodyDataSexKeyPoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
