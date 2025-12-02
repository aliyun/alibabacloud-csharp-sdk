// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetStockOssCheckTasksListRequest : TeaModel {
        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>End time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-18 02:08:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Whether it is a scheduled scan task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsInc")]
        [Validation(Required=false)]
        public bool? IsInc { get; set; }

        /// <summary>
        /// <para>Media type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public int? MediaType { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Sort field.</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public Dictionary<string, string> Sort { get; set; }

        /// <summary>
        /// <para>Start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-17 02:08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>batch</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
