// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetNetworkAccessEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>The network access endpoint information.</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpoint")]
        [Validation(Required=false)]
        public GetNetworkAccessEndpointResponseBodyNetworkAccessEndpoint NetworkAccessEndpoint { get; set; }
        public class GetNetworkAccessEndpointResponseBodyNetworkAccessEndpoint : TeaModel {
            /// <summary>
            /// <para>The time when the network access endpoint was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The private egress IP addresses of the dedicated network access endpoint. This parameter is returned only when NetworkEndpointType is set to private.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.168.x.x</para>
            /// </summary>
            [NameInMap("EgressPrivateIpAddresses")]
            [Validation(Required=false)]
            public List<string> EgressPrivateIpAddresses { get; set; }

            /// <summary>
            /// <para>The public egress IP addresses of the shared network access endpoint. This parameter is returned only when NetworkEndpointType is set to shared.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.0.XX.XX/27</para>
            /// </summary>
            [NameInMap("EgressPublicIpAddresses")]
            [Validation(Required=false)]
            public List<string> EgressPublicIpAddresses { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The dedicated network access endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae_examplexxx</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>The name of the dedicated network access endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Xx-business VPC access endpoint</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointName")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointName { get; set; }

            /// <summary>
            /// <para>The type of the network access endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>shared: shared network access endpoint.</description></item>
            /// <item><description>private: dedicated network access endpoint.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointType")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointType { get; set; }

            /// <summary>
            /// <para>The ID of the security group used by the dedicated network access endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-examplexxx</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The status of the network access endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pending: pending initialization.</description></item>
            /// <item><description>creating: being created.</description></item>
            /// <item><description>running: running.</description></item>
            /// <item><description>deleting: being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the dedicated network access endpoint was last updated. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The list of vSwitches to which the dedicated network access endpoint is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-examplexxx</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the dedicated network access endpoint is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-examplexxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The region of the VPC to which the dedicated network access endpoint is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
