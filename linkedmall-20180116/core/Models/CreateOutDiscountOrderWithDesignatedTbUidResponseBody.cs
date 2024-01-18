// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CreateOutDiscountOrderWithDesignatedTbUidResponseBody : TeaModel {
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
        public CreateOutDiscountOrderWithDesignatedTbUidResponseBodyModel Model { get; set; }
        public class CreateOutDiscountOrderWithDesignatedTbUidResponseBodyModel : TeaModel {
            [NameInMap("AllIdsMap")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> AllIdsMap { get; set; }

            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("LmOrderIds")]
            [Validation(Required=false)]
            public List<string> LmOrderIds { get; set; }

            [NameInMap("OrderIds")]
            [Validation(Required=false)]
            public List<string> OrderIds { get; set; }

            [NameInMap("PayTradeIds")]
            [Validation(Required=false)]
            public List<string> PayTradeIds { get; set; }

            [NameInMap("RedirectUrl")]
            [Validation(Required=false)]
            public string RedirectUrl { get; set; }

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
