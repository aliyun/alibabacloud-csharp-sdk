// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class ListNotaryOrdersRequest : TeaModel {
        [NameInMap("AliyunOrderId")]
        [Validation(Required=false)]
        public string AliyunOrderId { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("EndOrderDate")]
        [Validation(Required=false)]
        public long? EndOrderDate { get; set; }

        [NameInMap("NotaryStatus")]
        [Validation(Required=false)]
        public int? NotaryStatus { get; set; }

        [NameInMap("NotaryType")]
        [Validation(Required=false)]
        public int? NotaryType { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SortByType")]
        [Validation(Required=false)]
        public string SortByType { get; set; }

        [NameInMap("SortKeyType")]
        [Validation(Required=false)]
        public int? SortKeyType { get; set; }

        [NameInMap("StartOrderDate")]
        [Validation(Required=false)]
        public long? StartOrderDate { get; set; }

    }

}
