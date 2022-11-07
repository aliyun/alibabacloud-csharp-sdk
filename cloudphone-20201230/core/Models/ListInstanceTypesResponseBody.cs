// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListInstanceTypesResponseBody : TeaModel {
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public ListInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class ListInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<ListInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class ListInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                [NameInMap("DefaultResolution")]
                [Validation(Required=false)]
                public string DefaultResolution { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public string MemorySize { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NameEn")]
                [Validation(Required=false)]
                public string NameEn { get; set; }

                [NameInMap("Resolutions")]
                [Validation(Required=false)]
                public ListInstanceTypesResponseBodyInstanceTypesInstanceTypeResolutions Resolutions { get; set; }
                public class ListInstanceTypesResponseBodyInstanceTypesInstanceTypeResolutions : TeaModel {
                    [NameInMap("Resolution")]
                    [Validation(Required=false)]
                    public List<string> Resolution { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
