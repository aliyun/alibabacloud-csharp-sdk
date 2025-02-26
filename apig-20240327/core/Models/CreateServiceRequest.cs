// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateServiceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtg***</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<CreateServiceRequestServiceConfigs> ServiceConfigs { get; set; }
        public class CreateServiceRequestServiceConfigs : TeaModel {
            [NameInMap("addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            [NameInMap("aiServiceConfig")]
            [Validation(Required=false)]
            public AiServiceConfig AiServiceConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user-service</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>LATEST</para>
            /// </summary>
            [NameInMap("qualifier")]
            [Validation(Required=false)]
            public string Qualifier { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MSE_NACOS</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
