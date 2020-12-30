// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class DetachStreamRequest : TeaModel {
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Streams")]
        [Validation(Required=false)]
        public List<DetachStreamRequestStreams> Streams { get; set; }
        public class DetachStreamRequestStreams : TeaModel {
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

        }

    }

}
