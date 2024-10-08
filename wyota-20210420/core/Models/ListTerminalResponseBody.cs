// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListTerminalResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTerminalResponseBodyData> Data { get; set; }
        public class ListTerminalResponseBodyData : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("BindUserCount")]
            [Validation(Required=false)]
            public int? BindUserCount { get; set; }

            [NameInMap("BindUserId")]
            [Validation(Required=false)]
            public string BindUserId { get; set; }

            [NameInMap("BuildId")]
            [Validation(Required=false)]
            public string BuildId { get; set; }

            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public int? ClientType { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("InManage")]
            [Validation(Required=false)]
            public bool? InManage { get; set; }

            [NameInMap("Ipv4")]
            [Validation(Required=false)]
            public string Ipv4 { get; set; }

            /// <term><b>Obsolete</b></term>
            [NameInMap("LastLoginUser")]
            [Validation(Required=false)]
            [Obsolete]
            public string LastLoginUser { get; set; }

            [NameInMap("LocationInfo")]
            [Validation(Required=false)]
            public string LocationInfo { get; set; }

            [NameInMap("LockSettings")]
            [Validation(Required=false)]
            public bool? LockSettings { get; set; }

            [NameInMap("LoginUser")]
            [Validation(Required=false)]
            public string LoginUser { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("OnlineStatus")]
            [Validation(Required=false)]
            public bool? OnlineStatus { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("TerminalGroupId")]
            [Validation(Required=false)]
            public string TerminalGroupId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
