// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetSessionDetailResponseBody : TeaModel {
        [NameInMap("LoginTime")]
        [Validation(Required=false)]
        public string LoginTime { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        [NameInMap("LoginCode")]
        [Validation(Required=false)]
        public int? LoginCode { get; set; }

        [NameInMap("ClientPort")]
        [Validation(Required=false)]
        public int? ClientPort { get; set; }

        [NameInMap("LoginMessage")]
        [Validation(Required=false)]
        public string LoginMessage { get; set; }

        [NameInMap("DbUser")]
        [Validation(Required=false)]
        public string DbUser { get; set; }

        [NameInMap("LogoutTime")]
        [Validation(Required=false)]
        public string LogoutTime { get; set; }

        [NameInMap("ServerPort")]
        [Validation(Required=false)]
        public int? ServerPort { get; set; }

        [NameInMap("ClientOsUser")]
        [Validation(Required=false)]
        public string ClientOsUser { get; set; }

        [NameInMap("ServerMac")]
        [Validation(Required=false)]
        public string ServerMac { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClientProgram")]
        [Validation(Required=false)]
        public string ClientProgram { get; set; }

        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        [NameInMap("ServerIp")]
        [Validation(Required=false)]
        public string ServerIp { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("ClientMac")]
        [Validation(Required=false)]
        public string ClientMac { get; set; }

    }

}
