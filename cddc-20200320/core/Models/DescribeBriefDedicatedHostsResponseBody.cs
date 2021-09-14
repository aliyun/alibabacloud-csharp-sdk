// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeBriefDedicatedHostsResponseBody : TeaModel {
        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        [NameInMap("DedicatedHosts")]
        [Validation(Required=false)]
        public List<DescribeBriefDedicatedHostsResponseBodyDedicatedHosts> DedicatedHosts { get; set; }
        public class DescribeBriefDedicatedHostsResponseBodyDedicatedHosts : TeaModel {
            [NameInMap("AllocationStatus")]
            [Validation(Required=false)]
            public string AllocationStatus { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("HostStatus")]
            [Validation(Required=false)]
            public string HostStatus { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("HostCPU")]
            [Validation(Required=false)]
            public int? HostCPU { get; set; }

            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("HostMem")]
            [Validation(Required=false)]
            public int? HostMem { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

        }

    }

}
