// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallTrafficTrendRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds. This parameter is required. If this parameter is not specified, the API returns ErrorTimeError(400). The value must be a UNIX timestamp in seconds, and EndTime must be later than StartTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1758474000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the response message.</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds. This parameter is required. If this parameter is not specified, the API returns ErrorTimeError(400). The value must be a UNIX timestamp in seconds, and StartTime must be earlier than EndTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1758470400</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
