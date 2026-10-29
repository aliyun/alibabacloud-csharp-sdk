// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryTracedEventsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the time range to retrieve events. Unit: milliseconds.</para>
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
        /// <para>The maximum number of entries to return per page. You can use this parameter together with NextToken to paginate query results. &gt;Notice: The maximum number of entries returned per page cannot exceed 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The name of the matched rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-mnsrule</para>
        /// </summary>
        [NameInMap("MatchedRule")]
        [Validation(Required=false)]
        public string MatchedRule { get; set; }

        /// <summary>
        /// <para>The pagination token. If you specify Limit and more results are available, this token is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The start time of the time range to retrieve events. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1661773509000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The subject of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-1001</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}
