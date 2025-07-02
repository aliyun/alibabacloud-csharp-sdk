// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListUnbindDevicesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUnbindDevicesResponseBodyData Data { get; set; }
        public class ListUnbindDevicesResponseBodyData : TeaModel {
            [NameInMap("Devices")]
            [Validation(Required=false)]
            public List<ListUnbindDevicesResponseBodyDataDevices> Devices { get; set; }
            public class ListUnbindDevicesResponseBodyDataDevices : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                [NameInMap("BuildId")]
                [Validation(Required=false)]
                public string BuildId { get; set; }

                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                [NameInMap("ConnectionStatus")]
                [Validation(Required=false)]
                public string ConnectionStatus { get; set; }

                [NameInMap("DeviceMqttConnectionStatus")]
                [Validation(Required=false)]
                public int? DeviceMqttConnectionStatus { get; set; }

                [NameInMap("DeviceOs")]
                [Validation(Required=false)]
                public string DeviceOs { get; set; }

                [NameInMap("DevicePlatform")]
                [Validation(Required=false)]
                public string DevicePlatform { get; set; }

                [NameInMap("InManage")]
                [Validation(Required=false)]
                public bool? InManage { get; set; }

                [NameInMap("LastLoginTime")]
                [Validation(Required=false)]
                public string LastLoginTime { get; set; }

                [NameInMap("LastLoginUser")]
                [Validation(Required=false)]
                public string LastLoginUser { get; set; }

                [NameInMap("LoginUser")]
                [Validation(Required=false)]
                public string LoginUser { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("PasswordFreeLoginUser")]
                [Validation(Required=false)]
                public string PasswordFreeLoginUser { get; set; }

                [NameInMap("PasswordFreeLoginUserNickName")]
                [Validation(Required=false)]
                public string PasswordFreeLoginUserNickName { get; set; }

                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

                [NameInMap("SerialNo")]
                [Validation(Required=false)]
                public string SerialNo { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
