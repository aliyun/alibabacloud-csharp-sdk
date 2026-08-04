// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CreateQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The allocation strategy for the quota. Only <c>ByNodeSpecs</c> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ByNodeSpecs</para>
        /// </summary>
        [NameInMap("AllocateStrategy")]
        [Validation(Required=false)]
        public string AllocateStrategy { get; set; }

        /// <summary>
        /// <para>The native cluster specification for the quota.</para>
        /// </summary>
        [NameInMap("ClusterSpec")]
        [Validation(Required=false)]
        public ClusterSpec ClusterSpec { get; set; }

        /// <summary>
        /// <para>The description of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test quota</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The tags for the quota.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The minimum resources for the quota. You can define this in one of the following ways:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ResourceAmount</c>: Specifies the CPU, memory, and GPU details.</para>
        /// </description></item>
        /// <item><description><para><c>NodeSpecs</c>: Specifies the node specification and the number of nodes.</para>
        /// </description></item>
        /// </list>
        /// <para>Constraints:</para>
        /// <list type="bullet">
        /// <item><description><para>If this quota allocates resources from a dedicated resource group, you must use the <c>NodeSpecs</c> method.</para>
        /// </description></item>
        /// <item><description><para>If this quota allocates resources from a parent quota, both methods are allowed. However, all its child quotas must use the same method.</para>
        /// </description></item>
        /// <item><description><para>All GPU specifications within the quota must have the same GPU type.</para>
        /// </description></item>
        /// <item><description><para>For quotas with the resource type set to ECS or Lingjun, only the <c>NodeSpecs</c> method can be used.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Min")]
        [Validation(Required=false)]
        public ResourceSpec Min { get; set; }

        /// <summary>
        /// <para>The ID of the parent quota.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, a root quota is created. Resources are allocated from a dedicated resource group.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, a child quota is created. Resources are allocated from the nodes that are bound to the root quota.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>quota1ci8g793pgm</para>
        /// </summary>
        [NameInMap("ParentQuotaId")]
        [Validation(Required=false)]
        public string ParentQuotaId { get; set; }

        /// <summary>
        /// <para>The queuing strategy for the quota. Four strategies are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PaiStrategyIntelligent</c>: The intelligent strategy.</para>
        /// </description></item>
        /// <item><description><para><c>PaiStrategyBalance</c>: The balance strategy.</para>
        /// </description></item>
        /// <item><description><para><c>PaiStrategyRoundRobin</c>: The round-robin strategy.</para>
        /// </description></item>
        /// <item><description><para><c>PaiStrategyStrictFIFO</c>: The FIFO strategy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PaiStrategyIntelligent</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("QueueStrategy")]
        [Validation(Required=false)]
        public string QueueStrategy { get; set; }

        /// <summary>
        /// <para>Constraints for the <c>QuotaConfig</c> parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is ignored if the resource type is ECS or Lingjun.</para>
        /// </description></item>
        /// <item><description><para>If the resource type is ACS, the specified VPC and ACS configurations are applied.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("QuotaConfig")]
        [Validation(Required=false)]
        public QuotaConfig QuotaConfig { get; set; }

        /// <summary>
        /// <para>The name of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-quota</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <para>The IDs of the dedicated resource groups. The following constraints apply:</para>
        /// <list type="bullet">
        /// <item><description><para>Only a root quota, for which <c>ParentQuotaId</c> is empty, can allocate nodes from a resource group.</para>
        /// </description></item>
        /// <item><description><para>The VPC configurations of the specified resource groups must be the same.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The resource type of the quota. Valid values: Lingjun, ECS, and ACS. Default value: ECS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
