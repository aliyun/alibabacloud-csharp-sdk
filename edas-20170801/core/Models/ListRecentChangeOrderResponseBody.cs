// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListRecentChangeOrderResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ChangeOrderList")]
        [Validation(Required=false)]
        public ListRecentChangeOrderResponseBodyChangeOrderList ChangeOrderList { get; set; }
        public class ListRecentChangeOrderResponseBodyChangeOrderList : TeaModel {
            [NameInMap("ChangeOrder")]
            [Validation(Required=false)]
            public List<ListRecentChangeOrderResponseBodyChangeOrderListChangeOrder> ChangeOrder { get; set; }
            public class ListRecentChangeOrderResponseBodyChangeOrderListChangeOrder : TeaModel {
                public int? Status { get; set; }
                public string FinishTime { get; set; }
                public string CreateTime { get; set; }
                public string UserId { get; set; }
                public string ChangeOrderDescription { get; set; }
                public string Source { get; set; }
                public string CreateUserId { get; set; }
                public int? BatchCount { get; set; }
                public string CoTypeCode { get; set; }
                public string ChangeOrderId { get; set; }
                public string BatchType { get; set; }
                public string GroupId { get; set; }
                public string CoType { get; set; }
                public string AppId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
