// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class CheckPushReceiverResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CheckPushReceiverResponseBodyModule Module { get; set; }
        public class CheckPushReceiverResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanReceivePush")]
            [Validation(Required=false)]
            public bool? CanReceivePush { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>130****8600</para>
            /// </summary>
            [NameInMap("MaskedMobile")]
            [Validation(Required=false)]
            public string MaskedMobile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>78C60CC3-FF0A-44E2-989A-DDE0597791C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
