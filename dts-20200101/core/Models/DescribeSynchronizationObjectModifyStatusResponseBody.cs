// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationObjectModifyStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of full data synchronization.</para>
        /// </summary>
        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyDataInitializationStatus : TeaModel {
            /// <summary>
            /// <para>The error message returned if full data synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>java.lang.NumberFormatException: For input string: &quot;&quot;</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of full data synchronization. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The number of records that have been synchronized during full data synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39754</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The status of full data synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: Full data synchronization is not started.</description></item>
            /// <item><description><b>Migrating</b>: Full data synchronization is in progress.</description></item>
            /// <item><description><b>Failed</b>: Full data synchronization failed.</description></item>
            /// <item><description><b>Finished</b>: Full data synchronization is completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The status of incremental data synchronization.</para>
        /// <remarks>
        /// <para> This parameter and its sub-parameters will be removed in the future.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyDataSynchronizationStatus : TeaModel {
            /// <summary>
            /// <para>The synchronization latency, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            /// <summary>
            /// <para>The error message returned if incremental data synchronization failed.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of incremental data synchronization. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The status of incremental data synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: Incremental data synchronization is not started.</description></item>
            /// <item><description><b>Migrating</b>: Incremental data synchronization is in progress.</description></item>
            /// <item><description><b>Failed</b>: Incremental data synchronization failed.</description></item>
            /// <item><description><b>Finished</b>: Incremental data synchronization is completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Migrating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The error message returned if the task failed to modify the objects to be synchronized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DTS-070211: Connect Source DB failed. cause by [com.mysql.jdbc.exceptions.jdbc4.MySQLNonTransientConnectionException:Could not create connection to database server. Attempted reconnect 3 times. Giving up.][com.mysql.jdbc.exceptions.jdbc4.CommunicationsException:Communications link failure\n\nThe last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.][java.net.ConnectException:Connection timed out (Connection timed out)] About more information in [<a href="https://yq.aliyun.com/articles/499178%5D">https://yq.aliyun.com/articles/499178]</a>.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The precheck status.</para>
        /// </summary>
        [NameInMap("PrecheckStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatus PrecheckStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatus : TeaModel {
            /// <summary>
            /// <para>The result of each precheck item.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatusDetail> Detail { get; set; }
            public class DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatusDetail : TeaModel {
                /// <summary>
                /// <para>The precheck result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Success: The task passed the precheck.</description></item>
                /// <item><description>Failed: The task failed to pass the precheck.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public string CheckStatus { get; set; }

                /// <summary>
                /// <para>The error message returned if the task failed to pass the precheck.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the return value of the <b>CheckStatus</b> parameter is <b>Failed</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Original error: Access denied for user \&quot;dtstest\&quot;@\&quot;100.104.xxx.xx\&quot; (using password: YES)</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The name of the precheck item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK_CONN_SRC</para>
                /// </summary>
                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>The method to fix the precheck failure.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the return value of the <b>CheckStatus</b> parameter is Failed.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK_ERROR_DEST_CONN_REPAIR2</para>
                /// </summary>
                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

            }

            /// <summary>
            /// <para>The precheck progress. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The precheck status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B38C644B-4395-4F6F-86E3-592F26BE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the task that changes the objects to be synchronized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: The task is not started.</description></item>
        /// <item><description><b>Prechecking</b>: The task is being prechecked.</description></item>
        /// <item><description><b>PrecheckFailed</b>: The task failed to pass the precheck.</description></item>
        /// <item><description><b>Migrating</b>: The task is running.</description></item>
        /// <item><description><b>Failed</b>: The task failed.</description></item>
        /// <item><description><b>Finished</b>: The task is completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The status of schema synchronization.</para>
        /// </summary>
        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyStructureInitializationStatus : TeaModel {
            /// <summary>
            /// <para>The error message returned if schema synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-1020042 Execute sql error sql: Table \&quot;customer\&quot; already exists</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of schema synchronization. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The number of tables whose schemas have been synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The status of schema synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: Schema synchronization is not started.</description></item>
            /// <item><description><b>Migrating</b>: Schema synchronization is in progress.</description></item>
            /// <item><description><b>Failed</b>: Schema synchronization failed.</description></item>
            /// <item><description><b>Finished</b>: Schema synchronization is completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
