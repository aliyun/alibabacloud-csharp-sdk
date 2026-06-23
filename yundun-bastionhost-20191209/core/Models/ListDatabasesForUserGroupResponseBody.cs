// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListDatabasesForUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of databases that are queried.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<ListDatabasesForUserGroupResponseBodyDatabases> Databases { get; set; }
        public class ListDatabasesForUserGroupResponseBodyDatabases : TeaModel {
            /// <summary>
            /// <para>The type of the database address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Public</b>: public address</para>
            /// </description></item>
            /// <item><description><para><b>Private</b>: private address</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("ActiveAddressType")]
            [Validation(Required=false)]
            public string ActiveAddressType { get; set; }

            /// <summary>
            /// <para>The description of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The total number of database accounts that are queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DatabaseAccountCount")]
            [Validation(Required=false)]
            public long? DatabaseAccountCount { get; set; }

            /// <summary>
            /// <para>The ID of the database instance to which the database account belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The name of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL0</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The port of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("DatabasePort")]
            [Validation(Required=false)]
            public long? DatabasePort { get; set; }

            /// <summary>
            /// <para>The private endpoint of the database, which can be a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1******</para>
            /// </summary>
            [NameInMap("DatabasePrivateAddress")]
            [Validation(Required=false)]
            public string DatabasePrivateAddress { get; set; }

            /// <summary>
            /// <para>The public address of the database, which can be a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-uf65******</para>
            /// </summary>
            [NameInMap("DatabasePublicAddress")]
            [Validation(Required=false)]
            public string DatabasePublicAddress { get; set; }

            /// <summary>
            /// <para>The type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MySQL</b></para>
            /// </description></item>
            /// <item><description><para><b>Oracle</b></para>
            /// </description></item>
            /// <item><description><para><b>PostgreSQL</b></para>
            /// </description></item>
            /// <item><description><para><b>SQLServer</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            /// <summary>
            /// <para>The ID of the network domain to which the database belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("NetworkDomainId")]
            [Validation(Required=false)]
            public string NetworkDomainId { get; set; }

            /// <summary>
            /// <para>The source of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Local</b>: local database instance</para>
            /// </description></item>
            /// <item><description><para><b>Rds</b>: RDS database instance</para>
            /// </description></item>
            /// <item><description><para><b>PolarDB</b>: PolarDB database instance</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Local</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The ID of the RDS instance or PolarDB instance that corresponds to the database.</para>
            /// <remarks>
            /// <para>If <b>Source</b> is set to <b>Local</b>, this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9c7mjxywmdmqk7q6e4</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The unique ID that Alibaba Cloud generates for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of databases that are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
