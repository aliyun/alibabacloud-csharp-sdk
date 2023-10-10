// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ModifyScalingRuleRequest : TeaModel {
        /// <summary>
        /// Set the value to true if scale-outs are allowed.
        /// </summary>
        [NameInMap("AcceptEULA")]
        [Validation(Required=false)]
        public bool? AcceptEULA { get; set; }

        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the instance group to which the application is deployed.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The relationship among the conditions that trigger a scale-in.
        /// 
        /// *   OR: one of the conditions
        /// *   AND: all conditions
        /// </summary>
        [NameInMap("InCondition")]
        [Validation(Required=false)]
        public string InCondition { get; set; }

        /// <summary>
        /// The CPU utilization that triggers a scale-in.
        /// </summary>
        [NameInMap("InCpu")]
        [Validation(Required=false)]
        public int? InCpu { get; set; }

        /// <summary>
        /// The duration in which the metric threshold is exceeded. Unit: minutes.
        /// </summary>
        [NameInMap("InDuration")]
        [Validation(Required=false)]
        public int? InDuration { get; set; }

        /// <summary>
        /// Specifies whether to allow scale-ins.
        /// 
        /// *   true: allows scale-ins.
        /// *   false: does not allow scale-ins.
        /// </summary>
        [NameInMap("InEnable")]
        [Validation(Required=false)]
        public bool? InEnable { get; set; }

        /// <summary>
        /// The minimum number of instances that must be retained in each group when a scale-in is performed.
        /// </summary>
        [NameInMap("InInstanceNum")]
        [Validation(Required=false)]
        public int? InInstanceNum { get; set; }

        /// <summary>
        /// The system load that triggers a scale-in.
        /// </summary>
        [NameInMap("InLoad")]
        [Validation(Required=false)]
        public int? InLoad { get; set; }

        /// <summary>
        /// The minimum service latency that triggers a scale-in. The lower limit is 0. Unit: milliseconds.
        /// </summary>
        [NameInMap("InRT")]
        [Validation(Required=false)]
        public int? InRT { get; set; }

        /// <summary>
        /// The number of instances that are removed during each scale-in.
        /// </summary>
        [NameInMap("InStep")]
        [Validation(Required=false)]
        public int? InStep { get; set; }

        /// <summary>
        /// The key pair that is used to log on to the instance. This parameter takes effect only if you choose to create instances based on the specifications of an existing instance during a scale-out.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The multi-zone scaling policy. Valid values:
        /// 
        /// *   PRIORITY: The vSwitch that is first selected has the highest priority.
        /// *   BALANCE: This policy evenly distributes instances across zones in which the vSwitches reside.
        /// </summary>
        [NameInMap("MultiAzPolicy")]
        [Validation(Required=false)]
        public string MultiAzPolicy { get; set; }

        /// <summary>
        /// The CPU utilization that triggers a scale-out.
        /// </summary>
        [NameInMap("OutCPU")]
        [Validation(Required=false)]
        public int? OutCPU { get; set; }

        /// <summary>
        /// The relationship among the conditions that trigger a scale-out.
        /// 
        /// *   OR: one of the conditions
        /// *   AND: all conditions
        /// </summary>
        [NameInMap("OutCondition")]
        [Validation(Required=false)]
        public string OutCondition { get; set; }

        /// <summary>
        /// The duration in which the metric threshold is exceeded. Unit: minutes.
        /// </summary>
        [NameInMap("OutDuration")]
        [Validation(Required=false)]
        public int? OutDuration { get; set; }

        /// <summary>
        /// Specifies whether to allow scale-outs.
        /// </summary>
        [NameInMap("OutEnable")]
        [Validation(Required=false)]
        public bool? OutEnable { get; set; }

        /// <summary>
        /// The maximum number of instances in each group when a scale-out is performed.
        /// </summary>
        [NameInMap("OutInstanceNum")]
        [Validation(Required=false)]
        public int? OutInstanceNum { get; set; }

        /// <summary>
        /// The system load that triggers a scale-out.
        /// </summary>
        [NameInMap("OutLoad")]
        [Validation(Required=false)]
        public int? OutLoad { get; set; }

        /// <summary>
        /// The minimum service latency that triggers a scale-out. The lower limit is 0. Unit: milliseconds.
        /// </summary>
        [NameInMap("OutRT")]
        [Validation(Required=false)]
        public int? OutRT { get; set; }

        /// <summary>
        /// The number of instances that are added during each scale-out.
        /// </summary>
        [NameInMap("OutStep")]
        [Validation(Required=false)]
        public int? OutStep { get; set; }

        /// <summary>
        /// The password that is used to log on to the instance. This parameter takes effect only if you choose to create instances based on the specifications of an existing instance during a scale-out.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The source of the instance to be added during a scale-out. Valid values:
        /// 
        /// *   NEW: elastic resources
        /// *   AVAILABLE: existing resources If you prefer existing resources to elastic resources, set this parameter to AVAILABLE_FIRST.
        /// 
        /// If you set this parameter to NEW or AVAILABLE_FIRST, you must specify the auto-scaling parameters. If you set this parameter to NEW, instances are created based on a launch template or the specifications of an existing instance.
        /// </summary>
        [NameInMap("ResourceFrom")]
        [Validation(Required=false)]
        public string ResourceFrom { get; set; }

        /// <summary>
        /// The instance handling mode during a scale-in. Valid values:
        /// 
        /// *   release: When a scale-in is performed, instances that are no longer used are released.
        /// *   recycle: When a scale-in is performed, instances that are no longer used are stopped and reclaimed.
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        /// <summary>
        /// The ID of the launch template that is used to create instances during a scale-out. This parameter takes effect only if you set the OutEnable parameter to true. This parameter takes precedence over the TemplateInstanceId parameter.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The ID of the instance whose specifications are used to create instances during a scale-out. This parameter is valid only when you set the OutEnable parameter to true.
        /// </summary>
        [NameInMap("TemplateInstanceId")]
        [Validation(Required=false)]
        public string TemplateInstanceId { get; set; }

        /// <summary>
        /// The name of the instance whose specifications are used to create instances during a scale-out. This parameter takes effect only if you specify the TemplateInstanceId parameter.
        /// </summary>
        [NameInMap("TemplateInstanceName")]
        [Validation(Required=false)]
        public string TemplateInstanceName { get; set; }

        /// <summary>
        /// The version of the launch template that is used to create instances during a scale-out. This parameter takes effect only if you set the OutEnable parameter to true. To use the default template version, set this parameter to `-1`. Otherwise, set this parameter to the version that you want to use.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public int? TemplateVersion { get; set; }

        /// <summary>
        /// The IDs of the vSwitches that are associated with the VPC. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) that is associated with the instances created based on a launch template or the specifications of an existing instance.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
