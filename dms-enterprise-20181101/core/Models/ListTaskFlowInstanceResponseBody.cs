// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the execution records returned.</para>
        /// </summary>
        [NameInMap("DAGInstanceList")]
        [Validation(Required=false)]
        public ListTaskFlowInstanceResponseBodyDAGInstanceList DAGInstanceList { get; set; }
        public class ListTaskFlowInstanceResponseBodyDAGInstanceList : TeaModel {
            [NameInMap("DAGInstance")]
            [Validation(Required=false)]
            public List<ListTaskFlowInstanceResponseBodyDAGInstanceListDAGInstance> DAGInstance { get; set; }
            public class ListTaskFlowInstanceResponseBodyDAGInstanceListDAGInstance : TeaModel {
                /// <summary>
                /// <para>The business time of the task flow. The time is displayed in the yyyy-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-10 14:37:26</para>
                /// </summary>
                [NameInMap("BusinessTime")]
                [Validation(Required=false)]
                public string BusinessTime { get; set; }

                /// <summary>
                /// <para>The ID of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7***</para>
                /// </summary>
                [NameInMap("DagId")]
                [Validation(Required=false)]
                public string DagId { get; set; }

                /// <summary>
                /// <para>The name of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Spark_SQL_test</para>
                /// </summary>
                [NameInMap("DagName")]
                [Validation(Required=false)]
                public string DagName { get; set; }

                /// <summary>
                /// <para>The version of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("DagVersion")]
                [Validation(Required=false)]
                public string DagVersion { get; set; }

                /// <summary>
                /// <para>The time when the execution of the task flow was complete. The time is displayed in the yyyy-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-11 14:38:57</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The ID of the previously published version of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2****</para>
                /// </summary>
                [NameInMap("HistoryDagId")]
                [Validation(Required=false)]
                public long? HistoryDagId { get; set; }

                /// <summary>
                /// <para>The ID of the execution record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The description of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The name of the task flow owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_name</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The status of the task flow. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The task flow is waiting to be scheduled.</description></item>
                /// <item><description><b>1</b>: The task flow is being executed.</description></item>
                /// <item><description><b>2</b>: The task flow is paused.</description></item>
                /// <item><description><b>3</b>: The task flow failed.</description></item>
                /// <item><description><b>4</b>: The task flow is executed.</description></item>
                /// <item><description><b>5</b>: The task flow is complete.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The mode in which the task flow is triggered. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The task flow is automatically triggered based on periodic scheduling.</description></item>
                /// <item><description><b>1</b>: The task flow is manually triggered.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public int? TriggerType { get; set; }

                /// <summary>
                /// <para>The time when the execution of the task flow was start. The time is displayed in the yyyy-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-11 14:35:57</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8CFF2295-8249-5287-B888-DBD4F0D76CB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of execution records returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
