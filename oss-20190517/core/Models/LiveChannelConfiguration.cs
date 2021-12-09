// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LiveChannelConfiguration : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Snapshot")]
        [Validation(Required=false)]
        public LiveChannelSnapshot Snapshot { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Target")]
        [Validation(Required=false)]
        public LiveChannelTarget Target { get; set; }

    }

}
