// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class SubmitQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The query ID, which is used for subsequent polling of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d7b21d1ec4f441e79d5ba917c3283200</para>
        /// </summary>
        [NameInMap("queryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

    }

}
