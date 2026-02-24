// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceConfigurationSampleResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC300244-FCE3-5061-8214-C27ECB66****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sample.</para>
        /// </summary>
        [NameInMap("Sample")]
        [Validation(Required=false)]
        public GetResourceConfigurationSampleResponseBodySample Sample { get; set; }
        public class GetResourceConfigurationSampleResponseBodySample : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101339776561****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-g</para>
            /// </summary>
            [NameInMap("AvailabilityZone")]
            [Validation(Required=false)]
            public string AvailabilityZone { get; set; }

            /// <summary>
            /// <para>The complete configuration information of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Status\&quot;:\&quot;Running\&quot;,\&quot;HibernationOptions\&quot;:{\&quot;Configured\&quot;:\&quot;false\&quot;},\&quot;ResourceGroupId\&quot;:\&quot;rg-bp67acfmxazb4p****\&quot;,\&quot;MetadataOptions\&quot;:{\&quot;HttpPutResponseHopLimit\&quot;:\&quot;0\&quot;,\&quot;HttpTokens\&quot;:\&quot;optional\&quot;,\&quot;HttpEndpoint\&quot;:\&quot;enabled\&quot;},\&quot;InstanceId\&quot;:\&quot;i-bp67acfmxazb4p****\&quot;,\&quot;InstanceChargeType\&quot;:\&quot;PostPaid\&quot;,\&quot;Memory\&quot;:\&quot;16384\&quot;,\&quot;StoppedMode\&quot;:\&quot;KeepCharging\&quot;,\&quot;CpuOptions\&quot;:{\&quot;ThreadsPerCore\&quot;:\&quot;4\&quot;,\&quot;Numa\&quot;:\&quot;2\&quot;,\&quot;CoreCount\&quot;:\&quot;2\&quot;},\&quot;StartTime\&quot;:\&quot;2017-12-10T04:04Z\&quot;,\&quot;Cpu\&quot;:\&quot;8\&quot;,\&quot;OSName\&quot;:\&quot;CentOS 7.4 64 bit\&quot;,\&quot;DeletionProtection\&quot;:\&quot;false\&quot;,\&quot;SecurityGroupIds\&quot;:{\&quot;SecurityGroupId\&quot;:[null]},\&quot;InstanceNetworkType\&quot;:\&quot;vpc\&quot;,\&quot;InnerIpAddress\&quot;:{\&quot;IpAddress\&quot;:[\&quot;<c>42.112.**.**</c>\&quot;]},\&quot;ExpiredTime\&quot;:\&quot;2017-12-10T04:04Z\&quot;,\&quot;EipAddress\&quot;:{\&quot;AllocationId\&quot;:\&quot;eip-2ze88m67qx5z****\&quot;,\&quot;Bandwidth\&quot;:\&quot;5\&quot;,\&quot;IpAddress\&quot;:\&quot;<c>42.112.**.**</c>\&quot;,\&quot;IsSupportUnassociate\&quot;:\&quot;true\&quot;,\&quot;InternetChargeType\&quot;:\&quot;PayByTraffic\&quot;},\&quot;ImageId\&quot;:\&quot;m-bp67acfmxazb4p****\&quot;,\&quot;ImageOptions\&quot;:{\&quot;LoginAsNonRoot\&quot;:\&quot;false\&quot;},\&quot;HostName\&quot;:\&quot;testHostName\&quot;,\&quot;Tags\&quot;:{\&quot;Tag\&quot;:[null]},\&quot;VlanId\&quot;:\&quot;10\&quot;}</para>
            /// </summary>
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The time when the resource was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1646362560000</para>
            /// </summary>
            [NameInMap("ResourceCreationTime")]
            [Validation(Required=false)]
            public string ResourceCreationTime { get; set; }

            /// <summary>
            /// <para>The deletion status of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: The resource is retained.</para>
            /// </description></item>
            /// <item><description><para>0: The resource is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceDeleted")]
            [Validation(Required=false)]
            public string ResourceDeleted { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1aaegapahkh880****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-ecs</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The resource status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::Instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;key\&quot;:\&quot;value\&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The version information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
