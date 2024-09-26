// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineKeyPathResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the key path.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetBaselineKeyPathResponseBodyData> Data { get; set; }
        public class GetBaselineKeyPathResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data timestamp of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553443200000</para>
            /// </summary>
            [NameInMap("Bizdate")]
            [Validation(Required=false)]
            public long? Bizdate { get; set; }

            /// <summary>
            /// <para>The ID of the scheduling cycle of the instance. Valid values: 1 to 288.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InGroupId")]
            [Validation(Required=false)]
            public int? InGroupId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account used by the node owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9527952****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The type of the node. Valid values: 23, 10, 6, and 99. The value 23 indicates that the node is a Data Integration node. The value 10 indicates that the node is a MaxCompute SQL node. The value 6 indicates that the node is a Shell node. The value 99 indicates that the node is a zero load node.</para>
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
            /// <para>The running records of the instance.</para>
            /// </summary>
            [NameInMap("Runs")]
            [Validation(Required=false)]
            public List<GetBaselineKeyPathResponseBodyDataRuns> Runs { get; set; }
            public class GetBaselineKeyPathResponseBodyDataRuns : TeaModel {
                /// <summary>
                /// <para>The timestamp obtained by adding the predicted time when the instance started to run to the historical average running duration of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531402000</para>
                /// </summary>
                [NameInMap("AbsTime")]
                [Validation(Required=false)]
                public long? AbsTime { get; set; }

                /// <summary>
                /// <para>The timestamp of the predicted time when the instance started to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531686000</para>
                /// </summary>
                [NameInMap("BeginCast")]
                [Validation(Required=false)]
                public long? BeginCast { get; set; }

                /// <summary>
                /// <para>The timestamp of the actual time when the instance started to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531401000</para>
                /// </summary>
                [NameInMap("BeginRunningTime")]
                [Validation(Required=false)]
                public long? BeginRunningTime { get; set; }

                /// <summary>
                /// <para>The timestamp when the instance started to wait for resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531401000</para>
                /// </summary>
                [NameInMap("BeginWaitResTime")]
                [Validation(Required=false)]
                public long? BeginWaitResTime { get; set; }

                /// <summary>
                /// <para>The timestamp when the instance started to wait for the scheduling time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531400000</para>
                /// </summary>
                [NameInMap("BeginWaitTimeTime")]
                [Validation(Required=false)]
                public long? BeginWaitTimeTime { get; set; }

                /// <summary>
                /// <para>The timestamp of the predicted time when the instance finished running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531687000</para>
                /// </summary>
                [NameInMap("EndCast")]
                [Validation(Required=false)]
                public long? EndCast { get; set; }

                /// <summary>
                /// <para>The timestamp of the actual time when the instance finished running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531401000</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The status of the instance. Valid values: NOT_RUN, WAIT_TIME, WAIT_RESOURCE, RUNNING, CHECKING, CHECKING_CONDITION, FAILURE, and SUCCESS. The value NOT_RUN indicates that the instance is not run. The value WAIT_TIME indicates that the instance is waiting to be run. The value WAIT_RESOURCE indicates that the instance is waiting for resources. The value RUNNING indicates that the instance is running. The value CHECKING indicates that data quality is being checked for the instance. The value CHECKING_CONDITION indicates that branch conditions are being checked for the instance. The value FAILURE indicates that the instance fails to run. The value SUCCESS indicates that the instance is run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The information about the events that are associated with the instance.</para>
            /// </summary>
            [NameInMap("Topics")]
            [Validation(Required=false)]
            public List<GetBaselineKeyPathResponseBodyDataTopics> Topics { get; set; }
            public class GetBaselineKeyPathResponseBodyDataTopics : TeaModel {
                /// <summary>
                /// <para>The timestamp when the event was found.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531401000</para>
                /// </summary>
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public long? AddTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The event ID.</para>
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
        /// <b>Example:</b>
        /// <para>1031203110005</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The timestamp when the event was found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
