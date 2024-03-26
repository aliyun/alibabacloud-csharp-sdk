// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ReportTaskSucceededRequest : TeaModel {
        /// <summary>
        /// The output information of the task whose execution success you want to report.
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// The token of the task whose execution success you want to report. If this parameter appears in **waitforCallback** mode, the parameter is passed to the called service, such as Message Service (MNS) or Function Compute. For MNS, the value of this parameter can be obtained from the message. For Function Compute, the value of this parameter can be obtained from the event.
        /// </summary>
        [NameInMap("TaskToken")]
        [Validation(Required=false)]
        public string TaskToken { get; set; }

    }

}
