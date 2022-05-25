// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeIndonesiaIdentityCardResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeIndonesiaIdentityCardResponseBodyData Data { get; set; }
        public class RecognizeIndonesiaIdentityCardResponseBodyData : TeaModel {
            [NameInMap("AddressFifthLine")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataAddressFifthLine AddressFifthLine { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataAddressFifthLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataAddressFifthLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataAddressFifthLineKeyPoints : TeaModel {
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
            [NameInMap("AddressFirstLine")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataAddressFirstLine AddressFirstLine { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataAddressFirstLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataAddressFirstLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataAddressFirstLineKeyPoints : TeaModel {
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
            [NameInMap("AddressFourthLine")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataAddressFourthLine AddressFourthLine { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataAddressFourthLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataAddressFourthLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataAddressFourthLineKeyPoints : TeaModel {
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
            public RecognizeIndonesiaIdentityCardResponseBodyDataAddressSecondLine AddressSecondLine { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataAddressSecondLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataAddressSecondLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataAddressSecondLineKeyPoints : TeaModel {
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
            [NameInMap("AddressThirdLine")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataAddressThirdLine AddressThirdLine { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataAddressThirdLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataAddressThirdLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataAddressThirdLineKeyPoints : TeaModel {
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
            public RecognizeIndonesiaIdentityCardResponseBodyDataBirthDate BirthDate { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataBirthDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataBirthDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataBirthDateKeyPoints : TeaModel {
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
            [NameInMap("BirthPlace")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataBirthPlace BirthPlace { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataBirthPlace : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataBirthPlaceKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataBirthPlaceKeyPoints : TeaModel {
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
            [NameInMap("CardBox")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataCardBox CardBox { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataCardBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataCardBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataCardBoxKeyPoints : TeaModel {
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
            public RecognizeIndonesiaIdentityCardResponseBodyDataExpiryDate ExpiryDate { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataExpiryDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataExpiryDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataExpiryDateKeyPoints : TeaModel {
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
            [NameInMap("Gender")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataGender Gender { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataGender : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataGenderKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataGenderKeyPoints : TeaModel {
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
            [NameInMap("Height")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataHeight Height { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataHeight : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataHeightKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataHeightKeyPoints : TeaModel {
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
            public RecognizeIndonesiaIdentityCardResponseBodyDataIdNumber IdNumber { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataIdNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataIdNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataIdNumberKeyPoints : TeaModel {
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
            [NameInMap("LicenseNumber")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataLicenseNumber LicenseNumber { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataLicenseNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataLicenseNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataLicenseNumberKeyPoints : TeaModel {
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
            [NameInMap("MaritalStatus")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataMaritalStatus MaritalStatus { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataMaritalStatus : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataMaritalStatusKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataMaritalStatusKeyPoints : TeaModel {
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
            [NameInMap("NameFirstLine")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataNameFirstLine NameFirstLine { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataNameFirstLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataNameFirstLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataNameFirstLineKeyPoints : TeaModel {
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
            [NameInMap("NameSecondLine")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataNameSecondLine NameSecondLine { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataNameSecondLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataNameSecondLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataNameSecondLineKeyPoints : TeaModel {
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
            public RecognizeIndonesiaIdentityCardResponseBodyDataNationality Nationality { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataNationality : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataNationalityKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataNationalityKeyPoints : TeaModel {
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
            [NameInMap("Occupation")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataOccupation Occupation { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataOccupation : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataOccupationKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataOccupationKeyPoints : TeaModel {
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
            public RecognizeIndonesiaIdentityCardResponseBodyDataPortraitBox PortraitBox { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataPortraitBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataPortraitBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataPortraitBoxKeyPoints : TeaModel {
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
            [NameInMap("Province")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataProvince Province { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataProvince : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataProvinceKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataProvinceKeyPoints : TeaModel {
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
            [NameInMap("Religion")]
            [Validation(Required=false)]
            public RecognizeIndonesiaIdentityCardResponseBodyDataReligion Religion { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataReligion : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataReligionKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataReligionKeyPoints : TeaModel {
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
            public RecognizeIndonesiaIdentityCardResponseBodyDataSex Sex { get; set; }
            public class RecognizeIndonesiaIdentityCardResponseBodyDataSex : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeIndonesiaIdentityCardResponseBodyDataSexKeyPoints> KeyPoints { get; set; }
                public class RecognizeIndonesiaIdentityCardResponseBodyDataSexKeyPoints : TeaModel {
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
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
