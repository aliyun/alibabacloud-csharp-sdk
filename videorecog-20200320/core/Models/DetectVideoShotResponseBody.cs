// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class DetectVideoShotResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectVideoShotResponseBodyData Data { get; set; }
        public class DetectVideoShotResponseBodyData : TeaModel {
            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShotFrameIds")]
            [Validation(Required=false)]
            public List<int?> ShotFrameIds { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0033B795-09C7-4EB9-A33C-EBA325192B0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
