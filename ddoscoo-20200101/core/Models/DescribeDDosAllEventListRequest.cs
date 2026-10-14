// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosAllEventListRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. DDoS attack events that occurred before <b>EndTime</b> are queried. Specify a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>EndTime can specify only events within the last three months.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640966399</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The type of DDoS attack event to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>web-cc</b>: web resource exhaustion attack.</description></item>
        /// <item><description><b>cc</b>: connection flood attack.</description></item>
        /// <item><description><b>defense</b>: volumetric attack (scrubbing event).</description></item>
        /// <item><description><b>blackhole</b>: volumetric attack (blackhole filtering event).</description></item>
        /// </list>
        /// <para>You can specify multiple types. Separate them with commas (,).</para>
        /// <para>If you do not set this parameter, attack events of all types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defense</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.1</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The page number to return in a paging query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of attack events to return on each page in a paging query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. DDoS attack events that occurred after <b>StartTime</b> are queried. Specify a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>StartTime can specify only events within the last three months.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1609430400</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
