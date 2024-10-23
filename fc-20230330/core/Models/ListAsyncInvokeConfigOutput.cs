// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListAsyncInvokeConfigOutput : TeaModel {
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<AsyncConfig> Configs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8bj81uI8n****</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
