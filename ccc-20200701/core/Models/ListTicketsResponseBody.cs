// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListTicketsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTicketsResponseBodyData Data { get; set; }
        public class ListTicketsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListTicketsResponseBodyDataList> List { get; set; }
            public class ListTicketsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>assignee@ccc-test</para>
                /// </summary>
                [NameInMap("Assignee")]
                [Validation(Required=false)]
                public string Assignee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Assignee</para>
                /// </summary>
                [NameInMap("AssigneeName")]
                [Validation(Required=false)]
                public string AssigneeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>43c2671b-*****-4223-86d0-6bd187905cc8</para>
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Completed</para>
                /// </summary>
                [NameInMap("CloseCode")]
                [Validation(Required=false)]
                public string CloseCode { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;productName&quot;:&quot;alynx&quot;}</para>
                /// </summary>
                [NameInMap("Context")]
                [Validation(Required=false)]
                public string Context { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>creator@ccc-test</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Creator</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0707dab6-34a8-11ef-9823-161e3802b2d4</para>
                /// </summary>
                [NameInMap("CurrentTaskId")]
                [Validation(Required=false)]
                public string CurrentTaskId { get; set; }

                [NameInMap("CurrentTaskName")]
                [Validation(Required=false)]
                public string CurrentTaskName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("CurrentTaskStartTime")]
                [Validation(Required=false)]
                public long? CurrentTaskStartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>51e155ce-*****1-b402-13c69597b920</para>
                /// </summary>
                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-47150***150396416</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CHAT</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Processing</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c844a5f0-496c-4c5b-8a0c-dd27686e8ff6</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TemplateVersion")]
                [Validation(Required=false)]
                public string TemplateVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>feb83abd-9f08-49d2-9b56-41d1b66ca0ac</para>
                /// </summary>
                [NameInMap("TicketId")]
                [Validation(Required=false)]
                public string TicketId { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public string UpdatedTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7BEEA660-A45A-45E3-98CC-AFC65E715C23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
