// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert configuration of the service.</para>
        /// <remarks>
        /// <para>This configuration takes effect only if you configure an alert policy in <b>PolicyNames</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;TemplateUrl&quot;: &quot;<a href="http://template.file.url">http://template.file.url</a>&quot;, // Application group level alarm metadata &quot;ApplicationGroups&quot;: [ { &quot;Name&quot;: &quot;applicationGroup1&quot;, &quot;TemplateUrl&quot;: &quot;url1&quot; }, { &quot;Name&quot;: &quot;applicationGroup2&quot;, &quot;TemplateUrl&quot;: &quot;url2&quot; } ] }</para>
        /// </summary>
        [NameInMap("AlarmMetadata")]
        [Validation(Required=false)]
        public string AlarmMetadata { get; set; }

        /// <summary>
        /// <para>The service category name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public string Categories { get; set; }

        /// <summary>
        /// <para>The commodity specifications.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public GetServiceResponseBodyCommodity Commodity { get; set; }
        public class GetServiceResponseBodyCommodity : TeaModel {
            /// <summary>
            /// <para>The billing method.</para>
            /// <para>Valid values:</para>
            /// <para><b>PREPAY</b> (default): subscription.</para>
            /// <para><b>POSTPAY</b>: pay-as-you-go.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmjj00****</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The Lingxiao configuration metadata.</para>
            /// </summary>
            [NameInMap("CssMetadata")]
            [Validation(Required=false)]
            public GetServiceResponseBodyCommodityCssMetadata CssMetadata { get; set; }
            public class GetServiceResponseBodyCommodityCssMetadata : TeaModel {
                /// <summary>
                /// <para>The billing item mappings.</para>
                /// </summary>
                [NameInMap("ComponentsMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityCssMetadataComponentsMappings> ComponentsMappings { get; set; }
                public class GetServiceResponseBodyCommodityCssMetadataComponentsMappings : TeaModel {
                    /// <summary>
                    /// <para>The mappings.</para>
                    /// </summary>
                    [NameInMap("Mappings")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Mappings { get; set; }

                    /// <summary>
                    /// <para>The template name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>单机版</para>
                    /// </summary>
                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

            }

            /// <summary>
            /// <para>The deployment page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Order: Order page
            /// Detail: Details page</para>
            /// </summary>
            [NameInMap("DeployPage")]
            [Validation(Required=false)]
            public string DeployPage { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Marketplace metadata.</para>
            /// </summary>
            [NameInMap("MarketplaceMetadata")]
            [Validation(Required=false)]
            public GetServiceResponseBodyCommodityMarketplaceMetadata MarketplaceMetadata { get; set; }
            public class GetServiceResponseBodyCommodityMarketplaceMetadata : TeaModel {
                /// <summary>
                /// <para>The mapping between commodity specifications and templates or packages.</para>
                /// </summary>
                [NameInMap("SpecificationMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings> SpecificationMappings { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings : TeaModel {
                    /// <summary>
                    /// <para>The specification code of the Alibaba Cloud Marketplace commodity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmjj00****</para>
                    /// </summary>
                    [NameInMap("SpecificationCode")]
                    [Validation(Required=false)]
                    public string SpecificationCode { get; set; }

                    /// <summary>
                    /// <para>The package name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Package 1</para>
                    /// </summary>
                    [NameInMap("SpecificationName")]
                    [Validation(Required=false)]
                    public string SpecificationName { get; set; }

                    /// <summary>
                    /// <para>The template name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Standalone edition</para>
                    /// </summary>
                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

            }

            /// <summary>
            /// <para>The order time.</para>
            /// </summary>
            [NameInMap("OrderTime")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> OrderTime { get; set; }

            /// <summary>
            /// <para>The SaasBoost configuration metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;Enabled&quot;:false
            ///     //Public access URL
            ///     &quot;PublicAccessUrl&quot;:&quot;<a href="https://example.com">https://example.com</a>&quot;
            /// }</para>
            /// </summary>
            [NameInMap("SaasBoostMetadata")]
            [Validation(Required=false)]
            public string SaasBoostMetadata { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Marketplace specification details.</para>
            /// </summary>
            [NameInMap("Specifications")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyCommoditySpecifications> Specifications { get; set; }
            public class GetServiceResponseBodyCommoditySpecifications : TeaModel {
                /// <summary>
                /// <para>The commodity code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmjj00****</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The specification name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>specifications1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The purchasable duration. Unit: week or year.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// <para>The type.</para>
            /// <para>Valid values:</para>
            /// <para>Marketplace: Alibaba Cloud Marketplace.</para>
            /// <para>Css: Lingxiao.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Marketplace</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The compliance package metadata.</para>
        /// </summary>
        [NameInMap("ComplianceMetadata")]
        [Validation(Required=false)]
        public GetServiceResponseBodyComplianceMetadata ComplianceMetadata { get; set; }
        public class GetServiceResponseBodyComplianceMetadata : TeaModel {
            /// <summary>
            /// <para>The list of compliance packages.</para>
            /// </summary>
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<string> CompliancePacks { get; set; }

        }

        /// <summary>
        /// <para>The deployment channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NoWhere: The service has no deployment channel.</para>
        /// </description></item>
        /// <item><description><para>Marketplace: The service is deployed from Alibaba Cloud Marketplace.</para>
        /// </description></item>
        /// <item><description><para>ComputeNest: The service is deployed from Compute Nest.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Marketplace</para>
        /// </summary>
        [NameInMap("DeployFrom")]
        [Validation(Required=false)]
        public string DeployFrom { get; set; }

        /// <summary>
        /// <para>The deployment configuration of the service. The configuration is stored as a JSON string. The data format of the string varies based on the deployment type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;TemplateUrl\&quot;: \&quot;<a href="http://tidbRosFile%5C%5C%22%7D">http://tidbRosFile\\&quot;}</a></para>
        /// </summary>
        [NameInMap("DeployMetadata")]
        [Validation(Required=false)]
        public string DeployMetadata { get; set; }

        /// <summary>
        /// <para>The deployment type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ros: The service is deployed using ROS.</para>
        /// </description></item>
        /// <item><description><para>terraform: The service is deployed using Terraform.</para>
        /// </description></item>
        /// <item><description><para>spi: The service is deployed by calling a Service Provider Interface (SPI).</para>
        /// </description></item>
        /// <item><description><para>operation: The service is an Alibaba Cloud Managed Services deployment.</para>
        /// </description></item>
        /// <item><description><para>container: The service is deployed using a container.</para>
        /// </description></item>
        /// <item><description><para>pkg: The service is a package service.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ros</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>The duration of the Alibaba Cloud Managed Services. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>259200</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The information about the roles that are created in the service template.</para>
        /// </summary>
        [NameInMap("InstanceRoleInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyInstanceRoleInfos> InstanceRoleInfos { get; set; }
        public class GetServiceResponseBodyInstanceRoleInfos : TeaModel {
            /// <summary>
            /// <para>The content of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\n  \&quot;Version\&quot;: \&quot;1\&quot;,\n  \&quot;Statement\&quot;: [\n    {\n      \&quot;Effect\&quot;: \&quot;Allow\&quot;,\n      \&quot;Action\&quot;: \&quot;<em>\&quot;,\n      \&quot;Principal\&quot;: \&quot;</em>\&quot;,\n      \&quot;Resource\&quot;: \&quot;*\&quot;\n    }\n  ]\n}</para>
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <para>The information about the RAM entity.</para>
            /// </summary>
            [NameInMap("Principals")]
            [Validation(Required=false)]
            public List<string> Principals { get; set; }

            /// <summary>
            /// <para>The role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram-for-dts</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Template 1</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable Alibaba Cloud Managed Services. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled.</para>
        /// </description></item>
        /// <item><description><para>false: disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <b>ServiceType</b> is set to <b>private</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSupportOperated")]
        [Validation(Required=false)]
        public bool? IsSupportOperated { get; set; }

        /// <summary>
        /// <para>The license metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PayType\&quot;:\&quot;CustomFixTime\&quot;,\&quot;DefaultLicenseDays\&quot;:7,\&quot;CustomMetadata\&quot;:[{\&quot;TemplateName\&quot;:\&quot; template1\&quot;,\&quot;SpecificationName\&quot;:\&quot;bandwith-0\&quot;,\&quot;CustomData\&quot;:\&quot;1\&quot;}]}</para>
        /// </summary>
        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        /// <summary>
        /// <para>The application log configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Logstores\&quot;:[]}</para>
        /// </summary>
        [NameInMap("LogMetadata")]
        [Validation(Required=false)]
        public string LogMetadata { get; set; }

        /// <summary>
        /// <para>The O\&amp;M configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PrometheusConfigMap\&quot;:{\&quot;New_Vpc_Ack_And_Jumpserver\&quot;:{}}}</para>
        /// </summary>
        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public string OperationMetadata { get; set; }

        /// <summary>
        /// <para>The permission type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Deployable: The service is deployable.</para>
        /// </description></item>
        /// <item><description><para>Accessible: The service is accessible.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Deployable</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>The policy names. A single policy name can be up to 128 characters in length. Separate multiple names with commas (,). Only policies related to Alibaba Cloud Managed Services are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policyName1, policyName2</para>
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

        /// <summary>
        /// <para>The time when the service was published.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-21T00:00:00Z</para>
        /// </summary>
        [NameInMap("PublishTime")]
        [Validation(Required=false)]
        public string PublishTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06BF8F22-02DC-4750-83DF-3FFC11C065EA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service documents.</para>
        /// </summary>
        [NameInMap("ServiceDocumentInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceDocumentInfos> ServiceDocumentInfos { get; set; }
        public class GetServiceResponseBodyServiceDocumentInfos : TeaModel {
            /// <summary>
            /// <para>The document URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://help.aliyun.com/zh/compute-nest/use-cases/deploy-an-sd-painting-service-instance?spm=a2c4g.11186623.0.i2">https://help.aliyun.com/zh/compute-nest/use-cases/deploy-an-sd-painting-service-instance?spm=a2c4g.11186623.0.i2</a></para>
            /// </summary>
            [NameInMap("DocumentUrl")]
            [Validation(Required=false)]
            public string DocumentUrl { get; set; }

            /// <summary>
            /// <para>The language of the service document. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>zh-CN: Chinese.</para>
            /// </description></item>
            /// <item><description><para>en-US: English.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("Locale")]
            [Validation(Required=false)]
            public string Locale { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>单机版</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-0e6fca6a51a544xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service information.</para>
        /// </summary>
        [NameInMap("ServiceInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceInfos> ServiceInfos { get; set; }
        public class GetServiceResponseBodyServiceInfos : TeaModel {
            /// <summary>
            /// <para>The service agreements.</para>
            /// </summary>
            [NameInMap("Agreements")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyServiceInfosAgreements> Agreements { get; set; }
            public class GetServiceResponseBodyServiceInfosAgreements : TeaModel {
                /// <summary>
                /// <para>The agreement name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>User agreement</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The agreement URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://url">https://url</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The URL of the service icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/service-image/c1c4a559-cc60-4af1-b976-98f356602462.png">https://example.com/service-image/c1c4a559-cc60-4af1-b976-98f356602462.png</a></para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The language of the service configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>zh-CN: Chinese.</para>
            /// </description></item>
            /// <item><description><para>en-US: English.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("Locale")]
            [Validation(Required=false)]
            public string Locale { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Database B</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The summary of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B is an open-source distributed relational database independently designed and developed by Company A.</para>
            /// </summary>
            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

            /// <summary>
            /// <para>The service software.</para>
            /// </summary>
            [NameInMap("Softwares")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyServiceInfosSoftwares> Softwares { get; set; }
            public class GetServiceResponseBodyServiceInfosSoftwares : TeaModel {
                /// <summary>
                /// <para>The software name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wordpress</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The software version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.0.1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The multilingual configurations of the service.</para>
        /// </summary>
        [NameInMap("ServiceLocaleConfigs")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceLocaleConfigs> ServiceLocaleConfigs { get; set; }
        public class GetServiceResponseBodyServiceLocaleConfigs : TeaModel {
            /// <summary>
            /// <para>The English value of the service information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service Name</para>
            /// </summary>
            [NameInMap("EnValue")]
            [Validation(Required=false)]
            public string EnValue { get; set; }

            /// <summary>
            /// <para>The raw data value of the service information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service Name</para>
            /// </summary>
            [NameInMap("OriginalValue")]
            [Validation(Required=false)]
            public string OriginalValue { get; set; }

            /// <summary>
            /// <para>The Chinese value of the service information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>服务名称</para>
            /// </summary>
            [NameInMap("ZhValue")]
            [Validation(Required=false)]
            public string ZhValue { get; set; }

        }

        /// <summary>
        /// <para>The URL of the product page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example1.com">http://example1.com</a></para>
        /// </summary>
        [NameInMap("ServiceProductUrl")]
        [Validation(Required=false)]
        public string ServiceProductUrl { get; set; }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>private: The service is deployed in the user\&quot;s account.</para>
        /// </description></item>
        /// <item><description><para>managed: The service is hosted in the service provider\&quot;s account.</para>
        /// </description></item>
        /// <item><description><para>operation: The service is an Alibaba Cloud Managed Service.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The share type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Public: The service is public. Formal and trial deployments are not restricted.</para>
        /// </description></item>
        /// <item><description><para>Restricted: The service is restricted. Formal and trial deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>OnlyFormalRestricted: Only formal deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>OnlyTrialRestricted: Only trial deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>Hidden: The service is hidden, is not visible, and you cannot request permissions for deployment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// <para>The status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Draft: The service is in the draft state.</para>
        /// </description></item>
        /// <item><description><para>Beta: The service is in a pre-release state. The service cannot be modified but can be shared with other users.</para>
        /// </description></item>
        /// <item><description><para>Submitted: The service is submitted for approval. The service cannot be modified.</para>
        /// </description></item>
        /// <item><description><para>Approved: The service is approved. The service cannot be modified but can be published.</para>
        /// </description></item>
        /// <item><description><para>Launching: The service is being published.</para>
        /// </description></item>
        /// <item><description><para>Online: The service is published.</para>
        /// </description></item>
        /// <item><description><para>Offline: The service is unpublished.</para>
        /// </description></item>
        /// <item><description><para>Creating: The service is being created.</para>
        /// </description></item>
        /// <item><description><para>CreateFailed: The service failed to be created.</para>
        /// </description></item>
        /// <item><description><para>Updating: The service is being updated.</para>
        /// </description></item>
        /// <item><description><para>UpdateFailed: The service failed to be updated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The description of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Compute Nest team</para>
        /// </summary>
        [NameInMap("SupplierDesc")]
        [Validation(Required=false)]
        public string SupplierDesc { get; set; }

        /// <summary>
        /// <para>The icon of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://service-info-public.oss-cn-hangzhou.aliyuncs.com/xxx/service-image/xxx.png">https://service-info-public.oss-cn-hangzhou.aliyuncs.com/xxx/service-image/xxx.png</a></para>
        /// </summary>
        [NameInMap("SupplierLogo")]
        [Validation(Required=false)]
        public string SupplierLogo { get; set; }

        /// <summary>
        /// <para>The name of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Company A</para>
        /// </summary>
        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>158927391332*****</para>
        /// </summary>
        [NameInMap("SupplierUid")]
        [Validation(Required=false)]
        public long? SupplierUid { get; set; }

        /// <summary>
        /// <para>The URL of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com">http://example.com</a></para>
        /// </summary>
        [NameInMap("SupplierUrl")]
        [Validation(Required=false)]
        public string SupplierUrl { get; set; }

        /// <summary>
        /// <para>The contact information of the service provider.</para>
        /// </summary>
        [NameInMap("SupportContacts")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodySupportContacts> SupportContacts { get; set; }
        public class GetServiceResponseBodySupportContacts : TeaModel {
            /// <summary>
            /// <para>The type of the contact information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Email</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The contact information.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:supplier@example.com">supplier@example.com</a></para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The service tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyTags> Tags { get; set; }
        public class GetServiceResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The tenant type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SingleTenant: The service is a single-tenant service.</para>
        /// </description></item>
        /// <item><description><para>MultiTenant: The service is a multitenancy service.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SingleTenant</para>
        /// </summary>
        [NameInMap("TenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

        /// <summary>
        /// <para>The trial duration in days. The maximum trial duration is 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TrialDuration")]
        [Validation(Required=false)]
        public long? TrialDuration { get; set; }

        /// <summary>
        /// <para>The trial type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Trial: The service supports trial.</para>
        /// </description></item>
        /// <item><description><para>NotTrial: The service does not support trial.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Trial</para>
        /// </summary>
        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

        /// <summary>
        /// <para>The service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The version name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
