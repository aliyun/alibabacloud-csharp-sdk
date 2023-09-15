// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MLServiceParam : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("model")]
        [Validation(Required=false)]
        public MLServiceParamModel Model { get; set; }
        public class MLServiceParamModel : TeaModel {
            [NameInMap("modelResourceId")]
            [Validation(Required=false)]
            public string ModelResourceId { get; set; }

            [NameInMap("modelResourceType")]
            [Validation(Required=false)]
            public string ModelResourceType { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public MLServiceParamResource Resource { get; set; }
        public class MLServiceParamResource : TeaModel {
            [NameInMap("cpuLimit")]
            [Validation(Required=false)]
            public int? CpuLimit { get; set; }

            [NameInMap("gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            [NameInMap("memoryLimit")]
            [Validation(Required=false)]
            public int? MemoryLimit { get; set; }

            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

        }

        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
