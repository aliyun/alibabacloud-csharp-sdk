// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class StopScannerTaskRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the scan task. This is the TaskId returned by CreateTargetScanTask or the ScannerTaskId returned by ListScanTasksByTarget. If the task does not exist or belongs to another tenant, a 400 error is returned without exposing whether the resource exists.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-abc123def4567</para>
        /// </summary>
        [NameInMap("ScannerTaskId")]
        [Validation(Required=false)]
        public string ScannerTaskId { get; set; }

    }

}
