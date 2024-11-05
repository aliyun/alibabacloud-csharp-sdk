// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingInstanceConfigurationResponseBody : TeaModel {
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceConfigurationResponseBodyConfiguration> Configuration { get; set; }
        public class DescribeRenderingInstanceConfigurationResponseBodyConfiguration : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<DescribeRenderingInstanceConfigurationResponseBodyConfigurationAttributes> Attributes { get; set; }
            public class DescribeRenderingInstanceConfigurationResponseBodyConfigurationAttributes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>lon</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>location</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
