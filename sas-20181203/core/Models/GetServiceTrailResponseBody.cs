// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetServiceTrailResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configurations of the service trail.
        /// </summary>
        [NameInMap("ServiceTrail")]
        [Validation(Required=false)]
        public GetServiceTrailResponseBodyServiceTrail ServiceTrail { get; set; }
        public class GetServiceTrailResponseBodyServiceTrail : TeaModel {
            /// <summary>
            /// The status of the service trail. Valid values:
            /// 
            /// *   **on:**
            /// *   **off:**
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The timestamp generated when the service trail was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The timestamp generated when the service trail was last updated. Unit: milliseconds.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
