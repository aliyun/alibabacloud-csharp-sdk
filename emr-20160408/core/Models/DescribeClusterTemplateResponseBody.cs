// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeClusterTemplateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateInfo")]
        [Validation(Required=false)]
        public DescribeClusterTemplateResponseBodyTemplateInfo TemplateInfo { get; set; }
        public class DescribeClusterTemplateResponseBodyTemplateInfo : TeaModel {
            [NameInMap("AllowNotebook")]
            [Validation(Required=false)]
            public bool? AllowNotebook { get; set; }
            [NameInMap("BootstrapActionList")]
            [Validation(Required=false)]
            public DescribeClusterTemplateResponseBodyTemplateInfoBootstrapActionList BootstrapActionList { get; set; }
            public class DescribeClusterTemplateResponseBodyTemplateInfoBootstrapActionList : TeaModel {
                [NameInMap("BootstrapAction")]
                [Validation(Required=false)]
                public List<DescribeClusterTemplateResponseBodyTemplateInfoBootstrapActionListBootstrapAction> BootstrapAction { get; set; }
                public class DescribeClusterTemplateResponseBodyTemplateInfoBootstrapActionListBootstrapAction : TeaModel {
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

            }
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }
            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public DescribeClusterTemplateResponseBodyTemplateInfoConfigList ConfigList { get; set; }
            public class DescribeClusterTemplateResponseBodyTemplateInfoConfigList : TeaModel {
                [NameInMap("Config")]
                [Validation(Required=false)]
                public List<DescribeClusterTemplateResponseBodyTemplateInfoConfigListConfig> Config { get; set; }
                public class DescribeClusterTemplateResponseBodyTemplateInfoConfigListConfig : TeaModel {
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

            }
            [NameInMap("Configurations")]
            [Validation(Required=false)]
            public string Configurations { get; set; }
            [NameInMap("CreateSource")]
            [Validation(Required=false)]
            public string CreateSource { get; set; }
            [NameInMap("DepositType")]
            [Validation(Required=false)]
            public string DepositType { get; set; }
            [NameInMap("EasEnable")]
            [Validation(Required=false)]
            public bool? EasEnable { get; set; }
            [NameInMap("EmrVer")]
            [Validation(Required=false)]
            public string EmrVer { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("HighAvailabilityEnable")]
            [Validation(Required=false)]
            public bool? HighAvailabilityEnable { get; set; }
            [NameInMap("HostGroupList")]
            [Validation(Required=false)]
            public DescribeClusterTemplateResponseBodyTemplateInfoHostGroupList HostGroupList { get; set; }
            public class DescribeClusterTemplateResponseBodyTemplateInfoHostGroupList : TeaModel {
                [NameInMap("HostGroup")]
                [Validation(Required=false)]
                public List<DescribeClusterTemplateResponseBodyTemplateInfoHostGroupListHostGroup> HostGroup { get; set; }
                public class DescribeClusterTemplateResponseBodyTemplateInfoHostGroupListHostGroup : TeaModel {
                    [NameInMap("ChargeType")]
                    [Validation(Required=false)]
                    public string ChargeType { get; set; }

                    [NameInMap("DiskCapacity")]
                    [Validation(Required=false)]
                    public int? DiskCapacity { get; set; }

                    [NameInMap("DiskCount")]
                    [Validation(Required=false)]
                    public int? DiskCount { get; set; }

                    [NameInMap("DiskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

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

                    [NameInMap("MultiInstanceTypes")]
                    [Validation(Required=false)]
                    public string MultiInstanceTypes { get; set; }

                    [NameInMap("NodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                    [NameInMap("Period")]
                    [Validation(Required=false)]
                    public string Period { get; set; }

                    [NameInMap("SysDiskCapacity")]
                    [Validation(Required=false)]
                    public int? SysDiskCapacity { get; set; }

                    [NameInMap("SysDiskType")]
                    [Validation(Required=false)]
                    public string SysDiskType { get; set; }

                }

            }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("InitCustomHiveMetaDb")]
            [Validation(Required=false)]
            public bool? InitCustomHiveMetaDb { get; set; }
            [NameInMap("InstanceGeneration")]
            [Validation(Required=false)]
            public string InstanceGeneration { get; set; }
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public bool? IoOptimized { get; set; }
            [NameInMap("IsOpenPublicIp")]
            [Validation(Required=false)]
            public bool? IsOpenPublicIp { get; set; }
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }
            [NameInMap("LogEnable")]
            [Validation(Required=false)]
            public bool? LogEnable { get; set; }
            [NameInMap("LogPath")]
            [Validation(Required=false)]
            public string LogPath { get; set; }
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }
            [NameInMap("MasterNodeTotal")]
            [Validation(Required=false)]
            public int? MasterNodeTotal { get; set; }
            [NameInMap("MasterPwd")]
            [Validation(Required=false)]
            public string MasterPwd { get; set; }
            [NameInMap("MetaStoreConf")]
            [Validation(Required=false)]
            public string MetaStoreConf { get; set; }
            [NameInMap("MetaStoreType")]
            [Validation(Required=false)]
            public string MetaStoreType { get; set; }
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }
            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }
            [NameInMap("SoftwareInfoList")]
            [Validation(Required=false)]
            public DescribeClusterTemplateResponseBodyTemplateInfoSoftwareInfoList SoftwareInfoList { get; set; }
            public class DescribeClusterTemplateResponseBodyTemplateInfoSoftwareInfoList : TeaModel {
                [NameInMap("SoftwareInfo")]
                [Validation(Required=false)]
                public List<string> SoftwareInfo { get; set; }

            }
            [NameInMap("SshEnable")]
            [Validation(Required=false)]
            public bool? SshEnable { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeClusterTemplateResponseBodyTemplateInfoTags Tags { get; set; }
            public class DescribeClusterTemplateResponseBodyTemplateInfoTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeClusterTemplateResponseBodyTemplateInfoTagsTag> Tag { get; set; }
                public class DescribeClusterTemplateResponseBodyTemplateInfoTagsTag : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

            }
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }
            [NameInMap("UseCustomHiveMetaDb")]
            [Validation(Required=false)]
            public bool? UseCustomHiveMetaDb { get; set; }
            [NameInMap("UseLocalMetaDb")]
            [Validation(Required=false)]
            public bool? UseLocalMetaDb { get; set; }
            [NameInMap("UserDefinedEmrEcsRole")]
            [Validation(Required=false)]
            public string UserDefinedEmrEcsRole { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }
        };

    }

}
