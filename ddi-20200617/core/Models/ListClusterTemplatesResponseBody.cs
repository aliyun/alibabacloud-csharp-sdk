// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListClusterTemplatesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TemplateInfoList")]
        [Validation(Required=false)]
        public ListClusterTemplatesResponseBodyTemplateInfoList TemplateInfoList { get; set; }
        public class ListClusterTemplatesResponseBodyTemplateInfoList : TeaModel {
            [NameInMap("TemplateInfo")]
            [Validation(Required=false)]
            public List<ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfo> TemplateInfo { get; set; }
            public class ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfo : TeaModel {
                public string VpcId { get; set; }
                public string KeyPairName { get; set; }
                public bool? LogEnable { get; set; }
                public bool? SshEnable { get; set; }
                public bool? HighAvailabilityEnable { get; set; }
                public string SecurityGroupId { get; set; }
                public string UserId { get; set; }
                public bool? IsOpenPublicIp { get; set; }
                public bool? AllowNotebook { get; set; }
                public long? GmtModified { get; set; }
                public string TemplateName { get; set; }
                public string DepositType { get; set; }
                public string SecurityGroupName { get; set; }
                public string CreateSource { get; set; }
                public string InstanceGeneration { get; set; }
                public bool? UseCustomHiveMetaDb { get; set; }
                public bool? EasEnable { get; set; }
                public string UserDefinedEmrEcsRole { get; set; }
                public string MetaStoreType { get; set; }
                public string MachineType { get; set; }
                public bool? UseLocalMetaDb { get; set; }
                public int? MasterNodeTotal { get; set; }
                public bool? InitCustomHiveMetaDb { get; set; }
                public bool? IoOptimized { get; set; }
                public string MetaStoreConf { get; set; }
                public string VSwitchId { get; set; }
                public string Configurations { get; set; }
                public string LogPath { get; set; }
                public string ClusterType { get; set; }
                public string NetType { get; set; }
                public string ZoneId { get; set; }
                public long? GmtCreate { get; set; }
                public string Id { get; set; }
                public ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoBootstrapActionList BootstrapActionList { get; set; }
                public class ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoBootstrapActionList : TeaModel {
                    [NameInMap("BootstrapAction")]
                    [Validation(Required=false)]
                    public List<ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoBootstrapActionListBootstrapAction> BootstrapAction { get; set; }
                    public class ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoBootstrapActionListBootstrapAction : TeaModel {
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Arg")]
                        [Validation(Required=false)]
                        public string Arg { get; set; }

                    }

                }
                public ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoHostGroupList HostGroupList { get; set; }
                public class ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoHostGroupList : TeaModel {
                    [NameInMap("HostGroup")]
                    [Validation(Required=false)]
                    public List<ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoHostGroupListHostGroup> HostGroup { get; set; }
                    public class ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoHostGroupListHostGroup : TeaModel {
                        [NameInMap("SysDiskCapacity")]
                        [Validation(Required=false)]
                        public int? SysDiskCapacity { get; set; }

                        [NameInMap("HostGroupType")]
                        [Validation(Required=false)]
                        public string HostGroupType { get; set; }

                        [NameInMap("MultiInstanceTypes")]
                        [Validation(Required=false)]
                        public string MultiInstanceTypes { get; set; }

                        [NameInMap("SysDiskType")]
                        [Validation(Required=false)]
                        public string SysDiskType { get; set; }

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

                        [NameInMap("Period")]
                        [Validation(Required=false)]
                        public string Period { get; set; }

                        [NameInMap("DiskCapacity")]
                        [Validation(Required=false)]
                        public int? DiskCapacity { get; set; }

                        [NameInMap("NodeCount")]
                        [Validation(Required=false)]
                        public int? NodeCount { get; set; }

                        [NameInMap("HostGroupName")]
                        [Validation(Required=false)]
                        public string HostGroupName { get; set; }

                    }

                }
                public ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoConfigList ConfigList { get; set; }
                public class ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoConfigList : TeaModel {
                    [NameInMap("Config")]
                    [Validation(Required=false)]
                    public List<ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoConfigListConfig> Config { get; set; }
                    public class ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoConfigListConfig : TeaModel {
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

                }
                public ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoSoftwareInfoList SoftwareInfoList { get; set; }
                public class ListClusterTemplatesResponseBodyTemplateInfoListTemplateInfoSoftwareInfoList : TeaModel {
                    [NameInMap("SoftwareInfo")]
                    [Validation(Required=false)]
                    public List<string> SoftwareInfo { get; set; }

                }
            }
        };

    }

}
