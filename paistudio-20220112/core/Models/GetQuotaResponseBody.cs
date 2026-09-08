// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource allocation strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ByNodeSpec</para>
        /// </summary>
        [NameInMap("AllocateStrategy")]
        [Validation(Required=false)]
        public string AllocateStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the quota creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1884692****</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

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
        /// <para>The GPU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>L20</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <para>The time when the quota was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        /// <summary>
        /// <para>The time when the quota was last modified.</para>
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
        /// <para>The labels of the quota.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The ID of the latest quota operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation****</para>
        /// </summary>
        [NameInMap("LatestOperationId")]
        [Validation(Required=false)]
        public string LatestOperationId { get; set; }

        /// <summary>
        /// <para>The minimum quota configuration.</para>
        /// </summary>
        [NameInMap("Min")]
        [Validation(Required=false)]
        public ResourceSpec Min { get; set; }

        /// <summary>
        /// <para>The ID of the parent quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota1ci8g79****</para>
        /// </summary>
        [NameInMap("ParentQuotaId")]
        [Validation(Required=false)]
        public string ParentQuotaId { get; set; }

        /// <summary>
        /// <para>The queuing strategy for tasks in the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PaiStrategyIntelligent</para>
        /// </summary>
        [NameInMap("QueueStrategy")]
        [Validation(Required=false)]
        public string QueueStrategy { get; set; }

        /// <summary>
        /// <para>The cluster specifications and status composed of resources in the quota.</para>
        /// </summary>
        [NameInMap("QuotaCluster")]
        [Validation(Required=false)]
        public QuotaCluster QuotaCluster { get; set; }

        /// <summary>
        /// <para>The quota configuration:</para>
        /// <list type="bullet">
        /// <item><description><para>VPC information</para>
        /// </description></item>
        /// <item><description><para>Whether RDMA is supported</para>
        /// </description></item>
        /// <item><description><para>ACS configuration (takes effect when the resource type is ACS)</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("QuotaConfig")]
        [Validation(Required=false)]
        public QuotaConfig QuotaConfig { get; set; }

        /// <summary>
        /// <para>The details of the quota.</para>
        /// </summary>
        [NameInMap("QuotaDetails")]
        [Validation(Required=false)]
        public QuotaDetails QuotaDetails { get; set; }

        /// <summary>
        /// <para>The resource quota ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotajradxh4****</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The name of the resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-quota</para>
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
        /// <para>The error reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18D5A1C6-14B8-545E-8408-0A7DDB4C6B5E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group information associated with the resource quota.</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The resource type of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The status of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of sub-quotas under the quota.</para>
        /// </summary>
        [NameInMap("SubQuotas")]
        [Validation(Required=false)]
        public List<QuotaIdName> SubQuotas { get; set; }

        /// <summary>
        /// <para>The version information. Takes effect when the resource type is ECS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The workspaces associated with the quota.</para>
        /// </summary>
        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public List<WorkspaceIdName> Workspaces { get; set; }

    }

}
