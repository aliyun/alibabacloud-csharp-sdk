// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LiveRecord : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("RemoteAddr")]
        [Validation(Required=false)]
        public string RemoteAddr { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
