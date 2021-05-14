// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsShardingDbsResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShardingDbs")]
        [Validation(Required=false)]
        public DescribeDrdsShardingDbsResponseBodyShardingDbs ShardingDbs { get; set; }
        public class DescribeDrdsShardingDbsResponseBodyShardingDbs : TeaModel {
            [NameInMap("ShardingDb")]
            [Validation(Required=false)]
            public List<DescribeDrdsShardingDbsResponseBodyShardingDbsShardingDb> ShardingDb { get; set; }
            public class DescribeDrdsShardingDbsResponseBodyShardingDbsShardingDb : TeaModel {
                public int? MinPoolSize { get; set; }
                public int? MaxPoolSize { get; set; }
                public string DbInstanceId { get; set; }
                public string ConnectUrl { get; set; }
                public string GroupName { get; set; }
                public string DbType { get; set; }
                public int? IdleTimeOut { get; set; }
                public string ShardingDbName { get; set; }
                public int? BlockingTimeout { get; set; }
                public int? PreparedStatementCacheSize { get; set; }
                public string ConnectionProperties { get; set; }
                public string UserName { get; set; }
                public string DbStatus { get; set; }
            }
        };

    }

}
