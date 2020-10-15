// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceSpecResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataDiskMinSize")]
        [Validation(Required=true)]
        public int? DataDiskMinSize { get; set; }

        [NameInMap("DataDiskMaxSize")]
        [Validation(Required=true)]
        public int? DataDiskMaxSize { get; set; }

        [NameInMap("SystemDiskMaxSize")]
        [Validation(Required=true)]
        public int? SystemDiskMaxSize { get; set; }

        [NameInMap("BandwidthLimit")]
        [Validation(Required=true)]
        public int? BandwidthLimit { get; set; }

        [NameInMap("InstanceSpecs")]
        [Validation(Required=true)]
        public DescribeInstanceSpecResponseInstanceSpecs InstanceSpecs { get; set; }
        public class DescribeInstanceSpecResponseInstanceSpecs : TeaModel {
            [NameInMap("InstanceSpec")]
            [Validation(Required=true)]
            public List<DescribeInstanceSpecResponseInstanceSpecsInstanceSpec> InstanceSpec { get; set; }
            public class DescribeInstanceSpecResponseInstanceSpecsInstanceSpec : TeaModel {
                public string InstanceType { get; set; }
                public string Core { get; set; }
                public string Memory { get; set; }
                public string DisplayName { get; set; }
            }
        };

    }

}
