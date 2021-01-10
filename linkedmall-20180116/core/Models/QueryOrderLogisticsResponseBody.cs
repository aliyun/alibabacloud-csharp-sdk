// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderLogisticsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("OrderLogistics")]
        [Validation(Required=false)]
        public QueryOrderLogisticsResponseBodyOrderLogistics OrderLogistics { get; set; }
        public class QueryOrderLogisticsResponseBodyOrderLogistics : TeaModel {
            [NameInMap("Receiver")]
            [Validation(Required=false)]
            public QueryOrderLogisticsResponseBodyOrderLogisticsReceiver Receiver { get; set; }
            public class QueryOrderLogisticsResponseBodyOrderLogisticsReceiver : TeaModel {
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("ZipCode")]
                [Validation(Required=false)]
                public string ZipCode { get; set; }

                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }
            [NameInMap("DataProvider")]
            [Validation(Required=false)]
            public string DataProvider { get; set; }
            [NameInMap("DataProviderTitle")]
            [Validation(Required=false)]
            public string DataProviderTitle { get; set; }
            [NameInMap("LogisticsDetailList")]
            [Validation(Required=false)]
            public QueryOrderLogisticsResponseBodyOrderLogisticsLogisticsDetailList LogisticsDetailList { get; set; }
            public class QueryOrderLogisticsResponseBodyOrderLogisticsLogisticsDetailList : TeaModel {
                [NameInMap("LogisticsDetailList")]
                [Validation(Required=false)]
                public List<QueryOrderLogisticsResponseBodyOrderLogisticsLogisticsDetailListLogisticsDetailList> LogisticsDetailList { get; set; }
                public class QueryOrderLogisticsResponseBodyOrderLogisticsLogisticsDetailListLogisticsDetailList : TeaModel {
                    [NameInMap("StanderdDesc")]
                    [Validation(Required=false)]
                    public string StanderdDesc { get; set; }

                    [NameInMap("StatusIcon")]
                    [Validation(Required=false)]
                    public string StatusIcon { get; set; }

                    [NameInMap("OcurrTimeStr")]
                    [Validation(Required=false)]
                    public string OcurrTimeStr { get; set; }

                }

            }
            [NameInMap("LogisticsCompanyCode")]
            [Validation(Required=false)]
            public string LogisticsCompanyCode { get; set; }
            [NameInMap("LogisticsCompanyName")]
            [Validation(Required=false)]
            public string LogisticsCompanyName { get; set; }
            [NameInMap("Fetcher")]
            [Validation(Required=false)]
            public QueryOrderLogisticsResponseBodyOrderLogisticsFetcher Fetcher { get; set; }
            public class QueryOrderLogisticsResponseBodyOrderLogisticsFetcher : TeaModel {
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("ZipCode")]
                [Validation(Required=false)]
                public string ZipCode { get; set; }

                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }
        };

    }

}
