// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLLogContextLine : TeaModel {
        /// <summary>
        /// <para>The log text (&lt;= 2000 characters, with ANSI escape codes stripped).</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUDA out of memory. Tried to allocate 2.00 GiB</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The millisecond timestamp of the log line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787293208012</para>
        /// </summary>
        [NameInMap("TimestampMs")]
        [Validation(Required=false)]
        public long? TimestampMs { get; set; }

    }

}
