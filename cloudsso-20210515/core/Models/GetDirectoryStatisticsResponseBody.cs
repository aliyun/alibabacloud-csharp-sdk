// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetDirectoryStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The statistics of the directory.
        /// </summary>
        [NameInMap("DirectoryStatistics")]
        [Validation(Required=false)]
        public GetDirectoryStatisticsResponseBodyDirectoryStatistics DirectoryStatistics { get; set; }
        public class GetDirectoryStatisticsResponseBodyDirectoryStatistics : TeaModel {
            /// <summary>
            /// The number of access permissions that are assigned.
            /// </summary>
            [NameInMap("AccessAssignmentCount")]
            [Validation(Required=false)]
            public int? AccessAssignmentCount { get; set; }

            /// <summary>
            /// The number of access configurations.
            /// </summary>
            [NameInMap("AccessConfigurationCount")]
            [Validation(Required=false)]
            public int? AccessConfigurationCount { get; set; }

            /// <summary>
            /// The quota for access configurations.
            /// </summary>
            [NameInMap("AccessConfigurationQuota")]
            [Validation(Required=false)]
            public int? AccessConfigurationQuota { get; set; }

            /// <summary>
            /// The ID of the directory.
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// The name of the directory.
            /// </summary>
            [NameInMap("DirectoryName")]
            [Validation(Required=false)]
            public string DirectoryName { get; set; }

            /// <summary>
            /// The number of groups.
            /// </summary>
            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public int? GroupCount { get; set; }

            /// <summary>
            /// The quota for groups.
            /// </summary>
            [NameInMap("GroupQuota")]
            [Validation(Required=false)]
            public int? GroupQuota { get; set; }

            /// <summary>
            /// The number of tasks that are being performed.
            /// </summary>
            [NameInMap("InProgressTaskCount")]
            [Validation(Required=false)]
            public int? InProgressTaskCount { get; set; }

            /// <summary>
            /// The region ID of the directory.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The number of SCIM credentials.
            /// </summary>
            [NameInMap("SCIMServerCredentialCount")]
            [Validation(Required=false)]
            public int? SCIMServerCredentialCount { get; set; }

            /// <summary>
            /// Indicates whether SCIM synchronization is enabled. Valid values:
            /// 
            /// *   true: SCIM synchronization is enabled.
            /// *   false: SCIM synchronization is disabled.
            /// </summary>
            [NameInMap("SCIMSyncEnabled")]
            [Validation(Required=false)]
            public bool? SCIMSyncEnabled { get; set; }

            /// <summary>
            /// Indicates whether SSO logon is enabled. Valid values:
            /// 
            /// *   true: SSO logon is enabled.
            /// *   false: SSO logon is disabled.
            /// </summary>
            [NameInMap("SSOEnabled")]
            [Validation(Required=false)]
            public bool? SSOEnabled { get; set; }

            [NameInMap("SystemPolicyPerAccessConfigurationQuota")]
            [Validation(Required=false)]
            public int? SystemPolicyPerAccessConfigurationQuota { get; set; }

            /// <summary>
            /// The number of users.
            /// </summary>
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }

            /// <summary>
            /// The quota for users.
            /// </summary>
            [NameInMap("UserQuota")]
            [Validation(Required=false)]
            public int? UserQuota { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
