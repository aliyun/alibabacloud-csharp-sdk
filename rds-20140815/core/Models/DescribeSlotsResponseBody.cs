// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSlotsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the replication slot.
        /// </summary>
        [NameInMap("Slots")]
        [Validation(Required=false)]
        public List<DescribeSlotsResponseBodySlots> Slots { get; set; }
        public class DescribeSlotsResponseBodySlots : TeaModel {
            /// <summary>
            /// The name of the database in which the replication slot resides.
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// The extension used by the replication slot.
            /// </summary>
            [NameInMap("Plugin")]
            [Validation(Required=false)]
            public string Plugin { get; set; }

            /// <summary>
            /// The replication slot name.
            /// </summary>
            [NameInMap("SlotName")]
            [Validation(Required=false)]
            public string SlotName { get; set; }

            /// <summary>
            /// The replication slot status. Valid values:
            /// 
            /// *   ACTIVE
            /// *   INACTIVE
            /// </summary>
            [NameInMap("SlotStatus")]
            [Validation(Required=false)]
            public string SlotStatus { get; set; }

            /// <summary>
            /// The replication slot type. Valid values:
            /// 
            /// *   physical
            /// *   logical
            /// </summary>
            [NameInMap("SlotType")]
            [Validation(Required=false)]
            public string SlotType { get; set; }

            /// <summary>
            /// The latency of the logical subscription on the subscriber node that corresponds to the current replication slot. Unit: seconds.
            /// </summary>
            [NameInMap("SubReplayLag")]
            [Validation(Required=false)]
            public string SubReplayLag { get; set; }

            /// <summary>
            /// Indicates whether the replication slot is a temporary replication slot. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Temporary")]
            [Validation(Required=false)]
            public string Temporary { get; set; }

            /// <summary>
            /// The number of logs accumulated in the replication slot.
            /// </summary>
            [NameInMap("WalDelay")]
            [Validation(Required=false)]
            public string WalDelay { get; set; }

        }

    }

}
