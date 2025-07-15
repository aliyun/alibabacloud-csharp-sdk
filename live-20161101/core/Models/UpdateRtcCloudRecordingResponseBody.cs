// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateRtcCloudRecordingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>58-5876-</b></b>-83CA-B56278</b>****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>73-8501-</b></b>-8ac1-72295a</b>****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
