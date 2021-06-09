// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateServerGroupServersAttributeRequest : TeaModel {
        /// <summary>
        /// 后端服务器Id
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// 后端服务器
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public List<UpdateServerGroupServersAttributeRequestServers> Servers { get; set; }
        public class UpdateServerGroupServersAttributeRequestServers : TeaModel {
            /// <summary>
            /// 后端服务器描述
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 后端端口号
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// 后端服务器id
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// 后端服务器ip
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
            /// 后端服务器权重
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// 幂等Token
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// dryRun
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
