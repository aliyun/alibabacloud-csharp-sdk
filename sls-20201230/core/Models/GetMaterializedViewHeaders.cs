// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetMaterializedViewHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The content type of the request. The value must be <c>application/json</c>.</para>
        /// </summary>
        [NameInMap("Content-Type")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

    }

}
