// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class QueryLogistics4DistributionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<QueryLogistics4DistributionResponseBodyModel> Model { get; set; }
        public class QueryLogistics4DistributionResponseBodyModel : TeaModel {
            [NameInMap("DataProvider")]
            [Validation(Required=false)]
            public string DataProvider { get; set; }

            [NameInMap("DataProviderTitle")]
            [Validation(Required=false)]
            public string DataProviderTitle { get; set; }

            [NameInMap("Goods")]
            [Validation(Required=false)]
            public List<QueryLogistics4DistributionResponseBodyModelGoods> Goods { get; set; }
            public class QueryLogistics4DistributionResponseBodyModelGoods : TeaModel {
                [NameInMap("GoodName")]
                [Validation(Required=false)]
                public string GoodName { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

            }

            [NameInMap("LogisticsCompanyCode")]
            [Validation(Required=false)]
            public string LogisticsCompanyCode { get; set; }

            [NameInMap("LogisticsCompanyName")]
            [Validation(Required=false)]
            public string LogisticsCompanyName { get; set; }

            [NameInMap("LogisticsDetailList")]
            [Validation(Required=false)]
            public List<QueryLogistics4DistributionResponseBodyModelLogisticsDetailList> LogisticsDetailList { get; set; }
            public class QueryLogistics4DistributionResponseBodyModelLogisticsDetailList : TeaModel {
                [NameInMap("OcurrTimeStr")]
                [Validation(Required=false)]
                public string OcurrTimeStr { get; set; }

                [NameInMap("StanderdDesc")]
                [Validation(Required=false)]
                public string StanderdDesc { get; set; }

            }

            [NameInMap("MailNo")]
            [Validation(Required=false)]
            public string MailNo { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
