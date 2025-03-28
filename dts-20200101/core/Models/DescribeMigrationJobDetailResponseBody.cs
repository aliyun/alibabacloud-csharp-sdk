// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of data migration instances that can be displayed on one page.</para>
        /// </summary>
        [NameInMap("DataInitializationDetailList")]
        [Validation(Required=false)]
        public DescribeMigrationJobDetailResponseBodyDataInitializationDetailList DataInitializationDetailList { get; set; }
        public class DescribeMigrationJobDetailResponseBodyDataInitializationDetailList : TeaModel {
            [NameInMap("DataInitializationDetail")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobDetailResponseBodyDataInitializationDetailListDataInitializationDetail> DataInitializationDetail { get; set; }
            public class DescribeMigrationJobDetailResponseBodyDataInitializationDetailListDataInitializationDetail : TeaModel {
                /// <summary>
                /// <para>The status of full data migration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStarted</b>: Full data migration is not started.</description></item>
                /// <item><description><b>Migrating</b>: Full data migration is in progress.</description></item>
                /// <item><description><b>Failed</b>: Full data migration failed.</description></item>
                /// <item><description><b>Finished</b>: Full data migration is completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdata</para>
                /// </summary>
                [NameInMap("DestinationOwnerDBName")]
                [Validation(Required=false)]
                public string DestinationOwnerDBName { get; set; }

                /// <summary>
                /// <para>The page number of the returned page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java.lang.NumberFormatException: For input string: &quot;&quot;</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The details of full data migration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200001</para>
                /// </summary>
                [NameInMap("FinishRowNum")]
                [Validation(Required=false)]
                public string FinishRowNum { get; set; }

                /// <summary>
                /// <para>The name of the database to which the migration object in the source instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("MigrationTime")]
                [Validation(Required=false)]
                public string MigrationTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the call was successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdata</para>
                /// </summary>
                [NameInMap("SourceOwnerDBName")]
                [Validation(Required=false)]
                public string SourceOwnerDBName { get; set; }

                /// <summary>
                /// <para>The total number of entries that are returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The error message returned if the call failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>201477</para>
                /// </summary>
                [NameInMap("TotalRowNum")]
                [Validation(Required=false)]
                public string TotalRowNum { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message returned if full data migration failed.</para>
        /// </summary>
        [NameInMap("DataSynchronizationDetailList")]
        [Validation(Required=false)]
        public DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailList DataSynchronizationDetailList { get; set; }
        public class DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailList : TeaModel {
            [NameInMap("DataSynchronizationDetail")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailListDataSynchronizationDetail> DataSynchronizationDetail { get; set; }
            public class DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailListDataSynchronizationDetail : TeaModel {
                /// <summary>
                /// <para>The status of incremental data migration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStarted</b>: Incremental data migration is not started.</description></item>
                /// <item><description><b>Migrating</b>: Incremental data migration is in progress.</description></item>
                /// <item><description><b>Failed</b>: Incremental data migration failed.</description></item>
                /// <item><description><b>Finished</b>: Incremental data migration is completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdata</para>
                /// </summary>
                [NameInMap("DestinationOwnerDBName")]
                [Validation(Required=false)]
                public string DestinationOwnerDBName { get; set; }

                /// <summary>
                /// <para>The total number of records that are supposed to be migrated by the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The details of incremental data migration.</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The time taken by full data migration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdata</para>
                /// </summary>
                [NameInMap("SourceOwnerDBName")]
                [Validation(Required=false)]
                public string SourceOwnerDBName { get; set; }

                /// <summary>
                /// <para>The number of records that have been migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Migrating</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The name of the database to which the migration object in the destination instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// <para>Specifies whether to query the details of incremental data migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: no</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>false</b></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the details of full data migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: no</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>false</b></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0AE3CD0B-4148-426F-A90E-952467CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the database to which the migration object in the source instance belongs.</para>
        /// </summary>
        [NameInMap("StructureInitializationDetailList")]
        [Validation(Required=false)]
        public DescribeMigrationJobDetailResponseBodyStructureInitializationDetailList StructureInitializationDetailList { get; set; }
        public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailList : TeaModel {
            [NameInMap("StructureInitializationDetail")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetail> StructureInitializationDetail { get; set; }
            public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetail : TeaModel {
                /// <summary>
                /// <para>The schema of the migration object.</para>
                /// </summary>
                [NameInMap("ConstraintList")]
                [Validation(Required=false)]
                public DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintList ConstraintList { get; set; }
                public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintList : TeaModel {
                    [NameInMap("StructureInitializationDetail")]
                    [Validation(Required=false)]
                    public List<DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintListStructureInitializationDetail> StructureInitializationDetail { get; set; }
                    public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintListStructureInitializationDetail : TeaModel {
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
                        /// <para>dtstestdata</para>
                        /// </summary>
                        [NameInMap("DestinationOwnerDBName")]
                        [Validation(Required=false)]
                        public string DestinationOwnerDBName { get; set; }

                        /// <summary>
                        /// <para>The constraints of the migration object, such as indexes and foreign keys. </para>
                        /// <remarks>
                        /// <para> This parameter is returned only if the <b>ObjectType</b> parameter is set to <b>Table</b> and the migration object has constraints.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DTS-1020042 Execute sql error sql: ERROR: type &quot;geometry&quot; does not exist；</para>
                        /// </summary>
                        [NameInMap("ErrorMessage")]
                        [Validation(Required=false)]
                        public string ErrorMessage { get; set; }

                        /// <summary>
                        /// <para>The name of the database to which the migration object in the destination instance belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CREATE SEQUENCE &quot;public&quot;.&quot;collections_id_seq&quot;   MINVALUE 1   MAXVALUE 9223372036854775807   START 249   INCREMENT BY 1 ;</para>
                        /// </summary>
                        [NameInMap("ObjectDefinition")]
                        [Validation(Required=false)]
                        public string ObjectDefinition { get; set; }

                        /// <summary>
                        /// <para>The name of the database to which the migration object in the source instance belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>customer</para>
                        /// </summary>
                        [NameInMap("ObjectName")]
                        [Validation(Required=false)]
                        public string ObjectName { get; set; }

                        /// <summary>
                        /// <para>The name of migration object.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Table</para>
                        /// </summary>
                        [NameInMap("ObjectType")]
                        [Validation(Required=false)]
                        public string ObjectType { get; set; }

                        /// <summary>
                        /// <para>The error message returned if schema migration failed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dtstestdata</para>
                        /// </summary>
                        [NameInMap("SourceOwnerDBName")]
                        [Validation(Required=false)]
                        public string SourceOwnerDBName { get; set; }

                        /// <summary>
                        /// <para>The type of the migration object. Valid values: <b>Table</b>, <b>Constraint</b>, <b>Index</b>, <b>View</b>, <b>Materialize View</b>, <b>Type</b>, <b>Synonym</b>, <b>Trigger</b>, <b>Function</b>, <b>Procedure</b>, <b>Package</b>, <b>Default</b>, <b>Rule</b>, <b>PlanGuide</b>, and <b>Sequence</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Finished</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// <para>The status of schema migration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStarted</b>: Schema migration is not started.</description></item>
                /// <item><description><b>Migrating</b>: Schema migration is in progress.</description></item>
                /// <item><description><b>Failed</b>: Schema migration failed.</description></item>
                /// <item><description><b>Finished</b>: Schema migration is completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdata</para>
                /// </summary>
                [NameInMap("DestinationOwnerDBName")]
                [Validation(Required=false)]
                public string DestinationOwnerDBName { get; set; }

                /// <summary>
                /// <para>The details of schema migration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DTS-1020042 Execute sql error sql: DTS-1020042 Execute sql error sql: ERROR: column \&quot;id\&quot; named in key does not exist</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The task has failed for too long and cannot be restored</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE TABLE <c>dtstestdata</c>.<c>customer</c> (\n<c>runoob_id</c>  int(10) unsigned   auto_increment  COMMENT \&quot;\&quot;   NOT NULL   , \n<c>runoob_title</c>  varchar(100)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NOT NULL   , \n<c>runoob_author1216</c>  varchar(40)  CHARSET <c>utf8</c> COLLATE <c>utf8_general_ci</c>    COMMENT \&quot;\&quot;   NOT NULL   , \n<c>submission_date1216</c>  date     COMMENT \&quot;\&quot;   NULL   \n, PRIMARY KEY (<c>runoob_id</c>)) engine=InnoDB AUTO_INCREMENT=200001 DEFAULT CHARSET=<c>utf8</c> DEFAULT COLLATE <c>utf8_general_ci</c> ROW_FORMAT= Dynamic comment = \&quot;\&quot; ;\n</para>
                /// </summary>
                [NameInMap("ObjectDefinition")]
                [Validation(Required=false)]
                public string ObjectDefinition { get; set; }

                /// <summary>
                /// <para>The name of the database to which the migration object in the source instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The name of the database to which the migration object in the destination instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Table</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The error message returned if incremental data migration failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdata</para>
                /// </summary>
                [NameInMap("SourceOwnerDBName")]
                [Validation(Required=false)]
                public string SourceOwnerDBName { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
