// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSwitchRegionDetailResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSwitchRegionDetailResponseBodyData Data { get; set; }
        public class GetSwitchRegionDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the permissions were modified.
            /// </summary>
            [NameInMap("GmtIsAgreeModified")]
            [Validation(Required=false)]
            public long? GmtIsAgreeModified { get; set; }

            /// <summary>
            /// The notification time.
            /// </summary>
            [NameInMap("GmtNoticed")]
            [Validation(Required=false)]
            public long? GmtNoticed { get; set; }

            /// <summary>
            /// Indicates whether the migration is approved.
            /// </summary>
            [NameInMap("IsAgree")]
            [Validation(Required=false)]
            public string IsAgree { get; set; }

            /// <summary>
            /// Indicates whether the notification is sent.
            /// </summary>
            [NameInMap("IsNoticed")]
            [Validation(Required=false)]
            public string IsNoticed { get; set; }

            /// <summary>
            /// The status of the switching to the region.
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public List<GetSwitchRegionDetailResponseBodyDataRegionStatus> RegionStatus { get; set; }
            public class GetSwitchRegionDetailResponseBodyDataRegionStatus : TeaModel {
                /// <summary>
                /// The number of ECS instances.
                /// </summary>
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public int? EcsCount { get; set; }

                /// <summary>
                /// The time when the migration is scheduled.
                /// </summary>
                [NameInMap("GmtPlanSwitchTime")]
                [Validation(Required=false)]
                public long? GmtPlanSwitchTime { get; set; }

                /// <summary>
                /// The region in which the server resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The migration status. Valid values:
                /// 
                /// *   **0**: pending
                /// *   **1**: successful
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
