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
            /// 专属网络端点访问路径创建时间，Unix时间戳格式，单位为毫秒。
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 实例ID。
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 专属网络端点ID。
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// 专属网络端点访问路径ID。
            /// </summary>
            [NameInMap("NetworkAccessPathId")]
            [Validation(Required=false)]
            public string NetworkAccessPathId { get; set; }

            /// <summary>
            /// 专属网络端点访问路径使用的ENI ID。
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// 专属网络端点访问路径使用的ENI私网地址。
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// 专属网络端点访问路径状态。
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 专属网络端点访问路径最近更新时间，Unix时间戳格式，单位为毫秒。
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// 专属网络端点访问路径的ENI归属的交换机ID。
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
