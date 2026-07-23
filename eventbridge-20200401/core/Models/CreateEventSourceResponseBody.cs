// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateEventSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Success</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>Other values indicate errors. For more information, see the &quot;Error codes&quot; section.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned by the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateEventSourceResponseBodyData Data { get; set; }
        public class CreateEventSourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the event source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:eventbridge:cn-hangzhou:164901546557****:eventbus/my-event-bus/eventsource/mymns.source</para>
            /// </summary>
            [NameInMap("EventSourceARN")]
            [Validation(Required=false)]
            public string EventSourceARN { get; set; }

        }

        /// <summary>
        /// <para>The error message returned if the request is unsuccessful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Remote error. requestId: [A8EFABD2-95B9-1C46-9E01-xxxx], error code: [CreateRelatedResourceFailed], message: [Create related resource failed, EntityNotExist.Role : The role not exists: xxxx. \r\nRequestId : xxxx-168C-54ED-8FEB-BF11CB70AEB7]</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2922208e-e1c6-43ee-bfd1-aca50263bc8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of <c>true</c> indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
