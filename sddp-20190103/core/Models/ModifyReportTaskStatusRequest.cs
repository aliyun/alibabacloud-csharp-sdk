// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyReportTaskStatusRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Default value: **zh_cn**. Valid values:
        /// 
        /// *   **zh_cn**: Simplified Chinese
        /// *   **en_us**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Specifies the status of the report task. Valid values:
        /// 
        /// *   **0**: disabled
        /// *   **1**: enabled
        /// 
        /// > This parameter is required.
        /// </summary>
        [NameInMap("ReportTaskStatus")]
        [Validation(Required=false)]
        public int? ReportTaskStatus { get; set; }

    }

}
