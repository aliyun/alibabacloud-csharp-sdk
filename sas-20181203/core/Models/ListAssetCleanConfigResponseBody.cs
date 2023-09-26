// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAssetCleanConfigResponseBody : TeaModel {
        /// <summary>
        /// The number of cleanup configurations.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The asset cleanup configurations.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAssetCleanConfigResponseBodyData> Data { get; set; }
        public class ListAssetCleanConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The number of days before hosts whose provider cannot be identified are automatically cleaned after they enter the offline state. Valid value: an integer that ranges from 1 to 30.
            /// </summary>
            [NameInMap("CleanDays")]
            [Validation(Required=false)]
            public int? CleanDays { get; set; }

            /// <summary>
            /// Indicates whether the configuration takes effect. Valid values:
            /// 
            /// *   **0**: The configuration does not take effect.
            /// *   **1**: The configuration takes effect.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The type of hosts that are cleaned.
            /// 
            /// *   The value is set to **1**, which indicates hosts whose provider cannot be identified.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
