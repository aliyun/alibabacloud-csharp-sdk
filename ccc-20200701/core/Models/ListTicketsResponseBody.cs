// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListTicketsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTicketsResponseBodyData Data { get; set; }
        public class ListTicketsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Tickets list.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListTicketsResponseBodyDataList> List { get; set; }
            public class ListTicketsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Assignee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>assignee@ccc-test</para>
                /// </summary>
                [NameInMap("Assignee")]
                [Validation(Required=false)]
                public string Assignee { get; set; }

                /// <summary>
                /// <para>Assignee name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Assignee</para>
                /// </summary>
                [NameInMap("AssigneeName")]
                [Validation(Required=false)]
                public string AssigneeName { get; set; }

                /// <summary>
                /// <para>Ticket category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43c2671b-*****-4223-86d0-6bd187905cc8</para>
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                /// <summary>
                /// <para>Ticket category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>类目1</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para>Ticket close reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Completed</para>
                /// </summary>
                [NameInMap("CloseCode")]
                [Validation(Required=false)]
                public string CloseCode { get; set; }

                /// <summary>
                /// <para>Comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>Ticket form information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;productName&quot;:&quot;alynx&quot;}</para>
                /// </summary>
                [NameInMap("Context")]
                [Validation(Required=false)]
                public string Context { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>Creator ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>creator@ccc-test</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>Creator name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Creator</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>Current node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0707dab6-34a8-11ef-9823-161e3802b2d4</para>
                /// </summary>
                [NameInMap("CurrentTaskId")]
                [Validation(Required=false)]
                public string CurrentTaskId { get; set; }

                /// <summary>
                /// <para>Current node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>节点1</para>
                /// </summary>
                [NameInMap("CurrentTaskName")]
                [Validation(Required=false)]
                public string CurrentTaskName { get; set; }

                /// <summary>
                /// <para>Current node start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("CurrentTaskStartTime")]
                [Validation(Required=false)]
                public long? CurrentTaskStartTime { get; set; }

                /// <summary>
                /// <para>Customer ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51e155ce-*****1-b402-13c69597b920</para>
                /// </summary>
                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                /// <summary>
                /// <para>Ticket end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-47150***150396416</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>Ticket source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHAT</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>Ticket start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>State.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Processing</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>Template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c844a5f0-496c-4c5b-8a0c-dd27686e8ff6</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <para>Template version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TemplateVersion")]
                [Validation(Required=false)]
                public string TemplateVersion { get; set; }

                /// <summary>
                /// <para>Ticket ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>feb83abd-9f08-49d2-9b56-41d1b66ca0ac</para>
                /// </summary>
                [NameInMap("TicketId")]
                [Validation(Required=false)]
                public string TicketId { get; set; }

                /// <summary>
                /// <para>Ticket title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>标题</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public string UpdatedTime { get; set; }

            }

            /// <summary>
            /// <para>Paging ordinal number. Range: 1-100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>Paging size. Range: 1-100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BEEA660-A45A-45E3-98CC-AFC65E715C23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
