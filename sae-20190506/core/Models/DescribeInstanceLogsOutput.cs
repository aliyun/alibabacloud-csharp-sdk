// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeInstanceLogsOutput : TeaModel {
        /// <summary>
        /// <para>The log entries.</para>
        /// </summary>
        [NameInMap("WebLogEntrys")]
        [Validation(Required=false)]
        public List<WebLogEntry> WebLogEntrys { get; set; }

    }

}
