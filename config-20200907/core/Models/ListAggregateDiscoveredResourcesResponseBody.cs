// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateDiscoveredResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of resources.</para>
        /// </summary>
        [NameInMap("DiscoveredResourceProfiles")]
        [Validation(Required=false)]
        public ListAggregateDiscoveredResourcesResponseBodyDiscoveredResourceProfiles DiscoveredResourceProfiles { get; set; }
        public class ListAggregateDiscoveredResourcesResponseBodyDiscoveredResourceProfiles : TeaModel {
            /// <summary>
            /// <para>The details of the resources.</para>
            /// </summary>
            [NameInMap("DiscoveredResourceProfileList")]
            [Validation(Required=false)]
            public List<ListAggregateDiscoveredResourcesResponseBodyDiscoveredResourceProfilesDiscoveredResourceProfileList> DiscoveredResourceProfileList { get; set; }
            public class ListAggregateDiscoveredResourcesResponseBodyDiscoveredResourceProfilesDiscoveredResourceProfileList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that owns the resource. We recommend that you use the ResourceOwnerId parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161259599160****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The zone where the resource resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-huhehaote-a</para>
                /// </summary>
                [NameInMap("AvailabilityZone")]
                [Validation(Required=false)]
                public string AvailabilityZone { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-huhehaote</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The timestamp when the resource was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1618675206000</para>
                /// </summary>
                [NameInMap("ResourceCreationTime")]
                [Validation(Required=false)]
                public long? ResourceCreationTime { get; set; }

                /// <summary>
                /// <para>The status of the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: The resource is deleted.</para>
                /// </description></item>
                /// <item><description><para>1: The resource is in use.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ResourceDeleted")]
                [Validation(Required=false)]
                public int? ResourceDeleted { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-hp31cqoba96jagtz****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud Firewall</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that owns the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161259599160****</para>
                /// </summary>
                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public long? ResourceOwnerId { get; set; }

                /// <summary>
                /// <para>The status of the resource. The status of a resource is defined by the corresponding Alibaba Cloud service. This parameter can be empty. For example:</para>
                /// <list type="bullet">
                /// <item><description><para>If the resource type is ACS::ECS::Instance, the resource is stateful. The value of this parameter can be Running or Stopped.</para>
                /// </description></item>
                /// <item><description><para>If the resource type is ACS::OSS::Bucket, the resource is stateless. The value of this parameter is empty.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InUse</para>
                /// </summary>
                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public string ResourceStatus { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::NetworkInterface</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The resource tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;key1\&quot;:[\&quot;value2\&quot;]}</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The timestamp of the last update to the resource. This is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1722441600000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch to which the resource belongs. The format is vsw-t4n7pokxxxxxxxxxxxxxx. If the resource belongs to multiple vSwitches, the vSwitch IDs are separated by commas (,). An empty string is returned if the resource does not belong to a vSwitch.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-t4n7pokxxxxxxxxxxxxxx</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The resource build version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the resource belongs. The format is vpc-t4nhheyvay74fp7n0hxxx. An empty string is returned if the resource does not belong to a VPC.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-t4nhheyvay74fp7n0hxxx</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token used to start the next query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IWBjqMYSy0is7zSMGu16****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7817373-78CB-4F9A-8AFA-E7A88E9D64A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
