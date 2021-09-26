// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetSessionListResponseBody : TeaModel {
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BeginDate")]
        [Validation(Required=false)]
        public string BeginDate { get; set; }

        [NameInMap("Incomplete")]
        [Validation(Required=false)]
        public string Incomplete { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<GetSessionListResponseBodyResults> Results { get; set; }
        public class GetSessionListResponseBodyResults : TeaModel {
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            [NameInMap("LoginCode")]
            [Validation(Required=false)]
            public int? LoginCode { get; set; }

            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public int? ClientPort { get; set; }

            [NameInMap("LoginMessage")]
            [Validation(Required=false)]
            public string LoginMessage { get; set; }

            [NameInMap("DbUser")]
            [Validation(Required=false)]
            public string DbUser { get; set; }

            [NameInMap("ServerPort")]
            [Validation(Required=false)]
            public int? ServerPort { get; set; }

            [NameInMap("ClientOsUser")]
            [Validation(Required=false)]
            public string ClientOsUser { get; set; }

            [NameInMap("ServerMac")]
            [Validation(Required=false)]
            public string ServerMac { get; set; }

            [NameInMap("ClientProgram")]
            [Validation(Required=false)]
            public string ClientProgram { get; set; }

            [NameInMap("CaptureTime")]
            [Validation(Required=false)]
            public string CaptureTime { get; set; }

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

}
