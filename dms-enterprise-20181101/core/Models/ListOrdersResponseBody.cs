// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListOrdersResponseBody : TeaModel {
        [NameInMap("Orders")]
        [Validation(Required=false)]
        public ListOrdersResponseBodyOrders Orders { get; set; }
        public class ListOrdersResponseBodyOrders : TeaModel {
            [NameInMap("Order")]
            [Validation(Required=false)]
            public List<ListOrdersResponseBodyOrdersOrder> Order { get; set; }
            public class ListOrdersResponseBodyOrdersOrder : TeaModel {
                public string Comment { get; set; }
                public string LastModifyTime { get; set; }
                public string StatusCode { get; set; }
                public string CreateTime { get; set; }
                public string Committer { get; set; }
                public long? CommitterId { get; set; }
                public string StatusDesc { get; set; }
                public string PluginType { get; set; }
                public long? OrderId { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
