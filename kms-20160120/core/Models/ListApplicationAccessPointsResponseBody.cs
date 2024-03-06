// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListApplicationAccessPointsResponseBody : TeaModel {
        /// <summary>
        /// A list of AAPs.
        /// </summary>
        [NameInMap("ApplicationAccessPoints")]
        [Validation(Required=false)]
        public ListApplicationAccessPointsResponseBodyApplicationAccessPoints ApplicationAccessPoints { get; set; }
        public class ListApplicationAccessPointsResponseBodyApplicationAccessPoints : TeaModel {
            [NameInMap("ApplicationAccessPoint")]
            [Validation(Required=false)]
            public List<ListApplicationAccessPointsResponseBodyApplicationAccessPointsApplicationAccessPoint> ApplicationAccessPoint { get; set; }
            public class ListApplicationAccessPointsResponseBodyApplicationAccessPointsApplicationAccessPoint : TeaModel {
                /// <summary>
                /// The authentication method.
                /// </summary>
                [NameInMap("AuthenticationMethod")]
                [Validation(Required=false)]
                public string AuthenticationMethod { get; set; }

                /// <summary>
                /// The name of the AAP.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
