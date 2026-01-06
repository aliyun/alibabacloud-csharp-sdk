// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryTracedEventsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range when event traces are queried. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1661773509000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The name of the event bus.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyEventBus</para>
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// <para>The name of the event source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse</para>
        /// </summary>
        [NameInMap("EventSource")]
        [Validation(Required=false)]
        public string EventSource { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eventbridge:Events:HTTPEvent</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in a request. You can use this parameter and NextToken to implement paging.</para>
        /// <remarks>
        /// <para> A maximum of 100 entries can be returned in a request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The name of the event rule that is matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-mnsrule</para>
        /// </summary>
        [NameInMap("MatchedRule")]
        [Validation(Required=false)]
        public string MatchedRule { get; set; }

        /// <summary>
        /// <para>If you configure Limit and excess return values exist, this parameter is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query event traces. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1661773509000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}
