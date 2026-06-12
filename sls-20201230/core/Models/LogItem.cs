// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogItem : TeaModel {
        /// <summary>
        /// <para>A list of log fields.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<LogContent> Contents { get; set; }

        /// <summary>
        /// <para>The time of the log, formatted as a Unix timestamp. It represents the number of seconds that have elapsed since 00:00:00 UTC on January 1, 1970.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1690254376</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public int? Time { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("TimeNs")]
        [Validation(Required=false)]
        public int? TimeNs { get; set; }

    }

}
