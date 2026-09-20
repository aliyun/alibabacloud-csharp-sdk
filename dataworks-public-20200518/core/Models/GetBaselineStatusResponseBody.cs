// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the baseline instance.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBaselineStatusResponseBodyData Data { get; set; }
        public class GetBaselineStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            /// <summary>
            /// <para>The name of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Baseline name</para>
            /// </summary>
            [NameInMap("BaselineName")]
            [Validation(Required=false)]
            public string BaselineName { get; set; }

            /// <summary>
            /// <para>The business date timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553443200000</para>
            /// </summary>
            [NameInMap("Bizdate")]
            [Validation(Required=false)]
            public long? Bizdate { get; set; }

            /// <summary>
            /// <para>The information about the critical instance.</para>
            /// </summary>
            [NameInMap("BlockInstance")]
            [Validation(Required=false)]
            public GetBaselineStatusResponseBodyDataBlockInstance BlockInstance { get; set; }
            public class GetBaselineStatusResponseBodyDataBlockInstance : TeaModel {
                /// <summary>
                /// <para>The estimated completion timestamp of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553443200000</para>
                /// </summary>
                [NameInMap("EndCast")]
                [Validation(Required=false)]
                public long? EndCast { get; set; }

                /// <summary>
                /// <para>The actual completion timestamp of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553443200000</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
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
                /// <para>NodeName</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud UID of the node owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527952795****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

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
                /// <para>The status of the instance. Valid values: NOT_RUN, WAIT_TIME, WAIT_RESOURCE, RUNNING, CHECKING, CHECKING_CONDITION, FAILURE, and SUCCESS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The buffer time of the baseline instance, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("Buffer")]
            [Validation(Required=false)]
            public float? Buffer { get; set; }

            /// <summary>
            /// <para>The estimated completion timestamp of the baseline instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553443200000</para>
            /// </summary>
            [NameInMap("EndCast")]
            [Validation(Required=false)]
            public long? EndCast { get; set; }

            /// <summary>
            /// <para>The warning timestamp of the baseline instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553443200000</para>
            /// </summary>
            [NameInMap("ExpTime")]
            [Validation(Required=false)]
            public long? ExpTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the baseline instance is completed. Valid values: UNFINISH and FINISH.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UNFINISH</para>
            /// </summary>
            [NameInMap("FinishStatus")]
            [Validation(Required=false)]
            public string FinishStatus { get; set; }

            /// <summary>
            /// <para>The completion timestamp of the baseline instance. This parameter is returned only when FinishStatus is FINISH.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553443200000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The cycle number of the baseline instance. The value is 1 for daily baselines. The value ranges from [1,24\] for hourly baselines.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InGroupId")]
            [Validation(Required=false)]
            public int? InGroupId { get; set; }

            /// <summary>
            /// <para>The information about the latest instance.</para>
            /// </summary>
            [NameInMap("LastInstance")]
            [Validation(Required=false)]
            public GetBaselineStatusResponseBodyDataLastInstance LastInstance { get; set; }
            public class GetBaselineStatusResponseBodyDataLastInstance : TeaModel {
                /// <summary>
                /// <para>The estimated completion timestamp of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553443200000</para>
                /// </summary>
                [NameInMap("EndCast")]
                [Validation(Required=false)]
                public long? EndCast { get; set; }

                /// <summary>
                /// <para>The actual completion timestamp of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553443200000</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
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
                /// <para>9527952795****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

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
                /// <para>The status of the instance. Valid values: NOT_RUN, WAIT_TIME, WAIT_RESOURCE, RUNNING, CHECKING, CHECKING_CONDITION, FAILURE, and SUCCESS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the baseline owner. Multiple owners are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>9527952795****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The priority of the baseline. Valid values: 1, 2, 5, 7, and 8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the baseline belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The committed completion timestamp of the baseline instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553443200000</para>
            /// </summary>
            [NameInMap("SlaTime")]
            [Validation(Required=false)]
            public long? SlaTime { get; set; }

            /// <summary>
            /// <para>The status of the baseline. Valid values: ERROR, SAFE, DANGROUS (warning), and OVER (exceeded).</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAFE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
