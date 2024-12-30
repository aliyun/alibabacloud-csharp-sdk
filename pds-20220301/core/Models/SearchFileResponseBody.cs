// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the files.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<File> Items { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If next_marker is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        /// <summary>
        /// <para>The total number of retrieved files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1022</para>
        /// </summary>
        [NameInMap("total_count")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
