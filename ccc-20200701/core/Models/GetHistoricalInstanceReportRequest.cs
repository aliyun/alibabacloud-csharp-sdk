// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetHistoricalInstanceReportRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the Historical Data to retrieve, in UNIX timestamp format with millisecond precision. This parameter is optional. The default value is the current time. The time precision for statistics is hourly, snapped to the next full hour, and the interval is open. For example, if the start time is 11:12:20 and the end time is 11:45:50, the snapped input parameter Time Range becomes [11:00:00, 12:00:00), meaning greater than or equal to 11:00:00 and less than 12:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1532707199000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Media Type. The default value is Audio. Other valid values include Chat and Video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VIDEO</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The start time of the Historical Data to retrieve, in UNIX timestamp format with millisecond precision. This parameter is optional. The default value is 00:00:00 of the current day. The earliest allowed time is 180 days before the current time. The time precision for statistics is hourly, snapped to the previous full hour, and the interval is closed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1532448000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
