// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListMaxComputeExportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of MaxCompute delivery tasks that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of MaxCompute delivery tasks.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<MaxComputeExport> Results { get; set; }

        /// <summary>
        /// <para>The total number of MaxCompute delivery tasks in the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
