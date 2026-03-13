// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListConcurrencyConfigsOutput : TeaModel {
        /// <summary>
        /// <para>The list of concurrency configurations.</para>
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<ConcurrencyConfig> Configs { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If this parameter is not returned, all the concurrency configurations are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next_token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
