// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListOSSExportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of OSS shipping jobs returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of OSS shipping jobs.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<OSSExport> Results { get; set; }

        /// <summary>
        /// <para>The total number of OSS shipping jobs in the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
