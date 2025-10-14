// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeSiteTimeSeriesDataShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The end time for obtaining data.</para>
        /// <para>The date format follows ISO8601 notation and uses UTC+0 time, in the format yyyy-MM-ddTHH:mm:ssZ.</para>
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
        /// <para>Query metrics.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string FieldsShrink { get; set; }

        /// <summary>
        /// <para>The time granularity for querying data, in seconds.</para>
        /// <para>Depending on the maximum time span of a single query, this parameter supports values of 60 (1 minute), 300 (5 minutes), 3600 (1 hour), and 86400 (1 day). For details, see the <b>Supported Query Time Granularities</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>Site ID. Obtain the site ID by calling the <a href="~~ListSites~~">ListSites</a> interface.</para>
        /// <para>If this parameter is empty, user-level data will be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1150376036*****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        /// <summary>
        /// <para>The start time for obtaining data.</para>
        /// <para>The date format follows ISO8601 notation and uses UTC+0 time, in the format yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
