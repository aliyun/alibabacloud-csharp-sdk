// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetUpgradeStatusResponseBody : TeaModel {
        /// <summary>
        /// 错误信息描述。
        /// </summary>
        [NameInMap("error_message")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 预检查返回ID。
        /// </summary>
        [NameInMap("precheck_report_id")]
        [Validation(Required=false)]
        public string PrecheckReportId { get; set; }

        /// <summary>
        /// 升级状态。
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 升级任务执行到哪一步了。
        /// </summary>
        [NameInMap("upgrade_step")]
        [Validation(Required=false)]
        public string UpgradeStep { get; set; }

        /// <summary>
        /// 升级任务详情。
        /// </summary>
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
