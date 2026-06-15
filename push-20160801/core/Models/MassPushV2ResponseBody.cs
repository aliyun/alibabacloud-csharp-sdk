// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class MassPushV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>List of message IDs.</para>
        /// </summary>
        [NameInMap("MessageIds")]
        [Validation(Required=false)]
        public List<string> MessageIds { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>159E4422-6624-****-8943-DFD98D34858C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
