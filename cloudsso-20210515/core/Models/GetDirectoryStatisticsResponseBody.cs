// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetDirectoryStatisticsResponseBody : TeaModel {
        [NameInMap("DirectoryStatistics")]
        [Validation(Required=false)]
        public GetDirectoryStatisticsResponseBodyDirectoryStatistics DirectoryStatistics { get; set; }
        public class GetDirectoryStatisticsResponseBodyDirectoryStatistics : TeaModel {
            [NameInMap("AccessAssignmentCount")]
            [Validation(Required=false)]
            public int? AccessAssignmentCount { get; set; }

            [NameInMap("AccessConfigurationCount")]
            [Validation(Required=false)]
            public int? AccessConfigurationCount { get; set; }

            [NameInMap("AccessConfigurationQuota")]
            [Validation(Required=false)]
            public int? AccessConfigurationQuota { get; set; }

            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            [NameInMap("DirectoryName")]
            [Validation(Required=false)]
            public string DirectoryName { get; set; }

            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public int? GroupCount { get; set; }

            [NameInMap("GroupQuota")]
            [Validation(Required=false)]
            public int? GroupQuota { get; set; }

            [NameInMap("InProgressTaskCount")]
            [Validation(Required=false)]
            public int? InProgressTaskCount { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("SCIMServerCredentialCount")]
            [Validation(Required=false)]
            public int? SCIMServerCredentialCount { get; set; }

            [NameInMap("SCIMSyncEnabled")]
            [Validation(Required=false)]
            public bool? SCIMSyncEnabled { get; set; }

            [NameInMap("SSOEnabled")]
            [Validation(Required=false)]
            public bool? SSOEnabled { get; set; }

            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }

            [NameInMap("UserQuota")]
            [Validation(Required=false)]
            public int? UserQuota { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
