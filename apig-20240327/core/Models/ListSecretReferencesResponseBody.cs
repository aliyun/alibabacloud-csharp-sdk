// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListSecretReferencesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListSecretReferencesResponseBodyData Data { get; set; }
        public class ListSecretReferencesResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListSecretReferencesResponseBodyDataItems> Items { get; set; }
            public class ListSecretReferencesResponseBodyDataItems : TeaModel {
                [NameInMap("PluginConfig")]
                [Validation(Required=false)]
                public ListSecretReferencesResponseBodyDataItemsPluginConfig PluginConfig { get; set; }
                public class ListSecretReferencesResponseBodyDataItemsPluginConfig : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("pluginClassId")]
                    [Validation(Required=false)]
                    public string PluginClassId { get; set; }

                    [NameInMap("pluginId")]
                    [Validation(Required=false)]
                    public string PluginId { get; set; }

                }

                [NameInMap("ServiceConfig")]
                [Validation(Required=false)]
                public ListSecretReferencesResponseBodyDataItemsServiceConfig ServiceConfig { get; set; }
                public class ListSecretReferencesResponseBodyDataItemsServiceConfig : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                }

                [NameInMap("consumerConfig")]
                [Validation(Required=false)]
                public ListSecretReferencesResponseBodyDataItemsConsumerConfig ConsumerConfig { get; set; }
                public class ListSecretReferencesResponseBodyDataItemsConsumerConfig : TeaModel {
                    [NameInMap("consumerId")]
                    [Validation(Required=false)]
                    public string ConsumerId { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("mcpServerConfig")]
                [Validation(Required=false)]
                public ListSecretReferencesResponseBodyDataItemsMcpServerConfig McpServerConfig { get; set; }
                public class ListSecretReferencesResponseBodyDataItemsMcpServerConfig : TeaModel {
                    [NameInMap("httpApiId")]
                    [Validation(Required=false)]
                    public string HttpApiId { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("routeId")]
                    [Validation(Required=false)]
                    public string RouteId { get; set; }

                }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
