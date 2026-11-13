// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallDropTrendRequest : TeaModel {
        /// <summary>
        /// <para>Sets the end time of the query. The value is a UNIX timestamp in seconds. This parameter is required and must be specified together with StartTime. The value must be a UNIX timestamp in seconds and later than the value of StartTime. If this parameter is not specified, the API returns ErrorTimeError(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1758474000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language in which you want to receive messages. Valid values:</para>
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
        /// <para>Sets the start time of the query. The value is a UNIX timestamp in seconds. This parameter is required and must be specified together with EndTime. The value must be a UNIX timestamp in seconds and earlier than the value of EndTime. If this parameter is not specified, the API returns ErrorTimeError(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1758470400</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
