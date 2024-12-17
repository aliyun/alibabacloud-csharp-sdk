// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListNetworkAccessPathsResponseBody : TeaModel {
        [NameInMap("NetworkAccessPaths")]
        [Validation(Required=false)]
        public List<ListNetworkAccessPathsResponseBodyNetworkAccessPaths> NetworkAccessPaths { get; set; }
        public class ListNetworkAccessPathsResponseBodyNetworkAccessPaths : TeaModel {
            /// <summary>
            /// <para>专属网络端点访问路径创建时间，Unix时间戳格式，单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

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
            /// <para>专属网络端点访问路径ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>nap_examplexxx</para>
            /// </summary>
            [NameInMap("NetworkAccessPathId")]
            [Validation(Required=false)]
            public string NetworkAccessPathId { get; set; }

            /// <summary>
            /// <para>专属网络端点访问路径使用的ENI ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-examplexxx</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>专属网络端点访问路径使用的ENI私网地址。</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// <para>专属网络端点访问路径状态。</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>专属网络端点访问路径最近更新时间，Unix时间戳格式，单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>专属网络端点访问路径的ENI归属的交换机ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-examplexxx</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

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
