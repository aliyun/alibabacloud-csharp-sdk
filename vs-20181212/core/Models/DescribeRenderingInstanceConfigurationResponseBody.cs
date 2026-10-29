// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingInstanceConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration content.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceConfigurationResponseBodyConfiguration> Configuration { get; set; }
        public class DescribeRenderingInstanceConfigurationResponseBodyConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of attributes for the module.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<DescribeRenderingInstanceConfigurationResponseBodyConfigurationAttributes> Attributes { get; set; }
            public class DescribeRenderingInstanceConfigurationResponseBodyConfigurationAttributes : TeaModel {
                /// <summary>
                /// <para>The attribute name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lon</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The attribute value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <para>The name of the real-device simulation feature module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ctl: Control module.</description></item>
            /// <item><description>prop: Attribute module.</description></item>
            /// <item><description>location: Location module.</description></item>
            /// <item><description>battery: Battery module.</description></item>
            /// <item><description>network: Network module.</description></item>
            /// <item><description>bluetooth: Bluetooth module.</description></item>
            /// <item><description>sim: SIM card module.</description></item>
            /// <item><description>display: Device module.</description></item>
            /// <item><description>system: Basic module.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>location</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
