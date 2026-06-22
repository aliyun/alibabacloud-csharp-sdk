// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOperationProcessRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page to display in a paged query. This parameter is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the query based on the task completion time. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1635575219000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query based on the task creation time. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1680919232000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The list of task status codes.</para>
        /// </summary>
        [NameInMap("StatusCodes")]
        [Validation(Required=false)]
        public List<int?> StatusCodes { get; set; }

        /// <summary>
        /// <para>The list of task IDs.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

        /// <summary>
        /// <para>The list of task sources.</para>
        /// </summary>
        [NameInMap("TaskSources")]
        [Validation(Required=false)]
        public List<string> TaskSources { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CHECK_ALL: full check.</description></item>
        /// <item><description>CHECK_POLICY: check performed based on check items in the configured policy.</description></item>
        /// <item><description>CHECK_SCHEDULE: scheduled check.</description></item>
        /// <item><description>CHECK_ITEM: check performed based on specified check items.</description></item>
        /// <item><description>CHECK_INSTANCE: check performed based on specified check items and instances.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("TaskTypes")]
        [Validation(Required=false)]
        public List<string> TaskTypes { get; set; }

    }

}
