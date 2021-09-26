// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class CreateClusterTemplateRequest : TeaModel {
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

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

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("RenewAuto")]
        [Validation(Required=false)]
        public bool? RenewAuto { get; set; }

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

        [NameInMap("IoOptimizedOption")]
        [Validation(Required=false)]
        public bool? IoOptimizedOption { get; set; }

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

        [NameInMap("Configurations")]
        [Validation(Required=false)]
        public string Configurations { get; set; }

        [NameInMap("EnableEas")]
        [Validation(Required=false)]
        public bool? EnableEas { get; set; }

        [NameInMap("DepositType")]
        [Validation(Required=false)]
        public string DepositType { get; set; }

        [NameInMap("MachineType")]
        [Validation(Required=false)]
        public string MachineType { get; set; }

        [NameInMap("UseCustomHiveMetaDb")]
        [Validation(Required=false)]
        public bool? UseCustomHiveMetaDb { get; set; }

        [NameInMap("InitCustomHiveMetaDb")]
        [Validation(Required=false)]
        public bool? InitCustomHiveMetaDb { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OptionSoftWareList")]
        [Validation(Required=false)]
        public List<string> OptionSoftWareList { get; set; }

        [NameInMap("HostGroup")]
        [Validation(Required=false)]
        public List<CreateClusterTemplateRequestHostGroup> HostGroup { get; set; }
        public class CreateClusterTemplateRequestHostGroup : TeaModel {
            [NameInMap("SysDiskCapacity")]
            [Validation(Required=false)]
            public int? SysDiskCapacity { get; set; }

            [NameInMap("HostGroupType")]
            [Validation(Required=false)]
            public string HostGroupType { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("MultiInstanceTypes")]
            [Validation(Required=false)]
            public string MultiInstanceTypes { get; set; }

            [NameInMap("SysDiskType")]
            [Validation(Required=false)]
            public string SysDiskType { get; set; }

            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("DiskCount")]
            [Validation(Required=false)]
            public int? DiskCount { get; set; }

            [NameInMap("CreateType")]
            [Validation(Required=false)]
            public string CreateType { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("DiskCapacity")]
            [Validation(Required=false)]
            public int? DiskCapacity { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public int? NodeCount { get; set; }

            [NameInMap("HostGroupName")]
            [Validation(Required=false)]
            public string HostGroupName { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

        [NameInMap("BootstrapAction")]
        [Validation(Required=false)]
        public List<CreateClusterTemplateRequestBootstrapAction> BootstrapAction { get; set; }
        public class CreateClusterTemplateRequestBootstrapAction : TeaModel {
            [NameInMap("Arg")]
            [Validation(Required=false)]
            public string Arg { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public List<CreateClusterTemplateRequestConfig> Config { get; set; }
        public class CreateClusterTemplateRequestConfig : TeaModel {
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            [NameInMap("Replace")]
            [Validation(Required=false)]
            public string Replace { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ConfigKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            [NameInMap("Encrypt")]
            [Validation(Required=false)]
            public string Encrypt { get; set; }

        }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterTemplateRequestTag> Tag { get; set; }
        public class CreateClusterTemplateRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
