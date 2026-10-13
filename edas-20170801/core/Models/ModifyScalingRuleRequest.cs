// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ModifyScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>Must be set to true if auto scaling is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AcceptEULA")]
        [Validation(Required=false)]
        public bool? AcceptEULA { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74ee****-db65-4322-a1f6-bcb60e5b****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The deployment group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8123db90-880f-486f-<b><b>-</b></b>********</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The trigger condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OR: Any condition.</description></item>
        /// <item><description>AND: All conditions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;OR&quot;</para>
        /// </summary>
        [NameInMap("InCondition")]
        [Validation(Required=false)]
        public string InCondition { get; set; }

        /// <summary>
        /// <para>The trigger metric: CPU utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("InCpu")]
        [Validation(Required=false)]
        public int? InCpu { get; set; }

        /// <summary>
        /// <para>The duration, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("InDuration")]
        [Validation(Required=false)]
        public int? InDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the scale-in rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Included.</description></item>
        /// <item><description>false: Not included.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InEnable")]
        [Validation(Required=false)]
        public bool? InEnable { get; set; }

        /// <summary>
        /// <para>The minimum number of instances to retain when the group scales in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("InInstanceNum")]
        [Validation(Required=false)]
        public int? InInstanceNum { get; set; }

        /// <summary>
        /// <para>The trigger metric: system load.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("InLoad")]
        [Validation(Required=false)]
        public int? InLoad { get; set; }

        /// <summary>
        /// <para>The trigger metric: service latency. Unit: milliseconds. Minimum value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("InRT")]
        [Validation(Required=false)]
        public int? InRT { get; set; }

        /// <summary>
        /// <para>The number of instances to scale in at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InStep")]
        [Validation(Required=false)]
        public int? InStep { get; set; }

        /// <summary>
        /// <para>The name of the logon key pair for the instance. This parameter is valid only when the existing instance rule is used for auto scaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;tdy218&quot;</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The multi-zone scaling policy for auto scaling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIORITY: Priority policy.</description></item>
        /// <item><description>BALANCE: Balanced distribution policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;PRIORITY&quot;</para>
        /// </summary>
        [NameInMap("MultiAzPolicy")]
        [Validation(Required=false)]
        public string MultiAzPolicy { get; set; }

        /// <summary>
        /// <para>The trigger metric: CPU utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("OutCPU")]
        [Validation(Required=false)]
        public int? OutCPU { get; set; }

        /// <summary>
        /// <para>The trigger condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OR: Any condition.</description></item>
        /// <item><description>AND: All conditions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;OR&quot;</para>
        /// </summary>
        [NameInMap("OutCondition")]
        [Validation(Required=false)]
        public string OutCondition { get; set; }

        /// <summary>
        /// <para>The duration, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("OutDuration")]
        [Validation(Required=false)]
        public int? OutDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the scale-out rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OutEnable")]
        [Validation(Required=false)]
        public bool? OutEnable { get; set; }

        /// <summary>
        /// <para>The maximum number of instances when the group scales out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OutInstanceNum")]
        [Validation(Required=false)]
        public int? OutInstanceNum { get; set; }

        /// <summary>
        /// <para>The trigger metric: system load.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("OutLoad")]
        [Validation(Required=false)]
        public int? OutLoad { get; set; }

        /// <summary>
        /// <para>The trigger metric: service latency. Unit: milliseconds. Minimum value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OutRT")]
        [Validation(Required=false)]
        public int? OutRT { get; set; }

        /// <summary>
        /// <para>The number of instances to scale out at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OutStep")]
        [Validation(Required=false)]
        public int? OutStep { get; set; }

        /// <summary>
        /// <para>The logon password of the instance. This parameter is valid only when the existing instance rule is used for auto scaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Pwd*****&quot;</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The source of instances for scale-out. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NEW: Elastic resources.</description></item>
        /// <item><description>AVAILABLE: Existing resources. To prioritize existing resources, use AVAILABLE_FIRST.</description></item>
        /// </list>
        /// <para>If you set this parameter to NEW or AVAILABLE_FIRST, you must specify auto scaling parameters. Auto scaling includes two modes: launch template and existing instance rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;AVAILABLE&quot;</para>
        /// </summary>
        [NameInMap("ResourceFrom")]
        [Validation(Required=false)]
        public string ResourceFrom { get; set; }

        /// <summary>
        /// <para>The reclamation mode for scale-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>release: Release mode.</description></item>
        /// <item><description>recycle: Stop and reclaim mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;release&quot;</para>
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        /// <summary>
        /// <para>The launch template ID for auto scaling. This parameter is valid only when OutEnable is set to true, and it has a higher priority than TemplateInstanceId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;lt-wz9hkhn8wp*****&quot;</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The instance ID for the existing instance rule of auto scaling. This parameter is valid only when OutEnable is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;1&quot;</para>
        /// </summary>
        [NameInMap("TemplateInstanceId")]
        [Validation(Required=false)]
        public string TemplateInstanceId { get; set; }

        /// <summary>
        /// <para>The instance name for the existing instance rule of auto scaling. This parameter is valid only when TemplateInstanceId is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;tpl-tdy218&quot;</para>
        /// </summary>
        [NameInMap("TemplateInstanceName")]
        [Validation(Required=false)]
        public string TemplateInstanceName { get; set; }

        /// <summary>
        /// <para>The launch template version for auto scaling. This parameter is valid only when OutEnable is set to true. Set this parameter to <c>-1</c> to use the default template version, or set it to a specific version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public int? TemplateVersion { get; set; }

        /// <summary>
        /// <para>The list of vSwitch IDs in the VPC. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;vsw-bp1ldxs3d4fd*****&quot;</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>The VPC ID associated with the launch template or existing instance rule for auto scaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;vpc-bp1j55oz3bg*****&quot;</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
