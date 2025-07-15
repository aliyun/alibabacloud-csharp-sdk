// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateEventSubResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>760bad53276431c499e30dc36f6b****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The subscription ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad53276431c****</para>
        /// </summary>
        [NameInMap("SubscribeId")]
        [Validation(Required=false)]
        public string SubscribeId { get; set; }

    }

}
