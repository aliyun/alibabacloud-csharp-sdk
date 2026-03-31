// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetDiscoveredResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the resource.</para>
        /// </summary>
        [NameInMap("DiscoveredResourceDetail")]
        [Validation(Required=false)]
        public GetDiscoveredResourceResponseBodyDiscoveredResourceDetail DiscoveredResourceDetail { get; set; }
        public class GetDiscoveredResourceResponseBodyDiscoveredResourceDetail : TeaModel {
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
            /// <para>The ID of the zone in which the resource resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("AvailabilityZone")]
            [Validation(Required=false)]
            public string AvailabilityZone { get; set; }

            /// <summary>
            /// <para>The compliance evaluation result of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>COMPLIANT: The resource is evaluated as compliant.</description></item>
            /// <item><description>NON_COMPLIANT: The resource is evaluated as non-compliant.</description></item>
            /// <item><description>NOT_APPLICABLE: The rule does not apply to the resources.</description></item>
            /// <item><description>INSUFFICIENT_DATA: No data is available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLIANT</para>
            /// </summary>
            [NameInMap("ComplianceType")]
            [Validation(Required=false)]
            public string ComplianceType { get; set; }

            /// <summary>
            /// <para>The configuration of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;AccessControlList\&quot;:{\&quot;Grant\&quot;:\&quot;private\&quot;},\&quot;ServerSideEncryptionRule\&quot;:{\&quot;SSEAlgorithm\&quot;:\&quot;None\&quot;},\&quot;Comment\&quot;:\&quot;\&quot;,\&quot;CreationDate\&quot;:\&quot;2021-06-29T10:05:12.000Z\&quot;,\&quot;Owner\&quot;:{\&quot;DisplayName\&quot;:\&quot;100931896542****\&quot;,\&quot;ID\&quot;:\&quot;100931896542****\&quot;},\&quot;StorageClass\&quot;:\&quot;Standard\&quot;,\&quot;DataRedundancyType\&quot;:\&quot;LRS\&quot;,\&quot;AllowEmptyReferer\&quot;:\&quot;true\&quot;,\&quot;Name\&quot;:\&quot;new-bucket\&quot;,\&quot;BucketPolicy\&quot;:{\&quot;LogPrefix\&quot;:\&quot;\&quot;,\&quot;LogBucket\&quot;:\&quot;\&quot;},\&quot;ExtranetEndpoint\&quot;:\&quot;oss-cn-hangzhou.aliyuncs.com\&quot;,\&quot;IntranetEndpoint\&quot;:\&quot;oss-cn-hangzhou-internal.aliyuncs.com\&quot;,\&quot;Location\&quot;:\&quot;oss-cn-hangzhou\&quot;}</para>
            /// </summary>
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }

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
            /// <para>The timestamp when the resource was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1624961112000</para>
            /// </summary>
            [NameInMap("ResourceCreationTime")]
            [Validation(Required=false)]
            public long? ResourceCreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the resource was deleted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The resource was not deleted.</description></item>
            /// <item><description>0: The resource was deleted.</description></item>
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
            /// <para>new-bucket</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The name of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>new-bucket</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The status of the resource. The value of this parameter varies based on the resource type and may be empty.</para>
            /// <list type="bullet">
            /// <item><description>If the ResourceType parameter is set to ACS::ECS::Instance, the resource is an ECS instance that has a specific state. In this case, the valid values of this parameter are Running and Stopped.</description></item>
            /// <item><description>If the ResourceType parameter is ACS::OSS::Bucket, the resource is an Object Storage Service (OSS) bucket that is not in a specific state. In this case, this parameter is left empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>offline</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::OSS::BucketACS::CDN::Domain</para>
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

            /// <summary>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4D71ACE-6B0A-46E0-8352-56952378CC7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
