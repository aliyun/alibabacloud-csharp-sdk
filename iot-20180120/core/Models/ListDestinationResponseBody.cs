// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDestinationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Destinations")]
        [Validation(Required=false)]
        public ListDestinationResponseBodyDestinations Destinations { get; set; }
        public class ListDestinationResponseBodyDestinations : TeaModel {
            [NameInMap("destinations")]
            [Validation(Required=false)]
            public List<ListDestinationResponseBodyDestinationsDestinations> Destinations { get; set; }
            public class ListDestinationResponseBodyDestinationsDestinations : TeaModel {
                public string Configuration { get; set; }
                public string Description { get; set; }
                public long? DestinationId { get; set; }
                public bool? IsFailover { get; set; }
                public string Name { get; set; }
                public string Type { get; set; }
                public string UtcCreated { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
