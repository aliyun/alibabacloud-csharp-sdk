// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListNetworkAccessEndpointsResponseBody : TeaModel {
        [NameInMap("NetworkAccessEndpoints")]
        [Validation(Required=false)]
        public List<ListNetworkAccessEndpointsResponseBodyNetworkAccessEndpoints> NetworkAccessEndpoints { get; set; }
        public class ListNetworkAccessEndpointsResponseBodyNetworkAccessEndpoints : TeaModel {
            /// <summary>
            /// 专属网络端点创建时间，Unix时间戳格式，单位为毫秒。
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
            /// 专属网络端点名称。
            /// </summary>
            [NameInMap("NetworkAccessEndpointName")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointName { get; set; }

            /// <summary>
            /// 专属网络端点连接的类型。
            /// </summary>
            [NameInMap("NetworkAccessEndpointType")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointType { get; set; }

            /// <summary>
            /// 专属网络端点使用的安全组ID。
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// 专属网络端点状态。
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 专属网络端点最近更新时间，Unix时间戳格式，单位为毫秒。
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// 专属网络端点连接的指定vSwitch列表。
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// 专属网络端点连接的VpcID。
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// 专属网络端点连接的Vpc所属地域。
            /// </summary>
            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

        }

        /// <summary>
        /// 本次调用返回的查询凭证（Token）值，用于下一次翻页查询。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
