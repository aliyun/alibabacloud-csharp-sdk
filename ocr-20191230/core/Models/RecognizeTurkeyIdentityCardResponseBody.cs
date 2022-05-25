// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeTurkeyIdentityCardResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeTurkeyIdentityCardResponseBodyData Data { get; set; }
        public class RecognizeTurkeyIdentityCardResponseBodyData : TeaModel {
            [NameInMap("AuxiliaryTools")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataAuxiliaryTools AuxiliaryTools { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataAuxiliaryTools : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataAuxiliaryToolsKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataAuxiliaryToolsKeyPoints : TeaModel {
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
            public RecognizeTurkeyIdentityCardResponseBodyDataBirthDate BirthDate { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataBirthDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataBirthDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataBirthDateKeyPoints : TeaModel {
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
            [NameInMap("BirthPlace")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataBirthPlace BirthPlace { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataBirthPlace : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataBirthPlaceKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataBirthPlaceKeyPoints : TeaModel {
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
            [NameInMap("BloodType")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataBloodType BloodType { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataBloodType : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataBloodTypeKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataBloodTypeKeyPoints : TeaModel {
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
            public RecognizeTurkeyIdentityCardResponseBodyDataCardBox CardBox { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataCardBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataCardBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataCardBoxKeyPoints : TeaModel {
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
            [NameInMap("Cilt")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataCilt Cilt { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataCilt : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataCiltKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataCiltKeyPoints : TeaModel {
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
            public RecognizeTurkeyIdentityCardResponseBodyDataDocumentNumber DocumentNumber { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataDocumentNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataDocumentNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataDocumentNumberKeyPoints : TeaModel {
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
            [NameInMap("DriveClass")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataDriveClass DriveClass { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataDriveClass : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataDriveClassKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataDriveClassKeyPoints : TeaModel {
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
            [NameInMap("DueDate")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataDueDate DueDate { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataDueDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataDueDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataDueDateKeyPoints : TeaModel {
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
            [NameInMap("Duzenleyen")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataDuzenleyen Duzenleyen { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataDuzenleyen : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataDuzenleyenKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataDuzenleyenKeyPoints : TeaModel {
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
            [NameInMap("EntryNumber")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataEntryNumber EntryNumber { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataEntryNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataEntryNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataEntryNumberKeyPoints : TeaModel {
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
            public RecognizeTurkeyIdentityCardResponseBodyDataExpiryDate ExpiryDate { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataExpiryDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataExpiryDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataExpiryDateKeyPoints : TeaModel {
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
            [NameInMap("FatherName")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataFatherName FatherName { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataFatherName : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataFatherNameKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataFatherNameKeyPoints : TeaModel {
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
            [NameInMap("ForeignersId")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataForeignersId ForeignersId { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataForeignersId : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataForeignersIdKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataForeignersIdKeyPoints : TeaModel {
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
            [NameInMap("Gender")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataGender Gender { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataGender : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataGenderKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataGenderKeyPoints : TeaModel {
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
            [NameInMap("GivenName")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataGivenName GivenName { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataGivenName : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataGivenNameKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataGivenNameKeyPoints : TeaModel {
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
            [NameInMap("IdNumber")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataIdNumber IdNumber { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataIdNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataIdNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataIdNumberKeyPoints : TeaModel {
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
            [NameInMap("IssueBy")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataIssueBy IssueBy { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataIssueBy : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataIssueByKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataIssueByKeyPoints : TeaModel {
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
            [NameInMap("IssueCounty")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataIssueCounty IssueCounty { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataIssueCounty : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataIssueCountyKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataIssueCountyKeyPoints : TeaModel {
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
            [NameInMap("IssueDate")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataIssueDate IssueDate { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataIssueDate : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataIssueDateKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataIssueDateKeyPoints : TeaModel {
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
            [NameInMap("IssuePlace")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataIssuePlace IssuePlace { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataIssuePlace : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataIssuePlaceKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataIssuePlaceKeyPoints : TeaModel {
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
            [NameInMap("Kutuk")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataKutuk Kutuk { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataKutuk : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataKutukKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataKutukKeyPoints : TeaModel {
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
            [NameInMap("LicenseNumber")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataLicenseNumber LicenseNumber { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataLicenseNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataLicenseNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataLicenseNumberKeyPoints : TeaModel {
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
            [NameInMap("MaritalStatus")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataMaritalStatus MaritalStatus { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataMaritalStatus : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataMaritalStatusKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataMaritalStatusKeyPoints : TeaModel {
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
            [NameInMap("MotherName")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataMotherName MotherName { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataMotherName : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataMotherNameKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataMotherNameKeyPoints : TeaModel {
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
            [NameInMap("Name")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataName Name { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataName : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataNameKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataNameKeyPoints : TeaModel {
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
            public RecognizeTurkeyIdentityCardResponseBodyDataNationality Nationality { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataNationality : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataNationalityKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataNationalityKeyPoints : TeaModel {
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
            [NameInMap("NeighborhoodVillage")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataNeighborhoodVillage NeighborhoodVillage { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataNeighborhoodVillage : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataNeighborhoodVillageKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataNeighborhoodVillageKeyPoints : TeaModel {
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
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataPageNumber PageNumber { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataPageNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataPageNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataPageNumberKeyPoints : TeaModel {
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
            [NameInMap("PassportNumber")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataPassportNumber PassportNumber { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataPassportNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataPassportNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataPassportNumberKeyPoints : TeaModel {
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
            public RecognizeTurkeyIdentityCardResponseBodyDataPortraitBox PortraitBox { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataPortraitBox : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataPortraitBoxKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataPortraitBoxKeyPoints : TeaModel {
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
            [NameInMap("Province")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataProvince Province { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataProvince : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataProvinceKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataProvinceKeyPoints : TeaModel {
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
            [NameInMap("ProvinceOfResidence")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataProvinceOfResidence ProvinceOfResidence { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataProvinceOfResidence : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataProvinceOfResidenceKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataProvinceOfResidenceKeyPoints : TeaModel {
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
            [NameInMap("ReasonOfIssue")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataReasonOfIssue ReasonOfIssue { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataReasonOfIssue : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataReasonOfIssueKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataReasonOfIssueKeyPoints : TeaModel {
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
            [NameInMap("RegisterNumber")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataRegisterNumber RegisterNumber { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataRegisterNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataRegisterNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataRegisterNumberKeyPoints : TeaModel {
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
            [NameInMap("Religion")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataReligion Religion { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataReligion : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataReligionKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataReligionKeyPoints : TeaModel {
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
            [NameInMap("Sayfa")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataSayfa Sayfa { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataSayfa : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataSayfaKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataSayfaKeyPoints : TeaModel {
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
            [NameInMap("Seri")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataSeri Seri { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataSeri : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataSeriKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataSeriKeyPoints : TeaModel {
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
            public RecognizeTurkeyIdentityCardResponseBodyDataSex Sex { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataSex : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataSexKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataSexKeyPoints : TeaModel {
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
            [NameInMap("Surname")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataSurname Surname { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataSurname : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataSurnameKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataSurnameKeyPoints : TeaModel {
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
            [NameInMap("TypeOfResidencePermit")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataTypeOfResidencePermit TypeOfResidencePermit { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataTypeOfResidencePermit : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataTypeOfResidencePermitKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataTypeOfResidencePermitKeyPoints : TeaModel {
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
            [NameInMap("ValidUntil")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataValidUntil ValidUntil { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataValidUntil : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataValidUntilKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataValidUntilKeyPoints : TeaModel {
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
            [NameInMap("Village")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataVillage Village { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataVillage : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataVillageKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataVillageKeyPoints : TeaModel {
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
            [NameInMap("VolumeNumber")]
            [Validation(Required=false)]
            public RecognizeTurkeyIdentityCardResponseBodyDataVolumeNumber VolumeNumber { get; set; }
            public class RecognizeTurkeyIdentityCardResponseBodyDataVolumeNumber : TeaModel {
                [NameInMap("KeyPoints")]
                [Validation(Required=false)]
                public List<RecognizeTurkeyIdentityCardResponseBodyDataVolumeNumberKeyPoints> KeyPoints { get; set; }
                public class RecognizeTurkeyIdentityCardResponseBodyDataVolumeNumberKeyPoints : TeaModel {
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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
