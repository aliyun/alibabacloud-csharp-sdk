// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListServerGroupServersResponseBody : TeaModel {
        /// <summary>
        /// 本次查询返回记录数量
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页查询标识
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 后端服务器
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public List<ListServerGroupServersResponseBodyServers> Servers { get; set; }
        public class ListServerGroupServersResponseBodyServers : TeaModel {
            /// <summary>
            /// 描述信息
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 端口
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// 服务器id
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// 服务器ip
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// 后端服务器类型
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 权重
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
