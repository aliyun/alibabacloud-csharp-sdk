// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListOSSIngestionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of OSS data import jobs that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The OSS data import jobs.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<OSSIngestion> Results { get; set; }

        /// <summary>
        /// <para>The total number of OSS data import jobs in the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
