// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySharePromotionActivityAuditResultRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("SharePromotionActivityId")]
        [Validation(Required=false)]
        public string SharePromotionActivityId { get; set; }

        [NameInMap("ShareTaskCode")]
        [Validation(Required=false)]
        public string ShareTaskCode { get; set; }

    }

}
