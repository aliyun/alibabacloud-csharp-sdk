// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetPerRequestLogsInput : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("errorType")]
        [Validation(Required=false)]
        public string ErrorType { get; set; }

        [NameInMap("forwardLine")]
        [Validation(Required=false)]
        public long? ForwardLine { get; set; }

        [NameInMap("instanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

        [NameInMap("isColdStart")]
        [Validation(Required=false)]
        public bool? IsColdStart { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("requestID")]
        [Validation(Required=false)]
        public string RequestID { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

    }

}
