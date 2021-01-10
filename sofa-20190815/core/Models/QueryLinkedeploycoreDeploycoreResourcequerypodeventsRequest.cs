// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreResourcequerypodeventsRequest : TeaModel {
        [NameInMap("AppServiceId")]
        [Validation(Required=false)]
        public long? AppServiceId { get; set; }

        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("PodId")]
        [Validation(Required=false)]
        public string PodId { get; set; }

        [NameInMap("PodName")]
        [Validation(Required=false)]
        public string PodName { get; set; }

    }

}
