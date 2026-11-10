// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListSynchronizationJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The query token returned by this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of synchronization jobs.</para>
        /// </summary>
        [NameInMap("SynchronizationJobs")]
        [Validation(Required=false)]
        public List<ListSynchronizationJobsResponseBodySynchronizationJobs> SynchronizationJobs { get; set; }
        public class ListSynchronizationJobsResponseBodySynchronizationJobs : TeaModel {
            /// <summary>
            /// <para>The description of the synchronization job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The direction of the synchronization task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ingress: inbound</para>
            /// </description></item>
            /// <item><description><para>egress: outbound</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ingress</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The end time of the synchronization. The time is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The task result of the synchronization node.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public ListSynchronizationJobsResponseBodySynchronizationJobsResult Result { get; set; }
            public class ListSynchronizationJobsResponseBodySynchronizationJobsResult : TeaModel {
                /// <summary>
                /// <para>The error code of the synchronization result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MissingParameter.Username</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message of the synchronization result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The specified parameter Username is required!</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The statistics of the group member synchronization result.</para>
                /// </summary>
                [NameInMap("GroupMemberStatistics")]
                [Validation(Required=false)]
                public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatistics GroupMemberStatistics { get; set; }
                public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatistics : TeaModel {
                    /// <summary>
                    /// <para>The statistics of the binding result.</para>
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsBinded Binded { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsBinded : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the creation result.</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsCreated Created { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the deletion result.</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsDeleted Deleted { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the push result.</para>
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsPushed Pushed { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsPushed : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of identical results.</para>
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsSame Same { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsSame : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the update result.</para>
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsUpdated Updated { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

                /// <summary>
                /// <para>The group synchronization result statistics.</para>
                /// </summary>
                [NameInMap("GroupStatistics")]
                [Validation(Required=false)]
                public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatistics GroupStatistics { get; set; }
                public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatistics : TeaModel {
                    /// <summary>
                    /// <para>The statistics of the binding result.</para>
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsBinded Binded { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsBinded : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the creation result.</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsCreated Created { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the deletion result.</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsDeleted Deleted { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the push result.</para>
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsPushed Pushed { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsPushed : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of identical results.</para>
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsSame Same { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsSame : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the update result.</para>
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsUpdated Updated { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

                /// <summary>
                /// <para>The organizational unit synchronization result statistics.</para>
                /// </summary>
                [NameInMap("OrganizationalUnitStatistics")]
                [Validation(Required=false)]
                public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatistics OrganizationalUnitStatistics { get; set; }
                public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatistics : TeaModel {
                    /// <summary>
                    /// <para>The statistics of the binding result.</para>
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsBinded Binded { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsBinded : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the creation result.</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsCreated Created { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the deletion result.</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsDeleted Deleted { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The export result statistics.</para>
                    /// </summary>
                    [NameInMap("Exported")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsExported Exported { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsExported : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the push result.</para>
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsPushed Pushed { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsPushed : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of identical results.</para>
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsSame Same { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsSame : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the update result.</para>
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsUpdated Updated { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

                /// <summary>
                /// <para>The user synchronization result statistics.</para>
                /// </summary>
                [NameInMap("UserStatistics")]
                [Validation(Required=false)]
                public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatistics UserStatistics { get; set; }
                public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatistics : TeaModel {
                    /// <summary>
                    /// <para>The statistics of the binding result.</para>
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsBinded Binded { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsBinded : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the creation result.</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsCreated Created { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the deletion result.</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsDeleted Deleted { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The export result statistics.</para>
                    /// </summary>
                    [NameInMap("Exported")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsExported Exported { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsExported : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the push result.</para>
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsPushed Pushed { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsPushed : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of identical results.</para>
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsSame Same { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsSame : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The statistics of the update result.</para>
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsUpdated Updated { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <para>The number of failures.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The start time of the synchronization. The time is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the synchronization task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>pending: initial state</para>
            /// </description></item>
            /// <item><description><para>running: running</para>
            /// </description></item>
            /// <item><description><para>failed: failed</para>
            /// </description></item>
            /// <item><description><para>partial_success: partially successful</para>
            /// </description></item>
            /// <item><description><para>success: successful</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the synchronization job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sync_0000347vjovtcf41li0fgsd98gn24q9njxxxxx</para>
            /// </summary>
            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

            /// <summary>
            /// <para>The synchronization target ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_my664lwkhpicbyzirog3xxxxx</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The type of the synchronization target. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>identity_provider: identity provider</para>
            /// </description></item>
            /// <item><description><para>application: application</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>identity_provider</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The trigger type of the synchronization job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>auto: Automatically triggered.</para>
            /// </description></item>
            /// <item><description><para>manual: Manually triggered.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
