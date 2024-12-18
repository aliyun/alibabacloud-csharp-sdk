// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceComplianceTimelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D53A78F-1EB8-4264-A554-72F07E34FAE6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the compliance timeline.</para>
        /// </summary>
        [NameInMap("ResourceComplianceTimeline")]
        [Validation(Required=false)]
        public GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimeline ResourceComplianceTimeline { get; set; }
        public class GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimeline : TeaModel {
            /// <summary>
            /// <para>The status of the resource. The parameter value varies based on the resource type and may be left empty. Examples:</para>
            /// <list type="bullet">
            /// <item><description>If the value of the ResourceType parameter is ACS::ECS::Instance, the resource is an Elastic Compute Service (ECS) instance that has a specific state. In this case, the valid values of this parameter are Running and Stopped.</description></item>
            /// <item><description>If the value of the ResourceType parameter is ACS::OSS::Bucket, the resource is an Object Storage Service (OSS) bucket that is not in a specific state. In this case, this parameter is empty.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ComplianceList")]
            [Validation(Required=false)]
            public List<GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimelineComplianceList> ComplianceList { get; set; }
            public class GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimelineComplianceList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The ID of the zone in which the resource resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-f</para>
                /// </summary>
                [NameInMap("AvailabilityZone")]
                [Validation(Required=false)]
                public string AvailabilityZone { get; set; }

                /// <summary>
                /// <para>The timestamp when the compliance evaluation was recorded. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1625200295276</para>
                /// </summary>
                [NameInMap("CaptureTime")]
                [Validation(Required=false)]
                public long? CaptureTime { get; set; }

                /// <summary>
                /// <para>The information about the rules that evaluated the resource and the compliance evaluation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;AccessControlList&quot;: {
                ///         &quot;Grant&quot;: &quot;private&quot;
                ///     },
                ///     &quot;ServerSideEncryptionRule&quot;: {
                ///         &quot;SSEAlgorithm&quot;: &quot;None&quot;
                ///     },
                ///     &quot;Comment&quot;: &quot;&quot;,
                ///     &quot;Owner&quot;: {
                ///         &quot;DisplayName&quot;: &quot;126672004088****&quot;,
                ///         &quot;ID&quot;: &quot;126672004088****&quot;
                ///     },
                ///     &quot;ResourceGroupId&quot;: &quot;rg-acfmy4dfoau****&quot;,
                ///     &quot;StorageClass&quot;: &quot;Standard&quot;,
                ///     &quot;DataRedundancyType&quot;: &quot;LRS&quot;,
                ///     &quot;AllowEmptyReferer&quot;: &quot;true&quot;,
                ///     &quot;Name&quot;: &quot;test-private-oss****&quot;,
                ///     &quot;BucketPolicy&quot;: {
                ///         &quot;LogPrefix&quot;: &quot;&quot;,
                ///         &quot;LogBucket&quot;: &quot;&quot;
                ///     },
                ///     &quot;ExtranetEndpoint&quot;: &quot;oss-cn-hangzhou.aliyuncs.com&quot;,
                ///     &quot;IntranetEndpoint&quot;: &quot;oss-cn-hangzhou-internal.aliyuncs.com&quot;,
                ///     &quot;Location&quot;: &quot;oss-cn-hangzhou&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public string Configuration { get; set; }

                /// <summary>
                /// <para>The details of the resource change that triggered the compliance evaluation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;ResourceGroupId&quot;: [
                ///         &quot;rg-acfmy4dfoau****&quot;,
                ///         &quot;rg-a3dmy4lksta****&quot;
                ///     ]
                /// }</para>
                /// </summary>
                [NameInMap("ConfigurationDiff")]
                [Validation(Required=false)]
                public string ConfigurationDiff { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the resource resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The timestamp when the resource was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624961112000</para>
                /// </summary>
                [NameInMap("ResourceCreateTime")]
                [Validation(Required=false)]
                public long? ResourceCreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-private-oss****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The name of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-private-oss****</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The status of the resource. The parameter value varies based on the resource type and may be left empty. Examples:</para>
                /// <list type="bullet">
                /// <item><description>If the ResourceType parameter is set to ACS::ECS::Instance, the resource is an Elastic Compute Service (ECS) instance that has a specific state. In this case, the valid values of this parameter are Running and Stopped.</description></item>
                /// <item><description>If the ResourceType parameter is set to ACS::OSS::Bucket, the resource is an OSS bucket that does not have a specific state. In this case, this parameter is left empty.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public string ResourceStatus { get; set; }

                /// <summary>
                /// <para>The type of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::OSS::Bucket</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The tags of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;\&quot;hc\&quot;\&quot;:[\&quot;\&quot;value2\&quot;\&quot;]}</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned for a single request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5OVS5J4I1/UKTkHV5oNs****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
