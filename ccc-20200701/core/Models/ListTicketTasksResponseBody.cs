// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListTicketTasksResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTicketTasksResponseBodyData> Data { get; set; }
        public class ListTicketTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The action performed on the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CounterSignTask</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The ID of the assignee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>assignee@ccc-test</para>
            /// </summary>
            [NameInMap("Assignee")]
            [Validation(Required=false)]
            public string Assignee { get; set; }

            /// <summary>
            /// <para>The name of the assignee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>assignee</para>
            /// </summary>
            [NameInMap("AssigneeName")]
            [Validation(Required=false)]
            public string AssigneeName { get; set; }

            /// <summary>
            /// <para>The comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>同意</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620269200000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>A list of files.</para>
            /// </summary>
            [NameInMap("FileKeys")]
            [Validation(Required=false)]
            public List<string> FileKeys { get; set; }

            /// <summary>
            /// <para>A list of file access URLs.</para>
            /// </summary>
            [NameInMap("FileUrls")]
            [Validation(Required=false)]
            public List<string> FileUrls { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620259200000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The ID of the ticket node in the process definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APPROVAL__6zu2QjAz</para>
            /// </summary>
            [NameInMap("TaskDefinitionNodeId")]
            [Validation(Required=false)]
            public string TaskDefinitionNodeId { get; set; }

            /// <summary>
            /// <para>The type of the ticket node in the process definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APPROVAL</para>
            /// </summary>
            [NameInMap("TaskDefinitionNodeType")]
            [Validation(Required=false)]
            public string TaskDefinitionNodeType { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eb039a4a6a5742c6b44ccff0c1fca745</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>节点1</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The ID of the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5491d3b4-14ee-4341-b5f1-db2c78beddeb</para>
            /// </summary>
            [NameInMap("TicketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

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
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A list of error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE803553-8AA9-4B9D-9E4E-A82BC69EDCEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
