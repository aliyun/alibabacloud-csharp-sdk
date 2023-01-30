// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginSchemasResponseBody : TeaModel {
        /// <summary>
        /// The plug-in modes.
        /// </summary>
        [NameInMap("PluginSchemas")]
        [Validation(Required=false)]
        public DescribePluginSchemasResponseBodyPluginSchemas PluginSchemas { get; set; }
        public class DescribePluginSchemasResponseBodyPluginSchemas : TeaModel {
            [NameInMap("PluginSchema")]
            [Validation(Required=false)]
            public List<DescribePluginSchemasResponseBodyPluginSchemasPluginSchema> PluginSchema { get; set; }
            public class DescribePluginSchemasResponseBodyPluginSchemasPluginSchema : TeaModel {
                /// <summary>
                /// The plug-in description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the document.
                /// </summary>
                [NameInMap("DocumentId")]
                [Validation(Required=false)]
                public string DocumentId { get; set; }

                /// <summary>
                /// The name of the plug-in.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Indicates whether classification is supported.
                /// </summary>
                [NameInMap("SupportClassic")]
                [Validation(Required=false)]
                public bool? SupportClassic { get; set; }

                /// <summary>
                /// The plug-in title.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
