// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeExecutionPlanResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("WorkflowApp")]
        [Validation(Required=false)]
        public string WorkflowApp { get; set; }

        [NameInMap("DayOfWeek")]
        [Validation(Required=false)]
        public string DayOfWeek { get; set; }

        [NameInMap("TimeInterval")]
        [Validation(Required=false)]
        public int? TimeInterval { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DayOfMonth")]
        [Validation(Required=false)]
        public string DayOfMonth { get; set; }

        [NameInMap("ExecutionPlanVersion")]
        [Validation(Required=false)]
        public long? ExecutionPlanVersion { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("JobInfoList")]
        [Validation(Required=false)]
        public DescribeExecutionPlanResponseBodyJobInfoList JobInfoList { get; set; }
        public class DescribeExecutionPlanResponseBodyJobInfoList : TeaModel {
            [NameInMap("JobInfo")]
            [Validation(Required=false)]
            public List<DescribeExecutionPlanResponseBodyJobInfoListJobInfo> JobInfo { get; set; }
            public class DescribeExecutionPlanResponseBodyJobInfoListJobInfo : TeaModel {
                public string Type { get; set; }
                public string FailAct { get; set; }
                public string Name { get; set; }
                public string RunParameter { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("ClusterInfo")]
        [Validation(Required=false)]
        public DescribeExecutionPlanResponseBodyClusterInfo ClusterInfo { get; set; }
        public class DescribeExecutionPlanResponseBodyClusterInfo : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("UseCustomHiveMetaDB")]
            [Validation(Required=false)]
            public bool? UseCustomHiveMetaDB { get; set; }
            [NameInMap("LogEnable")]
            [Validation(Required=false)]
            public bool? LogEnable { get; set; }
            [NameInMap("UserDefinedEmrEcsRole")]
            [Validation(Required=false)]
            public string UserDefinedEmrEcsRole { get; set; }
            [NameInMap("HighAvailabilityEnable")]
            [Validation(Required=false)]
            public bool? HighAvailabilityEnable { get; set; }
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }
            [NameInMap("UseLocalMetaDb")]
            [Validation(Required=false)]
            public bool? UseLocalMetaDb { get; set; }
            [NameInMap("SoftwareInfo")]
            [Validation(Required=false)]
            public DescribeExecutionPlanResponseBodyClusterInfoSoftwareInfo SoftwareInfo { get; set; }
            public class DescribeExecutionPlanResponseBodyClusterInfoSoftwareInfo : TeaModel {
                [NameInMap("EmrVer")]
                [Validation(Required=false)]
                public string EmrVer { get; set; }

                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                [NameInMap("Softwares")]
                [Validation(Required=false)]
                public DescribeExecutionPlanResponseBodyClusterInfoSoftwareInfoSoftwares Softwares { get; set; }
                public class DescribeExecutionPlanResponseBodyClusterInfoSoftwareInfoSoftwares : TeaModel {
                    [NameInMap("Software")]
                    [Validation(Required=false)]
                    public List<DescribeExecutionPlanResponseBodyClusterInfoSoftwareInfoSoftwaresSoftware> Software { get; set; }
                    public class DescribeExecutionPlanResponseBodyClusterInfoSoftwareInfoSoftwaresSoftware : TeaModel {
                        public string DisplayName { get; set; }
                        public int? StartTpe { get; set; }
                        public string Version { get; set; }
                        public bool? OnlyDisplay { get; set; }
                        public bool? Optional { get; set; }
                        public string Name { get; set; }
                    }
                };

            }
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public bool? IoOptimized { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
            [NameInMap("Configurations")]
            [Validation(Required=false)]
            public string Configurations { get; set; }
            [NameInMap("EcsOrders")]
            [Validation(Required=false)]
            public DescribeExecutionPlanResponseBodyClusterInfoEcsOrders EcsOrders { get; set; }
            public class DescribeExecutionPlanResponseBodyClusterInfoEcsOrders : TeaModel {
                [NameInMap("EcsOrderInfo")]
                [Validation(Required=false)]
                public List<DescribeExecutionPlanResponseBodyClusterInfoEcsOrdersEcsOrderInfo> EcsOrderInfo { get; set; }
                public class DescribeExecutionPlanResponseBodyClusterInfoEcsOrdersEcsOrderInfo : TeaModel {
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("DiskCapacity")]
                    [Validation(Required=false)]
                    public int? DiskCapacity { get; set; }

                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public string NodeType { get; set; }

                    [NameInMap("NodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                    [NameInMap("DiskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("DiskCount")]
                    [Validation(Required=false)]
                    public int? DiskCount { get; set; }

                }

            }
            [NameInMap("EmrVer")]
            [Validation(Required=false)]
            public string EmrVer { get; set; }
            [NameInMap("LogPath")]
            [Validation(Required=false)]
            public string LogPath { get; set; }
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }
            [NameInMap("InitCustomHiveMetaDB")]
            [Validation(Required=false)]
            public bool? InitCustomHiveMetaDB { get; set; }
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }
            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public DescribeExecutionPlanResponseBodyClusterInfoConfigList ConfigList { get; set; }
            public class DescribeExecutionPlanResponseBodyClusterInfoConfigList : TeaModel {
                [NameInMap("Config")]
                [Validation(Required=false)]
                public List<DescribeExecutionPlanResponseBodyClusterInfoConfigListConfig> Config { get; set; }
                public class DescribeExecutionPlanResponseBodyClusterInfoConfigListConfig : TeaModel {
                    [NameInMap("ConfigValue")]
                    [Validation(Required=false)]
                    public string ConfigValue { get; set; }

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
            [NameInMap("BootstrapActionList")]
            [Validation(Required=false)]
            public DescribeExecutionPlanResponseBodyClusterInfoBootstrapActionList BootstrapActionList { get; set; }
            public class DescribeExecutionPlanResponseBodyClusterInfoBootstrapActionList : TeaModel {
                [NameInMap("BootstrapAction")]
                [Validation(Required=false)]
                public List<DescribeExecutionPlanResponseBodyClusterInfoBootstrapActionListBootstrapAction> BootstrapAction { get; set; }
                public class DescribeExecutionPlanResponseBodyClusterInfoBootstrapActionListBootstrapAction : TeaModel {
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

            }
            [NameInMap("InstanceGeneration")]
            [Validation(Required=false)]
            public string InstanceGeneration { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("EasEnable")]
            [Validation(Required=false)]
            public bool? EasEnable { get; set; }
        };

        [NameInMap("TimeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("CreateClusterOnDemand")]
        [Validation(Required=false)]
        public bool? CreateClusterOnDemand { get; set; }

    }

}
