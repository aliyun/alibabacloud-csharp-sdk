// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDestinationResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Page")]
        [Validation(Required=true)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Destinations")]
        [Validation(Required=true)]
        public ListDestinationResponseDestinations Destinations { get; set; }
        public class ListDestinationResponseDestinations : TeaModel {
            [NameInMap("destinations")]
            [Validation(Required=true)]
            public List<ListDestinationResponseDestinationsDestinations> Destinations { get; set; }
            public class ListDestinationResponseDestinationsDestinations : TeaModel {
                [NameInMap("Configuration")]
                [Validation(Required=true)]
                public string Configuration { get; set; }

                [NameInMap("Description")]
                [Validation(Required=true)]
                public string Description { get; set; }

                [NameInMap("DestinationId")]
                [Validation(Required=true)]
                public long? DestinationId { get; set; }

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

}
