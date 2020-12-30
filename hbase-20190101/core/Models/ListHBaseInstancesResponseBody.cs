// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ListHBaseInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public ListHBaseInstancesResponseBodyInstances Instances { get; set; }
        public class ListHBaseInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<ListHBaseInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class ListHBaseInstancesResponseBodyInstancesInstance : TeaModel {
                public bool? IsDefault { get; set; }
                public string InstanceName { get; set; }
                public string InstanceId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
