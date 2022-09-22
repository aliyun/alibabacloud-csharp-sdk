// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceSpecResponseBody : TeaModel {
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public int? BandwidthLimit { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("DataDiskMaxSize")]
        [Validation(Required=false)]
        public int? DataDiskMaxSize { get; set; }

        [NameInMap("DataDiskMinSize")]
        [Validation(Required=false)]
        public int? DataDiskMinSize { get; set; }

        [NameInMap("InstanceSpecs")]
        [Validation(Required=false)]
        public DescribeInstanceSpecResponseBodyInstanceSpecs InstanceSpecs { get; set; }
        public class DescribeInstanceSpecResponseBodyInstanceSpecs : TeaModel {
            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public List<DescribeInstanceSpecResponseBodyInstanceSpecsInstanceSpec> InstanceSpec { get; set; }
            public class DescribeInstanceSpecResponseBodyInstanceSpecsInstanceSpec : TeaModel {
                [NameInMap("Core")]
                [Validation(Required=false)]
                public string Core { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SystemDiskMaxSize")]
        [Validation(Required=false)]
        public int? SystemDiskMaxSize { get; set; }

    }

}
