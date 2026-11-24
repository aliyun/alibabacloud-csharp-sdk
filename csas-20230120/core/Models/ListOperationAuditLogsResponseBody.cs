// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListOperationAuditLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of administrator operation audit logs. The logs are sorted in descending order of operation time.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<ListOperationAuditLogsResponseBodyLogs> Logs { get; set; }
        public class ListOperationAuditLogsResponseBodyLogs : TeaModel {
            /// <summary>
            /// <para>The snapshot after the operation. It is recorded as-is by the audit framework and is not localized. This field is empty for historical logs that are not connected to the audit framework.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;RequestId&quot;:&quot;01A03244-5BAD-5FAA-93D6-E4F4A1A2****&quot;}</para>
            /// </summary>
            [NameInMap("AfterAction")]
            [Validation(Required=false)]
            public string AfterAction { get; set; }

            /// <summary>
            /// <para>The snapshot before the operation. It is recorded as-is by the audit framework and is not localized. This field is empty for historical logs that are not connected to the audit framework.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;pa-application-ea73352b4b75****&quot;</para>
            /// </summary>
            [NameInMap("BeforeAction")]
            [Validation(Required=false)]
            public string BeforeAction { get; set; }

            /// <summary>
            /// <para>The error code returned when the operation fails. This field is empty when the operation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceNotFound</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the operation fails. This field is empty when the operation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>the specified resource is not found</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The source type of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>console</b>: The event is triggered by a console call.</description></item>
            /// <item><description><b>sdk</b>: The event is triggered by an SDK call.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>console</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The operation feature module. The return value is localized based on the request language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office data protection</para>
            /// </summary>
            [NameInMap("OperationFunc")]
            [Validation(Required=false)]
            public string OperationFunc { get; set; }

            /// <summary>
            /// <para>The operation page. The return value is localized based on the request language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Peripheral management</para>
            /// </summary>
            [NameInMap("OperationPage")]
            [Validation(Required=false)]
            public string OperationPage { get; set; }

            /// <summary>
            /// <para>The operation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-24 13:38:06</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

            /// <summary>
            /// <para>The operation type. The return value is localized based on the request language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Modify peripheral control policy</para>
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID (AliUid) of the operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234****</para>
            /// </summary>
            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9D4B681-0E79-57B7-AF0D-4A675D40141C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of logs that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
