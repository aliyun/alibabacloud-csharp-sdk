// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDIJobRunDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDIJobRunDetailsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDIJobRunDetailsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The running information about the synchronization task.</para>
            /// </summary>
            [NameInMap("JobRunInfos")]
            [Validation(Required=false)]
            public List<ListDIJobRunDetailsResponseBodyPagingInfoJobRunInfos> JobRunInfos { get; set; }
            public class ListDIJobRunDetailsResponseBodyPagingInfoJobRunInfos : TeaModel {
                /// <summary>
                /// <para>The name of the database in the destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dst_db</para>
                /// </summary>
                [NameInMap("DestinationDatabaseName")]
                [Validation(Required=false)]
                public string DestinationDatabaseName { get; set; }

                /// <summary>
                /// <para>The name of the destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dst_name</para>
                /// </summary>
                [NameInMap("DestinationDatasourceName")]
                [Validation(Required=false)]
                public string DestinationDatasourceName { get; set; }

                /// <summary>
                /// <para>The name of the schema of the destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dst_schema</para>
                /// </summary>
                [NameInMap("DestinationSchemaName")]
                [Validation(Required=false)]
                public string DestinationSchemaName { get; set; }

                /// <summary>
                /// <para>The name of the table in the destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dst_name</para>
                /// </summary>
                [NameInMap("DestinationTableName")]
                [Validation(Required=false)]
                public string DestinationTableName { get; set; }

                /// <summary>
                /// <para>The error message that is returned if an error occurs during full batch synchronization. If no error occurs, no value is returned for this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sync table t1 fail.</para>
                /// </summary>
                [NameInMap("FullMigrationErrorMessage")]
                [Validation(Required=false)]
                public string FullMigrationErrorMessage { get; set; }

                /// <summary>
                /// <para>The status of full batch synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("FullMigrationStatus")]
                [Validation(Required=false)]
                public string FullMigrationStatus { get; set; }

                /// <summary>
                /// <para>The total number of errors that occur during full synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OfflineErrorRecords")]
                [Validation(Required=false)]
                public long? OfflineErrorRecords { get; set; }

                /// <summary>
                /// <para>The total number of bytes that are synchronized during full synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OfflineTotalBytes")]
                [Validation(Required=false)]
                public long? OfflineTotalBytes { get; set; }

                /// <summary>
                /// <para>The total number of data records that are synchronized during full synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OfflineTotalRecords")]
                [Validation(Required=false)]
                public long? OfflineTotalRecords { get; set; }

                /// <summary>
                /// <para>The error message that is returned if an error occurs during real-time synchronization. If no error occurs, no value is returned for this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sync table t1 fail.</para>
                /// </summary>
                [NameInMap("RealtimeMigrationErrorMessage")]
                [Validation(Required=false)]
                public string RealtimeMigrationErrorMessage { get; set; }

                /// <summary>
                /// <para>The status of real-time synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("RealtimeMigrationStatus")]
                [Validation(Required=false)]
                public string RealtimeMigrationStatus { get; set; }

                /// <summary>
                /// <para>The name of the database in the source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db_name</para>
                /// </summary>
                [NameInMap("SourceDatabaseName")]
                [Validation(Required=false)]
                public string SourceDatabaseName { get; set; }

                /// <summary>
                /// <para>The name of the source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds_name</para>
                /// </summary>
                [NameInMap("SourceDatasourceName")]
                [Validation(Required=false)]
                public string SourceDatasourceName { get; set; }

                /// <summary>
                /// <para>The name of the schema of the source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>schema_name</para>
                /// </summary>
                [NameInMap("SourceSchemaName")]
                [Validation(Required=false)]
                public string SourceSchemaName { get; set; }

                /// <summary>
                /// <para>The name of the table in the source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_name</para>
                /// </summary>
                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                /// <summary>
                /// <para>The error message that is returned if an error occurs during schema synchronization. If no error occurs, no value is returned for this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create table t1 fail.</para>
                /// </summary>
                [NameInMap("StructureMigrationErrorMessage")]
                [Validation(Required=false)]
                public string StructureMigrationErrorMessage { get; set; }

                /// <summary>
                /// <para>The synchronization status of the schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("StructureMigrationStatus")]
                [Validation(Required=false)]
                public string StructureMigrationStatus { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-9441</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
