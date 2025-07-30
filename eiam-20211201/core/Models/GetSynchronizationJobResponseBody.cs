// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetSynchronizationJobResponseBody : TeaModel {
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
        /// <para>The information about the synchronization job.</para>
        /// </summary>
        [NameInMap("SynchronizationJob")]
        [Validation(Required=false)]
        public GetSynchronizationJobResponseBodySynchronizationJob SynchronizationJob { get; set; }
        public class GetSynchronizationJobResponseBodySynchronizationJob : TeaModel {
            /// <summary>
            /// <para>The direction of the synchronization job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ingress</description></item>
            /// <item><description>egress</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ingress</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The end time of the synchronization. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The result of the synchronization job.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public GetSynchronizationJobResponseBodySynchronizationJobResult Result { get; set; }
            public class GetSynchronizationJobResponseBodySynchronizationJobResult : TeaModel {
                /// <summary>
                /// <para>The error code corresponding to the error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ResourceNotFound. SynchronizationJob</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned in the case of an error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The specified SynchronizationJob resource: %s not found.</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The group member synchronization result statistics.</para>
                /// </summary>
                [NameInMap("GroupMemberStatistics")]
                [Validation(Required=false)]
                public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatistics GroupMemberStatistics { get; set; }
                public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatistics : TeaModel {
                    /// <summary>
                    /// <para>The binding result statistics.</para>
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsBinded Binded { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsBinded : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The creation result statistics.</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsCreated Created { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The deletion result statistics.</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsDeleted Deleted { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The notification result statistics.</para>
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsPushed Pushed { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsPushed : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The result statistics about identical group members.</para>
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsSame Same { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsSame : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The update result statistics.</para>
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsUpdated Updated { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
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
                public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatistics GroupStatistics { get; set; }
                public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatistics : TeaModel {
                    /// <summary>
                    /// <para>The binding result statistics.</para>
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsBinded Binded { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsBinded : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The creation result statistics.</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsCreated Created { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The deletion result statistics.</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsDeleted Deleted { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The notification result statistics.</para>
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsPushed Pushed { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsPushed : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The result statistics about identical groups.</para>
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsSame Same { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsSame : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The update result statistics.</para>
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsUpdated Updated { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

                /// <summary>
                /// <para>The organization synchronization result statistics.</para>
                /// </summary>
                [NameInMap("OrganizationalUnitStatistics")]
                [Validation(Required=false)]
                public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatistics OrganizationalUnitStatistics { get; set; }
                public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatistics : TeaModel {
                    /// <summary>
                    /// <para>The binding result statistics.</para>
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsBinded Binded { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsBinded : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The creation result statistics.</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsCreated Created { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The deletion result statistics.</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsDeleted Deleted { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The notification result statistics.</para>
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsPushed Pushed { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsPushed : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The result statistics about identical organizations.</para>
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsSame Same { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsSame : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The update result statistics.</para>
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsUpdated Updated { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
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
                public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatistics UserStatistics { get; set; }
                public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatistics : TeaModel {
                    /// <summary>
                    /// <para>The binding result statistics.</para>
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsBinded Binded { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsBinded : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The creation result statistics.</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsCreated Created { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The deletion result statistics.</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsDeleted Deleted { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The notification result statistics.</para>
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsPushed Pushed { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsPushed : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The result statistics about identical users.</para>
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsSame Same { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsSame : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The update result statistics.</para>
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsUpdated Updated { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <para>The number of failed items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The number of skipped items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The number of successful items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total number of items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The start time of the synchronization. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the synchronization job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pending</description></item>
            /// <item><description>running</description></item>
            /// <item><description>failed</description></item>
            /// <item><description>partial_success</description></item>
            /// <item><description>success</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the synchronization job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sync_0000347vjovtcf41li0fgsd98gn24q9nj9xxxxx</para>
            /// </summary>
            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

            /// <summary>
            /// <para>The ID of the synchronization destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_my664lwkhpicbyzirog3nxxxxx</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The type of the synchronization destination. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>identity_provider</description></item>
            /// <item><description>application</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>identity_provider</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The trigger type of the synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>auto</description></item>
            /// <item><description>manual</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

    }

}
