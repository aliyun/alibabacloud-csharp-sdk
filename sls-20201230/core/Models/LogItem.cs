// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogItem : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<LogContent> Contents { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public int? Time { get; set; }

    }

}
