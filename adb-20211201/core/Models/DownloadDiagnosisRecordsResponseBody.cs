// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DownloadDiagnosisRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The download ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25494</para>
        /// </summary>
        [NameInMap("DownloadId")]
        [Validation(Required=false)]
        public int? DownloadId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>845774AC-5D43-53A2-AAB8-C73828E68508</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
