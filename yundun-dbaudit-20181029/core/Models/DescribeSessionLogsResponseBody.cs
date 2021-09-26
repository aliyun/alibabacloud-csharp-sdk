// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20181029.Models
{
    public class DescribeSessionLogsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SessionLogs")]
        [Validation(Required=false)]
        public List<DescribeSessionLogsResponseBodySessionLogs> SessionLogs { get; set; }
        public class DescribeSessionLogsResponseBodySessionLogs : TeaModel {
            [NameInMap("ClientUser")]
            [Validation(Required=false)]
            public string ClientUser { get; set; }

            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public int? SessionStatus { get; set; }

            [NameInMap("C5")]
            [Validation(Required=false)]
            public string C5 { get; set; }

            [NameInMap("ClientPrg")]
            [Validation(Required=false)]
            public string ClientPrg { get; set; }

            [NameInMap("Accessid")]
            [Validation(Required=false)]
            public string Accessid { get; set; }

            [NameInMap("C4")]
            [Validation(Required=false)]
            public string C4 { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("RequestFlow")]
            [Validation(Required=false)]
            public int? RequestFlow { get; set; }

            [NameInMap("ProCon")]
            [Validation(Required=false)]
            public int? ProCon { get; set; }

            [NameInMap("C2")]
            [Validation(Required=false)]
            public string C2 { get; set; }

            [NameInMap("Dip")]
            [Validation(Required=false)]
            public string Dip { get; set; }

            [NameInMap("Sip")]
            [Validation(Required=false)]
            public string Sip { get; set; }

            [NameInMap("C3")]
            [Validation(Required=false)]
            public string C3 { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("ResponseFlow")]
            [Validation(Required=false)]
            public int? ResponseFlow { get; set; }

            [NameInMap("Encode")]
            [Validation(Required=false)]
            public string Encode { get; set; }

            [NameInMap("NormalEnd")]
            [Validation(Required=false)]
            public int? NormalEnd { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            [NameInMap("Sport")]
            [Validation(Required=false)]
            public int? Sport { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            [NameInMap("StrInfo")]
            [Validation(Required=false)]
            public string StrInfo { get; set; }

            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public int? SqlCount { get; set; }

            [NameInMap("Smac")]
            [Validation(Required=false)]
            public int? Smac { get; set; }

            [NameInMap("Dport")]
            [Validation(Required=false)]
            public int? Dport { get; set; }

            [NameInMap("Dmac")]
            [Validation(Required=false)]
            public int? Dmac { get; set; }

            [NameInMap("C1")]
            [Validation(Required=false)]
            public string C1 { get; set; }

            [NameInMap("LoginUser")]
            [Validation(Required=false)]
            public string LoginUser { get; set; }

            [NameInMap("Sessionid")]
            [Validation(Required=false)]
            public string Sessionid { get; set; }

        }

    }

}
