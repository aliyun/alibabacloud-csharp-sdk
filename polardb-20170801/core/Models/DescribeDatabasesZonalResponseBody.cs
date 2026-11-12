// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDatabasesZonalResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the databases.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<DescribeDatabasesZonalResponseBodyDatabases> Databases { get; set; }
        public class DescribeDatabasesZonalResponseBodyDatabases : TeaModel {
            /// <summary>
            /// <para>The details of the database accounts.</para>
            /// <remarks>
            /// <para>If the cluster is a PolarDB for MySQL cluster, privileged accounts are not included.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribeDatabasesZonalResponseBodyDatabasesAccounts> Accounts { get; set; }
            public class DescribeDatabasesZonalResponseBodyDatabasesAccounts : TeaModel {
                /// <summary>
                /// <para>The name of the account.</para>
                /// <remarks>
                /// <para>If the cluster is a PolarDB for MySQL cluster, privileged accounts are not included.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test_acc</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The permissions of the account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ReadWrite</b>: read and write</description></item>
                /// <item><description><b>ReadOnly</b>: read-only </description></item>
                /// <item><description><b>DMLOnly</b>: DML only</description></item>
                /// <item><description><b>DDLOnly</b>: DDL only</description></item>
                /// <item><description><b>ReadIndex</b>: read and index</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ReadOnly</para>
                /// </summary>
                [NameInMap("AccountPrivilege")]
                [Validation(Required=false)]
                public string AccountPrivilege { get; set; }

                /// <summary>
                /// <para>The status of the account. Valid values: </para>
                /// <list type="bullet">
                /// <item><description><b>Creating</b>: The account is being created.</description></item>
                /// <item><description><b>Available</b>: The account is available.</description></item>
                /// <item><description><b>Deleting</b>: The account is being deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// <para>The authorization status. Valid values: </para>
                /// <list type="bullet">
                /// <item><description><b>Empowering</b>: The account is being authorized.</description></item>
                /// <item><description><b>Empowered</b>: The account is authorized.</description></item>
                /// <item><description><b>Removing</b>: The permissions are being revoked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Empowered</para>
                /// </summary>
                [NameInMap("PrivilegeStatus")]
                [Validation(Required=false)]
                public string PrivilegeStatus { get; set; }

            }

            /// <summary>
            /// <para>The name of the character set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>utf8mb4</para>
            /// </summary>
            [NameInMap("CharacterSetName")]
            [Validation(Required=false)]
            public string CharacterSetName { get; set; }

            /// <summary>
            /// <para>The description of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_des</para>
            /// </summary>
            [NameInMap("DBDescription")]
            [Validation(Required=false)]
            public string DBDescription { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The status of the database. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The database is being created.</description></item>
            /// <item><description><b>Running</b>: The database is running.</description></item>
            /// <item><description><b>Deleting</b>: The database is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBStatus")]
            [Validation(Required=false)]
            public string DBStatus { get; set; }

            /// <summary>
            /// <para>The type of the database engine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MySQL</b></description></item>
            /// <item><description><b>Oracle</b></description></item>
            /// <item><description><b>PostgreSQL</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The ID of the primary node that corresponds to the database in a Multi-master Cluster (Database/Table) Edition cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MasterID")]
            [Validation(Required=false)]
            public string MasterID { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value returned from the previous API call. If no subsequent query is required, do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707e******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
