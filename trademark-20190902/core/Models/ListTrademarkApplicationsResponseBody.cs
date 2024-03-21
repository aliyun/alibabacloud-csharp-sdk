// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class ListTrademarkApplicationsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TrademarkApplications")]
        [Validation(Required=false)]
        public ListTrademarkApplicationsResponseBodyTrademarkApplications TrademarkApplications { get; set; }
        public class ListTrademarkApplicationsResponseBodyTrademarkApplications : TeaModel {
            [NameInMap("TrademarkApplication")]
            [Validation(Required=false)]
            public List<ListTrademarkApplicationsResponseBodyTrademarkApplicationsTrademarkApplication> TrademarkApplication { get; set; }
            public class ListTrademarkApplicationsResponseBodyTrademarkApplicationsTrademarkApplication : TeaModel {
                [NameInMap("AgreementId")]
                [Validation(Required=false)]
                public string AgreementId { get; set; }

                [NameInMap("ApplicantId")]
                [Validation(Required=false)]
                public long? ApplicantId { get; set; }

                [NameInMap("ApplicantName")]
                [Validation(Required=false)]
                public string ApplicantName { get; set; }

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

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("FirstClassification")]
                [Validation(Required=false)]
                public ListTrademarkApplicationsResponseBodyTrademarkApplicationsTrademarkApplicationFirstClassification FirstClassification { get; set; }
                public class ListTrademarkApplicationsResponseBodyTrademarkApplicationsTrademarkApplicationFirstClassification : TeaModel {
                    [NameInMap("ClassificationCode")]
                    [Validation(Required=false)]
                    public string ClassificationCode { get; set; }

                    [NameInMap("ClassificationName")]
                    [Validation(Required=false)]
                    public string ClassificationName { get; set; }

                }

                [NameInMap("Flags")]
                [Validation(Required=false)]
                public ListTrademarkApplicationsResponseBodyTrademarkApplicationsTrademarkApplicationFlags Flags { get; set; }
                public class ListTrademarkApplicationsResponseBodyTrademarkApplicationsTrademarkApplicationFlags : TeaModel {
                    [NameInMap("Flags")]
                    [Validation(Required=false)]
                    public List<string> Flags { get; set; }

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

                [NameInMap("ServicePrice")]
                [Validation(Required=false)]
                public float? ServicePrice { get; set; }

                [NameInMap("SupplementId")]
                [Validation(Required=false)]
                public long? SupplementId { get; set; }

                [NameInMap("SupplementStatus")]
                [Validation(Required=false)]
                public int? SupplementStatus { get; set; }

                [NameInMap("SystemVersion")]
                [Validation(Required=false)]
                public string SystemVersion { get; set; }

                [NameInMap("ThirdClassification")]
                [Validation(Required=false)]
                public ListTrademarkApplicationsResponseBodyTrademarkApplicationsTrademarkApplicationThirdClassification ThirdClassification { get; set; }
                public class ListTrademarkApplicationsResponseBodyTrademarkApplicationsTrademarkApplicationThirdClassification : TeaModel {
                    [NameInMap("ThirdClassification")]
                    [Validation(Required=false)]
                    public List<ListTrademarkApplicationsResponseBodyTrademarkApplicationsTrademarkApplicationThirdClassificationThirdClassification> ThirdClassification { get; set; }
                    public class ListTrademarkApplicationsResponseBodyTrademarkApplicationsTrademarkApplicationThirdClassificationThirdClassification : TeaModel {
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

                [NameInMap("TrademarkNumber")]
                [Validation(Required=false)]
                public string TrademarkNumber { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
