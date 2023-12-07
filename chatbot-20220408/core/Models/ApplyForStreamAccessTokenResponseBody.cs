// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ApplyForStreamAccessTokenResponseBody : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StreamSecret")]
        [Validation(Required=false)]
        public string StreamSecret { get; set; }

    }

}
