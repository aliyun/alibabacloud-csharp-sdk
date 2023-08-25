// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SetSparkAppLogRootPathResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SetSparkAppLogRootPathResponseBodyData Data { get; set; }
        public class SetSparkAppLogRootPathResponseBodyData : TeaModel {
            /// <summary>
            /// The recommended default OSS log path.
            /// </summary>
            [NameInMap("DefaultLogPath")]
            [Validation(Required=false)]
            public string DefaultLogPath { get; set; }

            /// <summary>
            /// Indicates whether an OSS log path exists.
            /// </summary>
            [NameInMap("IsLogPathExists")]
            [Validation(Required=false)]
            public bool? IsLogPathExists { get; set; }

            /// <summary>
            /// The time when the modification was last modified.
            /// </summary>
            [NameInMap("ModifiedTimestamp")]
            [Validation(Required=false)]
            public string ModifiedTimestamp { get; set; }

            /// <summary>
            /// The modifier ID.
            /// </summary>
            [NameInMap("ModifiedUid")]
            [Validation(Required=false)]
            public string ModifiedUid { get; set; }

            /// <summary>
            /// The OSS log path.
            /// </summary>
            [NameInMap("RecordedLogPath")]
            [Validation(Required=false)]
            public string RecordedLogPath { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
