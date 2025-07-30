// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetNetworkAccessEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>Network endpoint information.</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpoint")]
        [Validation(Required=false)]
        public GetNetworkAccessEndpointResponseBodyNetworkAccessEndpoint NetworkAccessEndpoint { get; set; }
        public class GetNetworkAccessEndpointResponseBodyNetworkAccessEndpoint : TeaModel {
            /// <summary>
            /// <para>The time when the baseline was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Public egress ip address range of the dedicated network endpoint
            /// This field is returned only when NetworkEndpointType is set to private.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.168.x.x</para>
            /// </summary>
            [NameInMap("EgressPrivateIpAddresses")]
            [Validation(Required=false)]
            public List<string> EgressPrivateIpAddresses { get; set; }

            /// <summary>
            /// <para>Public egress ip address range of the shared network endpoint
            /// This field is returned only when networkEndpointType is set to shared.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.xx.xx.xxx/27</para>
            /// </summary>
            [NameInMap("EgressPublicIpAddresses")]
            [Validation(Required=false)]
            public List<string> EgressPublicIpAddresses { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The unique identifier of the network access endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae_examplexxx</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>Private network endpoint name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx business VPC access endpoint</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointName")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointName { get; set; }

            /// <summary>
            /// <para>Type of the Network Endpoint
            /// Possible values:</para>
            /// <para>shared: Shared network endpoint</para>
            /// <para>private: Dedicated network endpoint</para>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointType")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointType { get; set; }

            /// <summary>
            /// <para>The ID of the destination security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-examplexxx</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>Status of the Network Endpoint
            /// Possible values:</para>
            /// <para>pending: Pending initialization</para>
            /// <para>creating: Being created</para>
            /// <para>running: Running</para>
            /// <para>deleting: Being deleted</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the endpoint was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>List of specified vSwitches associated with the dedicated network endpoint connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-examplexxx</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-examplexxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The region ID of the outbound virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
