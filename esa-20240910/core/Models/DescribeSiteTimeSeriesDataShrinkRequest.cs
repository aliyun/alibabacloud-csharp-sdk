// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeSiteTimeSeriesDataShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The end time for the data query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-09T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The query metrics.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string FieldsShrink { get; set; }

        /// <summary>
        /// <para>The time granularity for the query data, in seconds.</para>
        /// <para>Based on the maximum time span of a single query, this parameter supports the values 60 (1 minute), 300 (5 minutes), 3600 (1 hour), and 86400 (1 day). For more information, see the <b>Supported time granularity</b> section above.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>If this parameter is left empty, account-level data is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1150376036*****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        /// <summary>
        /// <para>The start time for the data query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
