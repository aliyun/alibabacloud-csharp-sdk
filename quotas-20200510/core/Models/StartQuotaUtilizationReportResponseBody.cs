// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class StartQuotaUtilizationReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAM.PERMISSION.DENIED</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to do this action or the API input parameter is invalid.</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The description of the request processing result, such as report generation started or the allowed refresh time not reached. Use RefreshSuccess to determine the submission result instead of relying on the prompt text for programmatic evaluation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quota utilization report generation has started</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The UTC time when the next refresh can be initiated, in the yyyy-MM-dd\&quot;T\&quot;HH:mm:ss\&quot;Z\&quot; format, such as 2026-10-26T08:00:00Z. This parameter is returned when a task is not submitted due to refresh limits. This parameter is empty when a task is successfully submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-26T08:00:00Z</para>
        /// </summary>
        [NameInMap("NextRefreshTime")]
        [Validation(Required=false)]
        public string NextRefreshTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the report generation task was successfully submitted. A value of true indicates that the asynchronous task was submitted, but the report is not yet generated. A value of false indicates that the refresh limit period has not ended and no new task was submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RefreshSuccess")]
        [Validation(Required=false)]
        public bool? RefreshSuccess { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ED584FB-ECBF-4A2A-969D-F54D25EFABF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
