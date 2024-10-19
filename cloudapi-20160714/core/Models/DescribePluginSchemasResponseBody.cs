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
                /// <summary>
                /// <b>Example:</b>
                /// <para>plugin scheme description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4107**</para>
                /// </summary>
                [NameInMap("DocumentId")]
                [Validation(Required=false)]
                public string DocumentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VPC_C</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportClassic")]
                [Validation(Required=false)]
                public bool? SupportClassic { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>plugin schema title</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2D39D1B3-8548-508A-9CE2-7F4A3F2A7989</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
