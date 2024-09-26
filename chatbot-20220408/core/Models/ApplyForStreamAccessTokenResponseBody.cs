// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ApplyForStreamAccessTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>63ba97b4f18a4a04f715c81e8e643938</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cc9e88c0-4f41-4f1d-a1a9-91a72d2aa27d</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>736994BD-AA35-4742-88C9-E64BE4BAA14B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cc9e88c0-4f41-4f1d-a1a9-91a72d2aa27d</para>
        /// </summary>
        [NameInMap("StreamSecret")]
        [Validation(Required=false)]
        public string StreamSecret { get; set; }

    }

}
