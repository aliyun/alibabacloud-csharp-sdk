// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcPeakChannelCntDataRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Only a single ID can be specified.</para>
        /// <para>By default, all application IDs are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The end time for the data query. Specify the time in the UTC format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <para>The end time must be later than the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-29T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity for the data query, in seconds.</para>
        /// <para>Valid values: <b>3600</b> (1 hour) or <b>86400</b> (1 day). Default value: <b>3600</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The service area. CN: China (default value).</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("ServiceArea")]
        [Validation(Required=false)]
        public string ServiceArea { get; set; }

        /// <summary>
        /// <para>The start time for the data query. Specify the time in the UTC format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-29T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
