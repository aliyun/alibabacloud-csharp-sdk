// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class CreateMyBaseRequest : TeaModel {
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DedicatedHostGroupDescription")]
        [Validation(Required=false)]
        public string DedicatedHostGroupDescription { get; set; }

        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        [NameInMap("ECSClassList")]
        [Validation(Required=false)]
        public List<CreateMyBaseRequestECSClassList> ECSClassList { get; set; }
        public class CreateMyBaseRequestECSClassList : TeaModel {
            [NameInMap("dataDiskAutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string DataDiskAutoSnapshotPolicyId { get; set; }

            [NameInMap("dataDiskEncrypted")]
            [Validation(Required=false)]
            public bool? DataDiskEncrypted { get; set; }

            [NameInMap("dataDiskKMSKeyId")]
            [Validation(Required=false)]
            public string DataDiskKMSKeyId { get; set; }

            [NameInMap("dataDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string DataDiskPerformanceLevel { get; set; }

            [NameInMap("diskCapacity")]
            [Validation(Required=false)]
            public int? DiskCapacity { get; set; }

            [NameInMap("diskCount")]
            [Validation(Required=false)]
            public int? DiskCount { get; set; }

            [NameInMap("diskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("nodeCount")]
            [Validation(Required=false)]
            public int? NodeCount { get; set; }

            [NameInMap("sysDiskAutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string SysDiskAutoSnapshotPolicyId { get; set; }

            [NameInMap("sysDiskCapacity")]
            [Validation(Required=false)]
            public int? SysDiskCapacity { get; set; }

            [NameInMap("sysDiskEncrypted")]
            [Validation(Required=false)]
            public bool? SysDiskEncrypted { get; set; }

            [NameInMap("sysDiskKMSKeyId")]
            [Validation(Required=false)]
            public string SysDiskKMSKeyId { get; set; }

            [NameInMap("sysDiskType")]
            [Validation(Required=false)]
            public string SysDiskType { get; set; }

            [NameInMap("systemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

        }

        [NameInMap("EcsDeploymentSetId")]
        [Validation(Required=false)]
        public string EcsDeploymentSetId { get; set; }

        [NameInMap("EcsHostName")]
        [Validation(Required=false)]
        public string EcsHostName { get; set; }

        [NameInMap("EcsInstanceName")]
        [Validation(Required=false)]
        public string EcsInstanceName { get; set; }

        [NameInMap("EcsUniqueSuffix")]
        [Validation(Required=false)]
        public string EcsUniqueSuffix { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("OsPassword")]
        [Validation(Required=false)]
        public string OsPassword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public string PasswordInherit { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("PeriodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

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

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateMyBaseRequestTags> Tags { get; set; }
        public class CreateMyBaseRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("UserDataInBase64")]
        [Validation(Required=false)]
        public bool? UserDataInBase64 { get; set; }

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
