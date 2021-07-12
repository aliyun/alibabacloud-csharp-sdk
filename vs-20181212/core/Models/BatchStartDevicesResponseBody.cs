// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchStartDevicesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<BatchStartDevicesResponseBodyResults> Results { get; set; }
        public class BatchStartDevicesResponseBodyResults : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Streams")]
            [Validation(Required=false)]
            public List<BatchStartDevicesResponseBodyResultsStreams> Streams { get; set; }
            public class BatchStartDevicesResponseBodyResultsStreams : TeaModel {
                [NameInMap("Error")]
                [Validation(Required=false)]
                public string Error { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

        }

    }

}
