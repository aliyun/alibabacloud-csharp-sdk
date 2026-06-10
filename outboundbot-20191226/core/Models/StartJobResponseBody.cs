// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class StartJobResponseBody : TeaModel {
        /// <summary>
        /// <para>List of call IDs</para>
        /// </summary>
        [NameInMap("CallIds")]
        [Validation(Required=false)]
        public List<StartJobResponseBodyCallIds> CallIds { get; set; }
        public class StartJobResponseBodyCallIds : TeaModel {
            /// <summary>
            /// <para>Third-party contact ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>c93cdd1c-f9b5-4758-be43-7a237a7eaa1d</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Call ID for the task</para>
            /// 
            /// <b>Example:</b>
            /// <para>62229628-45d8-41bd-a80f-6e4c0a39f79b</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>API status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>API message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>8a621aa1-d2e7-43f3-b54d-8830af73c468</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call succeeded. true means success. false means failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Mapping between third-party contact IDs and outbound call task IDs</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<StartJobResponseBodyTaskIds> TaskIds { get; set; }
        public class StartJobResponseBodyTaskIds : TeaModel {
            /// <summary>
            /// <para>Third-party contact ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>c93cdd1c-f9b5-4758-be43-7a237a7eaa1d</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Outbound call task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>62229628-45d8-41bd-a80f-6e4c0a39f79b</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
