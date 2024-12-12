// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveTranscodeJobsRequest : TeaModel {
        /// <summary>
        /// <para>The search keyword. You can use the job ID or name as the keyword to search for jobs. If you search for jobs by name, fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24ecbb5c-4f98-4194-9400-f17102e27fc5</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting order. By default, the query results are sorted by creation time in descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc</description></item>
        /// <item><description>desc</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The start mode of the transcoding job.</para>
        /// <list type="bullet">
        /// <item><description>0: The transcoding job immediately starts.</description></item>
        /// <item><description>1: The transcoding job starts at the scheduled time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartMode")]
        [Validation(Required=false)]
        public int? StartMode { get; set; }

        /// <summary>
        /// <para>The state of the job.</para>
        /// <para>0: The job is not started. 1: The job is in progress. 2: The job is stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The type of the template used by the transcoding job.</para>
        /// <list type="bullet">
        /// <item><description>normal</description></item>
        /// <item><description>narrow-band</description></item>
        /// <item><description>audio-only</description></item>
        /// <item><description>origin</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
