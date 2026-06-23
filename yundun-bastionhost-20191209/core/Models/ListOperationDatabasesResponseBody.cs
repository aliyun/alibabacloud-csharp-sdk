// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationDatabasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The databases.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<ListOperationDatabasesResponseBodyDatabases> Databases { get; set; }
        public class ListOperationDatabasesResponseBodyDatabases : TeaModel {
            /// <summary>
            /// <para>The endpoint type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Public</b>: a public endpoint</para>
            /// </description></item>
            /// <item><description><para><b>Private</b>: a private endpoint</para>
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
            /// <para>The comment on the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpp</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The ID of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zDatabase</para>
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
            /// <para>The private endpoint of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-b******9b.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DatabasePrivateAddress")]
            [Validation(Required=false)]
            public string DatabasePrivateAddress { get; set; }

            /// <summary>
            /// <para>The public endpoint of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-uf******p45.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DatabasePublicAddress")]
            [Validation(Required=false)]
            public string DatabasePublicAddress { get; set; }

            /// <summary>
            /// <para>The database type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MySQL</b></para>
            /// </description></item>
            /// <item><description><para><b>PostgreSQL</b></para>
            /// </description></item>
            /// <item><description><para><b>Oracle</b></para>
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
            /// <para>The source of the database.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Local</b>: a local database</para>
            /// </description></item>
            /// <item><description><para><b>Rds</b>: an ApsaraDB RDS database</para>
            /// </description></item>
            /// <item><description><para><b>PolarDB</b>: a PolarDB database</para>
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
            /// <para>The ID of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9225bhipya******</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("SourceInstanceRegionId")]
            [Validation(Required=false)]
            public string SourceInstanceRegionId { get; set; }

            /// <summary>
            /// <para>The status of the source instance:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: The instance is running.</para>
            /// </description></item>
            /// <item><description><para><b>Release</b>: The instance is released.</para>
            /// </description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
