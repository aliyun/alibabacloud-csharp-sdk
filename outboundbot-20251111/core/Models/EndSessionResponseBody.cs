// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class EndSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The business processing status code. A value of OK indicates success. If an exception occurs, the corresponding business error code is returned. The error types and mapping rules follow the current API configuration. No error codes are added or modified for this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The session ID of the terminated text session, which corresponds to the session ID in the request. The service still returns this ID even if the session context has expired.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-11111111-2222-4333-8444-555555555555</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The HTTP status code recorded in the business response body. A value of 200 indicates a normal response. To determine whether the business operation is successful, you must also check the Code field. You cannot determine the success of the call based solely on the presence of this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The business response or error message. This field is usually empty or omitted for successful requests. For failed requests, it provides an error description to assist in troubleshooting. Use this field in conjunction with the Code and Params fields to identify the cause of the error. The example shows the error message returned when an instance does not exist, which corresponds to the NotExists.InstanceId error code. This example is for format reference only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance instance-example-001 does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of parameters used to localize error messages. These are not scenario variables or business results. A successful response usually returns an empty array. If an error occurs, the parameters corresponding to the error template may be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The ID used to trace and troubleshoot the current POP request. The value in the response corresponds to the current request. System request parameters are injected by the gateway, so you do not need to specify system fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAAAA-BBBB-4CCC-8DDD-EEEEEEEEEEEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
