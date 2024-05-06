// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class DescribeServerlessInstanceResponseBody : TeaModel {
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CuSize")]
        [Validation(Required=false)]
        public string CuSize { get; set; }

        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public string DiskSize { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("HaType")]
        [Validation(Required=false)]
        public string HaType { get; set; }

        [NameInMap("HasUser")]
        [Validation(Required=false)]
        public string HasUser { get; set; }

        [NameInMap("InnerEndpoint")]
        [Validation(Required=false)]
        public string InnerEndpoint { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("IsDeletionProtection")]
        [Validation(Required=false)]
        public string IsDeletionProtection { get; set; }

        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        [NameInMap("MainVersion")]
        [Validation(Required=false)]
        public string MainVersion { get; set; }

        [NameInMap("OuterEndpoint")]
        [Validation(Required=false)]
        public string OuterEndpoint { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReserverMaxQpsNum")]
        [Validation(Required=false)]
        public string ReserverMaxQpsNum { get; set; }

        [NameInMap("ReserverMinQpsNum")]
        [Validation(Required=false)]
        public string ReserverMinQpsNum { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UpdateStatus")]
        [Validation(Required=false)]
        public string UpdateStatus { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
