// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class CreateChatSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data structure.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateChatSessionResponseBodyData Data { get; set; }
        public class CreateChatSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Q&amp;A session ID, used to record multiple Q&amp;A sessions of the same user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>596ac39c-8855-4128-bad7-78aebeff48fc</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9bc20a5a-b26b-4c28-922a-7cd10b61f96f</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
