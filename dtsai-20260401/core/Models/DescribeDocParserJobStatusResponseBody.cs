// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DtsAI20260401.Models
{
    public class DescribeDocParserJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JobNotFound</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified job does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The failure reason. This parameter has a value only when Status is failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed Message</para>
        /// </summary>
        [NameInMap("FailureMessage")]
        [Validation(Required=false)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A30D0930-xxxx-xxxx-xxxx-C2C661CC8B58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>init</b>: Created and being prepared.</para>
        /// </description></item>
        /// <item><description><para><b>pending</b>: Queued and waiting to be scheduled.</para>
        /// </description></item>
        /// <item><description><para><b>running</b>: Being processed and parsed.</para>
        /// </description></item>
        /// <item><description><para><b>success</b>: Completed. You can call DescribeDocParserJobResult to obtain the result.</para>
        /// </description></item>
        /// <item><description><para><b>failed</b>: Failed. The reason is provided in FailureMessage.</para>
        /// </description></item>
        /// <item><description><para><b>cancelled</b>: Cancelled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
