// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateBatchJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The job group information.</para>
        /// </summary>
        [NameInMap("BatchJob")]
        [Validation(Required=false)]
        public CreateBatchJobsResponseBodyBatchJob BatchJob { get; set; }
        public class CreateBatchJobsResponseBodyBatchJob : TeaModel {
            /// <summary>
            /// <para>The job group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5a7e8b09-baf9-4cab-b540-c971f47a7146</para>
            /// </summary>
            [NameInMap("BatchJobId")]
            [Validation(Required=false)]
            public string BatchJobId { get; set; }

            /// <summary>
            /// <para>The list of calling numbers.</para>
            /// </summary>
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            /// <summary>
            /// <para>The time when the job group was created. The time is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1579068424000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The key of the uploaded Excel file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>52e80b02-0126-4556-a1e6-ef5b3747ed53/a9a3ddc7-d7d7-48cd-82b5-b31bb5510e71_2a66f8ad-dfbb-4980-9b84-439171295a11.xlsx</para>
            /// </summary>
            [NameInMap("JobFilePath")]
            [Validation(Required=false)]
            public string JobFilePath { get; set; }

            /// <summary>
            /// <para>The description of the job group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>First batch job</para>
            /// </summary>
            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            /// <summary>
            /// <para>The name of the job group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Batch job 01</para>
            /// </summary>
            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            /// <summary>
            /// <para>The scenario ID of the job group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6cea9bed-63e6-439e-ae4c-b3333efff53d</para>
            /// </summary>
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            /// <summary>
            /// <para>The job execution strategy.</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public CreateBatchJobsResponseBodyBatchJobStrategy Strategy { get; set; }
            public class CreateBatchJobsResponseBodyBatchJobStrategy : TeaModel {
                /// <summary>
                /// <para>The custom information of the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                /// <summary>
                /// <para>The end time of the scheduling strategy. The time is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2209702074000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The follow-up strategy for outbound calls that are not completed in the previous cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONTINUE</para>
                /// </summary>
                [NameInMap("FollowUpStrategy")]
                [Validation(Required=false)]
                public string FollowUpStrategy { get; set; }

                /// <summary>
                /// <para>Indicates whether the strategy is a template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                /// <summary>
                /// <para>The maximum number of retries per day after a call fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                /// <summary>
                /// <para>The minimum interval between retries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                /// <summary>
                /// <para>The repetition mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Once: The job is not repeated.</description></item>
                /// <item><description>Day: The job is repeated every day.</description></item>
                /// <item><description>Week: The job is repeated every week.</description></item>
                /// <item><description>Month: The job is repeated every month.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }

                /// <summary>
                /// <para>The list of days on which the job is repeated.</para>
                /// </summary>
                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }

                /// <summary>
                /// <para>The recording strategy for the calling number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LocalFirst</para>
                /// </summary>
                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                /// <summary>
                /// <para>The time when the job group starts to be executed. The time is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578550074000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The strategy description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Job execution strategy</para>
                /// </summary>
                [NameInMap("StrategyDescription")]
                [Validation(Required=false)]
                public string StrategyDescription { get; set; }

                /// <summary>
                /// <para>The strategy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f718798d-96be-40e4-bef6-317b54855708</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// <para>The strategy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Strategy</para>
                /// </summary>
                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

                /// <summary>
                /// <para>The strategy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Repeatable</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The time periods during which the job is executed in a day.</para>
                /// </summary>
                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<CreateBatchJobsResponseBodyBatchJobStrategyWorkingTime> WorkingTime { get; set; }
                public class CreateBatchJobsResponseBodyBatchJobStrategyWorkingTime : TeaModel {
                    /// <summary>
                    /// <para>The start time. The format is HH:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>09:00:00</para>
                    /// </summary>
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    /// <summary>
                    /// <para>The end time. The format is HH:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
