// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBatchTasksShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The end of the creation time range.</para>
        /// <para>The time is in ISO 8601 format in UTC (format: YYYY-MM-DDTHH:mm:ssZ).</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-06T20:52:40Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start of the creation time range.</para>
        /// <para>The time is in ISO 8601 format in UTC (format: YYYY-MM-DDTHH:mm:ssZ).</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-06T20:51:40Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The list of task statuses.</para>
        /// <remarks>
        /// <para>If this parameter is left empty, scheduled tasks in all statuses are queried by default.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string StatusShrink { get; set; }

        /// <summary>
        /// <para>The batch task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polarclaw_install_skills</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
