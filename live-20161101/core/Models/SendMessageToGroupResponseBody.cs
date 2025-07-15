// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SendMessageToGroupResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public SendMessageToGroupResponseBodyResult Result { get; set; }
        public class SendMessageToGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qt***</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

        }

    }

}
