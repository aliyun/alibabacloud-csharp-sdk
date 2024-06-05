// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_dg20230914.Models
{
    public class GetUserGatewayInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("GatewayInstanceList")]
        [Validation(Required=false)]
        public List<GetUserGatewayInstancesResponseBodyGatewayInstanceList> GatewayInstanceList { get; set; }
        public class GetUserGatewayInstancesResponseBodyGatewayInstanceList : TeaModel {
            /// <summary>
            /// 连接类型
            /// </summary>
            [NameInMap("ConnectEndpointType")]
            [Validation(Required=false)]
            public string ConnectEndpointType { get; set; }

            /// <summary>
            /// 进程的版本号
            /// </summary>
            [NameInMap("CurrentDaemonVersion")]
            [Validation(Required=false)]
            public string CurrentDaemonVersion { get; set; }

            /// <summary>
            /// 版本号
            /// </summary>
            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// 端点地址
            /// </summary>
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            /// <summary>
            /// 网关ID
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// 代表资源一级ID的资源属性字段
            /// </summary>
            [NameInMap("GatewayInstanceId")]
            [Validation(Required=false)]
            public string GatewayInstanceId { get; set; }

            [NameInMap("GatewayInstanceStatus")]
            [Validation(Required=false)]
            public string GatewayInstanceStatus { get; set; }

            /// <summary>
            /// 上次更新时间戳
            /// </summary>
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            /// <summary>
            /// 本地IP地址
            /// </summary>
            [NameInMap("LocalIP")]
            [Validation(Required=false)]
            public string LocalIP { get; set; }

            /// <summary>
            /// 提示信息
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// 主机
            /// </summary>
            [NameInMap("OutputIP")]
            [Validation(Required=false)]
            public string OutputIP { get; set; }

            /// <summary>
            /// 代表region的资源属性字段
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
