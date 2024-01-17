// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ExecuteBatchTaskRequest : TeaModel {
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("OutResult")]
        [Validation(Required=false)]
        public string OutResult { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        [NameInMap("TaskInformationList")]
        [Validation(Required=false)]
        public string TaskInformationList { get; set; }

    }

}
