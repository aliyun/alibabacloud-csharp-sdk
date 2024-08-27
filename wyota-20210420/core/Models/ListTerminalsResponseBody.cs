// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListTerminalsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTerminalsResponseBodyData> Data { get; set; }
        public class ListTerminalsResponseBodyData : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("BuildId")]
            [Validation(Required=false)]
            public string BuildId { get; set; }

            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public int? ClientType { get; set; }

            [NameInMap("CurrentConnectDesktop")]
            [Validation(Required=false)]
            public string CurrentConnectDesktop { get; set; }

            [NameInMap("CurrentLoginUser")]
            [Validation(Required=false)]
            public string CurrentLoginUser { get; set; }

            [NameInMap("Ipv4")]
            [Validation(Required=false)]
            public string Ipv4 { get; set; }

            [NameInMap("LocationInfo")]
            [Validation(Required=false)]
            public string LocationInfo { get; set; }

            [NameInMap("ManageTime")]
            [Validation(Required=false)]
            public string ManageTime { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            [NameInMap("PasswordFreeLoginUser")]
            [Validation(Required=false)]
            public string PasswordFreeLoginUser { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("SetPasswordFreeLoginUserTime")]
            [Validation(Required=false)]
            public string SetPasswordFreeLoginUserTime { get; set; }

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
