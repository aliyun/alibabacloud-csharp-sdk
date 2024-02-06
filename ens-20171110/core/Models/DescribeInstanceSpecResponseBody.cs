// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceSpecResponseBody : TeaModel {
        /// <summary>
        /// The bandwidth limit for a single instance. Unit: Mbit/s.
        /// </summary>
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public int? BandwidthLimit { get; set; }

        /// <summary>
        /// The returned service code. A value of 0 indicates that the operation was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The maximum capacity of a data disk. Unit: GB.
        /// </summary>
        [NameInMap("DataDiskMaxSize")]
        [Validation(Required=false)]
        public int? DataDiskMaxSize { get; set; }

        /// <summary>
        /// The minimum capacity of a data disk. Unit: GB.
        /// </summary>
        [NameInMap("DataDiskMinSize")]
        [Validation(Required=false)]
        public int? DataDiskMinSize { get; set; }

        /// <summary>
        /// The information about instance specifications.
        /// </summary>
        [NameInMap("InstanceSpecs")]
        [Validation(Required=false)]
        public DescribeInstanceSpecResponseBodyInstanceSpecs InstanceSpecs { get; set; }
        public class DescribeInstanceSpecResponseBodyInstanceSpecs : TeaModel {
            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public List<DescribeInstanceSpecResponseBodyInstanceSpecsInstanceSpec> InstanceSpec { get; set; }
            public class DescribeInstanceSpecResponseBodyInstanceSpecsInstanceSpec : TeaModel {
                /// <summary>
                /// The number of CPU cores.
                /// </summary>
                [NameInMap("Core")]
                [Validation(Required=false)]
                public string Core { get; set; }

                /// <summary>
                /// The display name of the instance type.
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The type of the instance.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The memory size. Unit: MB.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The maximum capacity of the system disk. Unit: GiB.
        /// </summary>
        [NameInMap("SystemDiskMaxSize")]
        [Validation(Required=false)]
        public int? SystemDiskMaxSize { get; set; }

    }

}
