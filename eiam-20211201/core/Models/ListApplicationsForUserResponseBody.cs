// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationsForUserResponseBody : TeaModel {
        /// <summary>
        /// The applications that the EIAM account can access.
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListApplicationsForUserResponseBodyApplications> Applications { get; set; }
        public class ListApplicationsForUserResponseBodyApplications : TeaModel {
            /// <summary>
            /// The ID of the application that the EIAM account can access.
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// Indicates whether the EIAM account has direct permissions on the application. Valid values:
            /// 
            /// *   true: The EIAM account has direct permissions on the application.
            /// *   false: The EIAM account does not have direct permissions on the application.
            /// </summary>
            [NameInMap("HasDirectAuthorization")]
            [Validation(Required=false)]
            public bool? HasDirectAuthorization { get; set; }

            /// <summary>
            /// Indicates whether the EIAM account has inherited permissions on the application. Valid values:
            /// 
            /// *   true: A parent organization or an organization to which the EIAM account belongs has direct permissions on the application.
            /// *   false: A parent organization or an organization to which the EIAM account belongs does not have direct permissions on the application.
            /// </summary>
            [NameInMap("HasInheritAuthorization")]
            [Validation(Required=false)]
            public bool? HasInheritAuthorization { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
