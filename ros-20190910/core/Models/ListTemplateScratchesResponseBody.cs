// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListTemplateScratchesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the resource scenario list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Settings for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D1C09606-C58B-558F-9B4E-5BF263D17D09</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource scenarios.</para>
        /// </summary>
        [NameInMap("TemplateScratches")]
        [Validation(Required=false)]
        public List<ListTemplateScratchesResponseBodyTemplateScratches> TemplateScratches { get; set; }
        public class ListTemplateScratchesResponseBodyTemplateScratches : TeaModel {
            /// <summary>
            /// <para>The time when the resource scenario was created. The time is displayed in UTC+0 and follows the ISO 8601 standard without the Z suffix. Format: YYYY-MM-DDThh:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-07T08:06:44</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the resource scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>纳管VPC资源。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The status code that indicates why the resource scenario failed to be generated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InvalidZoneId: invalid zone ID.</description></item>
            /// <item><description>IncorrectInstanceStatus: the instance status does not support this operation.</description></item>
            /// <item><description>RecommendEmpty.DiskCategoryNotRecommended: the cloud disk category is unavailable.</description></item>
            /// <item><description>Forbidden.RAM: insufficient RAM permissions.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only if Status is GENERATE_FAILED.</para>
            /// </remarks>
            /// <para>This information is generated based on call logs and may be incomplete. Verify the information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidZoneId</para>
            /// </summary>
            [NameInMap("FailedCode")]
            [Validation(Required=false)]
            public string FailedCode { get; set; }

            /// <summary>
            /// <para>The logical ID generation strategy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>LongTypePrefixAndIndexSuffix (default): long type prefix with index suffix.</para>
            /// </description></item>
            /// <item><description><para>LongTypePrefixAndHashSuffix: long type prefix with hash suffix.</para>
            /// </description></item>
            /// <item><description><para>ShortTypePrefixAndHashSuffix: short type prefix with hash suffix.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LongTypePrefixAndIndexSuffix</para>
            /// </summary>
            [NameInMap("LogicalIdStrategy")]
            [Validation(Required=false)]
            public string LogicalIdStrategy { get; set; }

            /// <summary>
            /// <para>The configuration parameters of the resource scenario.</para>
            /// </summary>
            [NameInMap("PreferenceParameters")]
            [Validation(Required=false)]
            public List<ListTemplateScratchesResponseBodyTemplateScratchesPreferenceParameters> PreferenceParameters { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesPreferenceParameters : TeaModel {
                /// <summary>
                /// <para>The parameter name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AlbAddressIpVersion: the IP version of the ALB address.</description></item>
                /// <item><description>AlbAddressType: the ALB address type.</description></item>
                /// <item><description>AlbLoadBalancerEdition: the ALB load balancing edition.</description></item>
                /// <item><description>AlbZoneMappings: the ALB active zone mappings.</description></item>
                /// <item><description>RamAttachedPolicyReplication: RAM policy replication.</description></item>
                /// <item><description>DeletionPolicy: the delete policy.</description></item>
                /// <item><description>DisableNameUnique: specifies whether to disable name uniqueness.</description></item>
                /// <item><description>InstanceAmount: the number of instances.</description></item>
                /// <item><description>InstanceDataReplication: instance data replication.</description></item>
                /// <item><description>InstancePeriod: the instance epoch.</description></item>
                /// <item><description>InstancePeriodUnit: the instance epoch unit.</description></item>
                /// <item><description>NamePrefix: the name prefix.</description></item>
                /// <item><description>RamAttachedPolicyReplication: RAM attached policy replication.</description></item>
                /// <item><description>RegionId: the region ID.</description></item>
                /// <item><description>RegionIds: the list of region IDs.</description></item>
                /// <item><description>ResourceView: the resource view.</description></item>
                /// <item><description>ReuseStrategy: the reuse strategy.</description></item>
                /// <item><description>SlbListenerProtocols: the SLB listener protocols.</description></item>
                /// <item><description>TemplateType: the template type.</description></item>
                /// <item><description>VSwitchId: the vSwitch ID.</description></item>
                /// <item><description>VpcId: the VPC ID.</description></item>
                /// <item><description>ZoneId: the zone ID.</description></item>
                /// </list>
                /// <para>This information is generated based on call logs and may be incomplete. Verify the information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DeletionPolicy</para>
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Retain</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm4nxcvht4pmi</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The source resource group.</para>
            /// </summary>
            [NameInMap("SourceResourceGroup")]
            [Validation(Required=false)]
            public ListTemplateScratchesResponseBodyTemplateScratchesSourceResourceGroup SourceResourceGroup { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesSourceResourceGroup : TeaModel {
                /// <summary>
                /// <para>The source resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzawhxxc****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The resource type filter.</para>
                /// </summary>
                [NameInMap("ResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> ResourceTypeFilter { get; set; }

            }

            /// <summary>
            /// <para>The source resources.</para>
            /// </summary>
            [NameInMap("SourceResources")]
            [Validation(Required=false)]
            public List<ListTemplateScratchesResponseBodyTemplateScratchesSourceResources> SourceResources { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesSourceResources : TeaModel {
                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-m5eauuq80anx59v28****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ALIYUN::ALB::LoadBalancer: Application Load Balancer (ALB) for load balancing.</description></item>
                /// <item><description>ALIYUN::ECS::Instance: Elastic Compute Service (ECS) instance.</description></item>
                /// <item><description>ALIYUN::RAM::Role: RAM role.</description></item>
                /// </list>
                /// <para>This information is generated based on call logs and may be incomplete. Verify the information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ECS::VPC</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The source tag.</para>
            /// </summary>
            [NameInMap("SourceTag")]
            [Validation(Required=false)]
            public ListTemplateScratchesResponseBodyTemplateScratchesSourceTag SourceTag { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesSourceTag : TeaModel {
                /// <summary>
                /// <para>The source tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;a&quot;: &quot;b&quot;}</para>
                /// </summary>
                [NameInMap("ResourceTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ResourceTags { get; set; }

                /// <summary>
                /// <para>The resource type filter.</para>
                /// </summary>
                [NameInMap("ResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> ResourceTypeFilter { get; set; }

            }

            /// <summary>
            /// <para>The status of the resource scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GENERATE_COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason why the resource scenario failed to be generated.</para>
            /// <remarks>
            /// <para>This parameter is returned only if Status is GENERATE_FAILED.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Resource ALIYUN::ECS::VPC vpc-m5eauuq80anx59v28**** could not be found for template scratch.</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The tags of the resource scenario.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTemplateScratchesResponseBodyTemplateScratchesTags> Tags { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the resource scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usage1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the resource scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the resource scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ts-48ad85d66cca4620****</para>
            /// </summary>
            [NameInMap("TemplateScratchId")]
            [Validation(Required=false)]
            public string TemplateScratchId { get; set; }

            /// <summary>
            /// <para>The type of the resource scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ResourceImport: resource management.</para>
            /// </description></item>
            /// <item><description><para>ArchitectureReplication: resource replication.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceImport</para>
            /// </summary>
            [NameInMap("TemplateScratchType")]
            [Validation(Required=false)]
            public string TemplateScratchType { get; set; }

            /// <summary>
            /// <para>The time when the resource scenario was last updated. The time is displayed in UTC+0 and follows the ISO 8601 standard without the Z suffix. Format: YYYY-MM-DDThh:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-07T08:06:44</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of resource scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
