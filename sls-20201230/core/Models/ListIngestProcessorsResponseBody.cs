// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListIngestProcessorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned in the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>A list of ingest processors that meet the query conditions.</para>
        /// </summary>
        [NameInMap("processors")]
        [Validation(Required=false)]
        public List<IngestProcessor> Processors { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
