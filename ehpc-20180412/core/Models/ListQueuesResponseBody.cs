// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListQueuesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried cluster queues.</para>
        /// </summary>
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public ListQueuesResponseBodyQueues Queues { get; set; }
        public class ListQueuesResponseBodyQueues : TeaModel {
            [NameInMap("QueueInfo")]
            [Validation(Required=false)]
            public List<ListQueuesResponseBodyQueuesQueueInfo> QueueInfo { get; set; }
            public class ListQueuesResponseBodyQueuesQueueInfo : TeaModel {
                /// <summary>
                /// <para>The instance type of the compute nodes.</para>
                /// </summary>
                [NameInMap("ComputeInstanceType")]
                [Validation(Required=false)]
                public ListQueuesResponseBodyQueuesQueueInfoComputeInstanceType ComputeInstanceType { get; set; }
                public class ListQueuesResponseBodyQueuesQueueInfoComputeInstanceType : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public List<string> InstanceType { get; set; }

                }

                /// <summary>
                /// <para>The ID of the deployment set to which to deploy the instance. You can call the <a href="https://help.aliyun.com/document_detail/91313.html">DescribeDeploymentSets</a> operation to query the deployment set ID. Only the deployment sets that use low latency policies are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds-bp1frxuzdg87zh4pzq****</para>
                /// </summary>
                [NameInMap("DeploymentSetId")]
                [Validation(Required=false)]
                public string DeploymentSetId { get; set; }

                /// <summary>
                /// <para>Indicates whether auto scale-out is enabled for the queue. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableAutoGrow")]
                [Validation(Required=false)]
                public bool? EnableAutoGrow { get; set; }

                /// <summary>
                /// <para>The prefix of the hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>compute</para>
                /// </summary>
                [NameInMap("HostNamePrefix")]
                [Validation(Required=false)]
                public string HostNamePrefix { get; set; }

                /// <summary>
                /// <para>The suffix of the hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01</para>
                /// </summary>
                [NameInMap("HostNameSuffix")]
                [Validation(Required=false)]
                public string HostNameSuffix { get; set; }

                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_7_06_64_20G_alibase_20****.vhd</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The communication mode of the elastic network interface (ENI). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Standard: The TCP communication mode is used.</description></item>
                /// <item><description>HighPerformance: The Elastic RDMA Interface (ERI) is enabled and the remote direct memory access (RDMA) communication mode is used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("NetworkInterfaceTrafficMode")]
                [Validation(Required=false)]
                public string NetworkInterfaceTrafficMode { get; set; }

                /// <summary>
                /// <para>The name of the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workq</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the queue belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxp7uc24****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The information about the preemptible instance.</para>
                /// </summary>
                [NameInMap("SpotInstanceTypes")]
                [Validation(Required=false)]
                public ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypes SpotInstanceTypes { get; set; }
                public class ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypes : TeaModel {
                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public List<ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypesInstance> Instance { get; set; }
                    public class ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypesInstance : TeaModel {
                        /// <summary>
                        /// <para>The instance type of the preemptible instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ecs.n1.tiny</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The maximum hourly price of the instance. The price can be accurate to three decimal places. This parameter is valid only when the SpotStrategy parameter is set to SpotWithPriceLimit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.062</para>
                        /// </summary>
                        [NameInMap("SpotPriceLimit")]
                        [Validation(Required=false)]
                        public float? SpotPriceLimit { get; set; }

                    }

                }

                /// <summary>
                /// <para>The preemption policy of the compute nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSpot: The instance is a regular pay-as-you-go instance.</description></item>
                /// <item><description>SpotWithPriceLimit: The instance is a preemptible instance for which you specify the maximum hourly price.</description></item>
                /// <item><description>SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>The type of queue. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Execution: Queues in which jobs can be executed.</description></item>
                /// <item><description>Router: Queues in which jobs cannot be executed. The received jobs in the queues must be forwarded to the bound Execution queues for execution.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Execution</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Specifies whether to use scaling groups of Auto Scaling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("UseESS")]
                [Validation(Required=false)]
                public bool? UseESS { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6E5005C-00B0-4F27-98BB-95AB88016C22</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
