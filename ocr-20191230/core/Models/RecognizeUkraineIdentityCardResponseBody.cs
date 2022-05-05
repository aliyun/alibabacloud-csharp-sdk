// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeUkraineIdentityCardResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeUkraineIdentityCardResponseBodyData Data { get; set; }
        public class RecognizeUkraineIdentityCardResponseBodyData : TeaModel {
            [NameInMap("BirthDate")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataBirthDate BirthDate { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataBirthDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataBirthDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataBirthDateKeyPoints : TeaModel {
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
            public RecognizeUkraineIdentityCardResponseBodyDataCardBox CardBox { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataCardBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataCardBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataCardBoxKeyPoints : TeaModel {
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
            [NameInMap("DocumentNumber")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataDocumentNumber DocumentNumber { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataDocumentNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataDocumentNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataDocumentNumberKeyPoints : TeaModel {
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
            [NameInMap("ExpiryDate")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataExpiryDate ExpiryDate { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataExpiryDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataExpiryDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataExpiryDateKeyPoints : TeaModel {
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
            [NameInMap("NameEnglish")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataNameEnglish NameEnglish { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataNameEnglish : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataNameEnglishKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataNameEnglishKeyPoints : TeaModel {
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
            [NameInMap("NameUkraine")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataNameUkraine NameUkraine { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataNameUkraine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataNameUkraineKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataNameUkraineKeyPoints : TeaModel {
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
            [NameInMap("Nationality")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataNationality Nationality { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataNationality : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataNationalityKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataNationalityKeyPoints : TeaModel {
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
            [NameInMap("Patronymic")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataPatronymic Patronymic { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataPatronymic : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataPatronymicKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataPatronymicKeyPoints : TeaModel {
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
            [NameInMap("PortraitBox")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataPortraitBox PortraitBox { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataPortraitBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataPortraitBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataPortraitBoxKeyPoints : TeaModel {
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
            [NameInMap("RecordNumber")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataRecordNumber RecordNumber { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataRecordNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataRecordNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataRecordNumberKeyPoints : TeaModel {
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
            [NameInMap("Sex")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataSex Sex { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataSex : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataSexKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataSexKeyPoints : TeaModel {
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
            [NameInMap("SurnameEnglish")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataSurnameEnglish SurnameEnglish { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataSurnameEnglish : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataSurnameEnglishKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataSurnameEnglishKeyPoints : TeaModel {
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
            [NameInMap("SurnameUkraine")]
            [Validation(Required=false)]
            public RecognizeUkraineIdentityCardResponseBodyDataSurnameUkraine SurnameUkraine { get; set; }
            public class RecognizeUkraineIdentityCardResponseBodyDataSurnameUkraine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeUkraineIdentityCardResponseBodyDataSurnameUkraineKeyPoints> KeyPoints { get; set; }
                public class RecognizeUkraineIdentityCardResponseBodyDataSurnameUkraineKeyPoints : TeaModel {
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
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
