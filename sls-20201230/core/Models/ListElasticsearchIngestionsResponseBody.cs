// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListElasticsearchIngestionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of Elasticsearch/OpenSearch import jobs returned in the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of Elasticsearch/OpenSearch import jobs.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<ESIngestion> Results { get; set; }

        /// <summary>
        /// <para>The total number of Elasticsearch/OpenSearch import jobs in the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
