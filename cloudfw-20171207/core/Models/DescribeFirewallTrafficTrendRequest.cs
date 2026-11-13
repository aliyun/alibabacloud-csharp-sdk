// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallTrafficTrendRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds. This parameter is required. If this parameter is not specified, ErrorTimeError (400) is returned.</para>
        /// <remarks>
        /// <para>The query interval (EndTime - StartTime) cannot exceed 90 days. Otherwise, ErrorTimeError is returned. If the specified time is later than the current time, the value is automatically adjusted to the current time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1758474000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language type for receiving messages.</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds. This parameter is required. If this parameter is not specified, ErrorTimeError (400) is returned.</para>
        /// <remarks>
        /// <para>The query interval (EndTime - StartTime) cannot exceed 90 days. Otherwise, ErrorTimeError is returned. If the specified time is later than the current time, the value is automatically adjusted to the current time. If StartTime is later than EndTime, no error is reported, but empty data is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1758470400</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
