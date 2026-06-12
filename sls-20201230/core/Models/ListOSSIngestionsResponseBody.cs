// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListOSSIngestionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of OSS import tasks returned in this response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>A list of OSS import tasks.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<OSSIngestion> Results { get; set; }

        /// <summary>
        /// <para>The total number of OSS import tasks in the Project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
