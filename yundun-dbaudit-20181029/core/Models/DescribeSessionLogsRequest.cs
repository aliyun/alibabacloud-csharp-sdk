// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20181029.Models
{
    public class DescribeSessionLogsRequest : TeaModel {
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

        [NameInMap("Sip")]
        [Validation(Required=false)]
        public string Sip { get; set; }

        [NameInMap("Sport")]
        [Validation(Required=false)]
        public string Sport { get; set; }

        [NameInMap("LoginUser")]
        [Validation(Required=false)]
        public string LoginUser { get; set; }

        [NameInMap("Dip")]
        [Validation(Required=false)]
        public string Dip { get; set; }

        [NameInMap("Dport")]
        [Validation(Required=false)]
        public string Dport { get; set; }

        [NameInMap("Sessionid")]
        [Validation(Required=false)]
        public string Sessionid { get; set; }

        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("Smac")]
        [Validation(Required=false)]
        public string Smac { get; set; }

        [NameInMap("Dmac")]
        [Validation(Required=false)]
        public string Dmac { get; set; }

        [NameInMap("ClientPrg")]
        [Validation(Required=false)]
        public string ClientPrg { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("ClientUser")]
        [Validation(Required=false)]
        public string ClientUser { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("SessionStatus")]
        [Validation(Required=false)]
        public string SessionStatus { get; set; }

        [NameInMap("SqlCount")]
        [Validation(Required=false)]
        public string SqlCount { get; set; }

        [NameInMap("ReqFlow")]
        [Validation(Required=false)]
        public string ReqFlow { get; set; }

        [NameInMap("RspFlow")]
        [Validation(Required=false)]
        public string RspFlow { get; set; }

    }

}
