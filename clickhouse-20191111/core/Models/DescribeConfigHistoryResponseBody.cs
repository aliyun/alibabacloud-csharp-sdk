// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeConfigHistoryResponseBody : TeaModel {
        /// <summary>
        /// The change records of the configuration parameters.
        /// </summary>
        [NameInMap("ConfigHistoryItems")]
        [Validation(Required=false)]
        public List<DescribeConfigHistoryResponseBodyConfigHistoryItems> ConfigHistoryItems { get; set; }
        public class DescribeConfigHistoryResponseBodyConfigHistoryItems : TeaModel {
            /// <summary>
            /// The ID of the change record.
            /// </summary>
            [NameInMap("ChangeId")]
            [Validation(Required=false)]
            public string ChangeId { get; set; }

            /// <summary>
            /// The user ID (UID) of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The reason for the setting modification of the configuration parameters.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// Indicates whether the setting modification of the configuration parameters took effect. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// The time when the values of the configuration parameters were changed. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
