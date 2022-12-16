// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryBusinessLocationsResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryBusinessLocationsResponseBodyData> Data { get; set; }
        public class QueryBusinessLocationsResponseBodyData : TeaModel {
            /// <summary>
            /// The Chinese name of the region.
            /// </summary>
            [NameInMap("CnName")]
            [Validation(Required=false)]
            public string CnName { get; set; }

            /// <summary>
            /// The description of the region.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The Chinese name of the district.
            /// </summary>
            [NameInMap("DistrictCnName")]
            [Validation(Required=false)]
            public string DistrictCnName { get; set; }

            /// <summary>
            /// The English name of the district.
            /// </summary>
            [NameInMap("DistrictEnName")]
            [Validation(Required=false)]
            public string DistrictEnName { get; set; }

            /// <summary>
            /// The ID of the district.
            /// </summary>
            [NameInMap("DistrictId")]
            [Validation(Required=false)]
            public string DistrictId { get; set; }

            /// <summary>
            /// The ordering information of the district.
            /// </summary>
            [NameInMap("DistrictOrdering")]
            [Validation(Required=false)]
            public int? DistrictOrdering { get; set; }

            /// <summary>
            /// The display name of the district.
            /// </summary>
            [NameInMap("DistrictShowName")]
            [Validation(Required=false)]
            public string DistrictShowName { get; set; }

            /// <summary>
            /// The complete description of the region.
            /// </summary>
            [NameInMap("EnDescription")]
            [Validation(Required=false)]
            public string EnDescription { get; set; }

            /// <summary>
            /// The English name of the region.
            /// </summary>
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ordering information.
            /// </summary>
            [NameInMap("Ordering")]
            [Validation(Required=false)]
            public int? Ordering { get; set; }

            /// <summary>
            /// The display name of the region.
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// The type of the data.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
