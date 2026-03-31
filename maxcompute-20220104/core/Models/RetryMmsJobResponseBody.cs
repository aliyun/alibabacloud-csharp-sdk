// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class RetryMmsJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>78</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public long? Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7F5DAD1C-9EC2-5FE5-97CF-BCE21B4ABA29</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
