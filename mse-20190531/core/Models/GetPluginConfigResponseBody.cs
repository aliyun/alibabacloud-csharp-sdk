// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetPluginConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPluginConfigResponseBodyData Data { get; set; }
        public class GetPluginConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The plug-in category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Custom.</description></item>
            /// <item><description>1: Authentication and authorization.</description></item>
            /// <item><description>2: Security protection.</description></item>
            /// <item><description>3: Transport protocol.</description></item>
            /// <item><description>4: Traffic control.</description></item>
            /// <item><description>5: Traffic observation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The configuration validation.</para>
            /// 
            /// <b>Example:</b>
            /// <h1>Validate required configuration fields. In the following example, the plug-in configuration must contain the &quot;name&quot;, &quot;age&quot;, and &quot;friends&quot; fields.</h1>
            /// <para>name: John
            /// age: 18
            /// friends:</para>
            /// <list type="bullet">
            /// <item><description>David</description></item>
            /// <item><description>Anne</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ConfigCheck")]
            [Validation(Required=false)]
            public string ConfigCheck { get; set; }

            /// <summary>
            /// <para>The plug-in configuration example.</para>
            /// 
            /// <b>Example:</b>
            /// <para>blocked_code: 404
            /// blocked_message: resource not found</para>
            /// </summary>
            [NameInMap("ConfigExample")]
            [Validation(Required=false)]
            public string ConfigExample { get; set; }

            /// <summary>
            /// <para>The start index of domain-level rules in GatewayConfigList. If no domain-level rules exist, the value is -1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DomainConfigStartIndex")]
            [Validation(Required=false)]
            public int? DomainConfigStartIndex { get; set; }

            /// <summary>
            /// <para>The list of gateway plug-in configurations.</para>
            /// </summary>
            [NameInMap("GatewayConfigList")]
            [Validation(Required=false)]
            public List<GetPluginConfigResponseBodyDataGatewayConfigList> GatewayConfigList { get; set; }
            public class GetPluginConfigResponseBodyDataGatewayConfigList : TeaModel {
                /// <summary>
                /// <para>The plug-in configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <h1>Validate required configuration fields. In the following example, the plug-in configuration must contain the &quot;name&quot;, &quot;age&quot;, and &quot;friends&quot; fields.</h1>
                /// <para>name: John
                /// age: 18
                /// friends:</para>
                /// <list type="bullet">
                /// <item><description>David</description></item>
                /// <item><description>Anne</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The plug-in application scope. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Global.</description></item>
                /// <item><description>1: Domain name.</description></item>
                /// <item><description>2: Route.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ConfigLevel")]
                [Validation(Required=false)]
                public int? ConfigLevel { get; set; }

                /// <summary>
                /// <para>Indicates whether the plug-in is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The unique ID of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-ubuwqygbq4783gqb2y3f87q****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1667309705000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1667309705000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The plug-in configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the gateway plug-in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PluginId")]
                [Validation(Required=false)]
                public long? PluginId { get; set; }

                /// <summary>
                /// <para>The list of domain name and route resources, distinguished by ConfigLevel.</para>
                /// </summary>
                [NameInMap("ResourceList")]
                [Validation(Required=false)]
                public List<GetPluginConfigResponseBodyDataGatewayConfigListResourceList> ResourceList { get; set; }
                public class GetPluginConfigResponseBodyDataGatewayConfigListResourceList : TeaModel {
                    /// <summary>
                    /// <para>The resource ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The resource name, which is the domain name or route name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-route</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The index of instance-level rules in GatewayConfigList. If no instance-level rules exist, the value is -1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("GatewayConfigStartIndex")]
            [Validation(Required=false)]
            public int? GatewayConfigStartIndex { get; set; }

            /// <summary>
            /// <para>The plug-in ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>The plug-in name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The plug-in execution phase. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Default phase.</description></item>
            /// <item><description>1: Authentication phase.</description></item>
            /// <item><description>2: Authorization phase.</description></item>
            /// <item><description>3: Statistics phase.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public int? Phase { get; set; }

            /// <summary>
            /// <para>The ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PrimaryUser")]
            [Validation(Required=false)]
            public string PrimaryUser { get; set; }

            /// <summary>
            /// <para>The plug-in execution priority. A larger value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The publish status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PublishState")]
            [Validation(Required=false)]
            public int? PublishState { get; set; }

            /// <summary>
            /// <para>The README description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>read me</para>
            /// </summary>
            [NameInMap("Readme")]
            [Validation(Required=false)]
            public string Readme { get; set; }

            /// <summary>
            /// <para>The README description in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>read me</para>
            /// </summary>
            [NameInMap("ReadmeEn")]
            [Validation(Required=false)]
            public string ReadmeEn { get; set; }

            /// <summary>
            /// <para>The start index of route-level rules in GatewayConfigList. If no route-level rules exist, the value is -1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RouteConfigStartIndex")]
            [Validation(Required=false)]
            public int? RouteConfigStartIndex { get; set; }

            /// <summary>
            /// <para>The enabling status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The plug-in summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a plug-in</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The plug-in summary in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Convert request/response headers, request query parameters, and request/response body parameters.</para>
            /// </summary>
            [NameInMap("SummaryEn")]
            [Validation(Required=false)]
            public string SummaryEn { get; set; }

            /// <summary>
            /// <para>The plug-in type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: HTTP filter.</description></item>
            /// <item><description>1: Network filter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The plug-in version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The list of gateway plug-in version information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;id&quot;:1, &quot;version&quot;: &quot;1.0.0&quot;}]</para>
            /// </summary>
            [NameInMap("VersionJson")]
            [Validation(Required=false)]
            public string VersionJson { get; set; }

            /// <summary>
            /// <para>The WebAssembly (Wasm) implementation language. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: C++.</description></item>
            /// <item><description>1: TinyGo.</description></item>
            /// <item><description>2: Rust.</description></item>
            /// <item><description>3: AssemblyScript.</description></item>
            /// <item><description>4: Zig.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WasmLang")]
            [Validation(Required=false)]
            public int? WasmLang { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The API message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03A3E2F4-6804-5663-9D5D-2EC47A1*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
