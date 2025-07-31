// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityScanRunLogResponseBody : TeaModel {
        [NameInMap("LogSegment")]
        [Validation(Required=false)]
        public GetDataQualityScanRunLogResponseBodyLogSegment LogSegment { get; set; }
        public class GetDataQualityScanRunLogResponseBodyLogSegment : TeaModel {
            [NameInMap("Log")]
            [Validation(Required=false)]
            public string Log { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>512000</para>
            /// </summary>
            [NameInMap("NextOffset")]
            [Validation(Required=false)]
            public long? NextOffset { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc14115***159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
