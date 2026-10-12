// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchExportHttpApisRequest : TeaModel {
        /// <summary>
        /// <para>The list of API IDs to export.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("apiIds")]
        [Validation(Required=false)]
        public List<string> ApiIds { get; set; }

        /// <summary>
        /// <para>The API type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("apiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        /// <summary>
        /// <para>The export extension configuration. When this configuration is specified for a REST API, gatewayId is required. This configuration is required for batch export of HTTP APIs.</para>
        /// </summary>
        [NameInMap("extensionConfig")]
        [Validation(Required=false)]
        public BatchExportHttpApisRequestExtensionConfig ExtensionConfig { get; set; }
        public class BatchExportHttpApisRequestExtensionConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to export the consumer authorization configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("withAuthConfig")]
            [Validation(Required=false)]
            public bool? WithAuthConfig { get; set; }

            /// <summary>
            /// <para>Specifies whether to export the authorized consumers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("withAuthConsumer")]
            [Validation(Required=false)]
            public bool? WithAuthConsumer { get; set; }

            /// <summary>
            /// <para>Specifies whether to export the plugin configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("withPlugin")]
            [Validation(Required=false)]
            public bool? WithPlugin { get; set; }

            /// <summary>
            /// <para>Specifies whether to export the policy configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("withPolicy")]
            [Validation(Required=false)]
            public bool? WithPolicy { get; set; }

            /// <summary>
            /// <para>Specifies whether to export the backend service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("withService")]
            [Validation(Required=false)]
            public bool? WithService { get; set; }

        }

        /// <summary>
        /// <para>The export format. Valid values: json and yaml. Default value: yaml.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yaml</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <para>The gateway instance ID. This parameter is required when extensionConfig is specified for a REST API. This parameter is required for batch export of HTTP APIs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

    }

}
