// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class RedirectTaskRequest : TeaModel {
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("ByManager")]
        [Validation(Required=false)]
        public string ByManager { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("NowActionExecutorId")]
        [Validation(Required=false)]
        public string NowActionExecutorId { get; set; }

        [NameInMap("ProcessInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
