// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListInsightsEventsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1480607940000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The types of the events that you want to query. Separate multiple event types with commas (,). If you do not specify this parameter, all events are queried.</para>
        /// <list type="bullet">
        /// <item><description>errorIncrease: API error-rate spike events. Examples: HTTP API error-rate spike events and Dubbo API error-rate spike events.</description></item>
        /// <item><description>topErrorIncrease: the top five API error-rate spike events with the highest traffic.</description></item>
        /// <item><description>topRtIncrease: API response-time spike events. Examples: HTTP API response-time spike events and Dubbo API response-time spike events.</description></item>
        /// <item><description>rtIncrease: the top five API response-time spike events with the highest traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>errorIncrease,topErrorIncrease,topExceptionIncrease,topRtIncrease,rtIncrease</para>
        /// </summary>
        [NameInMap("InsightsTypes")]
        [Validation(Required=false)]
        public string InsightsTypes { get; set; }

        /// <summary>
        /// <para>The ID of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aokcdqn3ly@a195c6d6421****</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The value is a timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1595174400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
