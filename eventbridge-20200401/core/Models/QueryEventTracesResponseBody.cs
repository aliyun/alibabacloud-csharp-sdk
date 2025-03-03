// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryEventTracesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <para>200: The request was successful.</para>
        /// <para>Other codes: The request failed. For information about error codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The name of the event source.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryEventTracesResponseBodyData> Data { get; set; }
        public class QueryEventTracesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the event trace. Valid values: PutEvent, FilterEvent, and PushEvent. The value PutEvent indicates that the event was delivered. The value FilterEvent indicates that the event was filtered. The value PushEvent indicates that the event was pushed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PutEvent</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The execution time of the event trace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659495343896</para>
            /// </summary>
            [NameInMap("ActionTime")]
            [Validation(Required=false)]
            public long? ActionTime { get; set; }

            /// <summary>
            /// <para>The endpoint of the event target. This parameter is returned only if Action is set to PushEvent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:mns:cn-zhangjiakou:123456789098****:queues/testQueue</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The name of the event bus.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("EventBusName")]
            [Validation(Required=false)]
            public string EventBusName { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a5747e4f-2af2-40b6-b262-d0140e995bf7</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The name of the event source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cert-api</para>
            /// </summary>
            [NameInMap("EventSource")]
            [Validation(Required=false)]
            public string EventSource { get; set; }

            /// <summary>
            /// <para>The delay period for which the event was delivered to the event target. This parameter is returned only if Action is set to PushEvent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("NotifyLatency")]
            [Validation(Required=false)]
            public string NotifyLatency { get; set; }

            /// <summary>
            /// <para>The delivery status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[200]Ok</para>
            /// </summary>
            [NameInMap("NotifyStatus")]
            [Validation(Required=false)]
            public string NotifyStatus { get; set; }

            /// <summary>
            /// <para>The time when the event was delivered to the event target. This parameter is returned only if Action is set to PushEvent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659495343896</para>
            /// </summary>
            [NameInMap("NotifyTime")]
            [Validation(Required=false)]
            public long? NotifyTime { get; set; }

            /// <summary>
            /// <para>The time when the event was delivered to the event bus. This parameter is returned only if Action is set to PutEvent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659495343896</para>
            /// </summary>
            [NameInMap("ReceivedTime")]
            [Validation(Required=false)]
            public long? ReceivedTime { get; set; }

            /// <summary>
            /// <para>The time when the event rule was matched. This parameter is returned only if Action is set to FilterEvent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659495343896</para>
            /// </summary>
            [NameInMap("RuleMatchingTime")]
            [Validation(Required=false)]
            public string RuleMatchingTime { get; set; }

            /// <summary>
            /// <para>The name of the event rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ramrolechange-mns</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventBusNotExist</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BB934571-1F5A-5E17-91DD-E2BC3E1BFBFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
