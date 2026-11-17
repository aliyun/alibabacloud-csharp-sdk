// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetWorkItemAuditResponseBody : TeaModel {
        /// <summary>
        /// <para>The common business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The complete work item audit records sorted in descending order of event time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;eventId&quot;:&quot;evt_example&quot;,&quot;eventType&quot;:&quot;WORK_ITEM_UPDATED&quot;,&quot;occurredAt&quot;:&quot;2026-11-05T08:00:00Z&quot;,&quot;status&quot;:&quot;SUCCESS&quot;}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<GetWorkItemAuditResponseBodyItems> Items { get; set; }
        public class GetWorkItemAuditResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of field change details. Each item includes the changed field and its values before and after the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;field&quot;:&quot;title&quot;,&quot;before&quot;:&quot;Old title&quot;,&quot;after&quot;:&quot;New title&quot;}]</para>
            /// </summary>
            [NameInMap("changes")]
            [Validation(Required=false)]
            public object Changes { get; set; }

            /// <summary>
            /// <para>The event description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The work item title is changed to Quarterly Sales Opportunity Review</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The unique identifier of the audit event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>evt_20261105_0001</para>
            /// </summary>
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The audit event type, such as WORK_ITEM_UPDATED or TODO_COMPLETED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WORK_ITEM_UPDATED</para>
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The time when the event occurred, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-05T08:00:00Z</para>
            /// </summary>
            [NameInMap("occurredAt")]
            [Validation(Required=false)]
            public string OccurredAt { get; set; }

            /// <summary>
            /// <para>The display name of the operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("operatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <para>The user ID of the operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("operatorUserId")]
            [Validation(Required=false)]
            public string OperatorUserId { get; set; }

            /// <summary>
            /// <para>The list of questions to be confirmed related to the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;question&quot;:&quot;Whether to continue execution&quot;}]</para>
            /// </summary>
            [NameInMap("questions")]
            [Validation(Required=false)]
            public List<object> Questions { get; set; }

            /// <summary>
            /// <para>The event result payload as a JSON object. If no result is available, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;result&quot;:&quot;ok&quot;}</para>
            /// </summary>
            [NameInMap("resultPayload")]
            [Validation(Required=false)]
            public object ResultPayload { get; set; }

            /// <summary>
            /// <para>The event status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The event title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Investigate sales opportunities</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The ID of the associated to-do item. If no to-do item is associated, an empty string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>todo_20261105_0007</para>
            /// </summary>
            [NameInMap("todoId")]
            [Validation(Required=false)]
            public string TodoId { get; set; }

        }

        /// <summary>
        /// <para>The common error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
