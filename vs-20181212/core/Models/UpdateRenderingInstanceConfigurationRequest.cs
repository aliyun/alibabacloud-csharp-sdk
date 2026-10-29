// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateRenderingInstanceConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The configuration content.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<UpdateRenderingInstanceConfigurationRequestConfiguration> Configuration { get; set; }
        public class UpdateRenderingInstanceConfigurationRequestConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of attributes corresponding to the module.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<UpdateRenderingInstanceConfigurationRequestConfigurationAttributes> Attributes { get; set; }
            public class UpdateRenderingInstanceConfigurationRequestConfigurationAttributes : TeaModel {
                /// <summary>
                /// <para>The name of the attribute.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lon</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the attribute.</para>
                /// <para>This parameter is required.</para>
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
            /// <item><description>prop: Property module.</description></item>
            /// <item><description>location: Location module.</description></item>
            /// <item><description>battery: Battery module.</description></item>
            /// <item><description>network: Network module.</description></item>
            /// <item><description>bluetooth: Bluetooth module.</description></item>
            /// <item><description>sim: SIM card module.</description></item>
            /// <item><description>display: Device module.</description></item>
            /// <item><description>system: Basic module.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>location</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

        /// <summary>
        /// <para>The instance ID of the cloud application service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}
