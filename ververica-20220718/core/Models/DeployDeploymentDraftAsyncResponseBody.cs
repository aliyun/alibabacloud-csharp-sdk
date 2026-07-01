// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DeployDeploymentDraftAsyncResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the asynchronous operation. This parameter is returned when the request is successful.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public DeployDeploymentDraftAsyncResponseBodyData Data { get; set; }
        public class DeployDeploymentDraftAsyncResponseBodyData : TeaModel {
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
        /// <list type="bullet">
        /// <item><description><para>If success is false, an error code is returned.</para>
        /// </description></item>
        /// <item><description><para>If success is true, an empty value is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If success is false, an error message is returned.</para>
        /// </description></item>
        /// <item><description><para>If success is true, an empty value is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The status code of the business operation. A value other than 200 indicates that the operation failed.</para>
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
