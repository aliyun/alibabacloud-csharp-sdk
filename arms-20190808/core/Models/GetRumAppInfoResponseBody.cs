// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumAppInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The details of the application.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRumAppInfoResponseBodyData Data { get; set; }
        public class GetRumAppInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The group to which the application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AppGroup")]
            [Validation(Required=false)]
            public string AppGroup { get; set; }

            /// <summary>
            /// <para>The application type. Valid values: web, miniapp, ios, and android.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("BackendServiceTraceRegion")]
            [Validation(Required=false)]
            public string BackendServiceTraceRegion { get; set; }

            /// <summary>
            /// <para>The mobile collection configurations.</para>
            /// </summary>
            [NameInMap("BonreeSDKConfig")]
            [Validation(Required=false)]
            public GetRumAppInfoResponseBodyDataBonreeSDKConfig BonreeSDKConfig { get; set; }
            public class GetRumAppInfoResponseBodyDataBonreeSDKConfig : TeaModel {
                /// <summary>
                /// <para>The module configuration.</para>
                /// </summary>
                [NameInMap("moduleConfig")]
                [Validation(Required=false)]
                public GetRumAppInfoResponseBodyDataBonreeSDKConfigModuleConfig ModuleConfig { get; set; }
                public class GetRumAppInfoResponseBodyDataBonreeSDKConfigModuleConfig : TeaModel {
                    /// <summary>
                    /// <para>The default configuration of the application.</para>
                    /// </summary>
                    [NameInMap("defaultConfig")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataBonreeSDKConfigModuleConfigDefaultConfigValue> DefaultConfig { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the configuration is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The version configurations of the application.</para>
                    /// </summary>
                    [NameInMap("versionConfigs")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataBonreeSDKConfigModuleConfigVersionConfigsValue> VersionConfigs { get; set; }

                }

                [NameInMap("samplingConfig")]
                [Validation(Required=false)]
                public GetRumAppInfoResponseBodyDataBonreeSDKConfigSamplingConfig SamplingConfig { get; set; }
                public class GetRumAppInfoResponseBodyDataBonreeSDKConfigSamplingConfig : TeaModel {
                    [NameInMap("samplingRate")]
                    [Validation(Required=false)]
                    public int? SamplingRate { get; set; }

                    [NameInMap("samplingType")]
                    [Validation(Required=false)]
                    public int? SamplingType { get; set; }

                }

            }

            /// <summary>
            /// <para>The domain name of the SDK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b59xxxxxxxx-sdk.rum.aliyuncs.com/v2/browser-sdk.js</para>
            /// </summary>
            [NameInMap("CdnDomain")]
            [Validation(Required=false)]
            public string CdnDomain { get; set; }

            /// <summary>
            /// <para>The time when the application was created. The value is a timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683353594000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The endpoint that is used to report application data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxx-default-cn.rum.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is subscribed. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSubscription")]
            [Validation(Required=false)]
            public string IsSubscription { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tomcat-demo-test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The alias of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nickname</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The name of the application package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.alibaba.rum</para>
            /// </summary>
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>avccccefy0@24cccccbf384dc6</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2vezare****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The list of service domain configurations. Only mobile applications are supported.</para>
            /// </summary>
            [NameInMap("ServiceDomainConfigs")]
            [Validation(Required=false)]
            public List<GetRumAppInfoResponseBodyDataServiceDomainConfigs> ServiceDomainConfigs { get; set; }
            public class GetRumAppInfoResponseBodyDataServiceDomainConfigs : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The domain name or IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The trace propagation protocols. This parameter is required if the tracing analysis feature is enabled.</para>
                /// </summary>
                [NameInMap("PropagatorTypes")]
                [Validation(Required=false)]
                public List<string> PropagatorTypes { get; set; }

                [NameInMap("SamplingRate")]
                [Validation(Required=false)]
                public int? SamplingRate { get; set; }

                /// <summary>
                /// <para>Indicates whether the tracing analysis feature is enabled. To enable the tracing analysis feature, you must activate Managed Service for OpenTelemetry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: enables the tracing analysis feature. If you enable the tracing analysis feature, related headers are inserted into requests for the domain name.</description></item>
                /// <item><description><c>false</c>: disables the tracing analysis feature.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Tracing")]
                [Validation(Required=false)]
                public bool? Tracing { get; set; }

            }

            /// <summary>
            /// <para>The name of the Simple Log Service Logstore that stores application data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logstore-rum</para>
            /// </summary>
            [NameInMap("SlsLogstore")]
            [Validation(Required=false)]
            public string SlsLogstore { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service project that stores application data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proj-xtrace-xxxxxxxxxxxxxxxxxxxxxxx-cn-hangzhou</para>
            /// </summary>
            [NameInMap("SlsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }

            /// <summary>
            /// <para>The status of the application. Valid values: created, running, and stopped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetRumAppInfoResponseBodyDataTags> Tags { get; set; }
            public class GetRumAppInfoResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Label</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the application. Valid value: RUM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUM</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StartTime is mandatory for this action.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5EC8221-08F2-4C95-9AF1-49FD998C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
