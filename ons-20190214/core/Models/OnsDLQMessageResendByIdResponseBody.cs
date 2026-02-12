// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsDLQMessageResendByIdResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsDLQMessageResendByIdResponseBodyData Data { get; set; }
        public class OnsDLQMessageResendByIdResponseBodyData : TeaModel {
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public List<string> MsgId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D94CC769-4DC3-4690-A868-9D0631B1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
