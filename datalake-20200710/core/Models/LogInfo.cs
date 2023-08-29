// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class LogInfo : TeaModel {
        [NameInMap("BizTime")]
        [Validation(Required=false)]
        public string BizTime { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LogContent")]
        [Validation(Required=false)]
        public string LogContent { get; set; }

        [NameInMap("LogId")]
        [Validation(Required=false)]
        public string LogId { get; set; }

        [NameInMap("LogSummary")]
        [Validation(Required=false)]
        public string LogSummary { get; set; }

        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

    }

}
