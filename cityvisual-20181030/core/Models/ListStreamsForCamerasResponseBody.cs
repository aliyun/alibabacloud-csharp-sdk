// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class ListStreamsForCamerasResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Streams")]
        [Validation(Required=false)]
        public ListStreamsForCamerasResponseBodyStreams Streams { get; set; }
        public class ListStreamsForCamerasResponseBodyStreams : TeaModel {
            [NameInMap("Stream")]
            [Validation(Required=false)]
            public List<string> Stream { get; set; }
        };

    }

}
