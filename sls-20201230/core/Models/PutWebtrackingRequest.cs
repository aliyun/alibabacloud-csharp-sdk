// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PutWebtrackingRequest : TeaModel {
        /// <summary>
        /// The logs. Each element is a JSON object that indicates a log.
        /// 
        /// >  **Note**: The time in a log that is collected by using the web tracking feature is the time at which Simple Log Service receives the log. You do not need to configure the \__time\_\_ field for each log. If this field exists, it is overwritten by the time at which Simple Log Service receives the log.
        /// </summary>
        [NameInMap("__logs__")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Logs { get; set; }

        /// <summary>
        /// The source of the logs.
        /// </summary>
        [NameInMap("__source__")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The tags of the logs.
        /// </summary>
        [NameInMap("__tags__")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// The topic of the logs.
        /// </summary>
        [NameInMap("__topic__")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
