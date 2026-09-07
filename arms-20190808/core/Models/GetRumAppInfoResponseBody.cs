// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumAppInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. A <c>200</c> status code indicates a successful request.</para>
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
            /// <para>This parameter is deprecated. The legacy application configuration in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;apiRequestOfH5&quot;:300,&quot;apiRequestOfOriginal&quot;:500,&quot;coldStart&quot;:5000,&quot;hotStart&quot;:3000,&quot;staticResourceLoad&quot;:300,&quot;stutter&quot;:1000,&quot;viewLoadOfH5&quot;:1000,&quot;viewLoadOfOriginal&quot;:2000}</para>
            /// </summary>
            [NameInMap("AppConfig")]
            [Validation(Required=false)]
            public string AppConfig { get; set; }

            /// <summary>
            /// <para>The application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AppGroup")]
            [Validation(Required=false)]
            public string AppGroup { get; set; }

            /// <summary>
            /// <para>The application type. Valid values: <c>web</c>, <c>miniapp</c>, <c>ios</c>, and <c>android</c>. <c>web</c> indicates Web and H5 applications, <c>miniapp</c> indicates mini programs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>The region where the back-end application is deployed. This parameter is used for end-to-end tracing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("BackendServiceTraceRegion")]
            [Validation(Required=false)]
            public string BackendServiceTraceRegion { get; set; }

            /// <summary>
            /// <para>The data collection configurations for mobile applications.</para>
            /// </summary>
            [NameInMap("BonreeSDKConfig")]
            [Validation(Required=false)]
            public GetRumAppInfoResponseBodyDataBonreeSDKConfig BonreeSDKConfig { get; set; }
            public class GetRumAppInfoResponseBodyDataBonreeSDKConfig : TeaModel {
                /// <summary>
                /// <para>The feature switches for modules.</para>
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
                    /// <para>The master switch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The application version configurations.</para>
                    /// </summary>
                    [NameInMap("versionConfigs")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataBonreeSDKConfigModuleConfigVersionConfigsValue> VersionConfigs { get; set; }

                }

                /// <summary>
                /// <para>The sampling configuration.</para>
                /// </summary>
                [NameInMap("samplingConfig")]
                [Validation(Required=false)]
                public GetRumAppInfoResponseBodyDataBonreeSDKConfigSamplingConfig SamplingConfig { get; set; }
                public class GetRumAppInfoResponseBodyDataBonreeSDKConfigSamplingConfig : TeaModel {
                    /// <summary>
                    /// <para>The sampling rate, in parts per thousand. The value must be greater than 0 and less than or equal to 1,000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("samplingRate")]
                    [Validation(Required=false)]
                    public int? SamplingRate { get; set; }

                    /// <summary>
                    /// <para>The sampling type. Only random session sampling is supported. You must set this parameter to <c>1</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("samplingType")]
                    [Validation(Required=false)]
                    public int? SamplingType { get; set; }

                }

            }

            /// <summary>
            /// <para>The SDK domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b59xxxxxxxx-sdk.rum.aliyuncs.com/v2/browser-sdk.js</para>
            /// </summary>
            [NameInMap("CdnDomain")]
            [Validation(Required=false)]
            public string CdnDomain { get; set; }

            /// <summary>
            /// <para>The creation time of the application. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683353594000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>门户首页。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The endpoint for reporting application data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxx-default-cn.rum.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is bookmarked. Valid values: <c>true</c> and <c>false</c>.</para>
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
            /// <para>The application package name.</para>
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
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2vezare****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The list of service domain name configurations. This parameter is supported only for mobile applications.</para>
            /// </summary>
            [NameInMap("ServiceDomainConfigs")]
            [Validation(Required=false)]
            public List<GetRumAppInfoResponseBodyDataServiceDomainConfigs> ServiceDomainConfigs { get; set; }
            public class GetRumAppInfoResponseBodyDataServiceDomainConfigs : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试</para>
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
                /// <para>The list of trace pass-through protocols. This parameter is required when trace tracking is enabled.</para>
                /// </summary>
                [NameInMap("PropagatorTypes")]
                [Validation(Required=false)]
                public List<string> PropagatorTypes { get; set; }

                /// <summary>
                /// <para>The trace sampling rate. Valid values: (0, 100].</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SamplingRate")]
                [Validation(Required=false)]
                public int? SamplingRate { get; set; }

                /// <summary>
                /// <para>Indicates whether to enable trace tracking. You must activate Application Real-Time Monitoring Service (ARMS) OpenTelemetry Edition to use this feature. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: enables trace tracking. If you set this parameter to true, a related header is inserted into the request for this domain name.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: does not enable trace tracking.</para>
                /// </description></item>
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
            /// <para>The name of the Log Service Logstore that is used to store application data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logstore-rum</para>
            /// </summary>
            [NameInMap("SlsLogstore")]
            [Validation(Required=false)]
            public string SlsLogstore { get; set; }

            /// <summary>
            /// <para>The name of the Log Service project that is used to store application data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proj-xtrace-xxxxxxxxxxxxxxxxxxxxxxx-cn-hangzhou</para>
            /// </summary>
            [NameInMap("SlsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }

            /// <summary>
            /// <para>The application status. Valid values: <c>created</c>, <c>running</c>, and <c>stopped</c>. <c>stopped</c> indicates that data reporting is stopped.</para>
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
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Label</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The application type. This parameter is a constant of <c>RUM</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUM</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("WebSDKConfigJson")]
            [Validation(Required=false)]
            public string WebSDKConfigJson { get; set; }

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
        /// <para>The error message returned for a failed request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>内部错误，请联系管理员。</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5EC8221-08F2-4C95-9AF1-49FD998C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
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
