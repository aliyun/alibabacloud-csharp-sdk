// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListInstanceTypesResponseBody : TeaModel {
        /// <summary>
        /// The instance types.
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public ListInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class ListInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<ListInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class ListInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                /// <summary>
                /// The number of vCPUs supported by the instance type.
                /// </summary>
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                /// <summary>
                /// The default resolution supported by the instance type.
                /// </summary>
                [NameInMap("DefaultResolution")]
                [Validation(Required=false)]
                public string DefaultResolution { get; set; }

                /// <summary>
                /// The instance type.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The instance type family.
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// The memory size supported by the instance type. Unit: GiB.
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public string MemorySize { get; set; }

                /// <summary>
                /// The name of the instance type in Chinese.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The name of the instance type in English.
                /// </summary>
                [NameInMap("NameEn")]
                [Validation(Required=false)]
                public string NameEn { get; set; }

                /// <summary>
                /// The resolutions supported by the instance type.
                /// </summary>
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

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
