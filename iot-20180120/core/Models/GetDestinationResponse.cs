// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetDestinationResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=true)]
        public GetDestinationResponseDestination Destination { get; set; }
        public class GetDestinationResponseDestination : TeaModel {
            [NameInMap("Configuration")]
            [Validation(Required=true)]
            public string Configuration { get; set; }

            [NameInMap("DestinationId")]
            [Validation(Required=true)]
            public string DestinationId { get; set; }

            [NameInMap("IsFailover")]
            [Validation(Required=true)]
            public bool? IsFailover { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=true)]
            public string Type { get; set; }

            [NameInMap("UtcCreated")]
            [Validation(Required=true)]
            public string UtcCreated { get; set; }

        }

    }

}
