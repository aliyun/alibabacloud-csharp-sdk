// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginSchemasResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PluginSchemas")]
        [Validation(Required=false)]
        public DescribePluginSchemasResponseBodyPluginSchemas PluginSchemas { get; set; }
        public class DescribePluginSchemasResponseBodyPluginSchemas : TeaModel {
            [NameInMap("PluginSchema")]
            [Validation(Required=false)]
            public List<DescribePluginSchemasResponseBodyPluginSchemasPluginSchema> PluginSchema { get; set; }
            public class DescribePluginSchemasResponseBodyPluginSchemasPluginSchema : TeaModel {
                public string Title { get; set; }
                public string Description { get; set; }
                public string Name { get; set; }
                public string DocumentId { get; set; }
                public bool? SupportClassic { get; set; }
            }
        };

    }

}
