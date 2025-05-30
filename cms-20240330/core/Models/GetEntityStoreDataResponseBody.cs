// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetEntityStoreDataResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<List<string>> Data { get; set; }

        [NameInMap("header")]
        [Validation(Required=false)]
        public List<string> Header { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
