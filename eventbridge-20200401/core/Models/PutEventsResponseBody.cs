// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class PutEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PutEventsResponseBodyData Data { get; set; }
        public class PutEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The collection of event sending results.</para>
            /// </summary>
            [NameInMap("EntryList")]
            [Validation(Required=false)]
            public List<PutEventsResponseBodyDataEntryList> EntryList { get; set; }
            public class PutEventsResponseBodyDataEntryList : TeaModel {
                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success indicates success. Other values indicate exceptions</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The detailed error description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>triggerPicture failed</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The event ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4c8b7500-2aea-4f5a-b7dd-9d9dd986c07d</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>The trace ID, which is used to query the exact call information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4E17C677F5357FB23D1A7FF964CD1999</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

            }

            /// <summary>
            /// <para>The number of events that failed to be sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FailedEntryCount")]
            [Validation(Required=false)]
            public int? FailedEntryCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventBusNotExist</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier that Alibaba Cloud generated for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BC1857D-E633-5E79-B2C2-43EF5F7730D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values: true: The operation was successful. false: The operation failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
