// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingInstanceConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceConfigurationResponseBodyConfiguration> Configuration { get; set; }
        public class DescribeRenderingInstanceConfigurationResponseBodyConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of properties for the module.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<DescribeRenderingInstanceConfigurationResponseBodyConfigurationAttributes> Attributes { get; set; }
            public class DescribeRenderingInstanceConfigurationResponseBodyConfigurationAttributes : TeaModel {
                /// <summary>
                /// <para>The name of the attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lon</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <para>The name of the device simulation feature module. Valid values:</para>
            /// <ol>
            /// <item><description><para>ctl: The control module.</para>
            /// </description></item>
            /// <item><description><para>prop: The property module.</para>
            /// </description></item>
            /// <item><description><para>location: The location module.</para>
            /// </description></item>
            /// <item><description><para>battery: The battery module.</para>
            /// </description></item>
            /// <item><description><para>network: The network module.</para>
            /// </description></item>
            /// <item><description><para>bluetooth: The Bluetooth module.</para>
            /// </description></item>
            /// <item><description><para>sim: The SIM card module.</para>
            /// </description></item>
            /// <item><description><para>display: The device module.</para>
            /// </description></item>
            /// <item><description><para>system: The basic module.</para>
            /// </description></item>
            /// </ol>
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
