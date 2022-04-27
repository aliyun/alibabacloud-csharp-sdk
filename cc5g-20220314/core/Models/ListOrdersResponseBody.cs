// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListOrdersResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 数组，返回示例目录。
        /// </summary>
        [NameInMap("Orders")]
        [Validation(Required=false)]
        public List<ListOrdersResponseBodyOrders> Orders { get; set; }
        public class ListOrdersResponseBodyOrders : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("CardCount")]
            [Validation(Required=false)]
            public string CardCount { get; set; }

            [NameInMap("CardNetType")]
            [Validation(Required=false)]
            public string CardNetType { get; set; }

            [NameInMap("CardType")]
            [Validation(Required=false)]
            public string CardType { get; set; }

            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("ContactPhone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("LogisticsId")]
            [Validation(Required=false)]
            public string LogisticsId { get; set; }

            [NameInMap("LogisticsStatus")]
            [Validation(Required=false)]
            public string LogisticsStatus { get; set; }

            [NameInMap("LogisticsType")]
            [Validation(Required=false)]
            public string LogisticsType { get; set; }

            [NameInMap("LogisticsUpdateTime")]
            [Validation(Required=false)]
            public string LogisticsUpdateTime { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("PayTime")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            [NameInMap("PostAddress")]
            [Validation(Required=false)]
            public string PostAddress { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// 资源名称
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
