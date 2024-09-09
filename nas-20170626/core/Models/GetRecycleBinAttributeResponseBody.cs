// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetRecycleBinAttributeResponseBody : TeaModel {
        /// <summary>
        /// The description of the recycle bin.
        /// </summary>
        [NameInMap("RecycleBinAttribute")]
        [Validation(Required=false)]
        public GetRecycleBinAttributeResponseBodyRecycleBinAttribute RecycleBinAttribute { get; set; }
        public class GetRecycleBinAttributeResponseBodyRecycleBinAttribute : TeaModel {
            [NameInMap("ArchiveSize")]
            [Validation(Required=false)]
            public long? ArchiveSize { get; set; }

            /// <summary>
            /// The time at which the recycle bin was enabled.
            /// </summary>
            [NameInMap("EnableTime")]
            [Validation(Required=false)]
            public string EnableTime { get; set; }

            /// <summary>
            /// The retention period of the files in the recycle bin. Unit: days.
            /// 
            /// If the recycle bin is disabled, 0 is returned for this parameter.
            /// </summary>
            [NameInMap("ReservedDays")]
            [Validation(Required=false)]
            public long? ReservedDays { get; set; }

            /// <summary>
            /// The size of the cold data that is dumped to the recycle bin. Unit: bytes.
            /// </summary>
            [NameInMap("SecondarySize")]
            [Validation(Required=false)]
            public long? SecondarySize { get; set; }

            /// <summary>
            /// The size of the files that are dumped to the recycle bin. Unit: bytes.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The status of the recycle bin.
            /// 
            /// Valid values:
            /// 
            /// *   Enable: The recycle bin is enabled.
            /// *   Disable: The recycle bin is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
