// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetUpgradeStatusResponseBody : TeaModel {
        [NameInMap("error_message")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("precheck_report_id")]
        [Validation(Required=false)]
        public string PrecheckReportId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("upgrade_step")]
        [Validation(Required=false)]
        public string UpgradeStep { get; set; }

        [NameInMap("upgrade_task")]
        [Validation(Required=false)]
        public GetUpgradeStatusResponseBodyUpgradeTask UpgradeTask { get; set; }
        public class GetUpgradeStatusResponseBodyUpgradeTask : TeaModel {
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

    }

}
