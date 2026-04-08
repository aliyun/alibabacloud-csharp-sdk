// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ExportHttpApiRequest : TeaModel {
        [NameInMap("extensionConfig")]
        [Validation(Required=false)]
        public ExportHttpApiRequestExtensionConfig ExtensionConfig { get; set; }
        public class ExportHttpApiRequestExtensionConfig : TeaModel {
            [NameInMap("withAuthConfig")]
            [Validation(Required=false)]
            public bool? WithAuthConfig { get; set; }

            [NameInMap("withAuthConsumer")]
            [Validation(Required=false)]
            public bool? WithAuthConsumer { get; set; }

            [NameInMap("withPlugin")]
            [Validation(Required=false)]
            public bool? WithPlugin { get; set; }

            [NameInMap("withPolicy")]
            [Validation(Required=false)]
            public bool? WithPolicy { get; set; }

            [NameInMap("withService")]
            [Validation(Required=false)]
            public bool? WithService { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-xxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("operationIds")]
        [Validation(Required=false)]
        public List<string> OperationIds { get; set; }

    }

}
