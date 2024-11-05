// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachHostAccountsFromHostShareKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the call.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DetachHostAccountsFromHostShareKeyResponseBodyResults> Results { get; set; }
        public class DetachHostAccountsFromHostShareKeyResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The error code returned. If <b>OK</b> is returned, the disassociation was successful. If a different error code is returned, the disassociation failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The ID of the host account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12407</para>
            /// </summary>
            [NameInMap("HostAccountId")]
            [Validation(Required=false)]
            public string HostAccountId { get; set; }

            /// <summary>
            /// <para>The ID of the shared key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("HostShareKeyId")]
            [Validation(Required=false)]
            public string HostShareKeyId { get; set; }

            /// <summary>
            /// <para>The error message returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The host account does not exist</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
