// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class DescribeShardDbConnectionInfoResponseBody : TeaModel {
        [NameInMap("ConnectionInfo")]
        [Validation(Required=false)]
        public DescribeShardDbConnectionInfoResponseBodyConnectionInfo ConnectionInfo { get; set; }
        public class DescribeShardDbConnectionInfoResponseBodyConnectionInfo : TeaModel {
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceUrl")]
            [Validation(Required=false)]
            public string InstanceUrl { get; set; }

            [NameInMap("blockingTimeout")]
            [Validation(Required=false)]
            public int? BlockingTimeout { get; set; }

            [NameInMap("connectionProperties")]
            [Validation(Required=false)]
            public string ConnectionProperties { get; set; }

            [NameInMap("dbStatus")]
            [Validation(Required=false)]
            public string DbStatus { get; set; }

            [NameInMap("dbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            [NameInMap("idleTimeOut")]
            [Validation(Required=false)]
            public int? IdleTimeOut { get; set; }

            [NameInMap("maxPoolSize")]
            [Validation(Required=false)]
            public int? MaxPoolSize { get; set; }

            [NameInMap("minPoolSize")]
            [Validation(Required=false)]
            public int? MinPoolSize { get; set; }

            [NameInMap("preparedStatementCacheSize")]
            [Validation(Required=false)]
            public int? PreparedStatementCacheSize { get; set; }

            [NameInMap("subDbName")]
            [Validation(Required=false)]
            public string SubDbName { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
