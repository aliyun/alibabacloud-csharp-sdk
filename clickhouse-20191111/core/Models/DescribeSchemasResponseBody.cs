// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeSchemasResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSchemasResponseBodyItems Items { get; set; }
        public class DescribeSchemasResponseBodyItems : TeaModel {
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public List<DescribeSchemasResponseBodyItemsSchema> Schema { get; set; }
            public class DescribeSchemasResponseBodyItemsSchema : TeaModel {
                public string DBClusterId { get; set; }
                public string SchemaName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
