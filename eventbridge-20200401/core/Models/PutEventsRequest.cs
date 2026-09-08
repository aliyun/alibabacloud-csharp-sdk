// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class PutEventsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the event bus.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-bus</para>
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<PutEventsRequestEventList> EventList { get; set; }
        public class PutEventsRequestEventList : TeaModel {
            /// <summary>
            /// <para>The event payload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;orderId&quot;: &quot;1001&quot;, &quot;amount&quot;: 99.9}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public object Data { get; set; }

            /// <summary>
            /// <para>The data format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application/json</para>
            /// </summary>
            [NameInMap("DataContentType")]
            [Validation(Required=false)]
            public string DataContentType { get; set; }

            /// <summary>
            /// <para>The data schema address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/schema/v1">https://example.com/schema/v1</a></para>
            /// </summary>
            [NameInMap("DataSchema")]
            [Validation(Required=false)]
            public string DataSchema { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5a2c8f4e-0001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The event source.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my.custom.source</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The protocol version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("SpecVersion")]
            [Validation(Required=false)]
            public string SpecVersion { get; set; }

            /// <summary>
            /// <para>The event subject.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order-1001</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The event time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-04T10:00:00Z</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The event type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order:created</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
