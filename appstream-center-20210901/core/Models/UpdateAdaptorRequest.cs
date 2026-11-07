// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UpdateAdaptorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application adapter to be modified. This parameter is required and must belong to an application adapter manageable by the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adt-bp1example****</para>
        /// </summary>
        [NameInMap("AdaptorId")]
        [Validation(Required=false)]
        public string AdaptorId { get; set; }

        /// <summary>
        /// <para><b>Not enabled. Do not pass this parameter.</b> This operation does not support modifying application scripts through this parameter.</para>
        /// <para>The example &quot;Not applicable (not enabled)&quot; is only a description of the field status and is not a valid parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not applicable (not enabled)</para>
        /// </summary>
        [NameInMap("AppScript")]
        [Validation(Required=false)]
        public string AppScript { get; set; }

        /// <summary>
        /// <para><b>Not enabled. Do not pass this parameter.</b> This operation does not support modifying executable file paths through this parameter.</para>
        /// <para>The example &quot;Not applicable (not enabled)&quot; is only a description of the field status and is not a valid parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not applicable (not enabled)</para>
        /// </summary>
        [NameInMap("ExecuteFileAddress")]
        [Validation(Required=false)]
        public string ExecuteFileAddress { get; set; }

        /// <summary>
        /// <para>The application optimization configuration, represented as a JSON object string. Pass this parameter only when specific optimization configuration requirements exist. The content must be a valid JSON object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("OptimizeParam")]
        [Validation(Required=false)]
        public string OptimizeParam { get; set; }

        /// <summary>
        /// <para>The command-line parameters used when the application starts. If not empty, this parameter is used to update the startup parameters of the application adapter. Specify the value based on the startup requirements of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>--lang=zh-CN</para>
        /// </summary>
        [NameInMap("SilenceParam")]
        [Validation(Required=false)]
        public string SilenceParam { get; set; }

        /// <summary>
        /// <para>The application runtime configuration object. If this parameter is omitted, the existing user configuration is not modified.</para>
        /// <para><b>If passed, the original UserConfig is entirely replaced and not merged item by item.</b> Submit the complete configuration and include the configuration items that need to be retained. Subfields that are not provided do not automatically inherit the original values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FixedResolution&quot;:&quot;1440x2560&quot;,&quot;DisconnectAction&quot;:&quot;KEEP_CURRENT&quot;,&quot;ShowWindow&quot;:&quot;HIDE&quot;}</para>
        /// </summary>
        [NameInMap("UserConfig")]
        [Validation(Required=false)]
        public UpdateAdaptorRequestUserConfig UserConfig { get; set; }
        public class UpdateAdaptorRequestUserConfig : TeaModel {
            /// <summary>
            /// <para>The processing policy after a connection is disconnected. When modifying other UserConfig configurations, if you need to retain the original policy, pass the original value in the complete configuration object. This operation does not automatically populate default values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KEEP_CURRENT</para>
            /// </summary>
            [NameInMap("DisconnectAction")]
            [Validation(Required=false)]
            public string DisconnectAction { get; set; }

            /// <summary>
            /// <para>The fixed resolution used when the application runs, in the format of width × height, in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1440x2560</para>
            /// </summary>
            [NameInMap("FixedResolution")]
            [Validation(Required=false)]
            public string FixedResolution { get; set; }

            /// <summary>
            /// <para>The application window display configuration. When modifying other UserConfig configurations, if you need to retain the original configuration, pass the original value in the complete configuration object. This operation does not automatically populate default values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HIDE</para>
            /// </summary>
            [NameInMap("ShowWindow")]
            [Validation(Required=false)]
            public string ShowWindow { get; set; }

        }

    }

}
