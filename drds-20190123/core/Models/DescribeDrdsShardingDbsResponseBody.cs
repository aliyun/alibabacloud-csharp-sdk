// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsShardingDbsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of database shards returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>509BDE17-505A-4B3B-854D-30D3F092502F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of returned database shards.</para>
        /// </summary>
        [NameInMap("ShardingDbs")]
        [Validation(Required=false)]
        public DescribeDrdsShardingDbsResponseBodyShardingDbs ShardingDbs { get; set; }
        public class DescribeDrdsShardingDbsResponseBodyShardingDbs : TeaModel {
            [NameInMap("ShardingDb")]
            [Validation(Required=false)]
            public List<DescribeDrdsShardingDbsResponseBodyShardingDbsShardingDb> ShardingDb { get; set; }
            public class DescribeDrdsShardingDbsResponseBodyShardingDbsShardingDb : TeaModel {
                /// <summary>
                /// <para>The timeout period for a transaction to wait for the release of the data lock.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("BlockingTimeout")]
                [Validation(Required=false)]
                public int? BlockingTimeout { get; set; }

                /// <summary>
                /// <para>The URL that is used to access the Apsara RDS for MySQL instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.100.64.100:11569</para>
                /// </summary>
                [NameInMap("ConnectUrl")]
                [Validation(Required=false)]
                public string ConnectUrl { get; set; }

                /// <summary>
                /// <para>The properties of the connection string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>connectTimeout=3000;autoReconnect=true;failOverReadOnly=false;socketTimeout=900000;rewriteBatchedStatements=true;characterEncoding=utf8</para>
                /// </summary>
                [NameInMap("ConnectionProperties")]
                [Validation(Required=false)]
                public string ConnectionProperties { get; set; }

                /// <summary>
                /// <para>The ID of the Apsara RDS for MySQL instance that is used as the storage of the database shard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp1hjzn0yv5j2****</para>
                /// </summary>
                [NameInMap("DbInstanceId")]
                [Validation(Required=false)]
                public string DbInstanceId { get; set; }

                /// <summary>
                /// <para>The status of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("DbStatus")]
                [Validation(Required=false)]
                public string DbStatus { get; set; }

                /// <summary>
                /// <para>The engine of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The name of group on which the database shard is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TEMP1_1568171495522SABE_KUP4_0000</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The timeout period of an idle connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("IdleTimeOut")]
                [Validation(Required=false)]
                public int? IdleTimeOut { get; set; }

                /// <summary>
                /// <para>The maximum size of the connection pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("MaxPoolSize")]
                [Validation(Required=false)]
                public int? MaxPoolSize { get; set; }

                /// <summary>
                /// <para>The minimum size of the connection pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MinPoolSize")]
                [Validation(Required=false)]
                public int? MinPoolSize { get; set; }

                /// <summary>
                /// <para>The size of cache for the returned results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreparedStatementCacheSize")]
                [Validation(Required=false)]
                public int? PreparedStatementCacheSize { get; set; }

                /// <summary>
                /// <para>The name of the database shard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>temp1_zhk1_0000</para>
                /// </summary>
                [NameInMap("ShardingDbName")]
                [Validation(Required=false)]
                public string ShardingDbName { get; set; }

                /// <summary>
                /// <para>The username that is used to connect to the ApsaraDB RDS for MySQL instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pg284mi8</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The number of returned database shards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
