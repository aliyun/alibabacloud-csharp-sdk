// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetCustomerListRequest : TeaModel {
        [NameInMap("AliyunPk")]
        [Validation(Required=false)]
        public long? AliyunPk { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("CustomerAccount")]
        [Validation(Required=false)]
        public string CustomerAccount { get; set; }

        [NameInMap("CustomerGcLevel")]
        [Validation(Required=false)]
        public string CustomerGcLevel { get; set; }

        [NameInMap("CustomerName")]
        [Validation(Required=false)]
        public string CustomerName { get; set; }

        [NameInMap("CustomerStatus")]
        [Validation(Required=false)]
        public int? CustomerStatus { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public string End { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RamUid")]
        [Validation(Required=false)]
        public long? RamUid { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public string Start { get; set; }

    }

}
