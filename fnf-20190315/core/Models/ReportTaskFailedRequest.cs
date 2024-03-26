// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ReportTaskFailedRequest : TeaModel {
        /// <summary>
        /// The cause of the failure. The value must be 1 to 4,096 characters in length.
        /// </summary>
        [NameInMap("Cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        /// <summary>
        /// The error code for the failed task. The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// The token of the specified task that you want to report. If this parameter appears in **waitforCallback** mode, the parameter is passed to the called service, such as Message Service (MNS) or Function Compute. For MNS, the value of this parameter can be obtained from a message. For Function Compute, the value of this parameter can be obtained from an event.
        /// </summary>
        [NameInMap("TaskToken")]
        [Validation(Required=false)]
        public string TaskToken { get; set; }

    }

}
