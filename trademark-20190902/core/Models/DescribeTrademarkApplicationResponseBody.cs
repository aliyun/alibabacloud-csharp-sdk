// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class DescribeTrademarkApplicationResponseBody : TeaModel {
        [NameInMap("AcceptUrl")]
        [Validation(Required=false)]
        public string AcceptUrl { get; set; }

        [NameInMap("AgreementId")]
        [Validation(Required=false)]
        public string AgreementId { get; set; }

        [NameInMap("Applicant")]
        [Validation(Required=false)]
        public DescribeTrademarkApplicationResponseBodyApplicant Applicant { get; set; }
        public class DescribeTrademarkApplicationResponseBodyApplicant : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("ApplicantName")]
            [Validation(Required=false)]
            public string ApplicantName { get; set; }

            [NameInMap("ApplicantRegion")]
            [Validation(Required=false)]
            public int? ApplicantRegion { get; set; }

            [NameInMap("ApplicantType")]
            [Validation(Required=false)]
            public int? ApplicantType { get; set; }

            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            [NameInMap("AuthorizationUrl")]
            [Validation(Required=false)]
            public string AuthorizationUrl { get; set; }

            [NameInMap("BusinessLicenceUrl")]
            [Validation(Required=false)]
            public string BusinessLicenceUrl { get; set; }

            [NameInMap("CardNumber")]
            [Validation(Required=false)]
            public string CardNumber { get; set; }

            [NameInMap("ContactAddress")]
            [Validation(Required=false)]
            public string ContactAddress { get; set; }

            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("ContactNumber")]
            [Validation(Required=false)]
            public string ContactNumber { get; set; }

            [NameInMap("ContactZipcode")]
            [Validation(Required=false)]
            public string ContactZipcode { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("EAddress")]
            [Validation(Required=false)]
            public string EAddress { get; set; }

            [NameInMap("EName")]
            [Validation(Required=false)]
            public string EName { get; set; }

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

        }

        [NameInMap("ApplicantId")]
        [Validation(Required=false)]
        public long? ApplicantId { get; set; }

        [NameInMap("ApplicationStatus")]
        [Validation(Required=false)]
        public int? ApplicationStatus { get; set; }

        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public int? ApplicationType { get; set; }

        [NameInMap("AuthorizationUrl")]
        [Validation(Required=false)]
        public string AuthorizationUrl { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BlackAndWhiteIconUrl")]
        [Validation(Required=false)]
        public string BlackAndWhiteIconUrl { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendInfo { get; set; }

        [NameInMap("FirstClassification")]
        [Validation(Required=false)]
        public DescribeTrademarkApplicationResponseBodyFirstClassification FirstClassification { get; set; }
        public class DescribeTrademarkApplicationResponseBodyFirstClassification : TeaModel {
            [NameInMap("ClassificationCode")]
            [Validation(Required=false)]
            public string ClassificationCode { get; set; }

            [NameInMap("ClassificationName")]
            [Validation(Required=false)]
            public string ClassificationName { get; set; }

        }

        [NameInMap("Flags")]
        [Validation(Required=false)]
        public DescribeTrademarkApplicationResponseBodyFlags Flags { get; set; }
        public class DescribeTrademarkApplicationResponseBodyFlags : TeaModel {
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public List<int?> Flag { get; set; }

        }

        [NameInMap("JudgeResultUrls")]
        [Validation(Required=false)]
        public DescribeTrademarkApplicationResponseBodyJudgeResultUrls JudgeResultUrls { get; set; }
        public class DescribeTrademarkApplicationResponseBodyJudgeResultUrls : TeaModel {
            [NameInMap("JudgeResultUrl")]
            [Validation(Required=false)]
            public List<string> JudgeResultUrl { get; set; }

        }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OrderPrice")]
        [Validation(Required=false)]
        public float? OrderPrice { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public int? PrincipalName { get; set; }

        [NameInMap("ReceiptUrls")]
        [Validation(Required=false)]
        public DescribeTrademarkApplicationResponseBodyReceiptUrls ReceiptUrls { get; set; }
        public class DescribeTrademarkApplicationResponseBodyReceiptUrls : TeaModel {
            [NameInMap("ReceiptUrl")]
            [Validation(Required=false)]
            public List<string> ReceiptUrl { get; set; }

        }

        [NameInMap("RecvUserLogistics")]
        [Validation(Required=false)]
        public string RecvUserLogistics { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SendSbjLogistics")]
        [Validation(Required=false)]
        public string SendSbjLogistics { get; set; }

        [NameInMap("SendUserLogistics")]
        [Validation(Required=false)]
        public string SendUserLogistics { get; set; }

        [NameInMap("ServicePrice")]
        [Validation(Required=false)]
        public float? ServicePrice { get; set; }

        [NameInMap("Supplements")]
        [Validation(Required=false)]
        public DescribeTrademarkApplicationResponseBodySupplements Supplements { get; set; }
        public class DescribeTrademarkApplicationResponseBodySupplements : TeaModel {
            [NameInMap("Supplement")]
            [Validation(Required=false)]
            public List<DescribeTrademarkApplicationResponseBodySupplementsSupplement> Supplement { get; set; }
            public class DescribeTrademarkApplicationResponseBodySupplementsSupplement : TeaModel {
                [NameInMap("AcceptExpirationDate")]
                [Validation(Required=false)]
                public long? AcceptExpirationDate { get; set; }

                [NameInMap("AcceptTime")]
                [Validation(Required=false)]
                public long? AcceptTime { get; set; }

                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public int? ApplicationType { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("OfficialFile")]
                [Validation(Required=false)]
                public string OfficialFile { get; set; }

                [NameInMap("OperateTime")]
                [Validation(Required=false)]
                public long? OperateTime { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("SbjExpirationDate")]
                [Validation(Required=false)]
                public long? SbjExpirationDate { get; set; }

                [NameInMap("SendTime")]
                [Validation(Required=false)]
                public long? SendTime { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("SupplementId")]
                [Validation(Required=false)]
                public long? SupplementId { get; set; }

                [NameInMap("SupplementStatus")]
                [Validation(Required=false)]
                public int? SupplementStatus { get; set; }

                [NameInMap("TrademarkNumber")]
                [Validation(Required=false)]
                public string TrademarkNumber { get; set; }

                [NameInMap("UserFiles")]
                [Validation(Required=false)]
                public DescribeTrademarkApplicationResponseBodySupplementsSupplementUserFiles UserFiles { get; set; }
                public class DescribeTrademarkApplicationResponseBodySupplementsSupplementUserFiles : TeaModel {
                    [NameInMap("UserFile")]
                    [Validation(Required=false)]
                    public List<string> UserFile { get; set; }

                }

            }

        }

        [NameInMap("ThirdClassifications")]
        [Validation(Required=false)]
        public DescribeTrademarkApplicationResponseBodyThirdClassifications ThirdClassifications { get; set; }
        public class DescribeTrademarkApplicationResponseBodyThirdClassifications : TeaModel {
            [NameInMap("ThirdClassification")]
            [Validation(Required=false)]
            public List<DescribeTrademarkApplicationResponseBodyThirdClassificationsThirdClassification> ThirdClassification { get; set; }
            public class DescribeTrademarkApplicationResponseBodyThirdClassificationsThirdClassification : TeaModel {
                [NameInMap("ClassificationCode")]
                [Validation(Required=false)]
                public string ClassificationCode { get; set; }

                [NameInMap("ClassificationName")]
                [Validation(Required=false)]
                public string ClassificationName { get; set; }

            }

        }

        [NameInMap("TotalPrice")]
        [Validation(Required=false)]
        public float? TotalPrice { get; set; }

        [NameInMap("TrademarkIcon")]
        [Validation(Required=false)]
        public string TrademarkIcon { get; set; }

        [NameInMap("TrademarkName")]
        [Validation(Required=false)]
        public string TrademarkName { get; set; }

        [NameInMap("TrademarkNameType")]
        [Validation(Required=false)]
        public int? TrademarkNameType { get; set; }

        [NameInMap("TrademarkNumber")]
        [Validation(Required=false)]
        public string TrademarkNumber { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
