// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDatasetFileMetasStatisticsResponseBody : TeaModel {
        [NameInMap("DatasetFileMetasStats")]
        [Validation(Required=false)]
        public List<DatasetFileMetasStat> DatasetFileMetasStats { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>73</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ADF6D849-*****-7E7030F0CE53</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
