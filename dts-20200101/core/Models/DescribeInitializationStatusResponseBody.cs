// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeInitializationStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of full data initialization.</para>
        /// </summary>
        [NameInMap("DataInitializationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyDataInitializationDetails> DataInitializationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyDataInitializationDetails : TeaModel {
            /// <summary>
            /// <para>The name of the database to which the objects to be synchronized belong in the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

            /// <summary>
            /// <para>The error message returned when full data initialization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>java.lang.NumberFormatException: For input string: &quot;&quot;</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The number of rows that have been synchronized.</para>
            /// <remarks>
            /// <para>This parameter indicates the total number of rows that are actually synchronized. The value of the <b>TotalRowNum</b> parameter is obtained from the system table of the source database before synchronization starts. Due to time differences during synchronization, the two values may differ.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>9993</para>
            /// </summary>
            [NameInMap("FinishRowNum")]
            [Validation(Required=false)]
            public string FinishRowNum { get; set; }

            /// <summary>
            /// <para>The name of the database to which the objects to be synchronized belong in the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("SourceOwnerDBName")]
            [Validation(Required=false)]
            public string SourceOwnerDBName { get; set; }

            /// <summary>
            /// <para>The status of full data initialization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: Not started.</description></item>
            /// <item><description><b>Migrating</b>: In progress.</description></item>
            /// <item><description><b>Failed</b>: Failed.</description></item>
            /// <item><description><b>Finished</b>: Completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The table name of the synchronization object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The total number of rows to be synchronized.</para>
            /// <remarks>
            /// <para>The value of this parameter is obtained from the system table of the source database before synchronization starts. The <b>FinishRowNum</b> parameter indicates the total number of rows that are actually synchronized. Due to time differences during synchronization, the two values may differ.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>9981</para>
            /// </summary>
            [NameInMap("TotalRowNum")]
            [Validation(Required=false)]
            public string TotalRowNum { get; set; }

            /// <summary>
            /// <para>The time consumed by full data initialization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("UsedTime")]
            [Validation(Required=false)]
            public string UsedTime { get; set; }

        }

        /// <summary>
        /// <para>The details of incremental data synchronization.</para>
        /// <remarks>
        /// <para>This parameter set and the included response parameters will be discontinued.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DataSynchronizationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyDataSynchronizationDetails> DataSynchronizationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyDataSynchronizationDetails : TeaModel {
            /// <summary>
            /// <para>The name of the database to which the objects to be synchronized belong in the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

            /// <summary>
            /// <para>The error message returned when incremental data synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>任务失败太久无法恢复</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The name of the database to which the objects to be synchronized belong in the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("SourceOwnerDBName")]
            [Validation(Required=false)]
            public string SourceOwnerDBName { get; set; }

            /// <summary>
            /// <para>The status of incremental data synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: Not started.</description></item>
            /// <item><description><b>Migrating</b>: In progress.</description></item>
            /// <item><description><b>Failed</b>: Failed.</description></item>
            /// <item><description><b>Finished</b>: Completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Migrating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The table name of the synchronization object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150DECD9-13FF-4929-A5DE-855BE9CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of schema initialization.</para>
        /// </summary>
        [NameInMap("StructureInitializationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyStructureInitializationDetails> StructureInitializationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyStructureInitializationDetails : TeaModel {
            /// <summary>
            /// <para>The constraints of the synchronization object, such as indexes and foreign keys.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>ObjectType</b> is set to <b>Table</b> and the synchronization object has constraints.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public List<DescribeInitializationStatusResponseBodyStructureInitializationDetailsConstraints> Constraints { get; set; }
            public class DescribeInitializationStatusResponseBodyStructureInitializationDetailsConstraints : TeaModel {
                /// <summary>
                /// <para>The name of the database to which the objects to be synchronized belong in the destination instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdata</para>
                /// </summary>
                [NameInMap("DestinationOwnerDBName")]
                [Validation(Required=false)]
                public string DestinationOwnerDBName { get; set; }

                /// <summary>
                /// <para>The error message returned when constraint creation failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DTS-1020042 Execute sql error sql: ERROR: type &quot;geometry&quot; does not exist</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The syntax definition for creating the constraint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE SEQUENCE &quot;public&quot;.&quot;collections_id_seq&quot;   MINVALUE 1   MAXVALUE 9223372036854775807   START 249   INCREMENT BY 1 ;</para>
                /// </summary>
                [NameInMap("ObjectDefinition")]
                [Validation(Required=false)]
                public string ObjectDefinition { get; set; }

                /// <summary>
                /// <para>The name of the synchronization object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The type of the synchronization object. The value is fixed as <b>Table</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Table</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The name of the database to which the objects to be synchronized belong in the source instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdata</para>
                /// </summary>
                [NameInMap("SourceOwnerDBName")]
                [Validation(Required=false)]
                public string SourceOwnerDBName { get; set; }

                /// <summary>
                /// <para>The status of constraint creation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStarted</b>: Not started.</description></item>
                /// <item><description><b>Migrating</b>: In progress.</description></item>
                /// <item><description><b>Failed</b>: Failed.</description></item>
                /// <item><description><b>Finished</b>: Completed.</description></item>
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
            /// <para>The name of the database to which the objects to be synchronized belong in the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

            /// <summary>
            /// <para>The error message returned when schema initialization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-1020042 Execute sql error sql: Table \&quot;customer\&quot; already exists</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The syntax definition of the synchronization object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE TABLE <c>dtstestdata</c>.<c>customer</c> (\n<c>customer_id</c>  int(10) unsigned   auto_increment  COMMENT \&quot;\&quot;   NOT NULL   , \n<c>customer_title</c>  varchar(100)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NOT NULL   , \n<c>customer_company1216</c>  varchar(40)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NOT NULL   , \n<c>submission_date1216</c>  date     COMMENT \&quot;\&quot;   NULL   \n, PRIMARY KEY (<c>customer_id</c>)) engine=InnoDB AUTO_INCREMENT=200001 DEFAULT CHARSET=<c>utf8</c> DEFAULT COLLATE <c>utf8_general_ci</c> ROW_FORMAT= Dynamic comment = \&quot;\&quot; ;\n</para>
            /// </summary>
            [NameInMap("ObjectDefinition")]
            [Validation(Required=false)]
            public string ObjectDefinition { get; set; }

            /// <summary>
            /// <para>The name of the synchronization object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

            /// <summary>
            /// <para>The type of the synchronization object. Valid values:
            /// <b>Table</b>, <b>Constraint</b>, <b>Index</b>, <b>View</b>, <b>Materialize View</b>, <b>Type</b>, <b>Synonym</b>, <b>Trigger</b>, <b>Function</b>, <b>Procedure</b>, <b>Package</b>, <b>Default</b>, <b>Rule</b>, <b>PlanGuide</b>, and <b>Sequence</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Table</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The name of the database to which the objects to be synchronized belong in the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("SourceOwnerDBName")]
            [Validation(Required=false)]
            public string SourceOwnerDBName { get; set; }

            /// <summary>
            /// <para>The status of schema initialization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: Not started.</description></item>
            /// <item><description><b>Migrating</b>: In progress.</description></item>
            /// <item><description><b>Failed</b>: Failed.</description></item>
            /// <item><description><b>Finished</b>: Completed.</description></item>
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
