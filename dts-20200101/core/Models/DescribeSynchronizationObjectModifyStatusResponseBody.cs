// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationObjectModifyStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The initial full data synchronization status.</para>
        /// </summary>
        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyDataInitializationStatus : TeaModel {
            /// <summary>
            /// <para>The error message returned when initial full data synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-070211: Connect Source DB failed. cause by [com.mysql.jdbc.exceptions.jdbc4.MySQLNonTransientConnectionException:Could not create connection to database server. Attempted reconnect 3 times. Giving up.][com.mysql.jdbc.exceptions.jdbc4.CommunicationsException:Communications link failure\n\nThe last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.][java.net.ConnectException:Connection timed out (Connection timed out)] About more information in [<a href="https://yq.aliyun.com/articles/499178%5D">https://yq.aliyun.com/articles/499178]</a>.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of initial full data synchronization, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The number of records that have been synchronized during initial full data synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39754</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The status of the synchronization object change. Valid values: -<b>notstarted</b>: not started. -<b>migrating</b>: synchronizing. -<b>failed</b>: synchronization failed. -<b>finaciallocked</b>: financial lock.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The incremental data synchronization status.</para>
        /// <remarks>
        /// <para>This parameter set and its response parameters will be discontinued.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyDataSynchronizationStatus : TeaModel {
            /// <summary>
            /// <para>The synchronization latency of incremental data synchronization, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            /// <summary>
            /// <para>The error message returned when incremental data synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-070211: Connect Source DB failed. cause by [com.mysql.jdbc.exceptions.jdbc4.MySQLNonTransientConnectionException:Could not create connection to database server. Attempted reconnect 3 times. Giving up.][com.mysql.jdbc.exceptions.jdbc4.CommunicationsException:Communications link failure\n\nThe last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.][java.net.ConnectException:Connection timed out (Connection timed out)] About more information in [<a href="https://yq.aliyun.com/articles/499178%5D">https://yq.aliyun.com/articles/499178]</a>.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of incremental data synchronization, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The status of the synchronization object change. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: not started.</description></item>
            /// <item><description><b>Prechecking</b>: running the precheck.</description></item>
            /// <item><description><b>PrecheckFailed</b>: the precheck failed.</description></item>
            /// <item><description><b>Migrating</b>: synchronizing.</description></item>
            /// <item><description><b>Failed</b>: synchronization failed.</description></item>
            /// <item><description><b>Finished</b>: synchronization completed.</description></item>
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
        /// <para>The error code returned when the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The error message returned when the task to modify synchronization objects failed.</para>
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
            /// <para>The execution details of each precheck item.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatusDetail> Detail { get; set; }
            public class DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatusDetail : TeaModel {
                /// <summary>
                /// <para>The check result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Success: The precheck item was passed.</description></item>
                /// <item><description>Failed: The precheck item was not passed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public string CheckStatus { get; set; }

                /// <summary>
                /// <para>The error message returned when the precheck item was not passed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DTS-070211: Connect Source DB failed. cause by [com.mysql.jdbc.exceptions.jdbc4.MySQLNonTransientConnectionException:Could not create connection to database server. Attempted reconnect 3 times. Giving up.][com.mysql.jdbc.exceptions.jdbc4.CommunicationsException:Communications link failure\n\nThe last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.][java.net.ConnectException:Connection timed out (Connection timed out)] About more information in [<a href="https://yq.aliyun.com/articles/499178%5D">https://yq.aliyun.com/articles/499178]</a>.</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The precheck item.</para>
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
                /// <para>This parameter is returned only when the value of the <b>CheckStatus</b> parameter is Failed.</para>
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
            /// <para>The precheck progress, in percentage.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B38C644B-4395-4F6F-86E3-592F26BE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the synchronization object change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: not started.</description></item>
        /// <item><description><b>Prechecking</b>: running the precheck.</description></item>
        /// <item><description><b>PrecheckFailed</b>: the precheck failed.</description></item>
        /// <item><description><b>Migrating</b>: synchronizing.</description></item>
        /// <item><description><b>Failed</b>: synchronization failed.</description></item>
        /// <item><description><b>Finished</b>: synchronization completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The initial schema synchronization status.</para>
        /// </summary>
        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyStructureInitializationStatus : TeaModel {
            /// <summary>
            /// <para>The error message returned when initial schema synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-070211: Connect Source DB failed. cause by [com.mysql.jdbc.exceptions.jdbc4.MySQLNonTransientConnectionException:Could not create connection to database server. Attempted reconnect 3 times. Giving up.][com.mysql.jdbc.exceptions.jdbc4.CommunicationsException:Communications link failure\n\nThe last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.][java.net.ConnectException:Connection timed out (Connection timed out)] About more information in [<a href="https://yq.aliyun.com/articles/499178%5D">https://yq.aliyun.com/articles/499178]</a>.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of initial schema synchronization, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The number of tables for which initial schema synchronization has been completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The initial schema synchronization status. Valid values: NotStarted: not started. Migrating: initializing. Failed: initialization failed. Finished: initialization completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
