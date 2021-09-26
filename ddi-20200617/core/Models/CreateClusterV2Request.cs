// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class CreateClusterV2Request : TeaModel {
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("LogPath")]
        [Validation(Required=false)]
        public string LogPath { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("IsOpenPublicIp")]
        [Validation(Required=false)]
        public bool? IsOpenPublicIp { get; set; }

        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("Auto")]
        [Validation(Required=false)]
        public bool? Auto { get; set; }

        [NameInMap("AutoPayOrder")]
        [Validation(Required=false)]
        public bool? AutoPayOrder { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("UserDefinedEmrEcsRole")]
        [Validation(Required=false)]
        public string UserDefinedEmrEcsRole { get; set; }

        [NameInMap("EmrVer")]
        [Validation(Required=false)]
        public string EmrVer { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("EnableHighAvailability")]
        [Validation(Required=false)]
        public bool? EnableHighAvailability { get; set; }

        [NameInMap("UseLocalMetaDb")]
        [Validation(Required=false)]
        public bool? UseLocalMetaDb { get; set; }

        [NameInMap("EnableSsh")]
        [Validation(Required=false)]
        public bool? EnableSsh { get; set; }

        [NameInMap("InstanceGeneration")]
        [Validation(Required=false)]
        public string InstanceGeneration { get; set; }

        [NameInMap("MasterPwd")]
        [Validation(Required=false)]
        public string MasterPwd { get; set; }

        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("MetaStoreType")]
        [Validation(Required=false)]
        public string MetaStoreType { get; set; }

        [NameInMap("MetaStoreConf")]
        [Validation(Required=false)]
        public string MetaStoreConf { get; set; }

        [NameInMap("ClickHouseConf")]
        [Validation(Required=false)]
        public string ClickHouseConf { get; set; }

        [NameInMap("ExtraAttributes")]
        [Validation(Required=false)]
        public string ExtraAttributes { get; set; }

        [NameInMap("DepositType")]
        [Validation(Required=false)]
        public string DepositType { get; set; }

        [NameInMap("MachineType")]
        [Validation(Required=false)]
        public string MachineType { get; set; }

        [NameInMap("UseCustomHiveMetaDB")]
        [Validation(Required=false)]
        public bool? UseCustomHiveMetaDB { get; set; }

        [NameInMap("InitCustomHiveMetaDB")]
        [Validation(Required=false)]
        public bool? InitCustomHiveMetaDB { get; set; }

        [NameInMap("Configurations")]
        [Validation(Required=false)]
        public string Configurations { get; set; }

        [NameInMap("EnableEas")]
        [Validation(Required=false)]
        public bool? EnableEas { get; set; }

        [NameInMap("RelatedClusterId")]
        [Validation(Required=false)]
        public string RelatedClusterId { get; set; }

        [NameInMap("WhiteListType")]
        [Validation(Required=false)]
        public string WhiteListType { get; set; }

        [NameInMap("AuthorizeContent")]
        [Validation(Required=false)]
        public string AuthorizeContent { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public List<CreateClusterV2RequestUserInfo> UserInfo { get; set; }
        public class CreateClusterV2RequestUserInfo : TeaModel {
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("HostComponentInfo")]
        [Validation(Required=false)]
        public List<CreateClusterV2RequestHostComponentInfo> HostComponentInfo { get; set; }
        public class CreateClusterV2RequestHostComponentInfo : TeaModel {
            [NameInMap("ComponentNameList")]
            [Validation(Required=false)]
            public List<string> ComponentNameList { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        [NameInMap("ServiceInfo")]
        [Validation(Required=false)]
        public List<CreateClusterV2RequestServiceInfo> ServiceInfo { get; set; }
        public class CreateClusterV2RequestServiceInfo : TeaModel {
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ServiceVersion")]
            [Validation(Required=false)]
            public string ServiceVersion { get; set; }

        }

        [NameInMap("PromotionInfo")]
        [Validation(Required=false)]
        public List<CreateClusterV2RequestPromotionInfo> PromotionInfo { get; set; }
        public class CreateClusterV2RequestPromotionInfo : TeaModel {
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("PromotionOptionCode")]
            [Validation(Required=false)]
            public string PromotionOptionCode { get; set; }

            [NameInMap("PromotionOptionNo")]
            [Validation(Required=false)]
            public string PromotionOptionNo { get; set; }

        }

        [NameInMap("HostGroup")]
        [Validation(Required=false)]
        public List<CreateClusterV2RequestHostGroup> HostGroup { get; set; }
        public class CreateClusterV2RequestHostGroup : TeaModel {
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("CreateType")]
            [Validation(Required=false)]
            public string CreateType { get; set; }

            [NameInMap("DiskCapacity")]
            [Validation(Required=false)]
            public int? DiskCapacity { get; set; }

            [NameInMap("DiskCount")]
            [Validation(Required=false)]
            public int? DiskCount { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("GpuDriver")]
            [Validation(Required=false)]
            public string GpuDriver { get; set; }

            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            [NameInMap("HostGroupName")]
            [Validation(Required=false)]
            public string HostGroupName { get; set; }

            [NameInMap("HostGroupType")]
            [Validation(Required=false)]
            public string HostGroupType { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public int? NodeCount { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("SysDiskCapacity")]
            [Validation(Required=false)]
            public int? SysDiskCapacity { get; set; }

            [NameInMap("SysDiskType")]
            [Validation(Required=false)]
            public string SysDiskType { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        [NameInMap("BootstrapAction")]
        [Validation(Required=false)]
        public List<CreateClusterV2RequestBootstrapAction> BootstrapAction { get; set; }
        public class CreateClusterV2RequestBootstrapAction : TeaModel {
            [NameInMap("Arg")]
            [Validation(Required=false)]
            public string Arg { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public List<CreateClusterV2RequestConfig> Config { get; set; }
        public class CreateClusterV2RequestConfig : TeaModel {
            [NameInMap("ConfigKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            [NameInMap("Encrypt")]
            [Validation(Required=false)]
            public string Encrypt { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("Replace")]
            [Validation(Required=false)]
            public string Replace { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterV2RequestTag> Tag { get; set; }
        public class CreateClusterV2RequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
