// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListParserDestinationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListParserDestinationResponseBodyData Data { get; set; }
        public class ListParserDestinationResponseBodyData : TeaModel {
            [NameInMap("destinations")]
            [Validation(Required=false)]
            public List<ListParserDestinationResponseBodyDataDestinations> Destinations { get; set; }
            public class ListParserDestinationResponseBodyDataDestinations : TeaModel {
                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public string Configuration { get; set; }

                [NameInMap("DestinationId")]
                [Validation(Required=false)]
                public long? DestinationId { get; set; }

                [NameInMap("IsFailover")]
                [Validation(Required=false)]
                public bool? IsFailover { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UtcCreated")]
                [Validation(Required=false)]
                public string UtcCreated { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
