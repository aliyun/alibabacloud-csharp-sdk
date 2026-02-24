// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceConfigurationTimelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED9CD1B3-286C-4E05-A765-5E1E0B9BC2AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configuration history of the resource.</para>
        /// </summary>
        [NameInMap("ResourceConfigurationTimeline")]
        [Validation(Required=false)]
        public GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimeline ResourceConfigurationTimeline { get; set; }
        public class GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimeline : TeaModel {
            /// <summary>
            /// <para>A list of configuration history records for the resource.</para>
            /// </summary>
            [NameInMap("ConfigurationList")]
            [Validation(Required=false)]
            public List<GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimelineConfigurationList> ConfigurationList { get; set; }
            public class GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimelineConfigurationList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("AvailabilityZone")]
                [Validation(Required=false)]
                public string AvailabilityZone { get; set; }

                /// <summary>
                /// <para>The timestamp when the resource change snapshot was recorded. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624961156000</para>
                /// </summary>
                [NameInMap("CaptureTime")]
                [Validation(Required=false)]
                public string CaptureTime { get; set; }

                /// <summary>
                /// <para>The details of the resource configuration change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;AccessControlList\&quot;:[null,{\&quot;Grant\&quot;:\&quot;private\&quot;}],\&quot;ServerSideEncryptionRule\&quot;:[null,{\&quot;SSEAlgorithm\&quot;:\&quot;None\&quot;}],\&quot;CreationDate\&quot;:[null,\&quot;2021-06-29T10:05:12.000Z\&quot;],\&quot;Owner\&quot;:[null,{\&quot;DisplayName\&quot;:\&quot;100931896542****\&quot;,\&quot;ID\&quot;:\&quot;100931896542****\&quot;}],\&quot;BucketPolicy\&quot;:[null,{\&quot;LogPrefix\&quot;:\&quot;\&quot;,\&quot;LogBucket\&quot;:\&quot;\&quot;}],\&quot;StorageClass\&quot;:[null,\&quot;Standard\&quot;],\&quot;ExtranetEndpoint\&quot;:[null,\&quot;oss-cn-hangzhou.aliyuncs.com\&quot;],\&quot;DataRedundancyType\&quot;:[null,\&quot;LRS\&quot;],\&quot;AllowEmptyReferer\&quot;:[null,\&quot;true\&quot;],\&quot;IntranetEndpoint\&quot;:[null,\&quot;oss-cn-hangzhou-internal.aliyuncs.com\&quot;],\&quot;Name\&quot;:[null,\&quot;new-bucket\&quot;],\&quot;Location\&quot;:[null,\&quot;oss-cn-hangzhou\&quot;]}</para>
                /// </summary>
                [NameInMap("ConfigurationDiff")]
                [Validation(Required=false)]
                public string ConfigurationDiff { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>Details of related resources, including their region ID, relationship, resource ID, and resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("Relationship")]
                [Validation(Required=false)]
                public string Relationship { get; set; }

                /// <summary>
                /// <para>The changes to the related resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("RelationshipDiff")]
                [Validation(Required=false)]
                public string RelationshipDiff { get; set; }

                /// <summary>
                /// <para>The timestamp when the resource was created. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624961112000</para>
                /// </summary>
                [NameInMap("ResourceCreateTime")]
                [Validation(Required=false)]
                public string ResourceCreateTime { get; set; }

                /// <summary>
                /// <para>The type of the resource change event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>DISCOVERED: A resource is discovered by Cloud Config.</para>
                /// </description></item>
                /// <item><description><para>DISCOVERED_REVISED: A resource is discovered by Cloud Config through a periodic reconciliation task.</para>
                /// </description></item>
                /// <item><description><para>MODIFY: A resource is modified.</para>
                /// </description></item>
                /// <item><description><para>MODIFY_REVISED: A resource modification is recorded through a periodic reconciliation task.</para>
                /// </description></item>
                /// <item><description><para>REMOVE: A resource is deleted.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>To ensure data integrity, Cloud Config periodically reconciles resource data. This process can generate resource discovery events, which occur infrequently.</para>
                /// </description></item>
                /// <item><description><para>The time of an event generated by a reconciliation task is the time when the task discovers the change. This is later than the actual time of the change.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>DISCOVERED</para>
                /// </summary>
                [NameInMap("ResourceEventType")]
                [Validation(Required=false)]
                public string ResourceEventType { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>new-bucket</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>new-bucket</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
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
            /// <para>The token that is used to retrieve the next page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IWBjqMYSy0is7zSMGu16****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
