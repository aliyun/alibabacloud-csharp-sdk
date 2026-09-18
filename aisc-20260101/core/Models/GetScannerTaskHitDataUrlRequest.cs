// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class GetScannerTaskHitDataUrlRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the scan task. This is the TaskId returned by CreateTargetScanTask or the ScannerTaskId returned by ListScanTasksByTarget. This parameter is registered as optional but is required in practice. An empty value returns HTTP status code 400. If the task does not exist or belongs to another tenant, HTTP status code 400 is returned uniformly to avoid exposing whether the resource exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-abc123def4567</para>
        /// </summary>
        [NameInMap("ScannerTaskId")]
        [Validation(Required=false)]
        public string ScannerTaskId { get; set; }

    }

}
