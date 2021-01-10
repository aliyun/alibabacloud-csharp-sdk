// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMqSofamqConsumerAccumulateRequest : TeaModel {
        [NameInMap("Cell")]
        [Validation(Required=false)]
        public string Cell { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=false)]
        public bool? Detail { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
