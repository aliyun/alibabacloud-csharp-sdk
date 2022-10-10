// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBClusterRequest : TeaModel {
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CloneDataPoint")]
        [Validation(Required=false)]
        public string CloneDataPoint { get; set; }

        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        [NameInMap("CreationCategory")]
        [Validation(Required=false)]
        public string CreationCategory { get; set; }

        [NameInMap("CreationOption")]
        [Validation(Required=false)]
        public string CreationOption { get; set; }

        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        [NameInMap("DBMinorVersion")]
        [Validation(Required=false)]
        public string DBMinorVersion { get; set; }

        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("DefaultTimeZone")]
        [Validation(Required=false)]
        public string DefaultTimeZone { get; set; }

        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

        [NameInMap("LowerCaseTableNames")]
        [Validation(Required=false)]
        public string LowerCaseTableNames { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        [NameInMap("SourceResourceId")]
        [Validation(Required=false)]
        public string SourceResourceId { get; set; }

        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public bool? TDEStatus { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBClusterRequestTag> Tag { get; set; }
        public class CreateDBClusterRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
