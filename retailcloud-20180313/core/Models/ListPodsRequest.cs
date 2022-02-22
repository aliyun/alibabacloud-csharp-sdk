// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListPodsRequest : TeaModel {
        [NameInMap("DeployOrderId")]
        [Validation(Required=false)]
        public long? DeployOrderId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResultList")]
        [Validation(Required=false)]
        public List<int?> ResultList { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<int?> StatusList { get; set; }

    }

}
