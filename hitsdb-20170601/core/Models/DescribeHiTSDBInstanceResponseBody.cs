// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20170601.Models
{
    public class DescribeHiTSDBInstanceResponseBody : TeaModel {
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        [NameInMap("CpuNumber")]
        [Validation(Required=false)]
        public string CpuNumber { get; set; }

        [NameInMap("MemSize")]
        [Validation(Required=false)]
        public string MemSize { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("GmtExpire")]
        [Validation(Required=false)]
        public string GmtExpire { get; set; }

        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("MaxTimelineLimit")]
        [Validation(Required=false)]
        public string MaxTimelineLimit { get; set; }

        [NameInMap("PublicConnectionString")]
        [Validation(Required=false)]
        public string PublicConnectionString { get; set; }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        [NameInMap("InstanceTps")]
        [Validation(Required=false)]
        public string InstanceTps { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("InstanceStorage")]
        [Validation(Required=false)]
        public string InstanceStorage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        [NameInMap("Series")]
        [Validation(Required=false)]
        public int? Series { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("SecurityIpList")]
        [Validation(Required=false)]
        public List<DescribeHiTSDBInstanceResponseBodySecurityIpList> SecurityIpList { get; set; }
        public class DescribeHiTSDBInstanceResponseBodySecurityIpList : TeaModel {
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

    }

}
