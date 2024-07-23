// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DisconnectDesktopSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of invalid sessions.</para>
        /// </summary>
        [NameInMap("InvalidSessions")]
        [Validation(Required=false)]
        public List<DisconnectDesktopSessionsResponseBodyInvalidSessions> InvalidSessions { get; set; }
        public class DisconnectDesktopSessionsResponseBodyInvalidSessions : TeaModel {
            /// <summary>
            /// <para>The cloud desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-2jv6wugbkp65pxxxx</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The end user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wy01</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2507CFA8-FEAB-5208-98F5-5E028C50XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
