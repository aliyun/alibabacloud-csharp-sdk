// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSTopologyInstanceRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobRequestId")]
        [Validation(Required=false)]
        public string JobRequestId { get; set; }

        [NameInMap("ParentActivityInstanceId")]
        [Validation(Required=false)]
        public long? ParentActivityInstanceId { get; set; }

        [NameInMap("Shardings")]
        [Validation(Required=false)]
        public string Shardings { get; set; }

    }

}
