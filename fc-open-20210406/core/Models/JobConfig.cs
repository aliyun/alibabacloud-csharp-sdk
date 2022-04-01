// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class JobConfig : TeaModel {
        /// <summary>
        /// maxRetryTime
        /// </summary>
        [NameInMap("maxRetryTime")]
        [Validation(Required=false)]
        public long? MaxRetryTime { get; set; }

        /// <summary>
        /// triggerInterval
        /// </summary>
        [NameInMap("triggerInterval")]
        [Validation(Required=false)]
        public long? TriggerInterval { get; set; }

    }

}
