// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaApplicationApprovalResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>Specifies whether retries are allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Retries are not allowed.</description></item>
        /// <item><description>true: Retries are allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PARAMETER.ILLEGALL</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter[%s] is required.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetQuotaApplicationApprovalResponseBodyModule Module { get; set; }
        public class GetQuotaApplicationApprovalResponseBodyModule : Darabonba.Model {
            /// <summary>
            /// <para>The average approval time for the quota application. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("ApprovalHours")]
            [Validation(Required=false)]
            public int? ApprovalHours { get; set; }

            /// <summary>
            /// <para>The approval reminder interval for the quota application. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("ReminderIntervalHours")]
            [Validation(Required=false)]
            public int? ReminderIntervalHours { get; set; }

            /// <summary>
            /// <para>Specifies whether approval reminders are supported for the quota application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: Not supported.</description></item>
            /// <item><description>true: Supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportReminder")]
            [Validation(Required=false)]
            public bool? SupportReminder { get; set; }

            /// <summary>
            /// <para>The reason why approval reminders are not supported for the quota application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>can only be remind once within the interval</para>
            /// </summary>
            [NameInMap("UnsupportReminderReason")]
            [Validation(Required=false)]
            public string UnsupportReminderReason { get; set; }

        }

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
        /// <para>Specifies whether the call was successful. Valid values:</para>
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

