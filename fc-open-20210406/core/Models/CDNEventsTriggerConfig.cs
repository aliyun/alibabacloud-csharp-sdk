// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CDNEventsTriggerConfig : TeaModel {
        /// <summary>
        /// eventName
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// eventVersion
        /// </summary>
        [NameInMap("eventVersion")]
        [Validation(Required=false)]
        public string EventVersion { get; set; }

        /// <summary>
        /// filter
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> Filter { get; set; }

        /// <summary>
        /// notes
        /// </summary>
        [NameInMap("notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

    }

}
