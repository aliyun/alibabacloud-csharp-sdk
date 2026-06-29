// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ExportHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to export plug-in configurations.</para>
        /// </summary>
        [NameInMap("extensionConfig")]
        [Validation(Required=false)]
        public ExportHttpApiRequestExtensionConfig ExtensionConfig { get; set; }
        public class ExportHttpApiRequestExtensionConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to export consumer authorization configurations for operations or routes.</para>
            /// </summary>
            [NameInMap("withAuthConfig")]
            [Validation(Required=false)]
            public bool? WithAuthConfig { get; set; }

            /// <summary>
            /// <para>Specifies whether to export authorized consumers.</para>
            /// </summary>
            [NameInMap("withAuthConsumer")]
            [Validation(Required=false)]
            public bool? WithAuthConsumer { get; set; }

            /// <summary>
            /// <para>Specifies whether to export plug-in configurations.</para>
            /// </summary>
            [NameInMap("withPlugin")]
            [Validation(Required=false)]
            public bool? WithPlugin { get; set; }

            /// <summary>
            /// <para>Specifies whether to export policy configurations.</para>
            /// </summary>
            [NameInMap("withPolicy")]
            [Validation(Required=false)]
            public bool? WithPolicy { get; set; }

            /// <summary>
            /// <para>Specifies whether to export backend services.</para>
            /// </summary>
            [NameInMap("withService")]
            [Validation(Required=false)]
            public bool? WithService { get; set; }

        }

        /// <summary>
        /// <para>The gateway instance ID. This parameter is required when you export gateway extension information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The IDs of specific operations to export when you export a REST API.</para>
        /// </summary>
        [NameInMap("operationIds")]
        [Validation(Required=false)]
        public List<string> OperationIds { get; set; }

    }

}
