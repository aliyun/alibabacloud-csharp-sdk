// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDestinationResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data destinations.
        /// </summary>
        [NameInMap("Destinations")]
        [Validation(Required=false)]
        public ListDestinationResponseBodyDestinations Destinations { get; set; }
        public class ListDestinationResponseBodyDestinations : TeaModel {
            [NameInMap("destinations")]
            [Validation(Required=false)]
            public List<ListDestinationResponseBodyDestinationsDestinations> Destinations { get; set; }
            public class ListDestinationResponseBodyDestinationsDestinations : TeaModel {
                /// <summary>
                /// The configuration data of the data destination.
                /// </summary>
                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public string Configuration { get; set; }

                /// <summary>
                /// The description of the data destination.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the data destination.
                /// </summary>
                [NameInMap("DestinationId")]
                [Validation(Required=false)]
                public long? DestinationId { get; set; }

                /// <summary>
                /// Indicates whether the data destination is configured to receive error operation data. Error operation data is the data that failed to be forwarded for two consecutive times.
                /// 
                /// *   **true**: The data destination is configured to receive error operation data.
                /// *   **false**: The data destination is configured to receive regular data instead of error operation data.
                /// 
                /// Default value: **false**.
                /// </summary>
                [NameInMap("IsFailover")]
                [Validation(Required=false)]
                public bool? IsFailover { get; set; }

                /// <summary>
                /// The name of the data destination.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The action of forwarding data to the data destination.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The time when the data destination was created. The time is displayed in UTC. The time follows the ISO 8601 standard in the `yyyy-MM-dd\"T\"HH:mm:ss.SSS\"Z\"` format.
                /// </summary>
                [NameInMap("UtcCreated")]
                [Validation(Required=false)]
                public string UtcCreated { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
