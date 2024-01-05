// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkConfigLogPathResponseBody : TeaModel {
        /// <summary>
        /// The queried Spark log configuration.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkConfigLogPathResponseBodyData Data { get; set; }
        public class GetSparkConfigLogPathResponseBodyData : TeaModel {
            /// <summary>
            /// The default log path.
            /// </summary>
            [NameInMap("DefaultLogPath")]
            [Validation(Required=false)]
            public string DefaultLogPath { get; set; }

            /// <summary>
            /// Indicates whether a log path exists.
            /// </summary>
            [NameInMap("IsLogPathExists")]
            [Validation(Required=false)]
            public bool? IsLogPathExists { get; set; }

            /// <summary>
            /// The last modification time.
            /// </summary>
            [NameInMap("ModifiedTimestamp")]
            [Validation(Required=false)]
            public string ModifiedTimestamp { get; set; }

            /// <summary>
            /// The account ID of the modifier.
            /// </summary>
            [NameInMap("ModifiedUid")]
            [Validation(Required=false)]
            public string ModifiedUid { get; set; }

            /// <summary>
            /// The recorded log path.
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
