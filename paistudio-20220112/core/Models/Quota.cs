// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Quota : TeaModel {
        /// <summary>
        /// <para>The resource allocation strategy. Currently, only ByNodeSpecs is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ByNodeSpec</para>
        /// </summary>
        [NameInMap("AllocateStrategy")]
        [Validation(Required=false)]
        public string AllocateStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the resource quota creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1884692****</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The description of the resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test quota</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>L20</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <para>The time when the resource quota was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        /// <summary>
        /// <para>The time when the resource quota was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The list of high-performance network zones.</para>
        /// </summary>
        [NameInMap("HyperZones")]
        [Validation(Required=false)]
        public List<string> HyperZones { get; set; }

        /// <summary>
        /// <para>The labels of the resource quota.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The ID of the latest operation on the resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation****</para>
        /// </summary>
        [NameInMap("LatestOperationId")]
        [Validation(Required=false)]
        public string LatestOperationId { get; set; }

        /// <summary>
        /// <para>The guaranteed resources.</para>
        /// </summary>
        [NameInMap("Min")]
        [Validation(Required=false)]
        public ResourceSpec Min { get; set; }

        /// <summary>
        /// <para>The ID of the parent resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ParentQuotaId")]
        [Validation(Required=false)]
        public string ParentQuotaId { get; set; }

        /// <summary>
        /// <para>The queue policy for the quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PaiStrategyIntelligent: intelligent policies</description></item>
        /// <item><description>PaiStrategyBalance: balanced policy</description></item>
        /// <item><description>PaiStrategyRoundRobin: resource priority policy</description></item>
        /// <item><description>PaiStrategyStrictFIFO: FIFO policy</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PaiStrategyIntelligent</para>
        /// </summary>
        [NameInMap("QueueStrategy")]
        [Validation(Required=false)]
        public string QueueStrategy { get; set; }

        /// <summary>
        /// <para>The specifications and status of the cluster composed of resources in the quota.</para>
        /// </summary>
        [NameInMap("QuotaCluster")]
        [Validation(Required=false)]
        public QuotaCluster QuotaCluster { get; set; }

        /// <summary>
        /// <para>The configuration of the resource quota.</para>
        /// </summary>
        [NameInMap("QuotaConfig")]
        [Validation(Required=false)]
        public QuotaConfig QuotaConfig { get; set; }

        /// <summary>
        /// <para>The details of the resource quota.</para>
        /// </summary>
        [NameInMap("QuotaDetails")]
        [Validation(Required=false)]
        public QuotaDetails QuotaDetails { get; set; }

        /// <summary>
        /// <para>The ID of the resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota12345</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The name of the resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-quota</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <para>The cause of the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The list of resource groups.</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Lingjun</description></item>
        /// <item><description>ECS (default)</description></item>
        /// <item><description>ACS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The status of the resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of sub-quotas of the resource quota.</para>
        /// </summary>
        [NameInMap("SubQuotas")]
        [Validation(Required=false)]
        public List<QuotaIdName> SubQuotas { get; set; }

        /// <summary>
        /// <para>The version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The workspaces associated with the resource quota.</para>
        /// </summary>
        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public List<WorkspaceIdName> Workspaces { get; set; }

    }

}
