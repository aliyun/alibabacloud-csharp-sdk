// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateSnapshotSettingResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateSnapshotSettingResponseBodyResult Result { get; set; }
        public class UpdateSnapshotSettingResponseBodyResult : TeaModel {
            /// <summary>
            /// Specifies whether to enable automatic backup.
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The start time of automatic backup.
            /// </summary>
            [NameInMap("quartzRegex")]
            [Validation(Required=false)]
            public string QuartzRegex { get; set; }

        }

    }

}
