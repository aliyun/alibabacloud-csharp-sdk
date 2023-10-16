// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTradeMarkApplicationsRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ClassificationCode")]
        [Validation(Required=false)]
        public string ClassificationCode { get; set; }

        [NameInMap("Hidden")]
        [Validation(Required=false)]
        public int? Hidden { get; set; }

        [NameInMap("IntentionBizId")]
        [Validation(Required=false)]
        public string IntentionBizId { get; set; }

        [NameInMap("LogisticsNo")]
        [Validation(Required=false)]
        public string LogisticsNo { get; set; }

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

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public int? ProductType { get; set; }

        [NameInMap("SortFiled")]
        [Validation(Required=false)]
        public string SortFiled { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        [NameInMap("Specification")]
        [Validation(Required=false)]
        public int? Specification { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("SupplementStatus")]
        [Validation(Required=false)]
        public int? SupplementStatus { get; set; }

        [NameInMap("TmName")]
        [Validation(Required=false)]
        public string TmName { get; set; }

        [NameInMap("TmNumber")]
        [Validation(Required=false)]
        public string TmNumber { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
