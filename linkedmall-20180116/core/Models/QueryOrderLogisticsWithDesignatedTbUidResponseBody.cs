// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderLogisticsWithDesignatedTbUidResponseBody : TeaModel {
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
        public List<QueryOrderLogisticsWithDesignatedTbUidResponseBodyModel> Model { get; set; }
        public class QueryOrderLogisticsWithDesignatedTbUidResponseBodyModel : TeaModel {
            [NameInMap("DataProvider")]
            [Validation(Required=false)]
            public string DataProvider { get; set; }

            [NameInMap("DataProviderTitle")]
            [Validation(Required=false)]
            public string DataProviderTitle { get; set; }

            [NameInMap("Fetcher")]
            [Validation(Required=false)]
            public QueryOrderLogisticsWithDesignatedTbUidResponseBodyModelFetcher Fetcher { get; set; }
            public class QueryOrderLogisticsWithDesignatedTbUidResponseBodyModelFetcher : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("ZipCode")]
                [Validation(Required=false)]
                public string ZipCode { get; set; }

            }

            [NameInMap("LogisticsCompanyCode")]
            [Validation(Required=false)]
            public string LogisticsCompanyCode { get; set; }

            [NameInMap("LogisticsCompanyName")]
            [Validation(Required=false)]
            public string LogisticsCompanyName { get; set; }

            [NameInMap("LogisticsDetailList")]
            [Validation(Required=false)]
            public List<QueryOrderLogisticsWithDesignatedTbUidResponseBodyModelLogisticsDetailList> LogisticsDetailList { get; set; }
            public class QueryOrderLogisticsWithDesignatedTbUidResponseBodyModelLogisticsDetailList : TeaModel {
                [NameInMap("OcurrTimeStr")]
                [Validation(Required=false)]
                public string OcurrTimeStr { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("StanderdDesc")]
                [Validation(Required=false)]
                public string StanderdDesc { get; set; }

                [NameInMap("StatusIcon")]
                [Validation(Required=false)]
                public string StatusIcon { get; set; }

            }

            [NameInMap("MailNo")]
            [Validation(Required=false)]
            public string MailNo { get; set; }

            [NameInMap("PackageGoodItems")]
            [Validation(Required=false)]
            public List<QueryOrderLogisticsWithDesignatedTbUidResponseBodyModelPackageGoodItems> PackageGoodItems { get; set; }
            public class QueryOrderLogisticsWithDesignatedTbUidResponseBodyModelPackageGoodItems : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

            }

            [NameInMap("Receiver")]
            [Validation(Required=false)]
            public QueryOrderLogisticsWithDesignatedTbUidResponseBodyModelReceiver Receiver { get; set; }
            public class QueryOrderLogisticsWithDesignatedTbUidResponseBodyModelReceiver : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("ZipCode")]
                [Validation(Required=false)]
                public string ZipCode { get; set; }

            }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
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
