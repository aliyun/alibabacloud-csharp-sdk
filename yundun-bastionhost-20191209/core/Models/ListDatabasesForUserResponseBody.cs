// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListDatabasesForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The databases returned.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<ListDatabasesForUserResponseBodyDatabases> Databases { get; set; }
        public class ListDatabasesForUserResponseBodyDatabases : TeaModel {
            /// <summary>
            /// <para>The address type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Public</b></para>
            /// </description></item>
            /// <item><description><para><b>Private</b></para>
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
            /// <para>36</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL56</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The database port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("DatabasePort")]
            [Validation(Required=false)]
            public long? DatabasePort { get; set; }

            /// <summary>
            /// <para>The internal endpoint of the database. The value is a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("DatabasePrivateAddress")]
            [Validation(Required=false)]
            public string DatabasePrivateAddress { get; set; }

            /// <summary>
            /// <para>The public endpoint of the database. The value is a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("DatabasePublicAddress")]
            [Validation(Required=false)]
            public string DatabasePublicAddress { get; set; }

            /// <summary>
            /// <para>The database engine. Valid values:</para>
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
            /// <para>The ID of the network domain where the database resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NetworkDomainId")]
            [Validation(Required=false)]
            public string NetworkDomainId { get; set; }

            /// <summary>
            /// <para>The database type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Local</b>: on-premises database.</para>
            /// </description></item>
            /// <item><description><para><b>Rds</b>: ApsaraDB RDS instance.</para>
            /// </description></item>
            /// <item><description><para><b>PolarDB</b>: PolarDB cluster.</para>
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
            /// <para>The ID of the ApsaraDB RDS instance or PolarDB cluster.</para>
            /// <remarks>
            /// <para>No value is returned for this parameter if <b>Source</b> is set to <b>Local</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9fv2hwux78x9******</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8A665B9-8550-4942-9DEE-73198051856B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of databases returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
