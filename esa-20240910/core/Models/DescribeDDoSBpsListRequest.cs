// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeDDoSBpsListRequest : TeaModel {
        /// <summary>
        /// <para>Protection area, defaulting to global if not filled. When specified, the values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>domestic: Mainland China.</para>
        /// </description></item>
        /// <item><description><para>overseas: Global (excluding Mainland China).</para>
        /// </description></item>
        /// <item><description><para>global: Global.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>The end time for fetching data. In ISO8601 format, using UTC+0, formatted as: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <para>The end time must be later than the start time, and the span between start and end times should not exceed 31 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-18T06:19:42Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70966210986912</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The start time for fetching data, in ISO8601 format, using UTC+0, formatted as: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-14T17:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
