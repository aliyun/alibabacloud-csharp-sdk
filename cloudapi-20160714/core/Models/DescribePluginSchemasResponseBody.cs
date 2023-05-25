// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginSchemasResponseBody : TeaModel {
        [NameInMap("PluginSchemas")]
        [Validation(Required=false)]
        public DescribePluginSchemasResponseBodyPluginSchemas PluginSchemas { get; set; }
        public class DescribePluginSchemasResponseBodyPluginSchemas : TeaModel {
            [NameInMap("PluginSchema")]
            [Validation(Required=false)]
            public List<DescribePluginSchemasResponseBodyPluginSchemasPluginSchema> PluginSchema { get; set; }
            public class DescribePluginSchemasResponseBodyPluginSchemasPluginSchema : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DocumentId")]
                [Validation(Required=false)]
                public string DocumentId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SupportClassic")]
                [Validation(Required=false)]
                public bool? SupportClassic { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
