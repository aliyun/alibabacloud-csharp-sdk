// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartJobsRequest : TeaModel {
        /// <summary>
        /// <para>The job state.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Finished: The job is complete.</description></item>
        /// <item><description>Failed: The job failed.</description></item>
        /// <item><description>Executing: The job is in progress.</description></item>
        /// <item><description>Created: The job is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("JobState")]
        [Validation(Required=false)]
        public string JobState { get; set; }

        /// <summary>
        /// <para>The job type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASR: automatic speech recognition(job) job.</description></item>
        /// <item><description>DynamicChart: dynamic chart job.</description></item>
        /// <item><description>VideoTranslation: video translation job.</description></item>
        /// <item><description>TextToSpeech: intelligent audio production job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASR</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// <para>Default value: 10. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>73f33c91-d59383e8280b</b></b></para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting parameter. By default, the query results are sorted by creation time in descending order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreationTime:Asc: sorted by creation time in ascending order.</description></item>
        /// <item><description>CreationTime:Desc: sorted by creation time in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
