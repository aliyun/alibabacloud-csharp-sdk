// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserProvisioningStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The statistics of the RAM user provisioning.
        /// </summary>
        [NameInMap("UserProvisioningStatistics")]
        [Validation(Required=false)]
        public GetUserProvisioningStatisticsResponseBodyUserProvisioningStatistics UserProvisioningStatistics { get; set; }
        public class GetUserProvisioningStatisticsResponseBodyUserProvisioningStatistics : TeaModel {
            /// <summary>
            /// The ID of the resource directory.
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// The entity ID, which is the ID of the RAM user provisioning.
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// The number of failed RAM user provisioning events that are associated with the RAM user provisioning.
            /// </summary>
            [NameInMap("FailedEventCount")]
            [Validation(Required=false)]
            public long? FailedEventCount { get; set; }

            /// <summary>
            /// The time when the RAM user provisioning was last performed.
            /// </summary>
            [NameInMap("LatestAsyncTime")]
            [Validation(Required=false)]
            public string LatestAsyncTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the resource directory belongs.
            /// </summary>
            [NameInMap("OwnerPk")]
            [Validation(Required=false)]
            public string OwnerPk { get; set; }

            /// <summary>
            /// The entity type. The value is fixed as `User Provisioning`.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
