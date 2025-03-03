// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetJobsResponseBody : TeaModel {
        [NameInMap("DatasetJobs")]
        [Validation(Required=false)]
        public List<DatasetJob> DatasetJobs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8D7B2E70-F770-505B-A672-09F1D8F2EC1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
