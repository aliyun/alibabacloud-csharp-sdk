// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetDetailByUuidResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AssetDetail")]
        [Validation(Required=false)]
        public DescribeAssetDetailByUuidResponseBodyAssetDetail AssetDetail { get; set; }
        public class DescribeAssetDetailByUuidResponseBodyAssetDetail : TeaModel {
            [NameInMap("CpuInfo")]
            [Validation(Required=false)]
            public string CpuInfo { get; set; }
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }
            [NameInMap("OsDetail")]
            [Validation(Required=false)]
            public string OsDetail { get; set; }
            [NameInMap("Kernel")]
            [Validation(Required=false)]
            public string Kernel { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("IpList")]
            [Validation(Required=false)]
            public List<string> IpList { get; set; }
            [NameInMap("GroupTrace")]
            [Validation(Required=false)]
            public string GroupTrace { get; set; }
            [NameInMap("DiskInfoList")]
            [Validation(Required=false)]
            public List<string> DiskInfoList { get; set; }
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }
            [NameInMap("MacList")]
            [Validation(Required=false)]
            public List<string> MacList { get; set; }
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }
            [NameInMap("SysInfo")]
            [Validation(Required=false)]
            public string SysInfo { get; set; }
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }
        };

    }

}
