// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeUserClusterHostResponseBody : TeaModel {
        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public string MaxRecordsPerPage { get; set; }

        [NameInMap("HostItems")]
        [Validation(Required=false)]
        public List<DescribeUserClusterHostResponseBodyHostItems> HostItems { get; set; }
        public class DescribeUserClusterHostResponseBodyHostItems : TeaModel {
            [NameInMap("HostIP")]
            [Validation(Required=false)]
            public string HostIP { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("HostStatus")]
            [Validation(Required=false)]
            public string HostStatus { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("HostStorage")]
            [Validation(Required=false)]
            public string HostStorage { get; set; }

            [NameInMap("InstanceNumber")]
            [Validation(Required=false)]
            public string InstanceNumber { get; set; }

            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            [NameInMap("HostClass")]
            [Validation(Required=false)]
            public string HostClass { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("AllocationStatus")]
            [Validation(Required=false)]
            public string AllocationStatus { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("HostCpu")]
            [Validation(Required=false)]
            public string HostCpu { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("HostMem")]
            [Validation(Required=false)]
            public string HostMem { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

        [NameInMap("ItemNumbers")]
        [Validation(Required=false)]
        public int? ItemNumbers { get; set; }

    }

}
