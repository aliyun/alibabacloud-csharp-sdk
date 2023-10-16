// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTradeMarkApplicationDetailResponseBody : TeaModel {
        [NameInMap("AcceptUrl")]
        [Validation(Required=false)]
        public string AcceptUrl { get; set; }

        [NameInMap("AdminUploads")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationDetailResponseBodyAdminUploads AdminUploads { get; set; }
        public class QueryTradeMarkApplicationDetailResponseBodyAdminUploads : TeaModel {
            [NameInMap("LicensePicUrl")]
            [Validation(Required=false)]
            public string LicensePicUrl { get; set; }

            [NameInMap("LoaPicUrl")]
            [Validation(Required=false)]
            public string LoaPicUrl { get; set; }

        }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendInfo { get; set; }

        [NameInMap("FirstClassification")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationDetailResponseBodyFirstClassification FirstClassification { get; set; }
        public class QueryTradeMarkApplicationDetailResponseBodyFirstClassification : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Flags")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationDetailResponseBodyFlags Flags { get; set; }
        public class QueryTradeMarkApplicationDetailResponseBodyFlags : TeaModel {
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public List<int?> Flag { get; set; }

        }

        [NameInMap("GrayIconUrl")]
        [Validation(Required=false)]
        public string GrayIconUrl { get; set; }

        [NameInMap("JudgeResultUrl")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationDetailResponseBodyJudgeResultUrl JudgeResultUrl { get; set; }
        public class QueryTradeMarkApplicationDetailResponseBodyJudgeResultUrl : TeaModel {
            [NameInMap("JudgeResultUrl")]
            [Validation(Required=false)]
            public List<string> JudgeResultUrl { get; set; }

        }

        [NameInMap("LegalNoticeUrl")]
        [Validation(Required=false)]
        public string LegalNoticeUrl { get; set; }

        [NameInMap("LoaUrl")]
        [Validation(Required=false)]
        public string LoaUrl { get; set; }

        [NameInMap("LogisticsCertificateUrl")]
        [Validation(Required=false)]
        public string LogisticsCertificateUrl { get; set; }

        [NameInMap("LogisticsNo")]
        [Validation(Required=false)]
        public string LogisticsNo { get; set; }

        [NameInMap("MaterialDetail")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationDetailResponseBodyMaterialDetail MaterialDetail { get; set; }
        public class QueryTradeMarkApplicationDetailResponseBodyMaterialDetail : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("BusinessLicenceUrl")]
            [Validation(Required=false)]
            public string BusinessLicenceUrl { get; set; }

            [NameInMap("CardNumber")]
            [Validation(Required=false)]
            public string CardNumber { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("ContactAddress")]
            [Validation(Required=false)]
            public string ContactAddress { get; set; }

            [NameInMap("ContactCity")]
            [Validation(Required=false)]
            public string ContactCity { get; set; }

            [NameInMap("ContactDistrict")]
            [Validation(Required=false)]
            public string ContactDistrict { get; set; }

            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("ContactNumber")]
            [Validation(Required=false)]
            public string ContactNumber { get; set; }

            [NameInMap("ContactProvince")]
            [Validation(Required=false)]
            public string ContactProvince { get; set; }

            [NameInMap("ContactZipcode")]
            [Validation(Required=false)]
            public string ContactZipcode { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("DetailedContactAddress")]
            [Validation(Required=false)]
            public string DetailedContactAddress { get; set; }

            [NameInMap("EAddress")]
            [Validation(Required=false)]
            public string EAddress { get; set; }

            [NameInMap("EName")]
            [Validation(Required=false)]
            public string EName { get; set; }

            [NameInMap("ExpirationDate")]
            [Validation(Required=false)]
            public string ExpirationDate { get; set; }

            [NameInMap("FactAndReasonPdfPath")]
            [Validation(Required=false)]
            public string FactAndReasonPdfPath { get; set; }

            [NameInMap("IdCardName")]
            [Validation(Required=false)]
            public string IdCardName { get; set; }

            [NameInMap("IdCardNumber")]
            [Validation(Required=false)]
            public string IdCardNumber { get; set; }

            [NameInMap("IdCardUrl")]
            [Validation(Required=false)]
            public string IdCardUrl { get; set; }

            [NameInMap("LegalNoticeUrl")]
            [Validation(Required=false)]
            public string LegalNoticeUrl { get; set; }

            [NameInMap("LoaUrl")]
            [Validation(Required=false)]
            public string LoaUrl { get; set; }

            [NameInMap("MaterialVersion")]
            [Validation(Required=false)]
            public string MaterialVersion { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PassportUrl")]
            [Validation(Required=false)]
            public string PassportUrl { get; set; }

            [NameInMap("PersonalType")]
            [Validation(Required=false)]
            public long? PersonalType { get; set; }

            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public int? PrincipalName { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public int? Region { get; set; }

            [NameInMap("ReviewAdditionalFiles")]
            [Validation(Required=false)]
            public QueryTradeMarkApplicationDetailResponseBodyMaterialDetailReviewAdditionalFiles ReviewAdditionalFiles { get; set; }
            public class QueryTradeMarkApplicationDetailResponseBodyMaterialDetailReviewAdditionalFiles : TeaModel {
                [NameInMap("ReviewAdditionalFile")]
                [Validation(Required=false)]
                public List<string> ReviewAdditionalFile { get; set; }

            }

            [NameInMap("ReviewApplicationFile")]
            [Validation(Required=false)]
            public string ReviewApplicationFile { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SupplementEvidenceCatalogFile")]
            [Validation(Required=false)]
            public string SupplementEvidenceCatalogFile { get; set; }

            [NameInMap("SupplementEvidenceMaterialFile")]
            [Validation(Required=false)]
            public string SupplementEvidenceMaterialFile { get; set; }

            [NameInMap("SupplementReasonFile")]
            [Validation(Required=false)]
            public string SupplementReasonFile { get; set; }

            [NameInMap("Town")]
            [Validation(Required=false)]
            public string Town { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public long? MaterialId { get; set; }

        [NameInMap("NotAcceptUrl")]
        [Validation(Required=false)]
        public string NotAcceptUrl { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OrderPrice")]
        [Validation(Required=false)]
        public float? OrderPrice { get; set; }

        [NameInMap("PartnerCode")]
        [Validation(Required=false)]
        public string PartnerCode { get; set; }

        [NameInMap("PartnerMobile")]
        [Validation(Required=false)]
        public string PartnerMobile { get; set; }

        [NameInMap("PartnerName")]
        [Validation(Required=false)]
        public string PartnerName { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public int? PrincipalName { get; set; }

        [NameInMap("ReceiptUrl")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationDetailResponseBodyReceiptUrl ReceiptUrl { get; set; }
        public class QueryTradeMarkApplicationDetailResponseBodyReceiptUrl : TeaModel {
            [NameInMap("ReceiptUrl")]
            [Validation(Required=false)]
            public List<string> ReceiptUrl { get; set; }

        }

        [NameInMap("RecvUserLogistics")]
        [Validation(Required=false)]
        public string RecvUserLogistics { get; set; }

        [NameInMap("RenewResponse")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationDetailResponseBodyRenewResponse RenewResponse { get; set; }
        public class QueryTradeMarkApplicationDetailResponseBodyRenewResponse : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("EngAddress")]
            [Validation(Required=false)]
            public string EngAddress { get; set; }

            [NameInMap("EngName")]
            [Validation(Required=false)]
            public string EngName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegisterTime")]
            [Validation(Required=false)]
            public long? RegisterTime { get; set; }

            [NameInMap("SubmitSbjtime")]
            [Validation(Required=false)]
            public long? SubmitSbjtime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReviewOfficialFiles")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationDetailResponseBodyReviewOfficialFiles ReviewOfficialFiles { get; set; }
        public class QueryTradeMarkApplicationDetailResponseBodyReviewOfficialFiles : TeaModel {
            [NameInMap("ReviewAudit")]
            [Validation(Required=false)]
            public string ReviewAudit { get; set; }

            [NameInMap("ReviewKeep")]
            [Validation(Required=false)]
            public string ReviewKeep { get; set; }

            [NameInMap("ReviewPart")]
            [Validation(Required=false)]
            public string ReviewPart { get; set; }

            [NameInMap("ReviewPass")]
            [Validation(Required=false)]
            public string ReviewPass { get; set; }

            [NameInMap("ReviewSupplements")]
            [Validation(Required=false)]
            public QueryTradeMarkApplicationDetailResponseBodyReviewOfficialFilesReviewSupplements ReviewSupplements { get; set; }
            public class QueryTradeMarkApplicationDetailResponseBodyReviewOfficialFilesReviewSupplements : TeaModel {
                [NameInMap("ReviewSupplement")]
                [Validation(Required=false)]
                public List<string> ReviewSupplement { get; set; }

            }

        }

        [NameInMap("SendSbjLogistics")]
        [Validation(Required=false)]
        public string SendSbjLogistics { get; set; }

        [NameInMap("SendTime")]
        [Validation(Required=false)]
        public string SendTime { get; set; }

        [NameInMap("SendUserLogistics")]
        [Validation(Required=false)]
        public string SendUserLogistics { get; set; }

        [NameInMap("ServicePrice")]
        [Validation(Required=false)]
        public float? ServicePrice { get; set; }

        [NameInMap("Specification")]
        [Validation(Required=false)]
        public int? Specification { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("SubmitAuditTime")]
        [Validation(Required=false)]
        public long? SubmitAuditTime { get; set; }

        [NameInMap("SubmitTime")]
        [Validation(Required=false)]
        public long? SubmitTime { get; set; }

        [NameInMap("Supplements")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationDetailResponseBodySupplements Supplements { get; set; }
        public class QueryTradeMarkApplicationDetailResponseBodySupplements : TeaModel {
            [NameInMap("Supplements")]
            [Validation(Required=false)]
            public List<QueryTradeMarkApplicationDetailResponseBodySupplementsSupplements> Supplements { get; set; }
            public class QueryTradeMarkApplicationDetailResponseBodySupplementsSupplements : TeaModel {
                [NameInMap("AcceptDeadTime")]
                [Validation(Required=false)]
                public long? AcceptDeadTime { get; set; }

                [NameInMap("AcceptTime")]
                [Validation(Required=false)]
                public long? AcceptTime { get; set; }

                [NameInMap("BatchNum")]
                [Validation(Required=false)]
                public string BatchNum { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("FileTemplateUrls")]
                [Validation(Required=false)]
                public QueryTradeMarkApplicationDetailResponseBodySupplementsSupplementsFileTemplateUrls FileTemplateUrls { get; set; }
                public class QueryTradeMarkApplicationDetailResponseBodySupplementsSupplementsFileTemplateUrls : TeaModel {
                    [NameInMap("FileTemplateUrls")]
                    [Validation(Required=false)]
                    public List<string> FileTemplateUrls { get; set; }

                }

                [NameInMap("Filename")]
                [Validation(Required=false)]
                public string Filename { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("OperateTime")]
                [Validation(Required=false)]
                public long? OperateTime { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("SbjDeadTime")]
                [Validation(Required=false)]
                public long? SbjDeadTime { get; set; }

                [NameInMap("SendTime")]
                [Validation(Required=false)]
                public long? SendTime { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TmNumber")]
                [Validation(Required=false)]
                public string TmNumber { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("UploadFileTemplateUrl")]
                [Validation(Required=false)]
                public string UploadFileTemplateUrl { get; set; }

            }

        }

        [NameInMap("SystemVersion")]
        [Validation(Required=false)]
        public string SystemVersion { get; set; }

        [NameInMap("ThirdClassification")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationDetailResponseBodyThirdClassification ThirdClassification { get; set; }
        public class QueryTradeMarkApplicationDetailResponseBodyThirdClassification : TeaModel {
            [NameInMap("ThirdClassifications")]
            [Validation(Required=false)]
            public List<QueryTradeMarkApplicationDetailResponseBodyThirdClassificationThirdClassifications> ThirdClassifications { get; set; }
            public class QueryTradeMarkApplicationDetailResponseBodyThirdClassificationThirdClassifications : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("TmIcon")]
        [Validation(Required=false)]
        public string TmIcon { get; set; }

        [NameInMap("TmName")]
        [Validation(Required=false)]
        public string TmName { get; set; }

        [NameInMap("TmNameType")]
        [Validation(Required=false)]
        public int? TmNameType { get; set; }

        [NameInMap("TmNumber")]
        [Validation(Required=false)]
        public string TmNumber { get; set; }

        [NameInMap("TotalPrice")]
        [Validation(Required=false)]
        public float? TotalPrice { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
