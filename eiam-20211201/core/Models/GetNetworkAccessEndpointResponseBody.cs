// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetNetworkAccessEndpointResponseBody : TeaModel {
        [NameInMap("NetworkAccessEndpoint")]
        [Validation(Required=false)]
        public GetNetworkAccessEndpointResponseBodyNetworkAccessEndpoint NetworkAccessEndpoint { get; set; }
        public class GetNetworkAccessEndpointResponseBodyNetworkAccessEndpoint : TeaModel {
            /// <summary>
            /// <para>专属网络端点创建时间，Unix时间戳格式，单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>网络访问端私网出口IP地址列表。</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.168.x.x</para>
            /// </summary>
            [NameInMap("EgressPrivateIpAddresses")]
            [Validation(Required=false)]
            public List<string> EgressPrivateIpAddresses { get; set; }

            /// <summary>
            /// <para>网络访问端点公网出口IP地址段</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.xx.xx.xxx/27</para>
            /// </summary>
            [NameInMap("EgressPublicIpAddresses")]
            [Validation(Required=false)]
            public List<string> EgressPublicIpAddresses { get; set; }

            /// <summary>
            /// <para>实例ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>专属网络端点ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae_examplexxx</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>专属网络端点名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx业务VPC访问端点</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointName")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointName { get; set; }

            /// <summary>
            /// <para>专属网络端点连接的类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointType")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointType { get; set; }

            /// <summary>
            /// <para>专属网络端点使用的安全组ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-examplexxx</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>专属网络端点状态。</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>专属网络端点最近更新时间，Unix时间戳格式，单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>专属网络端点连接的指定vSwitch列表。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-examplexxx</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>专属网络端点连接的VpcID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-examplexxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>专属网络端点连接的Vpc所属地域。</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
