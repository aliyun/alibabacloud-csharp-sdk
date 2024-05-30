// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCloudVendorRegionsResponseBody : TeaModel {
        /// <summary>
        /// The return code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The regions that the service provider supports.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCloudVendorRegionsResponseBodyData> Data { get; set; }
        public class ListCloudVendorRegionsResponseBodyData : TeaModel {
            /// <summary>
            /// The area to which the region belongs. The valid values vary based on the value of the Vendor parameter.
            /// 
            /// *   Valid values if **Vendor** is set to Tencent:
            /// *   **cn**: China
            /// *   **southeast_asia**: Southeast Asia Pacific
            /// *   **northeast_asia**: Northeast Asia Pacific
            /// *   **southern_asia**: South Asia Pacific
            /// *   **north_America**: North America
            /// *   **south_America**: South America
            /// *   **western_America**: Western United States
            /// *   **eastern_America**: Eastern United States
            /// *   **european**: Europe
            /// *   Valid values if **Vendor** is set to HUAWEICLOUD:
            /// *   **cn**: China
            /// *   **africa**: Africa
            /// *   **latin_america**: Latin America
            /// *   **asia**: Asia Pacific
            /// *   Valid values if **Vendor** is set to Azure:
            /// *   **middle_east**: Middle East
            /// *   **south_america**: South America
            /// *   **canada**: Canada
            /// *   **asia-pacific**: Asia Pacific
            /// *   **europe**: Europe
            /// *   **africa**: Africa
            /// *   **us**: United States
            /// *   **other**: other regions
            /// *   Valid values if **Vendor** is set to AWS:
            /// *   **cn**: China
            /// *   **us**: United States
            /// *   **eu**: Europe
            /// *   **asia**: Asia Pacific
            /// *   **south_america**: South America
            /// *   **me**: Middle East
            /// *   **ca**: Canada
            /// *   **af**: Africa
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// Indicates whether the region is configured as a synchronization region on another site. Valid values:
            /// 
            /// *   **0**: The region is not configured as a synchronization region on another site.
            /// *   **1**: The region is configured as a synchronization region on another site.
            /// </summary>
            [NameInMap("Disable")]
            [Validation(Required=false)]
            public int? Disable { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// Indicates whether the region is configured as a synchronization region on this site. Valid values:
            /// 
            /// *   **0**: The region is not configured as a synchronization region on this site.
            /// *   **1**: The region is configured as a synchronization region on this site.
            /// </summary>
            [NameInMap("Selected")]
            [Validation(Required=false)]
            public int? Selected { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
