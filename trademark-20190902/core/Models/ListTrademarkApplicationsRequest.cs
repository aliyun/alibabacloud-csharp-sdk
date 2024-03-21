// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class ListTrademarkApplicationsRequest : TeaModel {
        [NameInMap("ApplicantName")]
        [Validation(Required=false)]
        public string ApplicantName { get; set; }

        [NameInMap("ApplicationStatus")]
        [Validation(Required=false)]
        public int? ApplicationStatus { get; set; }

        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("CreateTimeLeft")]
        [Validation(Required=false)]
        public long? CreateTimeLeft { get; set; }

        [NameInMap("CreateTimeRight")]
        [Validation(Required=false)]
        public long? CreateTimeRight { get; set; }

        [NameInMap("Flag")]
        [Validation(Required=false)]
        public int? Flag { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public int? ProductType { get; set; }

        [NameInMap("QueryVoucherOrderDoneFlag")]
        [Validation(Required=false)]
        public bool? QueryVoucherOrderDoneFlag { get; set; }

        [NameInMap("QueryVoucherOrderFlag")]
        [Validation(Required=false)]
        public bool? QueryVoucherOrderFlag { get; set; }

        [NameInMap("SortFiled")]
        [Validation(Required=false)]
        public string SortFiled { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        [NameInMap("SupplementStatus")]
        [Validation(Required=false)]
        public int? SupplementStatus { get; set; }

        [NameInMap("TrademarkName")]
        [Validation(Required=false)]
        public string TrademarkName { get; set; }

        [NameInMap("TrademarkNumber")]
        [Validation(Required=false)]
        public string TrademarkNumber { get; set; }

    }

}
