// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ModifyScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>Set the value to true if scale-outs are allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AcceptEULA")]
        [Validation(Required=false)]
        public bool? AcceptEULA { get; set; }

        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74ee****-db65-4322-a1f6-bcb60e5b****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the instance group to which the application is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8123db90-880f-486f-<b><b>-</b></b>********</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The relationship among the conditions that trigger a scale-in.</para>
        /// <list type="bullet">
        /// <item><description>OR: one of the conditions</description></item>
        /// <item><description>AND: all conditions</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;OR&quot;</para>
        /// </summary>
        [NameInMap("InCondition")]
        [Validation(Required=false)]
        public string InCondition { get; set; }

        /// <summary>
        /// <para>The CPU utilization that triggers a scale-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("InCpu")]
        [Validation(Required=false)]
        public int? InCpu { get; set; }

        /// <summary>
        /// <para>The duration in which the metric threshold is exceeded. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("InDuration")]
        [Validation(Required=false)]
        public int? InDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow scale-ins.</para>
        /// <list type="bullet">
        /// <item><description>true: allows scale-ins.</description></item>
        /// <item><description>false: does not allow scale-ins.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InEnable")]
        [Validation(Required=false)]
        public bool? InEnable { get; set; }

        /// <summary>
        /// <para>The minimum number of instances that must be retained in each group when a scale-in is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("InInstanceNum")]
        [Validation(Required=false)]
        public int? InInstanceNum { get; set; }

        /// <summary>
        /// <para>The system load that triggers a scale-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("InLoad")]
        [Validation(Required=false)]
        public int? InLoad { get; set; }

        /// <summary>
        /// <para>The minimum service latency that triggers a scale-in. The lower limit is 0. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("InRT")]
        [Validation(Required=false)]
        public int? InRT { get; set; }

        /// <summary>
        /// <para>The number of instances that are removed during each scale-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InStep")]
        [Validation(Required=false)]
        public int? InStep { get; set; }

        /// <summary>
        /// <para>The key pair that is used to log on to the instance. This parameter takes effect only if you choose to create instances based on the specifications of an existing instance during a scale-out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;tdy218&quot;</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The multi-zone scaling policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIORITY: The vSwitch that is first selected has the highest priority.</description></item>
        /// <item><description>BALANCE: This policy evenly distributes instances across zones in which the vSwitches reside.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;PRIORITY&quot;</para>
        /// </summary>
        [NameInMap("MultiAzPolicy")]
        [Validation(Required=false)]
        public string MultiAzPolicy { get; set; }

        /// <summary>
        /// <para>The CPU utilization that triggers a scale-out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("OutCPU")]
        [Validation(Required=false)]
        public int? OutCPU { get; set; }

        /// <summary>
        /// <para>The relationship among the conditions that trigger a scale-out.</para>
        /// <list type="bullet">
        /// <item><description>OR: one of the conditions</description></item>
        /// <item><description>AND: all conditions</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;OR&quot;</para>
        /// </summary>
        [NameInMap("OutCondition")]
        [Validation(Required=false)]
        public string OutCondition { get; set; }

        /// <summary>
        /// <para>The duration in which the metric threshold is exceeded. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("OutDuration")]
        [Validation(Required=false)]
        public int? OutDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow scale-outs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OutEnable")]
        [Validation(Required=false)]
        public bool? OutEnable { get; set; }

        /// <summary>
        /// <para>The maximum number of instances in each group when a scale-out is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OutInstanceNum")]
        [Validation(Required=false)]
        public int? OutInstanceNum { get; set; }

        /// <summary>
        /// <para>The system load that triggers a scale-out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("OutLoad")]
        [Validation(Required=false)]
        public int? OutLoad { get; set; }

        /// <summary>
        /// <para>The minimum service latency that triggers a scale-out. The lower limit is 0. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OutRT")]
        [Validation(Required=false)]
        public int? OutRT { get; set; }

        /// <summary>
        /// <para>The number of instances that are added during each scale-out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OutStep")]
        [Validation(Required=false)]
        public int? OutStep { get; set; }

        /// <summary>
        /// <para>The password that is used to log on to the instance. This parameter takes effect only if you choose to create instances based on the specifications of an existing instance during a scale-out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Pwd*****&quot;</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The source of the instance to be added during a scale-out. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NEW: elastic resources</description></item>
        /// <item><description>AVAILABLE: existing resources If you prefer existing resources to elastic resources, set this parameter to AVAILABLE_FIRST.</description></item>
        /// </list>
        /// <para>If you set this parameter to NEW or AVAILABLE_FIRST, you must specify the auto-scaling parameters. If you set this parameter to NEW, instances are created based on a launch template or the specifications of an existing instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;AVAILABLE&quot;</para>
        /// </summary>
        [NameInMap("ResourceFrom")]
        [Validation(Required=false)]
        public string ResourceFrom { get; set; }

        /// <summary>
        /// <para>The instance handling mode during a scale-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>release: When a scale-in is performed, instances that are no longer used are released.</description></item>
        /// <item><description>recycle: When a scale-in is performed, instances that are no longer used are stopped and reclaimed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;release&quot;</para>
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        /// <summary>
        /// <para>The ID of the launch template that is used to create instances during a scale-out. This parameter takes effect only if you set the OutEnable parameter to true. This parameter takes precedence over the TemplateInstanceId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;lt-wz9hkhn8wp*****&quot;</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the instance whose specifications are used to create instances during a scale-out. This parameter is valid only when you set the OutEnable parameter to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;1&quot;</para>
        /// </summary>
        [NameInMap("TemplateInstanceId")]
        [Validation(Required=false)]
        public string TemplateInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance whose specifications are used to create instances during a scale-out. This parameter takes effect only if you specify the TemplateInstanceId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;tpl-tdy218&quot;</para>
        /// </summary>
        [NameInMap("TemplateInstanceName")]
        [Validation(Required=false)]
        public string TemplateInstanceName { get; set; }

        /// <summary>
        /// <para>The version of the launch template that is used to create instances during a scale-out. This parameter takes effect only if you set the OutEnable parameter to true. To use the default template version, set this parameter to <c>-1</c>. Otherwise, set this parameter to the version that you want to use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public int? TemplateVersion { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches that are associated with the VPC. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;vsw-bp1ldxs3d4fd*****&quot;</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) that is associated with the instances created based on a launch template or the specifications of an existing instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;vpc-bp1j55oz3bg*****&quot;</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
