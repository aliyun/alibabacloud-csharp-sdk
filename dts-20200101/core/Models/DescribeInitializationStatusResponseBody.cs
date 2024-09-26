// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeInitializationStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of initial full data synchronization.</para>
        /// </summary>
        [NameInMap("DataInitializationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyDataInitializationDetails> DataInitializationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyDataInitializationDetails : TeaModel {
            /// <summary>
            /// <para>The name of the database to which the object in the destination instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

            /// <summary>
            /// <para>The error message returned if initial full data synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>java.lang.NumberFormatException: For input string: &quot;&quot;</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The total number of rows that are actually synchronized.</para>
            /// <remarks>
            /// <para> This parameter indicates the total number of actually synchronized rows. In contrast, the value of the <b>TotalRowNum</b> parameter is calculated based on the system tables in the source database. The values of the two parameters may be different due to time difference.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>9993</para>
            /// </summary>
            [NameInMap("FinishRowNum")]
            [Validation(Required=false)]
            public string FinishRowNum { get; set; }

            /// <summary>
            /// <para>The name of the database to which the object in the source instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("SourceOwnerDBName")]
            [Validation(Required=false)]
            public string SourceOwnerDBName { get; set; }

            /// <summary>
            /// <para>The status of initial full data synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b></description></item>
            /// <item><description><b>Migrating</b></description></item>
            /// <item><description><b>Failed</b></description></item>
            /// <item><description><b>Finished</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The total number of rows that are supposed to be synchronized.</para>
            /// <remarks>
            /// <para> The value of this parameter is calculated based on the system tables in the source database. In contrast, the <b>FinishRowNum</b> parameter indicates the total number of actually synchronized rows. The values of the two parameters may be different due to time difference.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>9981</para>
            /// </summary>
            [NameInMap("TotalRowNum")]
            [Validation(Required=false)]
            public string TotalRowNum { get; set; }

            /// <summary>
            /// <para>The time spent on full data synchronization.</para>
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
        /// <para> This parameter and the parameters it contains will be removed in the future.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DataSynchronizationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyDataSynchronizationDetails> DataSynchronizationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyDataSynchronizationDetails : TeaModel {
            /// <summary>
            /// <para>The name of the database to which the object in the destination instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

            /// <summary>
            /// <para>The error message returned if incremental data synchronization failed.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The name of the database to which the object in the source instance belongs.</para>
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
            /// <item><description><b>NotStarted</b></description></item>
            /// <item><description><b>Migrating</b></description></item>
            /// <item><description><b>Failed</b></description></item>
            /// <item><description><b>Finished</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Migrating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150DECD9-13FF-4929-A5DE-855BE9CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of initial schema synchronization.</para>
        /// </summary>
        [NameInMap("StructureInitializationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyStructureInitializationDetails> StructureInitializationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyStructureInitializationDetails : TeaModel {
            /// <summary>
            /// <para>The constraints of the synchronization object, such as indexes and foreign keys.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the <b>ObjectType</b> parameter is set to <b>Table</b> and the synchronization object has constraints.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public List<DescribeInitializationStatusResponseBodyStructureInitializationDetailsConstraints> Constraints { get; set; }
            public class DescribeInitializationStatusResponseBodyStructureInitializationDetailsConstraints : TeaModel {
                /// <summary>
                /// <para>The name of the database to which the object in the destination instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdata</para>
                /// </summary>
                [NameInMap("DestinationOwnerDBName")]
                [Validation(Required=false)]
                public string DestinationOwnerDBName { get; set; }

                /// <summary>
                /// <para>The error message returned if constraints failed to be created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DTS-1020042 Execute sql error sql: ERROR: type &quot;geometry&quot; does not exist</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The syntax to create constraints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE SEQUENCE &quot;public&quot;.&quot;collections_id_seq&quot;   MINVALUE 1   MAXVALUE 9223372036854775807   START 249   INCREMENT BY 1 ;</para>
                /// </summary>
                [NameInMap("ObjectDefinition")]
                [Validation(Required=false)]
                public string ObjectDefinition { get; set; }

                /// <summary>
                /// <para>The name of the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The type of the object. Valid value: <b>Table</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Table</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The name of the database to which the object in the source instance belongs.</para>
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
                /// <item><description><b>NotStarted</b></description></item>
                /// <item><description><b>Migrating</b></description></item>
                /// <item><description><b>Failed</b></description></item>
                /// <item><description><b>Finished</b></description></item>
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
            /// <para>The name of the database to which the object in the destination instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

            /// <summary>
            /// <para>The error message returned if initial schema synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-1020042 Execute sql error sql: Table \&quot;customer\&quot; already exists</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The schema of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE TABLE <c>dtstestdata</c>.<c>customer</c> (\n<c>customer_id</c>  int(10) unsigned   auto_increment  COMMENT \&quot;\&quot;   NOT NULL   , \n<c>customer_title</c>  varchar(100)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NOT NULL   , \n<c>customer_company1216</c>  varchar(40)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NOT NULL   , \n<c>submission_date1216</c>  date     COMMENT \&quot;\&quot;   NULL   \n, PRIMARY KEY (<c>customer_id</c>)) engine=InnoDB AUTO_INCREMENT=200001 DEFAULT CHARSET=<c>utf8</c> DEFAULT COLLATE <c>utf8_general_ci</c> ROW_FORMAT= Dynamic comment = \&quot;\&quot; ;\n</para>
            /// </summary>
            [NameInMap("ObjectDefinition")]
            [Validation(Required=false)]
            public string ObjectDefinition { get; set; }

            /// <summary>
            /// <para>The name of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

            /// <summary>
            /// <para>The type of the object. Valid values:</para>
            /// <para><b>Table</b>, <b>Constraint</b>, <b>Index</b>, <b>View</b>, <b>Materialize View</b>, <b>Type</b>, <b>Synonym</b>, <b>Trigger</b>, <b>Function</b>, <b>Procedure</b>, <b>Package</b>, <b>Default</b>, <b>Rule</b>, <b>PlanGuide</b>, and <b>Sequence</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Table</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The name of the database to which the object in the source instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("SourceOwnerDBName")]
            [Validation(Required=false)]
            public string SourceOwnerDBName { get; set; }

            /// <summary>
            /// <para>The status of initial schema synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b></description></item>
            /// <item><description><b>Migrating</b></description></item>
            /// <item><description><b>Failed</b></description></item>
            /// <item><description><b>Finished</b></description></item>
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
