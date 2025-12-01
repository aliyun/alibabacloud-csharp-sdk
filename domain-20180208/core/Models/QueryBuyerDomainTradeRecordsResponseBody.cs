// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryBuyerDomainTradeRecordsResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryBuyerDomainTradeRecordsResponseBodyModule Module { get; set; }
        public class QueryBuyerDomainTradeRecordsResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryBuyerDomainTradeRecordsResponseBodyModuleData> Data { get; set; }
            public class QueryBuyerDomainTradeRecordsResponseBodyModuleData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>T2023122019031400****</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RMB</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-07-07 23:59:59</para>
                /// </summary>
                [NameInMap("DeliveryTime")]
                [Validation(Required=false)]
                public string DeliveryTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>kythelmet.cn</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-07-07 23:59:59</para>
                /// </summary>
                [NameInMap("PayTime")]
                [Validation(Required=false)]
                public string PayTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5b05d1f7-26f0-4ad7-97d9-ac96fd9b65ba</para>
                /// </summary>
                [NameInMap("TradeId")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>27660.0</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FIX_PRICE</para>
                /// </summary>
                [NameInMap("TradeType")]
                [Validation(Required=false)]
                public string TradeType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>294</para>
            /// </summary>
            [NameInMap("TotalItemNum")]
            [Validation(Required=false)]
            public int? TotalItemNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalPageNum")]
            [Validation(Required=false)]
            public int? TotalPageNum { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F5BC888-521D-503A-A79B-CEDC9A23D716</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
