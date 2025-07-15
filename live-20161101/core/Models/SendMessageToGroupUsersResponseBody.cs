// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SendMessageToGroupUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-****-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public SendMessageToGroupUsersResponseBodyResult Result { get; set; }
        public class SendMessageToGroupUsersResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hp***</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

        }

    }

}
