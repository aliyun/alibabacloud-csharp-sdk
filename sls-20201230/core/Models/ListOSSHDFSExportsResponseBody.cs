// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListOSSHDFSExportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of OSS-HDFS export tasks returned in the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of OSS-HDFS export tasks.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<OSSExport> Results { get; set; }

        /// <summary>
        /// <para>The total number of OSS-HDFS export tasks in the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
