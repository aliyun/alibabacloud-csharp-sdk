// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobFailure : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1660120062</para>
        /// </summary>
        [NameInMap("failedAt")]
        [Validation(Required=false)]
        public long? FailedAt { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
