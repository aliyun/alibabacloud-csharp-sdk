// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineKeyPathResponseBody : TeaModel {
        /// <summary>
        /// <para>The critical path information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetBaselineKeyPathResponseBodyData> Data { get; set; }
        public class GetBaselineKeyPathResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The timestamp of the business date of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553443200000</para>
            /// </summary>
            [NameInMap("Bizdate")]
            [Validation(Required=false)]
            public long? Bizdate { get; set; }

            /// <summary>
            /// <para>The cycle number of the instance. Valid values: [1,288\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InGroupId")]
            [Validation(Required=false)]
            public int? InGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node name</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the node owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9527952****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The node type. Common node types include Data Integration (23), MaxCompute SQL (10), Shell (6), and virtual node (99).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PrgType")]
            [Validation(Required=false)]
            public int? PrgType { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The run records of the instance.</para>
            /// </summary>
            [NameInMap("Runs")]
            [Validation(Required=false)]
            public List<GetBaselineKeyPathResponseBodyDataRuns> Runs { get; set; }
            public class GetBaselineKeyPathResponseBodyDataRuns : TeaModel {
                /// <summary>
                /// <para>The timestamp calculated by adding the historical average run duration to the estimated start time of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531402000</para>
                /// </summary>
                [NameInMap("AbsTime")]
                [Validation(Required=false)]
                public long? AbsTime { get; set; }

                /// <summary>
                /// <para>The estimated start time of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531686000</para>
                /// </summary>
                [NameInMap("BeginCast")]
                [Validation(Required=false)]
                public long? BeginCast { get; set; }

                /// <summary>
                /// <para>The timestamp when the instance actually started running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531401000</para>
                /// </summary>
                [NameInMap("BeginRunningTime")]
                [Validation(Required=false)]
                public long? BeginRunningTime { get; set; }

                /// <summary>
                /// <para>The timestamp when the instance entered the waiting-for-resources state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531401000</para>
                /// </summary>
                [NameInMap("BeginWaitResTime")]
                [Validation(Required=false)]
                public long? BeginWaitResTime { get; set; }

                /// <summary>
                /// <para>The timestamp when the instance entered the waiting-for-time state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531400000</para>
                /// </summary>
                [NameInMap("BeginWaitTimeTime")]
                [Validation(Required=false)]
                public long? BeginWaitTimeTime { get; set; }

                /// <summary>
                /// <para>The estimated end time of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531687000</para>
                /// </summary>
                [NameInMap("EndCast")]
                [Validation(Required=false)]
                public long? EndCast { get; set; }

                /// <summary>
                /// <para>The timestamp when the instance actually finished running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531401000</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NOT_RUN: not run.</description></item>
                /// <item><description>WAIT_TIME: waiting for the scheduled time.</description></item>
                /// <item><description>WAIT_RESOURCE: waiting for resources.</description></item>
                /// <item><description>RUNNING: running.</description></item>
                /// <item><description>CHECKING: checking.</description></item>
                /// <item><description>CHECKING_CONDITION: checking conditions.</description></item>
                /// <item><description>FAILURE: failed.</description></item>
                /// <item><description>SUCCESS: succeeded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The event information associated with the instance.</para>
            /// </summary>
            [NameInMap("Topics")]
            [Validation(Required=false)]
            public List<GetBaselineKeyPathResponseBodyDataTopics> Topics { get; set; }
            public class GetBaselineKeyPathResponseBodyDataTopics : TeaModel {
                /// <summary>
                /// <para>The timestamp when the event was detected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531401000</para>
                /// </summary>
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public long? AddTime { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                /// <summary>
                /// <para>The name of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1031203110005</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

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
        /// <para>The unique ID of the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
