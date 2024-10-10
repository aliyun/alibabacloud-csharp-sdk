// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushMessageToAndroidResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>501029</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9998B3CC-ED9E-4CB3-A8FB-DCC61296BFBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
