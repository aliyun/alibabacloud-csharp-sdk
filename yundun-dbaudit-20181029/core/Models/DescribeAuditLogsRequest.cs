// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20181029.Models
{
    public class DescribeAuditLogsRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("Dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public string DbId { get; set; }

        [NameInMap("QueryString")]
        [Validation(Required=false)]
        public string QueryString { get; set; }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        [NameInMap("LoginUser")]
        [Validation(Required=false)]
        public string LoginUser { get; set; }

        [NameInMap("OpType")]
        [Validation(Required=false)]
        public string OpType { get; set; }

        [NameInMap("Sip")]
        [Validation(Required=false)]
        public string Sip { get; set; }

        [NameInMap("Dip")]
        [Validation(Required=false)]
        public string Dip { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        [NameInMap("Accessid")]
        [Validation(Required=false)]
        public string Accessid { get; set; }

        [NameInMap("Sessionid")]
        [Validation(Required=false)]
        public string Sessionid { get; set; }

        [NameInMap("Sqlid")]
        [Validation(Required=false)]
        public string Sqlid { get; set; }

        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("Sport")]
        [Validation(Required=false)]
        public string Sport { get; set; }

        [NameInMap("Dport")]
        [Validation(Required=false)]
        public string Dport { get; set; }

        [NameInMap("Smac")]
        [Validation(Required=false)]
        public string Smac { get; set; }

        [NameInMap("Dmac")]
        [Validation(Required=false)]
        public string Dmac { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("ClientPrg")]
        [Validation(Required=false)]
        public string ClientPrg { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("ClientUser")]
        [Validation(Required=false)]
        public string ClientUser { get; set; }

        [NameInMap("SqlLen")]
        [Validation(Required=false)]
        public string SqlLen { get; set; }

        [NameInMap("EffectRow")]
        [Validation(Required=false)]
        public string EffectRow { get; set; }

        [NameInMap("Cost")]
        [Validation(Required=false)]
        public string Cost { get; set; }

        [NameInMap("ResultDesc")]
        [Validation(Required=false)]
        public string ResultDesc { get; set; }

        [NameInMap("DataSet")]
        [Validation(Required=false)]
        public string DataSet { get; set; }

        [NameInMap("AlarmName")]
        [Validation(Required=false)]
        public string AlarmName { get; set; }

        [NameInMap("AlarmLevel")]
        [Validation(Required=false)]
        public string AlarmLevel { get; set; }

    }

}
