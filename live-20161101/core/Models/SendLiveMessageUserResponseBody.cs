// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SendLiveMessageUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the message, which is a unique identifier that can be used to delete the message. The ID can be up to 64 bytes in length and can contain letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>169830****</para>
        /// </summary>
        [NameInMap("MsgTid")]
        [Validation(Required=false)]
        public string MsgTid { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CFDE7AB-571A-14EA-B072-989FF753****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
