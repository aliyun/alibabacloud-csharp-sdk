// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDatasetFileMetasStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the returned aggregation list. You can get the count for each aggregated item. The list is sorted by Count in descending order by default.</para>
        /// </summary>
        [NameInMap("DatasetFileMetasStats")]
        [Validation(Required=false)]
        public List<DatasetFileMetasStat> DatasetFileMetasStats { get; set; }

        /// <summary>
        /// <para>The number of statistical results returned. For example, the number of metadata entries or the number of user tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADF6D849-*****-7E7030F0CE53</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
