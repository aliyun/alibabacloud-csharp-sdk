// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsShardingDbsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of database shards returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of returned database shards.
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
                /// The timeout period for a transaction to wait for the release of the data lock.
                /// </summary>
                [NameInMap("BlockingTimeout")]
                [Validation(Required=false)]
                public int? BlockingTimeout { get; set; }

                /// <summary>
                /// The URL that is used to access the Apsara RDS for MySQL instance.
                /// </summary>
                [NameInMap("ConnectUrl")]
                [Validation(Required=false)]
                public string ConnectUrl { get; set; }

                /// <summary>
                /// The properties of the connection string.
                /// </summary>
                [NameInMap("ConnectionProperties")]
                [Validation(Required=false)]
                public string ConnectionProperties { get; set; }

                /// <summary>
                /// The ID of the Apsara RDS for MySQL instance that is used as the storage of the database shard.
                /// </summary>
                [NameInMap("DbInstanceId")]
                [Validation(Required=false)]
                public string DbInstanceId { get; set; }

                /// <summary>
                /// The status of the database.
                /// </summary>
                [NameInMap("DbStatus")]
                [Validation(Required=false)]
                public string DbStatus { get; set; }

                /// <summary>
                /// The engine of the database.
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The name of group on which the database shard is stored.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The timeout period of an idle connection.
                /// </summary>
                [NameInMap("IdleTimeOut")]
                [Validation(Required=false)]
                public int? IdleTimeOut { get; set; }

                /// <summary>
                /// The maximum size of the connection pool.
                /// </summary>
                [NameInMap("MaxPoolSize")]
                [Validation(Required=false)]
                public int? MaxPoolSize { get; set; }

                /// <summary>
                /// The minimum size of the connection pool.
                /// </summary>
                [NameInMap("MinPoolSize")]
                [Validation(Required=false)]
                public int? MinPoolSize { get; set; }

                /// <summary>
                /// The size of cache for the returned results.
                /// </summary>
                [NameInMap("PreparedStatementCacheSize")]
                [Validation(Required=false)]
                public int? PreparedStatementCacheSize { get; set; }

                /// <summary>
                /// The name of the database shard.
                /// </summary>
                [NameInMap("ShardingDbName")]
                [Validation(Required=false)]
                public string ShardingDbName { get; set; }

                /// <summary>
                /// The username that is used to connect to the ApsaraDB RDS for MySQL instance.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The number of returned database shards.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
