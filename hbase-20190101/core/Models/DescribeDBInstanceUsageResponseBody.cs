// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeDBInstanceUsageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A2D841CE-D066-53E8-B9AC-3731DCC85397</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;disk_usage_record\&quot;:{\&quot;disk_used\&quot;:\&quot;0.9GB\&quot;,\&quot;disk_total\&quot;:\&quot;1156.1GB\&quot;,\&quot;usage_rate\&quot;:\&quot;1%\&quot;}}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

    }

}
