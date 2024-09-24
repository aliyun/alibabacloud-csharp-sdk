// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListTemplateScratchesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
            /// <para>The time when the resource scenario was created.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
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
            /// <para>The description of the scenario.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The status code of the resource scenario that failed to be generated.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the value of Status is GENERATE_FAILED.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidZoneId</para>
            /// </summary>
            [NameInMap("FailedCode")]
            [Validation(Required=false)]
            public string FailedCode { get; set; }

            /// <summary>
            /// <para>The policy based on which the logical ID is generated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LongTypePrefixAndIndexSuffix (default): long-type prefix + index-type suffix</description></item>
            /// <item><description>LongTypePrefixAndHashSuffix: long-type prefix + hash-type suffix</description></item>
            /// <item><description>ShortTypePrefixAndHashSuffix: short-type prefix + hash-type suffix</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LongTypePrefixAndIndexSuffix</para>
            /// </summary>
            [NameInMap("LogicalIdStrategy")]
            [Validation(Required=false)]
            public string LogicalIdStrategy { get; set; }

            /// <summary>
            /// <para>The preference parameters of the resource scenario.</para>
            /// </summary>
            [NameInMap("PreferenceParameters")]
            [Validation(Required=false)]
            public List<ListTemplateScratchesResponseBodyTemplateScratchesPreferenceParameters> PreferenceParameters { get; set; }
            public class ListTemplateScratchesResponseBodyTemplateScratchesPreferenceParameters : TeaModel {
                /// <summary>
                /// <para>The parameter name.</para>
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
            /// <para>The ID of the resource group.</para>
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
                /// <para>The ID of the source resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzawhxxc****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The resource types for filtering resources.</para>
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
                /// <para>The resource type.</para>
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
                /// <para>The source tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;a&quot;: &quot;b&quot;}</para>
                /// </summary>
                [NameInMap("ResourceTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ResourceTags { get; set; }

                /// <summary>
                /// <para>The resource types for filtering resources.</para>
                /// </summary>
                [NameInMap("ResourceTypeFilter")]
                [Validation(Required=false)]
                public List<string> ResourceTypeFilter { get; set; }

            }

            /// <summary>
            /// <para>The state of the resource scenario.</para>
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
            /// <para> This parameter is returned only if the value of Status is GENERATE_FAILED.</para>
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
            /// <item><description>ResourceImport: resource management</description></item>
            /// <item><description>ArchitectureReplication: resource replication</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceImport</para>
            /// </summary>
            [NameInMap("TemplateScratchType")]
            [Validation(Required=false)]
            public string TemplateScratchType { get; set; }

            /// <summary>
            /// <para>The time when the resource scenario was updated.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-07T08:06:44</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
