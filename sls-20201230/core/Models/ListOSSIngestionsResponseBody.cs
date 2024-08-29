// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListOSSIngestionsResponseBody : TeaModel {
        /// <summary>
        /// The number of OSS data import jobs that are returned.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The OSS data import jobs.
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<OSSIngestion> Results { get; set; }

        /// <summary>
        /// The total number of OSS data import jobs in the project.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
