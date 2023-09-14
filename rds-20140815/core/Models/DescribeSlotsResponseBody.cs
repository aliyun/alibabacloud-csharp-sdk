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
        /// An array that consists of information about replication slots.
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
            /// The extension that is used by the replication slot.
            /// </summary>
            [NameInMap("Plugin")]
            [Validation(Required=false)]
            public string Plugin { get; set; }

            /// <summary>
            /// The name of the replication slot.
            /// </summary>
            [NameInMap("SlotName")]
            [Validation(Required=false)]
            public string SlotName { get; set; }

            /// <summary>
            /// The status of the replication slot.
            /// 
            /// Valid values:
            /// 
            /// *   ACTIVE
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   INACTIVE
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("SlotStatus")]
            [Validation(Required=false)]
            public string SlotStatus { get; set; }

            /// <summary>
            /// The type of the replication slot.
            /// </summary>
            [NameInMap("SlotType")]
            [Validation(Required=false)]
            public string SlotType { get; set; }

            /// <summary>
            /// The current Replication Slot corresponds to the specific delay of the logical subscription of the subscriber, in seconds (s)
            /// </summary>
            [NameInMap("SubReplayLag")]
            [Validation(Required=false)]
            public string SubReplayLag { get; set; }

            /// <summary>
            /// Indicates whether the replication slot is temporary.
            /// 
            /// Valid values:
            /// 
            /// *   true
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   false
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Temporary")]
            [Validation(Required=false)]
            public string Temporary { get; set; }

            /// <summary>
            /// The number of logs that are accumulated for the replication slot.
            /// </summary>
            [NameInMap("WalDelay")]
            [Validation(Required=false)]
            public string WalDelay { get; set; }

        }

    }

}
