// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ValidateDeploymentDraftAsyncResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ValidateDeploymentDraftAsyncResponseBodyData Data { get; set; }
        public class ValidateDeploymentDraftAsyncResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the asynchronous ticket. Use this ID to query the result of the asynchronous operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b3dcdb25-bf36-457d-92ba-a36077e8****</para>
            /// </summary>
            [NameInMap("ticketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

        }

        /// <summary>
        /// <para>The error code. This parameter is returned when the request fails. If the request is successful, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is returned when the request fails. If the request is successful, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The status code. This is always 200. Use the success parameter to determine if the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBC799F0-AS7S-1D30-8A4F-882ED4DD****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
