// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListServerGroupsResponseBody : TeaModel {
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
        /// 服务器组
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<ListServerGroupsResponseBodyServerGroups> ServerGroups { get; set; }
        public class ListServerGroupsResponseBodyServerGroups : TeaModel {
            /// <summary>
            /// 健康检查配置
            /// </summary>
            [NameInMap("HealthCheckConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsHealthCheckConfig HealthCheckConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsHealthCheckConfig : TeaModel {
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public bool? HealthCheckEnabled { get; set; }
                [NameInMap("HealthCheckHost")]
                [Validation(Required=false)]
                public string HealthCheckHost { get; set; }
                [NameInMap("HealthCheckCodes")]
                [Validation(Required=false)]
                public List<string> HealthCheckCodes { get; set; }
                [NameInMap("HealthCheckHttpVersion")]
                [Validation(Required=false)]
                public string HealthCheckHttpVersion { get; set; }
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }
                [NameInMap("HealthCheckMethod")]
                [Validation(Required=false)]
                public string HealthCheckMethod { get; set; }
                [NameInMap("HealthCheckPath")]
                [Validation(Required=false)]
                public string HealthCheckPath { get; set; }
                [NameInMap("HealthCheckProtocol")]
                [Validation(Required=false)]
                public string HealthCheckProtocol { get; set; }
                [NameInMap("HealthCheckTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckTimeout { get; set; }
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }
            };

            /// <summary>
            /// 服务器组协议
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// 资源组id
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// 调度策略
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            /// <summary>
            /// 服务器组Id
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// 服务器组名称
            /// </summary>
            [NameInMap("ServerGroupName")]
            [Validation(Required=false)]
            public string ServerGroupName { get; set; }

            /// <summary>
            /// 服务器组状态
            /// </summary>
            [NameInMap("ServerGroupStatus")]
            [Validation(Required=false)]
            public string ServerGroupStatus { get; set; }

            /// <summary>
            /// 会话保持配置
            /// </summary>
            [NameInMap("StickySessionConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsStickySessionConfig StickySessionConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsStickySessionConfig : TeaModel {
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }
                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }
                [NameInMap("StickySessionEnabled")]
                [Validation(Required=false)]
                public bool? StickySessionEnabled { get; set; }
                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }
            };

            /// <summary>
            /// 服务器组所在VpcId
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
