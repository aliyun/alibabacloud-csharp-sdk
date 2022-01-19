// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeLogHubAttributeResponseBody : TeaModel {
        [NameInMap("LoghubInfo")]
        [Validation(Required=false)]
        public DescribeLogHubAttributeResponseBodyLoghubInfo LoghubInfo { get; set; }
        public class DescribeLogHubAttributeResponseBodyLoghubInfo : TeaModel {
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }
            [NameInMap("DeliverName")]
            [Validation(Required=false)]
            public string DeliverName { get; set; }
            [NameInMap("DeliverTime")]
            [Validation(Required=false)]
            public string DeliverTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DomainUrl")]
            [Validation(Required=false)]
            public string DomainUrl { get; set; }
            [NameInMap("FilterDirtyData")]
            [Validation(Required=false)]
            public string FilterDirtyData { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("LogHubStores")]
            [Validation(Required=false)]
            public DescribeLogHubAttributeResponseBodyLoghubInfoLogHubStores LogHubStores { get; set; }
            public class DescribeLogHubAttributeResponseBodyLoghubInfoLogHubStores : TeaModel {
                [NameInMap("LogHubStore")]
                [Validation(Required=false)]
                public List<DescribeLogHubAttributeResponseBodyLoghubInfoLogHubStoresLogHubStore> LogHubStore { get; set; }
                public class DescribeLogHubAttributeResponseBodyLoghubInfoLogHubStoresLogHubStore : TeaModel {
                    [NameInMap("FieldKey")]
                    [Validation(Required=false)]
                    public string FieldKey { get; set; }

                    [NameInMap("LogKey")]
                    [Validation(Required=false)]
                    public string LogKey { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
