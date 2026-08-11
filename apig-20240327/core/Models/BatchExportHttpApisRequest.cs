// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchExportHttpApisRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("apiIds")]
        [Validation(Required=false)]
        public List<string> ApiIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("apiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        [NameInMap("extensionConfig")]
        [Validation(Required=false)]
        public BatchExportHttpApisRequestExtensionConfig ExtensionConfig { get; set; }
        public class BatchExportHttpApisRequestExtensionConfig : TeaModel {
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
        /// <para>yaml</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-xxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

    }

}
