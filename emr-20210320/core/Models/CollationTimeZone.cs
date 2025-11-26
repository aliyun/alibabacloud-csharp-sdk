// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class CollationTimeZone : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>UTC+08:00</para>
        /// </summary>
        [NameInMap("CurrentTimeOffset")]
        [Validation(Required=false)]
        public string CurrentTimeOffset { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
