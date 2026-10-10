// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetTicketResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTicketResponseBodyData Data { get; set; }
        public class GetTicketResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The assignee ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent1@ccc-test</para>
            /// </summary>
            [NameInMap("Assignee")]
            [Validation(Required=false)]
            public string Assignee { get; set; }

            /// <summary>
            /// <para>The assignee name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent A</para>
            /// </summary>
            [NameInMap("AssigneeName")]
            [Validation(Required=false)]
            public string AssigneeName { get; set; }

            /// <summary>
            /// <para>The ticket category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8939-4223-86d0-6bd187905cc8</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The ticket category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>After-sales category</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The reason for closing the ticket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Completed: Completed.</description></item>
            /// <item><description>Terminated: Canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Completed</para>
            /// </summary>
            [NameInMap("CloseCode")]
            [Validation(Required=false)]
            public string CloseCode { get; set; }

            /// <summary>
            /// <para>The handling comments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The ticket field information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;productName&quot;:&quot;Product A&quot;}</para>
            /// </summary>
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            /// <summary>
            /// <para>The time when the ticket was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620259200000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The creator ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>creator@ccc-test</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The creator name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent B</para>
            /// </summary>
            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>The current node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>912f0b78-6639-4a93-ae18-0d832885c27e</para>
            /// </summary>
            [NameInMap("CurrentTaskId")]
            [Validation(Required=false)]
            public string CurrentTaskId { get; set; }

            /// <summary>
            /// <para>The current node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node 1</para>
            /// </summary>
            [NameInMap("CurrentTaskName")]
            [Validation(Required=false)]
            public string CurrentTaskName { get; set; }

            /// <summary>
            /// <para>The start time of the current node. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1693793208075</para>
            /// </summary>
            [NameInMap("CurrentTaskStartTime")]
            [Validation(Required=false)]
            public long? CurrentTaskStartTime { get; set; }

            /// <summary>
            /// <para>The customer ID in the customer profile of Cloud Call Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4223-86d0-6bd187905-891798749</para>
            /// </summary>
            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// <para>The completion time of ticket processing. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687846259999</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The call ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-399383842187575296</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The ticket source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AUDIO: Voice service.</description></item>
            /// <item><description>CHAT: Online service.</description></item>
            /// <item><description>Console: Created from the ticket console.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Audio</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The start time of ticket processing. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620259200000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The ticket status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Processing: Processing.</description></item>
            /// <item><description>Withdrawal: Withdrawn.</description></item>
            /// <item><description>Rejected: Rejected.</description></item>
            /// <item><description>Closed: Closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Processing</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The ticket template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test_43c2671b-8939-4223-86d0-6bd187905cc8_*****0666238</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The ticket template version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The ticket ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b3a6a131-359e-46bd-9bc5-1f5cb0ea093f</para>
            /// </summary>
            [NameInMap("TicketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

            /// <summary>
            /// <para>The ticket title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>After-sales ticket</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The time of the last update. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1693793208075</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BF268B34-09C2-43FD-BAC4-5D31EA633111</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
