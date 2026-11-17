// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class MakePilotCallResponseBody : TeaModel {
        /// <summary>
        /// <para>The business processing status code. OK indicates success. When an exception occurs, the corresponding business error code is returned. Error types and mapping rules follow the current API configuration. No error codes are added or modified in this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The session ID of the current real-number outbound call test. The return of this object does not indicate that the called party has answered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SessionId&quot;:&quot;test-11111111-2222-4333-8444-555555555555&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MakePilotCallResponseBodyData Data { get; set; }
        public class MakePilotCallResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The session ID used to uniquely associate the current interaction. For a text session, it is the text- ID returned when the session is started. For web voice, it is the ws- ID. For a real-number outbound call test, it is the test- ID. Subsequent calls must use the actual return value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-11111111-2222-4333-8444-555555555555</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code recorded in the business response body. A normal return value is 200. To determine whether the business operation is successful, you must also check Code. You cannot determine the success of the call solely based on the presence of this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The business response or error description. This field is usually empty or not returned upon success. A fixed text cannot be required upon success. Upon failure, this field contains an error description to assist in troubleshooting. Combine this field with Code and Params to understand the cause of the error. The example shows an error message when the instance does not exist, where Code is NotExists.InstanceId. This is for format reference only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance instance-example-001 does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of parameters used for the localized display of error messages. This is not a scenario variable or business result. A normal successful response usually returns an empty array. When an error occurs, parameters corresponding to the error template may be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The ID used to associate and troubleshoot the current POP request. The value in the response corresponds to the current request. System request parameters are injected by the gateway. Callers do not need to fill in system fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAAAA-BBBB-4CCC-8DDD-EEEEEEEEEEEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
