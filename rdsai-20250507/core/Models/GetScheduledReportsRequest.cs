// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetScheduledReportsRequest : TeaModel {
        /// <summary>
        /// <para>The task end time based on which the reports are filtered. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. If you leave this parameter unspecified, all reports are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-25T02:02:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of reports returned on each page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The inspection task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>847268a4-196f-416b-aa12-bfe0c115****</para>
        /// </summary>
        [NameInMap("ScheduledId")]
        [Validation(Required=false)]
        public string ScheduledId { get; set; }

        /// <summary>
        /// <para>The task start time based on which the reports are filtered. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. If you leave this parameter unspecified, all reports are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-25T01:02:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
