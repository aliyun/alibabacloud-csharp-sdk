// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RebuildDesktopsResponseBody : TeaModel {
        /// <summary>
        /// <para>The recreation results.</para>
        /// </summary>
        [NameInMap("RebuildResults")]
        [Validation(Required=false)]
        public List<RebuildDesktopsResponseBodyRebuildResults> RebuildResults { get; set; }
        public class RebuildDesktopsResponseBodyRebuildResults : TeaModel {
            /// <summary>
            /// <para>The recreation result code. If the request was successful, <c>success</c> is returned. If the request failed, an error message is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IncorrectDesktopStatus</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The IDs of the cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-gx2x1dhsmucyy****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The error message. This parameter is invalid if the value of <c>Code</c> is <c>success</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The current status of the desktop does not support this operation.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
