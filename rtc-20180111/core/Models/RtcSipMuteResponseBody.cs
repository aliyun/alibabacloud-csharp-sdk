// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class RtcSipMuteResponseBody : TeaModel {
        [NameInMap("ErrTracks")]
        [Validation(Required=false)]
        public List<RtcSipMuteResponseBodyErrTracks> ErrTracks { get; set; }
        public class RtcSipMuteResponseBodyErrTracks : TeaModel {
            /// <summary>
            /// <para>ErrMsg。</para>
            /// 
            /// <b>Example:</b>
            /// <para>participant does not existed.</para>
            /// </summary>
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>OperationId。</para>
            /// 
            /// <b>Example:</b>
            /// <para>12122121</para>
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E7997404-5858-5C4D-94E4-33677412ACDC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
