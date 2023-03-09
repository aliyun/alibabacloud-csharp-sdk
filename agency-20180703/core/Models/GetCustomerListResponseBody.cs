// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetCustomerListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomerListResponseBodyData Data { get; set; }
        public class GetCustomerListResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetCustomerListResponseBodyDataList List { get; set; }
            public class GetCustomerListResponseBodyDataList : TeaModel {
                [NameInMap("FxCustomerReportDTO")]
                [Validation(Required=false)]
                public List<GetCustomerListResponseBodyDataListFxCustomerReportDTO> FxCustomerReportDTO { get; set; }
                public class GetCustomerListResponseBodyDataListFxCustomerReportDTO : TeaModel {
                    [NameInMap("Cid")]
                    [Validation(Required=false)]
                    public long? Cid { get; set; }

                    [NameInMap("CustomerGcLevel")]
                    [Validation(Required=false)]
                    public string CustomerGcLevel { get; set; }

                    [NameInMap("CustomerName")]
                    [Validation(Required=false)]
                    public string CustomerName { get; set; }

                    [NameInMap("CustomerStatus")]
                    [Validation(Required=false)]
                    public int? CustomerStatus { get; set; }

                    [NameInMap("CustomerType")]
                    [Validation(Required=false)]
                    public int? CustomerType { get; set; }

                    [NameInMap("CustomerUids")]
                    [Validation(Required=false)]
                    public GetCustomerListResponseBodyDataListFxCustomerReportDTOCustomerUids CustomerUids { get; set; }
                    public class GetCustomerListResponseBodyDataListFxCustomerReportDTOCustomerUids : TeaModel {
                        [NameInMap("CustomerUid")]
                        [Validation(Required=false)]
                        public List<string> CustomerUid { get; set; }

                    }

                    [NameInMap("ExpireTime")]
                    [Validation(Required=false)]
                    public string ExpireTime { get; set; }

                    [NameInMap("GcLevelAmountInfo")]
                    [Validation(Required=false)]
                    public GetCustomerListResponseBodyDataListFxCustomerReportDTOGcLevelAmountInfo GcLevelAmountInfo { get; set; }
                    public class GetCustomerListResponseBodyDataListFxCustomerReportDTOGcLevelAmountInfo : TeaModel {
                        [NameInMap("OneMonthAmount")]
                        [Validation(Required=false)]
                        public string OneMonthAmount { get; set; }

                        [NameInMap("ShowOne")]
                        [Validation(Required=false)]
                        public bool? ShowOne { get; set; }

                        [NameInMap("ShowSix")]
                        [Validation(Required=false)]
                        public bool? ShowSix { get; set; }

                        [NameInMap("ShowThree")]
                        [Validation(Required=false)]
                        public bool? ShowThree { get; set; }

                        [NameInMap("SixMonthAmount")]
                        [Validation(Required=false)]
                        public string SixMonthAmount { get; set; }

                        [NameInMap("ThreeMonthAmount")]
                        [Validation(Required=false)]
                        public string ThreeMonthAmount { get; set; }

                        [NameInMap("TwelveMonthAmount")]
                        [Validation(Required=false)]
                        public string TwelveMonthAmount { get; set; }

                    }

                    [NameInMap("HasAccount")]
                    [Validation(Required=false)]
                    public int? HasAccount { get; set; }

                    [NameInMap("ReportedTime")]
                    [Validation(Required=false)]
                    public string ReportedTime { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetCustomerListResponseBodyPageInfo PageInfo { get; set; }
        public class GetCustomerListResponseBodyPageInfo : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
