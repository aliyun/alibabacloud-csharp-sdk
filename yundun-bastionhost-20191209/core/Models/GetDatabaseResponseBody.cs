// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned detailed information about the database.</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public GetDatabaseResponseBodyDatabase Database { get; set; }
        public class GetDatabaseResponseBodyDatabase : TeaModel {
            /// <summary>
            /// <para>The address type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Public</description></item>
            /// <item><description>Private</description></item>
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
            /// <para>22</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
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
            /// <para>The internal endpoint of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1zq******</para>
            /// </summary>
            [NameInMap("DatabasePrivateAddress")]
            [Validation(Required=false)]
            public string DatabasePrivateAddress { get; set; }

            /// <summary>
            /// <para>The public endpoint of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-uf65******</para>
            /// </summary>
            [NameInMap("DatabasePublicAddress")]
            [Validation(Required=false)]
            public string DatabasePublicAddress { get; set; }

            /// <summary>
            /// <para>The database engine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>mysql</b></description></item>
            /// <item><description><b>sqlserver</b></description></item>
            /// <item><description><b>postgresql</b></description></item>
            /// <item><description><b>oracle</b></description></item>
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
            /// <para>45</para>
            /// </summary>
            [NameInMap("NetworkDomainId")]
            [Validation(Required=false)]
            public string NetworkDomainId { get; set; }

            /// <summary>
            /// <para>The database type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Local</b>: on-premises database.</description></item>
            /// <item><description><b>Rds</b>: ApsaraDB RDS instance.</description></item>
            /// <item><description><b>PolarDB</b>: PolarDB cluster.</description></item>
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
            /// <para>If <b>Source</b> is set to <b>Local</b>, this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9527ob0e0nftcsffke</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the ApsaraDB RDS instance or PolarDB cluster.</para>
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
        /// <para>4D72B883-9D15-5B05-B987-DFD10EB1FFB4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
