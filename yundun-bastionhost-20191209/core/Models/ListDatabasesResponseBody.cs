// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListDatabasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The databases returned.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<ListDatabasesResponseBodyDatabases> Databases { get; set; }
        public class ListDatabasesResponseBodyDatabases : TeaModel {
            /// <summary>
            /// <para>The address type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Public</b></description></item>
            /// <item><description><b>Private</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("ActiveAddressType")]
            [Validation(Required=false)]
            public string ActiveAddressType { get; set; }

            /// <summary>
            /// <para>The remarks of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
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
            public int? DatabasePort { get; set; }

            /// <summary>
            /// <para>The internal address of the database. The value is a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-wz973w7******</para>
            /// </summary>
            [NameInMap("DatabasePrivateAddress")]
            [Validation(Required=false)]
            public string DatabasePrivateAddress { get; set; }

            /// <summary>
            /// <para>The public address of the database. The value is a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-uf65n2******</para>
            /// </summary>
            [NameInMap("DatabasePublicAddress")]
            [Validation(Required=false)]
            public string DatabasePublicAddress { get; set; }

            /// <summary>
            /// <para>The database engine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MySQL</b></description></item>
            /// <item><description><b>Oracle</b></description></item>
            /// <item><description><b>PostgreSQL</b></description></item>
            /// <item><description><b>SQLServer</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            /// <summary>
            /// <para>The ID of the network domain where the database resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("NetworkDomainId")]
            [Validation(Required=false)]
            public string NetworkDomainId { get; set; }

            /// <summary>
            /// <para>The type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Local</b>: on-premises database.</description></item>
            /// <item><description><b>Rds</b>: ApsaraDB for RDS instance.</description></item>
            /// <item><description><b>PolarDB</b>: PolarDB cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Local</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The ID of the ApsaraDB for RDS instance or PolarDB cluster.</para>
            /// <remarks>
            /// <para>No value is returned for this parameter if <b>Source</b> is set to <b>Local</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9ejupczf41******</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the ApsaraDB for RDS instance or PolarDB cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SourceInstanceRegionId")]
            [Validation(Required=false)]
            public string SourceInstanceRegionId { get; set; }

            /// <summary>
            /// <para>The status of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b></description></item>
            /// <item><description><b>Release</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("SourceInstanceState")]
            [Validation(Required=false)]
            public string SourceInstanceState { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of databases returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
