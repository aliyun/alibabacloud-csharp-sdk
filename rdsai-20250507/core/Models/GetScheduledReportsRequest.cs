// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetScheduledReportsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query range. The time must be in the YYYY-MM-DDTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-25T02:02:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The default value is 20, and the maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the inspection task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>847268a4-196f-416b-aa12-bfe0c115****</para>
        /// </summary>
        [NameInMap("ScheduledId")]
        [Validation(Required=false)]
        public string ScheduledId { get; set; }

        /// <summary>
        /// <para>The start time of the query range. The time must be in the YYYY-MM-DDTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-25T01:02:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
