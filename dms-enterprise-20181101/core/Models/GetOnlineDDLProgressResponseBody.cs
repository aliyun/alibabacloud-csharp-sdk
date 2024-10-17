// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOnlineDDLProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details of the task.</para>
        /// </summary>
        [NameInMap("OnlineDDLTaskDetail")]
        [Validation(Required=false)]
        public GetOnlineDDLProgressResponseBodyOnlineDDLTaskDetail OnlineDDLTaskDetail { get; set; }
        public class GetOnlineDDLProgressResponseBodyOnlineDDLTaskDetail : TeaModel {
            /// <summary>
            /// <para>The cleanup policy of the original table after the cut-over. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DROP</b>: Invalid original tables are deleted.</description></item>
            /// <item><description><b>MOVE</b>: Invalid original tables are moved to the test database. You can delete the tables manually.</description></item>
            /// <item><description><b>NOTHING</b>: Invalid original tables are retained in the original database. You can delete the tables manually.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DROP</para>
            /// </summary>
            [NameInMap("CleanStrategy")]
            [Validation(Required=false)]
            public string CleanStrategy { get; set; }

            /// <summary>
            /// <para>The policy of full replication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AUTO</b>: DMS dynamically adjusts the chunk size based on the performance of the database. Tables are locked for less than 1.5 seconds during a single replication operation.</description></item>
            /// <item><description><b>RUNNING</b>: DMS uses the specified value of the CopyChunkSize parameter. The valid value of the CopyChunkSize parameter ranges from 1 to 60000. If you set this parameter to RUNNING, you must specify the CopyChunkSize parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUTO</para>
            /// </summary>
            [NameInMap("CopyChunkMode")]
            [Validation(Required=false)]
            public string CopyChunkMode { get; set; }

            /// <summary>
            /// <para>The size of each chunk that is used to replicate data. This parameter is used to specify the size of each chunk. A larger chunk size increases the replication efficiency and decreases the business performance.</para>
            /// <remarks>
            /// <para>During full replication, the original table is divided into N small chunks and each chunk is replicated to the temporary table one by one. By default, DMS dynamically adjusts the size of each chunk.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("CopyChunkSize")]
            [Validation(Required=false)]
            public long? CopyChunkSize { get; set; }

            /// <summary>
            /// <para>The actual amount of data replicated from the original table in the lock-free change operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("CopyCount")]
            [Validation(Required=false)]
            public long? CopyCount { get; set; }

            /// <summary>
            /// <para>The estimated total number of rows of the data. The value is obtained from the statistical data in the information_schema database. In most cases, the estimated total number of rows is smaller than the actual number of rows in a table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CopyTotal")]
            [Validation(Required=false)]
            public long? CopyTotal { get; set; }

            /// <summary>
            /// <para>The number of retries when the cut-over fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CutoverFailRetryTimes")]
            [Validation(Required=false)]
            public long? CutoverFailRetryTimes { get; set; }

            /// <summary>
            /// <para>The maximum period of time that a table can be locked during cut-over. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CutoverLockTimeSeconds")]
            [Validation(Required=false)]
            public long? CutoverLockTimeSeconds { get; set; }

            /// <summary>
            /// <para>The end of the time window of the cut-over operation. This value is at least 30 minutes later than the CutoverWindowStartTime parameter. Default value: 23:59:59</para>
            /// 
            /// <b>Example:</b>
            /// <para>13:00:00</para>
            /// </summary>
            [NameInMap("CutoverWindowEndTime")]
            [Validation(Required=false)]
            public string CutoverWindowEndTime { get; set; }

            /// <summary>
            /// <para>The beginning of the time window of the cut-over operation. Default value: 00:00:00. This parameter controls the time window of the cut-over. Cut-over can be performed only when the cut-over conditions are met and the time is within the specified time window. If the time is not within the time window, the cut-over operation is not performed until the time reaches the beginning of the time window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12:00:00</para>
            /// </summary>
            [NameInMap("CutoverWindowStartTime")]
            [Validation(Required=false)]
            public string CutoverWindowStartTime { get; set; }

            /// <summary>
            /// <para>The replay latency of DMS. Unit: seconds. The replay latency is the period of time that is taken to replay the binary logs of the table to the temporary table. The latency does not indicate the data migration latency between a primary database and a secondary database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public long? DelaySeconds { get; set; }

            /// <summary>
            /// <para>The state of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The task is being initialized.</description></item>
            /// <item><description><b>SUCCESS</b>: The task is complete.</description></item>
            /// <item><description><b>RUNNING</b>: The task is being executed.</description></item>
            /// <item><description><b>WAITING_CUTOVER</b>: The task is waiting for cut-over.</description></item>
            /// <item><description><b>RESTARTING</b>: The task is restarting.</description></item>
            /// <item><description><b>PAUSE</b>: The task is suspended.</description></item>
            /// <item><description><b>UNSUPPORTED</b>: The task is not supported.</description></item>
            /// <item><description><b>CANCELED</b>: The task is canceled.</description></item>
            /// <item><description><b>FAIL</b>: The task failed.</description></item>
            /// <item><description><b>INTERRUPT</b>: The task is interrupted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <para>The estimated execution progress. The actual progress is subject to the task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90%</para>
            /// </summary>
            [NameInMap("ProgressRatio")]
            [Validation(Required=false)]
            public string ProgressRatio { get; set; }

            /// <summary>
            /// <para>The description of the task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34E01EDD-6A16-4CF0-9541-C644D1BE01AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
