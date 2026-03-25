// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListSecretReferencesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListSecretReferencesResponseBodyData Data { get; set; }
        public class ListSecretReferencesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of reference details.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListSecretReferencesResponseBodyDataItems> Items { get; set; }
            public class ListSecretReferencesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The information about the plug-in that references the current key.</para>
                /// </summary>
                [NameInMap("PluginConfig")]
                [Validation(Required=false)]
                public ListSecretReferencesResponseBodyDataItemsPluginConfig PluginConfig { get; set; }
                public class ListSecretReferencesResponseBodyDataItemsPluginConfig : TeaModel {
                    /// <summary>
                    /// <para>The plug-in name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oauth</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The plug-in type ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pls-xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("pluginClassId")]
                    [Validation(Required=false)]
                    public string PluginClassId { get; set; }

                    /// <summary>
                    /// <para>The plug-in ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pl-d4ijk56m1hkhxxxxxxxx</para>
                    /// </summary>
                    [NameInMap("pluginId")]
                    [Validation(Required=false)]
                    public string PluginId { get; set; }

                }

                /// <summary>
                /// <para>The service information that references the current key.</para>
                /// </summary>
                [NameInMap("ServiceConfig")]
                [Validation(Required=false)]
                public ListSecretReferencesResponseBodyDataItemsServiceConfig ServiceConfig { get; set; }
                public class ListSecretReferencesResponseBodyDataItemsServiceConfig : TeaModel {
                    /// <summary>
                    /// <para>The service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>myService</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The service ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>svc-cvgbtcmm1hkmxxxxxxxx</para>
                    /// </summary>
                    [NameInMap("serviceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                }

                /// <summary>
                /// <para>The consumer information that references the current key.</para>
                /// </summary>
                [NameInMap("consumerConfig")]
                [Validation(Required=false)]
                public ListSecretReferencesResponseBodyDataItemsConsumerConfig ConsumerConfig { get; set; }
                public class ListSecretReferencesResponseBodyDataItemsConsumerConfig : TeaModel {
                    /// <summary>
                    /// <para>The consumer ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cs-d0iltnem1hkhxxxxxxxx</para>
                    /// </summary>
                    [NameInMap("consumerId")]
                    [Validation(Required=false)]
                    public string ConsumerId { get; set; }

                    /// <summary>
                    /// <para>The consumer name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>myconsumer</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The gateway instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>MCP service information that references the current key.</para>
                /// </summary>
                [NameInMap("mcpServerConfig")]
                [Validation(Required=false)]
                public ListSecretReferencesResponseBodyDataItemsMcpServerConfig McpServerConfig { get; set; }
                public class ListSecretReferencesResponseBodyDataItemsMcpServerConfig : TeaModel {
                    /// <summary>
                    /// <para>The HTTP API ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>api-d2vv43em201hxxxxxxxx</para>
                    /// </summary>
                    [NameInMap("httpApiId")]
                    [Validation(Required=false)]
                    public string HttpApiId { get; set; }

                    /// <summary>
                    /// <para>The route name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The route ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hr-cv0i5oum1hkhxxxxxxxx</para>
                    /// </summary>
                    [NameInMap("routeId")]
                    [Validation(Required=false)]
                    public string RouteId { get; set; }

                }

                /// <summary>
                /// <para>The type of resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Plugin</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE857A85-251D-5018-8103-A38957D71***</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
