// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryProduceListRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("CreateTimeLeft")]
        [Validation(Required=false)]
        public long? CreateTimeLeft { get; set; }

        [NameInMap("CreateTimeRight")]
        [Validation(Required=false)]
        public long? CreateTimeRight { get; set; }

        [NameInMap("MaterialName")]
        [Validation(Required=false)]
        public string MaterialName { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("TmName")]
        [Validation(Required=false)]
        public string TmName { get; set; }

        [NameInMap("TmNumber")]
        [Validation(Required=false)]
        public string TmNumber { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
