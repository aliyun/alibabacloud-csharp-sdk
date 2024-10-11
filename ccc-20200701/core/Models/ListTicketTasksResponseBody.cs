// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListTicketTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTicketTasksResponseBodyData> Data { get; set; }
        public class ListTicketTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CounterSignTask</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>assignee@ccc-test</para>
            /// </summary>
            [NameInMap("Assignee")]
            [Validation(Required=false)]
            public string Assignee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>assignee</para>
            /// </summary>
            [NameInMap("AssigneeName")]
            [Validation(Required=false)]
            public string AssigneeName { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1620269200000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("FileKeys")]
            [Validation(Required=false)]
            public List<string> FileKeys { get; set; }

            [NameInMap("FileUrls")]
            [Validation(Required=false)]
            public List<string> FileUrls { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1620259200000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>APPROVAL__6zu2QjAz</para>
            /// </summary>
            [NameInMap("TaskDefinitionNodeId")]
            [Validation(Required=false)]
            public string TaskDefinitionNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>APPROVAL</para>
            /// </summary>
            [NameInMap("TaskDefinitionNodeType")]
            [Validation(Required=false)]
            public string TaskDefinitionNodeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eb039a4a6a5742c6b44ccff0c1fca745</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5491d3b4-14ee-4341-b5f1-db2c78beddeb</para>
            /// </summary>
            [NameInMap("TicketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DE803553-8AA9-4B9D-9E4E-A82BC69EDCEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
