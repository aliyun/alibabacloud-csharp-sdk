// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetScalingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScalingRulesResponseBodyData Data { get; set; }
        public class GetScalingRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: regular Docker cluster</description></item>
            /// <item><description>1: Swarm cluster (deprecated)</description></item>
            /// <item><description>2: Elastic Compute Service (ECS) cluster</description></item>
            /// <item><description>3: self-managed Kubernetes cluster in EDAS</description></item>
            /// <item><description>4: cluster in which Pandora automatically registers applications</description></item>
            /// <item><description>5: Container Service for Kubernetes (ACK) clusters</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public int? ClusterType { get; set; }

            /// <summary>
            /// <para>The overcommit ratio supported by a Docker cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: 1:1, which means that resources are not overcommitted.</description></item>
            /// <item><description>2: 1:2, which means that resources are overcommitted by 1:2.</description></item>
            /// <item><description>4: 1:4, which means that resources are overcommitted by 1:4.</description></item>
            /// <item><description>8: 1:8, which means that resources are overcommitted by 1:8.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OversoldFactor")]
            [Validation(Required=false)]
            public int? OversoldFactor { get; set; }

            /// <summary>
            /// <para>The array data of the scaling rule.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public GetScalingRulesResponseBodyDataRuleList RuleList { get; set; }
            public class GetScalingRulesResponseBodyDataRuleList : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<GetScalingRulesResponseBodyDataRuleListRule> Rule { get; set; }
                public class GetScalingRulesResponseBodyDataRuleListRule : TeaModel {
                    /// <summary>
                    /// <para>The ID of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>33e39be9-3e5f-*********</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The relationship among the conditions that trigger the scaling rule.</para>
                    /// <list type="bullet">
                    /// <item><description>OR: one of the conditions</description></item>
                    /// <item><description>AND: all conditions</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OR</para>
                    /// </summary>
                    [NameInMap("Cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>The minimum CPU utilization that triggers the scaling rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The time when the scaling rule was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1574251601801</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The duration of the scaling rule. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1574251601</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <para>Indicates whether scale-ins or scale-outs are allowed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Scale-ins or scale-outs are allowed.</description></item>
                    /// <item><description>false: Scale-ins or scale-outs are disallowed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance group to which the application is deployed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d8bb9d60-91b5-4cdf-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <para>The maximum number of instances in the group when a scale-out is performed, or the minimum number of instances in the group when a scale-in is performed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("InstNum")]
                    [Validation(Required=false)]
                    public int? InstNum { get; set; }

                    /// <summary>
                    /// <para>The system load that triggers the scaling rule. The system load is evaluated based on the number of processes that are being executed by CPUs and the number of processes that wait to be executed by CPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("LoadNum")]
                    [Validation(Required=false)]
                    public int? LoadNum { get; set; }

                    /// <summary>
                    /// <para>The type of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HSF</para>
                    /// </summary>
                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                    /// <summary>
                    /// <para>The type of the scaling rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>SCALE_IN: scale-in rules</description></item>
                    /// <item><description>SCALE_OUT: scale-out rules</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SCALE_OUT</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <para>The policy of auto scaling across multiple zones. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PRIORITY: The vSwitch that is first selected has the highest priority.</description></item>
                    /// <item><description>BALANCE: This policy evenly distributes instances across zones in which the vSwitches reside.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRIORITY</para>
                    /// </summary>
                    [NameInMap("MultiAzPolicy")]
                    [Validation(Required=false)]
                    public string MultiAzPolicy { get; set; }

                    /// <summary>
                    /// <para>The source of the instance that you want to add during a scale-out. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>NEW: Elastic resources are used.</description></item>
                    /// <item><description>AVAILABLE: The existing resources are used.</description></item>
                    /// <item><description>AVAILABLE_FIRST: The existing resources are used first.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AVAILABLE</para>
                    /// </summary>
                    [NameInMap("ResourceFrom")]
                    [Validation(Required=false)]
                    public string ResourceFrom { get; set; }

                    /// <summary>
                    /// <para>The service latency that triggers the scaling rule. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Rt")]
                    [Validation(Required=false)]
                    public int? Rt { get; set; }

                    /// <summary>
                    /// <para>The ID of the specification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>03f493c0-xxxx-xxxx-xxxx-12e85cadeb41</para>
                    /// </summary>
                    [NameInMap("SpecId")]
                    [Validation(Required=false)]
                    public string SpecId { get; set; }

                    /// <summary>
                    /// <para>The number of instances that are added during each scale-out or removed during each scale-in.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public int? Step { get; set; }

                    /// <summary>
                    /// <para>The ID of the launch template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lt-bp1xxxxn73pxxxxf83l</para>
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    /// <summary>
                    /// <para>The version of the launch template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1143542</para>
                    /// </summary>
                    [NameInMap("TemplateVersion")]
                    [Validation(Required=false)]
                    public int? TemplateVersion { get; set; }

                    /// <summary>
                    /// <para>The time when the scaling rule was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1574251601785</para>
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                    /// <summary>
                    /// <para>The IDs of the vSwitches. The IDs of multiple vSwitches are separated by commas (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-mxxxxkxxxx4xxxxwbionj</para>
                    /// </summary>
                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-wz9b246z******</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            /// <summary>
            /// <para>The time when the scaling rule was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1574251601785</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9b246z******</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D16979DC-4D42-***********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the scaling rule was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1574251601785</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
