// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ModifyExecutionPlanRequest : TeaModel {
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("LogEnable")]
        [Validation(Required=false)]
        public bool? LogEnable { get; set; }

        [NameInMap("LogPath")]
        [Validation(Required=false)]
        public string LogPath { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("IsOpenPublicIp")]
        [Validation(Required=false)]
        public bool? IsOpenPublicIp { get; set; }

        [NameInMap("CreateClusterOnDemand")]
        [Validation(Required=false)]
        public bool? CreateClusterOnDemand { get; set; }

        [NameInMap("EmrVer")]
        [Validation(Required=false)]
        public string EmrVer { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("HighAvailabilityEnable")]
        [Validation(Required=false)]
        public bool? HighAvailabilityEnable { get; set; }

        [NameInMap("UseLocalMetaDb")]
        [Validation(Required=false)]
        public bool? UseLocalMetaDb { get; set; }

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

        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public bool? IoOptimized { get; set; }

        [NameInMap("InstanceGeneration")]
        [Validation(Required=false)]
        public string InstanceGeneration { get; set; }

        [NameInMap("EasEnable")]
        [Validation(Required=false)]
        public bool? EasEnable { get; set; }

        [NameInMap("WorkflowDefinition")]
        [Validation(Required=false)]
        public string WorkflowDefinition { get; set; }

        [NameInMap("UseCustomHiveMetaDB")]
        [Validation(Required=false)]
        public bool? UseCustomHiveMetaDB { get; set; }

        [NameInMap("InitCustomHiveMetaDB")]
        [Validation(Required=false)]
        public bool? InitCustomHiveMetaDB { get; set; }

        [NameInMap("Configurations")]
        [Validation(Required=false)]
        public string Configurations { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("ExecutionPlanVersion")]
        [Validation(Required=false)]
        public long? ExecutionPlanVersion { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        [NameInMap("TimeInterval")]
        [Validation(Required=false)]
        public int? TimeInterval { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TimeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

        [NameInMap("DayOfWeek")]
        [Validation(Required=false)]
        public string DayOfWeek { get; set; }

        [NameInMap("DayOfMonth")]
        [Validation(Required=false)]
        public string DayOfMonth { get; set; }

        [NameInMap("OptionSoftWareList")]
        [Validation(Required=false)]
        public List<string> OptionSoftWareList { get; set; }

        [NameInMap("EcsOrder")]
        [Validation(Required=false)]
        public List<ModifyExecutionPlanRequestEcsOrder> EcsOrder { get; set; }
        public class ModifyExecutionPlanRequestEcsOrder : TeaModel {
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

        [NameInMap("BootstrapAction")]
        [Validation(Required=false)]
        public List<ModifyExecutionPlanRequestBootstrapAction> BootstrapAction { get; set; }
        public class ModifyExecutionPlanRequestBootstrapAction : TeaModel {
            [NameInMap("ExecutionFailStrategy")]
            [Validation(Required=false)]
            public string ExecutionFailStrategy { get; set; }

            [NameInMap("Arg")]
            [Validation(Required=false)]
            public string Arg { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("ExecutionTarget")]
            [Validation(Required=false)]
            public string ExecutionTarget { get; set; }

            [NameInMap("ExecutionMoment")]
            [Validation(Required=false)]
            public string ExecutionMoment { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public List<ModifyExecutionPlanRequestConfig> Config { get; set; }
        public class ModifyExecutionPlanRequestConfig : TeaModel {
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

        [NameInMap("JobIdList")]
        [Validation(Required=false)]
        public List<string> JobIdList { get; set; }

    }

}
