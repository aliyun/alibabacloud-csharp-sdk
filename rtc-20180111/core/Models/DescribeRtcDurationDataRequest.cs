// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcDurationDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can specify only one ID.</para>
        /// <para>If you leave this parameter empty, data for all your applications is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in UTC format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <para>The end time must be later than the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-04T07:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the query, in seconds.</para>
        /// <para>Valid values are <b>3600</b> (1 hour) and <b>86400</b> (1 day). The default value is <b>3600</b>.</para>
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
        /// <para>The area where the service is deployed. The default value is CN, which indicates China.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("ServiceArea")]
        [Validation(Required=false)]
        public string ServiceArea { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Specify the time in UTC format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-04T05:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
