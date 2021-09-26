// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20181029.Models
{
    public class DescribeAuditLogsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AuditLogs")]
        [Validation(Required=false)]
        public List<DescribeAuditLogsResponseBodyAuditLogs> AuditLogs { get; set; }
        public class DescribeAuditLogsResponseBodyAuditLogs : TeaModel {
            [NameInMap("ClientUser")]
            [Validation(Required=false)]
            public string ClientUser { get; set; }

            [NameInMap("EffectRow")]
            [Validation(Required=false)]
            public int? EffectRow { get; set; }

            [NameInMap("C5")]
            [Validation(Required=false)]
            public string C5 { get; set; }

            [NameInMap("ClientPrg")]
            [Validation(Required=false)]
            public string ClientPrg { get; set; }

            [NameInMap("Accessid")]
            [Validation(Required=false)]
            public string Accessid { get; set; }

            [NameInMap("ResultDesc")]
            [Validation(Required=false)]
            public string ResultDesc { get; set; }

            [NameInMap("SqlLen")]
            [Validation(Required=false)]
            public int? SqlLen { get; set; }

            [NameInMap("Payload")]
            [Validation(Required=false)]
            public string Payload { get; set; }

            [NameInMap("C4")]
            [Validation(Required=false)]
            public string C4 { get; set; }

            [NameInMap("DateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("DataSet")]
            [Validation(Required=false)]
            public string DataSet { get; set; }

            [NameInMap("Sqlid")]
            [Validation(Required=false)]
            public string Sqlid { get; set; }

            [NameInMap("RelateIp")]
            [Validation(Required=false)]
            public string RelateIp { get; set; }

            [NameInMap("AlarmLevel")]
            [Validation(Required=false)]
            public int? AlarmLevel { get; set; }

            [NameInMap("C2")]
            [Validation(Required=false)]
            public string C2 { get; set; }

            [NameInMap("Dip")]
            [Validation(Required=false)]
            public string Dip { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

            [NameInMap("Cost")]
            [Validation(Required=false)]
            public int? Cost { get; set; }

            [NameInMap("RelateUser")]
            [Validation(Required=false)]
            public string RelateUser { get; set; }

            [NameInMap("Sip")]
            [Validation(Required=false)]
            public string Sip { get; set; }

            [NameInMap("C3")]
            [Validation(Required=false)]
            public string C3 { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("AlarmName")]
            [Validation(Required=false)]
            public string AlarmName { get; set; }

            [NameInMap("PickIp")]
            [Validation(Required=false)]
            public string PickIp { get; set; }

            [NameInMap("RelateInfo")]
            [Validation(Required=false)]
            public string RelateInfo { get; set; }

            [NameInMap("PickUser")]
            [Validation(Required=false)]
            public string PickUser { get; set; }

            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            [NameInMap("Sport")]
            [Validation(Required=false)]
            public int? Sport { get; set; }

            [NameInMap("DataSetSize")]
            [Validation(Required=false)]
            public int? DataSetSize { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            [NameInMap("AlarmFlag")]
            [Validation(Required=false)]
            public int? AlarmFlag { get; set; }

            [NameInMap("Smac")]
            [Validation(Required=false)]
            public int? Smac { get; set; }

            [NameInMap("Dport")]
            [Validation(Required=false)]
            public int? Dport { get; set; }

            [NameInMap("C1")]
            [Validation(Required=false)]
            public string C1 { get; set; }

            [NameInMap("Dmac")]
            [Validation(Required=false)]
            public int? Dmac { get; set; }

            [NameInMap("LoginUser")]
            [Validation(Required=false)]
            public string LoginUser { get; set; }

            [NameInMap("Sessionid")]
            [Validation(Required=false)]
            public string Sessionid { get; set; }

        }

    }

}
