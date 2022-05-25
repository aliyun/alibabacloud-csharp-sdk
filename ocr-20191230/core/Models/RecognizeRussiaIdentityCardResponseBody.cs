// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeRussiaIdentityCardResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeRussiaIdentityCardResponseBodyData Data { get; set; }
        public class RecognizeRussiaIdentityCardResponseBodyData : TeaModel {
            [NameInMap("BirthDate")]
            [Validation(Required=false)]
            public RecognizeRussiaIdentityCardResponseBodyDataBirthDate BirthDate { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataBirthDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataBirthDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataBirthDateKeyPoints : TeaModel {
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
            [NameInMap("BirthPlaceFirstLine")]
            [Validation(Required=false)]
            public RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceFirstLine BirthPlaceFirstLine { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceFirstLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceFirstLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceFirstLineKeyPoints : TeaModel {
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
            [NameInMap("BirthPlaceSecondLine")]
            [Validation(Required=false)]
            public RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceSecondLine BirthPlaceSecondLine { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceSecondLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceSecondLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceSecondLineKeyPoints : TeaModel {
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
            [NameInMap("BirthPlaceThirdLine")]
            [Validation(Required=false)]
            public RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceThirdLine BirthPlaceThirdLine { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceThirdLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceThirdLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataBirthPlaceThirdLineKeyPoints : TeaModel {
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
            public RecognizeRussiaIdentityCardResponseBodyDataCardBox CardBox { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataCardBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataCardBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataCardBoxKeyPoints : TeaModel {
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
            [NameInMap("GivenName")]
            [Validation(Required=false)]
            public RecognizeRussiaIdentityCardResponseBodyDataGivenName GivenName { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataGivenName : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataGivenNameKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataGivenNameKeyPoints : TeaModel {
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
            public RecognizeRussiaIdentityCardResponseBodyDataIdNumber IdNumber { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataIdNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataIdNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataIdNumberKeyPoints : TeaModel {
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
            [NameInMap("PaternalName")]
            [Validation(Required=false)]
            public RecognizeRussiaIdentityCardResponseBodyDataPaternalName PaternalName { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataPaternalName : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataPaternalNameKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataPaternalNameKeyPoints : TeaModel {
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
            public RecognizeRussiaIdentityCardResponseBodyDataPortraitBox PortraitBox { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataPortraitBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataPortraitBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataPortraitBoxKeyPoints : TeaModel {
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
            public RecognizeRussiaIdentityCardResponseBodyDataSex Sex { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataSex : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataSexKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataSexKeyPoints : TeaModel {
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
            [NameInMap("SurnameFirstLine")]
            [Validation(Required=false)]
            public RecognizeRussiaIdentityCardResponseBodyDataSurnameFirstLine SurnameFirstLine { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataSurnameFirstLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataSurnameFirstLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataSurnameFirstLineKeyPoints : TeaModel {
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
            [NameInMap("SurnameSecondLine")]
            [Validation(Required=false)]
            public RecognizeRussiaIdentityCardResponseBodyDataSurnameSecondLine SurnameSecondLine { get; set; }
            public class RecognizeRussiaIdentityCardResponseBodyDataSurnameSecondLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeRussiaIdentityCardResponseBodyDataSurnameSecondLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeRussiaIdentityCardResponseBodyDataSurnameSecondLineKeyPoints : TeaModel {
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
