// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineKeyPathResponseBody : TeaModel {
        /// <summary>
        /// The information about the key path.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetBaselineKeyPathResponseBodyData> Data { get; set; }
        public class GetBaselineKeyPathResponseBodyData : TeaModel {
            /// <summary>
            /// The data timestamp of the baseline instance.
            /// </summary>
            [NameInMap("Bizdate")]
            [Validation(Required=false)]
            public long? Bizdate { get; set; }

            /// <summary>
            /// The ID of the scheduling cycle of the instance. Valid values: 1 to 288.
            /// </summary>
            [NameInMap("InGroupId")]
            [Validation(Required=false)]
            public int? InGroupId { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// The name of the node.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account used by the node owner.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The type of the node. Valid values: 23, 10, 6, and 99. The value 23 indicates that the node is a Data Integration node. The value 10 indicates that the node is a MaxCompute SQL node. The value 6 indicates that the node is a Shell node. The value 99 indicates that the node is a zero load node.
            /// </summary>
            [NameInMap("PrgType")]
            [Validation(Required=false)]
            public int? PrgType { get; set; }

            /// <summary>
            /// The ID of the workspace to which the node belongs.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// The running records of the instance.
            /// </summary>
            [NameInMap("Runs")]
            [Validation(Required=false)]
            public List<GetBaselineKeyPathResponseBodyDataRuns> Runs { get; set; }
            public class GetBaselineKeyPathResponseBodyDataRuns : TeaModel {
                /// <summary>
                /// The timestamp obtained by adding the predicted time when the instance started to run to the historical average running duration of the instance.
                /// </summary>
                [NameInMap("AbsTime")]
                [Validation(Required=false)]
                public long? AbsTime { get; set; }

                /// <summary>
                /// The timestamp of the predicted time when the instance started to run.
                /// </summary>
                [NameInMap("BeginCast")]
                [Validation(Required=false)]
                public long? BeginCast { get; set; }

                /// <summary>
                /// The timestamp of the actual time when the instance started to run.
                /// </summary>
                [NameInMap("BeginRunningTime")]
                [Validation(Required=false)]
                public long? BeginRunningTime { get; set; }

                /// <summary>
                /// The timestamp when the instance started to wait for resources.
                /// </summary>
                [NameInMap("BeginWaitResTime")]
                [Validation(Required=false)]
                public long? BeginWaitResTime { get; set; }

                /// <summary>
                /// The timestamp when the instance started to wait for the scheduling time.
                /// </summary>
                [NameInMap("BeginWaitTimeTime")]
                [Validation(Required=false)]
                public long? BeginWaitTimeTime { get; set; }

                /// <summary>
                /// The timestamp of the predicted time when the instance finished running.
                /// </summary>
                [NameInMap("EndCast")]
                [Validation(Required=false)]
                public long? EndCast { get; set; }

                /// <summary>
                /// The timestamp of the actual time when the instance finished running.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// The status of the instance. Valid values: NOT_RUN, WAIT_TIME, WAIT_RESOURCE, RUNNING, CHECKING, CHECKING_CONDITION, FAILURE, and SUCCESS. The value NOT_RUN indicates that the instance is not run. The value WAIT_TIME indicates that the instance is waiting to be run. The value WAIT_RESOURCE indicates that the instance is waiting for resources. The value RUNNING indicates that the instance is running. The value CHECKING indicates that data quality is being checked for the instance. The value CHECKING_CONDITION indicates that branch conditions are being checked for the instance. The value FAILURE indicates that the instance fails to run. The value SUCCESS indicates that the instance is run.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The information about the events that are associated with the instance.
            /// </summary>
            [NameInMap("Topics")]
            [Validation(Required=false)]
            public List<GetBaselineKeyPathResponseBodyDataTopics> Topics { get; set; }
            public class GetBaselineKeyPathResponseBodyDataTopics : TeaModel {
                /// <summary>
                /// The timestamp when the event was found.
                /// </summary>
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public long? AddTime { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The ID of the event.
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                /// <summary>
                /// The name of the event.
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
