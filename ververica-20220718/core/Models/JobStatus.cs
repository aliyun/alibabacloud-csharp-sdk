// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobStatus : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("currentJobStatus")]
        [Validation(Required=false)]
        public string CurrentJobStatus { get; set; }

        [NameInMap("failure")]
        [Validation(Required=false)]
        public JobFailure Failure { get; set; }

        [NameInMap("running")]
        [Validation(Required=false)]
        public JobStatusRunning Running { get; set; }

    }

}
