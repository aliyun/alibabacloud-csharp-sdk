// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryLogisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLogisticsResponseBodyData Data { get; set; }
        public class QueryLogisticsResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryLogisticsResponseBodyDataData> Data { get; set; }
            public class QueryLogisticsResponseBodyDataData : TeaModel {
                [NameInMap("DataProvider")]
                [Validation(Required=false)]
                public string DataProvider { get; set; }

                [NameInMap("DataProviderTitle")]
                [Validation(Required=false)]
                public string DataProviderTitle { get; set; }

                [NameInMap("Goods")]
                [Validation(Required=false)]
                public QueryLogisticsResponseBodyDataDataGoods Goods { get; set; }
                public class QueryLogisticsResponseBodyDataDataGoods : TeaModel {
                    [NameInMap("Goods")]
                    [Validation(Required=false)]
                    public List<QueryLogisticsResponseBodyDataDataGoodsGoods> Goods { get; set; }
                    public class QueryLogisticsResponseBodyDataDataGoodsGoods : TeaModel {
                        [NameInMap("GoodName")]
                        [Validation(Required=false)]
                        public string GoodName { get; set; }

                        [NameInMap("ItemId")]
                        [Validation(Required=false)]
                        public long? ItemId { get; set; }

                        [NameInMap("Quantity")]
                        [Validation(Required=false)]
                        public int? Quantity { get; set; }

                    }

                }

                [NameInMap("LogisticsCompanyCode")]
                [Validation(Required=false)]
                public string LogisticsCompanyCode { get; set; }

                [NameInMap("LogisticsCompanyName")]
                [Validation(Required=false)]
                public string LogisticsCompanyName { get; set; }

                [NameInMap("LogisticsDetailList")]
                [Validation(Required=false)]
                public QueryLogisticsResponseBodyDataDataLogisticsDetailList LogisticsDetailList { get; set; }
                public class QueryLogisticsResponseBodyDataDataLogisticsDetailList : TeaModel {
                    [NameInMap("LogisticsDetailList")]
                    [Validation(Required=false)]
                    public List<QueryLogisticsResponseBodyDataDataLogisticsDetailListLogisticsDetailList> LogisticsDetailList { get; set; }
                    public class QueryLogisticsResponseBodyDataDataLogisticsDetailListLogisticsDetailList : TeaModel {
                        [NameInMap("OcurrTimeStr")]
                        [Validation(Required=false)]
                        public string OcurrTimeStr { get; set; }

                        [NameInMap("StanderdDesc")]
                        [Validation(Required=false)]
                        public string StanderdDesc { get; set; }

                    }

                }

                [NameInMap("MailNo")]
                [Validation(Required=false)]
                public string MailNo { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
