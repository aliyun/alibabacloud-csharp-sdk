// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosAllEventListRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The DDoS attack events occur before <b>EndTime</b> are queried. This value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640966399</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The type of the DDoS attack events you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>web-cc</b>: resource exhaustion attacks</description></item>
        /// <item><description><b>cc</b>: connection flood attacks</description></item>
        /// <item><description><b>defense</b>: DDoS attacks that trigger traffic scrubbing</description></item>
        /// <item><description><b>blackhole</b>: DDoS attacks that trigger blackhole filtering</description></item>
        /// </list>
        /// <para>If you want to query multiple types of DDoS attack events, separate them with commas (,).</para>
        /// <para>If you do not configure this parameter, DDoS attack events of all types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defense</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The DDoS attack events occur after <b>StartTime</b> are queried. This value is a UNIX timestamp. Unit: seconds.</para>
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
