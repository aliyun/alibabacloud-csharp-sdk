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
                /// <para>The account name.</para>
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
                /// <item><description><para><b>ReadWrite</b></para>
                /// </description></item>
                /// <item><description><para><b>ReadOnly</b></para>
                /// </description></item>
                /// <item><description><para><b>DMLOnly</b></para>
                /// </description></item>
                /// <item><description><para><b>DDLOnly</b></para>
                /// </description></item>
                /// <item><description><para><b>ReadIndex</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ReadOnly</para>
                /// </summary>
                [NameInMap("AccountPrivilege")]
                [Validation(Required=false)]
                public string AccountPrivilege { get; set; }

                /// <summary>
                /// <para>The status of the account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Creating</b></para>
                /// </description></item>
                /// <item><description><para><b>Available</b></para>
                /// </description></item>
                /// <item><description><para><b>Deleting</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// <para>The authorization status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Empowering</b>: Permissions are being granted.</para>
                /// </description></item>
                /// <item><description><para><b>Empowered</b>: Permissions are granted.</para>
                /// </description></item>
                /// <item><description><para><b>Removing</b>: Permissions are being revoked.</para>
                /// </description></item>
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
            /// <para>The character set.</para>
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
            /// <para>The status of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Creating</b></para>
            /// </description></item>
            /// <item><description><para><b>Running</b></para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBStatus")]
            [Validation(Required=false)]
            public string DBStatus { get; set; }

            /// <summary>
            /// <para>The database engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MySQL</b></para>
            /// </description></item>
            /// <item><description><para><b>Oracle</b></para>
            /// </description></item>
            /// <item><description><para><b>PostgreSQL</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The ID of the primary node that corresponds to the database in a Multi-master Cluster (Database/Table) edition cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MasterID")]
            [Validation(Required=false)]
            public string MasterID { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. This is the NextToken value from the previous API call. If there are no more results, do not specify this parameter.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
