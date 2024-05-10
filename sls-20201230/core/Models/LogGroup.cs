// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogGroup : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LogTags")]
        [Validation(Required=false)]
        public List<LogTag> LogTags { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<LogItem> Logs { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
