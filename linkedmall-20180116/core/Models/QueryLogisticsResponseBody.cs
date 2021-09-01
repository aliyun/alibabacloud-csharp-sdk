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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLogisticsResponseBodyData Data { get; set; }
        public class QueryLogisticsResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryLogisticsResponseBodyDataData> Data { get; set; }
            public class QueryLogisticsResponseBodyDataData : TeaModel {
                public string LogisticsCompanyCode { get; set; }
                public string MailNo { get; set; }
                public string LogisticsCompanyName { get; set; }
                public string DataProvider { get; set; }
                public string DataProviderTitle { get; set; }
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
                public QueryLogisticsResponseBodyDataDataGoods Goods { get; set; }
                public class QueryLogisticsResponseBodyDataDataGoods : TeaModel {
                    [NameInMap("Goods")]
                    [Validation(Required=false)]
                    public List<QueryLogisticsResponseBodyDataDataGoodsGoods> Goods { get; set; }
                    public class QueryLogisticsResponseBodyDataDataGoodsGoods : TeaModel {
                        [NameInMap("ItemId")]
                        [Validation(Required=false)]
                        public long? ItemId { get; set; }

                        [NameInMap("GoodName")]
                        [Validation(Required=false)]
                        public string GoodName { get; set; }

                        [NameInMap("Quantity")]
                        [Validation(Required=false)]
                        public int? Quantity { get; set; }

                    }

                }
            }
        };

    }

}
