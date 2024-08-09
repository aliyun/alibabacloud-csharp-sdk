// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StopJobRequest : TeaModel {
        /// <summary>
        /// The parameter that is used to stop the job.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public StopJobRequestBody Body { get; set; }

    }

}
