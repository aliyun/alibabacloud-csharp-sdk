// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeRoutineSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The specification of the CPU time slice. Valid values: 5 ms, 50 ms, and 100 ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ms, 50ms, 100ms</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE4E1B80-D5F3-47DB-824A-DA98A21854C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
