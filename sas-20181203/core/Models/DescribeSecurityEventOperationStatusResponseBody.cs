// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityEventOperationStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683940A-E4AE-4473-8C40-F4075434B76B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the task that handles the alert events.</para>
        /// </summary>
        [NameInMap("SecurityEventOperationStatusResponse")]
        [Validation(Required=false)]
        public DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponse SecurityEventOperationStatusResponse { get; set; }
        public class DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponse : TeaModel {
            /// <summary>
            /// <para>An array consisting of the status of the alert events handled by the task.</para>
            /// </summary>
            [NameInMap("SecurityEventOperationStatuses")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponseSecurityEventOperationStatuses> SecurityEventOperationStatuses { get; set; }
            public class DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponseSecurityEventOperationStatuses : TeaModel {
                /// <summary>
                /// <para>The code that indicates the handling result of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ignore.Success</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The ID of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12321</para>
                /// </summary>
                [NameInMap("SecurityEventId")]
                [Validation(Required=false)]
                public string SecurityEventId { get; set; }

                /// <summary>
                /// <para>The handling status of the alert event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Processing</b>: The alert event is being handled.</description></item>
                /// <item><description><b>Success</b>: The alert event is handled.</description></item>
                /// <item><description><b>Failed</b>: The alert event failed to be handled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The status of the task that handles the alert events. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Processing</b>: The task is running.</description></item>
            /// <item><description><b>Success</b>: The task is successful.</description></item>
            /// <item><description><b>Failure</b>: The task failed.</description></item>
            /// <item><description><b>Pending</b>: The task is pending.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

    }

}
