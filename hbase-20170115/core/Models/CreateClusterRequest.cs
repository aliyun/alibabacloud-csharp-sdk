// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class CreateClusterRequest : TeaModel {
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CloudType")]
        [Validation(Required=false)]
        public string CloudType { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ColdStorageSize")]
        [Validation(Required=false)]
        public string ColdStorageSize { get; set; }

        [NameInMap("CoreDiskQuantity")]
        [Validation(Required=false)]
        public string CoreDiskQuantity { get; set; }

        [NameInMap("CoreDiskSize")]
        [Validation(Required=false)]
        public string CoreDiskSize { get; set; }

        [NameInMap("CoreDiskType")]
        [Validation(Required=false)]
        public string CoreDiskType { get; set; }

        [NameInMap("CoreInstanceQuantity")]
        [Validation(Required=false)]
        public string CoreInstanceQuantity { get; set; }

        [NameInMap("CoreInstanceType")]
        [Validation(Required=false)]
        public string CoreInstanceType { get; set; }

        [NameInMap("DbInstanceConnType")]
        [Validation(Required=false)]
        public string DbInstanceConnType { get; set; }

        [NameInMap("DbInstanceType")]
        [Validation(Required=false)]
        public string DbInstanceType { get; set; }

        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("DepMode")]
        [Validation(Required=false)]
        public string DepMode { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("IsColdStorage")]
        [Validation(Required=false)]
        public string IsColdStorage { get; set; }

        [NameInMap("MasterInstanceType")]
        [Validation(Required=false)]
        public string MasterInstanceType { get; set; }

        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

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
