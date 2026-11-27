// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcUserCntDataRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can specify only one ID.</para>
        /// <para>By default, all application IDs are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The end time of the queried data. The time is displayed in UTC. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <para>The end time must be later than the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-29T01:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity at which the data is queried. Unit: seconds.</para>
        /// <para>Valid values: <b>3600</b> (one hour) or <b>86400</b> (one day). Default value: <b>3600</b>.</para>
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
        /// <para>The start time of the queried data. The time is displayed in UTC. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-29T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
