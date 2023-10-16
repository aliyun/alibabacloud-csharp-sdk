// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTradeProduceListRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BuyerStatus")]
        [Validation(Required=false)]
        public int? BuyerStatus { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PreOrderId")]
        [Validation(Required=false)]
        public string PreOrderId { get; set; }

        [NameInMap("RegisterNumber")]
        [Validation(Required=false)]
        public string RegisterNumber { get; set; }

        [NameInMap("SortFiled")]
        [Validation(Required=false)]
        public string SortFiled { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
