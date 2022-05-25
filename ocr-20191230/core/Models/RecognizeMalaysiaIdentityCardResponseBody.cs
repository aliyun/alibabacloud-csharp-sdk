// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeMalaysiaIdentityCardResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeMalaysiaIdentityCardResponseBodyData Data { get; set; }
        public class RecognizeMalaysiaIdentityCardResponseBodyData : TeaModel {
            [NameInMap("AddressFifthLine")]
            [Validation(Required=false)]
            public RecognizeMalaysiaIdentityCardResponseBodyDataAddressFifthLine AddressFifthLine { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataAddressFifthLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataAddressFifthLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataAddressFifthLineKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataAddressFirstLine AddressFirstLine { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataAddressFirstLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataAddressFirstLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataAddressFirstLineKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataAddressFourthLine AddressFourthLine { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataAddressFourthLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataAddressFourthLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataAddressFourthLineKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataAddressSecondLine AddressSecondLine { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataAddressSecondLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataAddressSecondLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataAddressSecondLineKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataAddressThirdLine AddressThirdLine { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataAddressThirdLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataAddressThirdLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataAddressThirdLineKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataCardBox CardBox { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataCardBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataCardBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataCardBoxKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataDriveClass DriveClass { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataDriveClass : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataDriveClassKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataDriveClassKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataExpiryDate ExpiryDate { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataExpiryDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataExpiryDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataExpiryDateKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataIdNumber IdNumber { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataIdNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataIdNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataIdNumberKeyPoints : TeaModel {
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
            [NameInMap("IssueDate")]
            [Validation(Required=false)]
            public RecognizeMalaysiaIdentityCardResponseBodyDataIssueDate IssueDate { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataIssueDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataIssueDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataIssueDateKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataNameFirstLine NameFirstLine { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataNameFirstLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataNameFirstLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataNameFirstLineKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataNameSecondLine NameSecondLine { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataNameSecondLine : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataNameSecondLineKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataNameSecondLineKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataNationality Nationality { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataNationality : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataNationalityKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataNationalityKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataPortraitBox PortraitBox { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataPortraitBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataPortraitBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataPortraitBoxKeyPoints : TeaModel {
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
            public RecognizeMalaysiaIdentityCardResponseBodyDataSex Sex { get; set; }
            public class RecognizeMalaysiaIdentityCardResponseBodyDataSex : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeMalaysiaIdentityCardResponseBodyDataSexKeyPoints> KeyPoints { get; set; }
                public class RecognizeMalaysiaIdentityCardResponseBodyDataSexKeyPoints : TeaModel {
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
