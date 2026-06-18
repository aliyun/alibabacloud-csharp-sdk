// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Request status code. A return value of OK indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List of job data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTaskResponseBodyData Data { get; set; }
        public class ListTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>Number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>List of job information.</para>
            /// </summary>
            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<ListTaskResponseBodyDataRecord> Record { get; set; }
            public class ListTaskResponseBodyDataRecord : TeaModel {
                /// <summary>
                /// <para>Number of completed calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CompleteCount")]
                [Validation(Required=false)]
                public int? CompleteCount { get; set; }

                /// <summary>
                /// <para>Job start time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1618477232000</para>
                /// </summary>
                [NameInMap("FireTime")]
                [Validation(Required=false)]
                public string FireTime { get; set; }

                /// <summary>
                /// <para>Creation Time of the job. Format: UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1618477232000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The unique job ID for the robot calling task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the specified robot, which is the script ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12****</para>
                /// </summary>
                [NameInMap("RobotId")]
                [Validation(Required=false)]
                public long? RobotId { get; set; }

                /// <summary>
                /// <para>Robot Name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>机器人</para>
                /// </summary>
                [NameInMap("RobotName")]
                [Validation(Required=false)]
                public string RobotName { get; set; }

                /// <summary>
                /// <para>Task Status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RELEASE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Task Name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试任务</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>Total number of processed calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>Total number of jobs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API was invoked successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
