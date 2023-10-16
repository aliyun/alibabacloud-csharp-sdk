// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTmSbjProduceRequest : TeaModel {
        [NameInMap("HighPriorityBizTypeStr")]
        [Validation(Required=false)]
        public string HighPriorityBizTypeStr { get; set; }

        [NameInMap("HighPriorityMaterialNameStr")]
        [Validation(Required=false)]
        public string HighPriorityMaterialNameStr { get; set; }

        [NameInMap("HighPriorityOrderIdStr")]
        [Validation(Required=false)]
        public string HighPriorityOrderIdStr { get; set; }

        [NameInMap("HighPriorityUserIdStr")]
        [Validation(Required=false)]
        public string HighPriorityUserIdStr { get; set; }

        [NameInMap("PrincipalKey")]
        [Validation(Required=false)]
        public string PrincipalKey { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

        [NameInMap("ProducerType")]
        [Validation(Required=false)]
        public string ProducerType { get; set; }

        [NameInMap("QueryOrderPageSize")]
        [Validation(Required=false)]
        public long? QueryOrderPageSize { get; set; }

    }

}
