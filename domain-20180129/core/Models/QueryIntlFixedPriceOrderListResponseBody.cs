// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryIntlFixedPriceOrderListResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryIntlFixedPriceOrderListResponseBodyModule Module { get; set; }
        public class QueryIntlFixedPriceOrderListResponseBodyModule : TeaModel {
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryIntlFixedPriceOrderListResponseBodyModuleData> Data { get; set; }
            public class QueryIntlFixedPriceOrderListResponseBodyModuleData : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public int? OrderType { get; set; }

                [NameInMap("Price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalItemNum")]
            [Validation(Required=false)]
            public int? TotalItemNum { get; set; }

            [NameInMap("TotalPageNum")]
            [Validation(Required=false)]
            public int? TotalPageNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D6CB3623-4726-4947-AC2B-2C6E673B447C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
