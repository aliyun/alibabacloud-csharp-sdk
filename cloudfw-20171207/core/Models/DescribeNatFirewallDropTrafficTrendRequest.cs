// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallDropTrafficTrendRequest : TeaModel {
        /// <summary>
        /// <para>The end time. Specify a UNIX timestamp in seconds. This parameter is required. If this parameter is not specified, the API returns ErrorTimeError (400). Specify a UNIX timestamp in seconds. The value of EndTime must be later than the value of StartTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1758334822</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122.190.56.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The start time. Specify a UNIX timestamp in seconds. This parameter is required. If this parameter is not specified, the API returns ErrorTimeError (400). Specify a UNIX timestamp in seconds. The value of StartTime must be earlier than the value of EndTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1740968766</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
