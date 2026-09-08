// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CreateQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The quota allocation strategy. Currently, only ByNodeSpecs is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ByNodeSpecs</para>
        /// </summary>
        [NameInMap("AllocateStrategy")]
        [Validation(Required=false)]
        public string AllocateStrategy { get; set; }

        /// <summary>
        /// <para>The specifications of the native cluster for the resource quota.</para>
        /// </summary>
        [NameInMap("ClusterSpec")]
        [Validation(Required=false)]
        public ClusterSpec ClusterSpec { get; set; }

        /// <summary>
        /// <para>The quota description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test quota</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The quota labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The minimum quota configuration. Valid options:</para>
        /// <list type="bullet">
        /// <item><description>ResourceAmount: specifies CPU, memory, or GPU details.</description></item>
        /// <item><description>NodeSpecs: specifies the instance type and quantity.</description></item>
        /// </list>
        /// <para>Constraints:</para>
        /// <list type="bullet">
        /// <item><description>If the quota allocates resources from a dedicated resource group, only the NodeSpecs strategy is allowed.</description></item>
        /// <item><description>If the quota allocates resources from a parent quota, both strategies are allowed, but all child quotas must use the same strategy.</description></item>
        /// <item><description>All GPU specifications within a quota must use the same GPU type.</description></item>
        /// <item><description>Resource quotas with the ECS or Lingjun resource type can only use the NodeSpecs strategy.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Min")]
        [Validation(Required=false)]
        public ResourceSpec Min { get; set; }

        /// <summary>
        /// <para>The parent QuotaId:</para>
        /// <list type="bullet">
        /// <item><description>If ParentQuotaId is empty, a root quota is created and machines are allocated from the dedicated resource group.</description></item>
        /// <item><description>If ParentQuotaId is not empty, a child quota is created and resources are allocated from the nodes bound to the root quota.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>quota1ci8g793pgm</para>
        /// </summary>
        [NameInMap("ParentQuotaId")]
        [Validation(Required=false)]
        public string ParentQuotaId { get; set; }

        /// <summary>
        /// <para>Four queuing policies are supported for quotas.</para>
        /// <list type="bullet">
        /// <item><description>PaiStrategyIntelligent: intelligent policies.</description></item>
        /// <item><description>PaiStrategyBalance: balanced policy.</description></item>
        /// <item><description>PaiStrategyRoundRobin: resource-priority policy.</description></item>
        /// <item><description>PaiStrategyStrictFIFO: FIFO policy.</description></item>
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
        /// <para>QuotaConfig configuration constraints:</para>
        /// <list type="bullet">
        /// <item><description>This configuration does not take effect when the ECS or Lingjun resource type is used.</description></item>
        /// <item><description>When the ACS resource type is used, the user VPC information and ACS configuration take effect.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("QuotaConfig")]
        [Validation(Required=false)]
        public QuotaConfig QuotaConfig { get; set; }

        /// <summary>
        /// <para>The quota name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-quota</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <para>The list of dedicated resource groups. Constraints:</para>
        /// <list type="bullet">
        /// <item><description>Only root quotas (where ParentQuotaId is empty) can allocate machines from resource groups.</description></item>
        /// <item><description>The VPC configurations in the specified resource groups must be consistent.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The quota resource type (Lingjun/ECS/ACS). Default value: ECS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
