// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// The information about applications.
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// The application name.
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// The status of the application operation.
            /// </summary>
            [NameInMap("ApplicationState")]
            [Validation(Required=false)]
            public string ApplicationState { get; set; }

            /// <summary>
            /// The version of the application.
            /// </summary>
            [NameInMap("ApplicationVersion")]
            [Validation(Required=false)]
            [Obsolete]
            public string ApplicationVersion { get; set; }

            /// <summary>
            /// The community edition.
            /// </summary>
            [NameInMap("CommunityVersion")]
            [Validation(Required=false)]
            public string CommunityVersion { get; set; }

        }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The page number of the next page returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
