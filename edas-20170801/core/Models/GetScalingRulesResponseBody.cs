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
            /// <item><description><para>0: regular Docker cluster</para>
            /// </description></item>
            /// <item><description><para>1: Swarm cluster (deprecated)</para>
            /// </description></item>
            /// <item><description><para>2: Elastic Compute Service (ECS) cluster</para>
            /// </description></item>
            /// <item><description><para>3: self-managed Kubernetes cluster in EDAS</para>
            /// </description></item>
            /// <item><description><para>4: cluster in which Pandora automatically registers applications</para>
            /// </description></item>
            /// <item><description><para>5: Container Service for Kubernetes (ACK) clusters</para>
            /// </description></item>
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
            /// <item><description><para>1: 1:1, which means that resources are not overcommitted.</para>
            /// </description></item>
            /// <item><description><para>2: 1:2, which means that resources are overcommitted by 1:2.</para>
            /// </description></item>
            /// <item><description><para>4: 1:4, which means that resources are overcommitted by 1:4.</para>
            /// </description></item>
            /// <item><description><para>8: 1:8, which means that resources are overcommitted by 1:8.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OversoldFactor")]
            [Validation(Required=false)]
            public int? OversoldFactor { get; set; }

            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public GetScalingRulesResponseBodyDataRuleList RuleList { get; set; }
            public class GetScalingRulesResponseBodyDataRuleList : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<GetScalingRulesResponseBodyDataRuleListRule> Rule { get; set; }
                public class GetScalingRulesResponseBodyDataRuleListRule : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("Cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("InstNum")]
                    [Validation(Required=false)]
                    public int? InstNum { get; set; }

                    [NameInMap("LoadNum")]
                    [Validation(Required=false)]
                    public int? LoadNum { get; set; }

                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    [NameInMap("MultiAzPolicy")]
                    [Validation(Required=false)]
                    public string MultiAzPolicy { get; set; }

                    [NameInMap("ResourceFrom")]
                    [Validation(Required=false)]
                    public string ResourceFrom { get; set; }

                    [NameInMap("Rt")]
                    [Validation(Required=false)]
                    public int? Rt { get; set; }

                    [NameInMap("SpecId")]
                    [Validation(Required=false)]
                    public string SpecId { get; set; }

                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public int? Step { get; set; }

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    [NameInMap("TemplateVersion")]
                    [Validation(Required=false)]
                    public int? TemplateVersion { get; set; }

                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

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
