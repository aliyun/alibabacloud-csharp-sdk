// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert configurations of the service.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when you specify an alert policy for <b>PolicyNames</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;TemplateUrl&quot;: &quot;<a href="http://template.file.url">http://template.file.url</a>&quot;, &quot;ApplicationGroups&quot;: [ { &quot;Name&quot;: &quot;applicationGroup1&quot;, &quot;TemplateUrl&quot;: &quot;url1&quot; }, { &quot;Name&quot;: &quot;applicationGroup2&quot;, &quot;TemplateUrl&quot;: &quot;url2&quot; } ] }</para>
        /// </summary>
        [NameInMap("AlarmMetadata")]
        [Validation(Required=false)]
        public string AlarmMetadata { get; set; }

        /// <summary>
        /// <para>The categories of the Flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public string Categories { get; set; }

        /// <summary>
        /// <para>The information about the order placed in Alibaba Cloud Marketplace.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public GetServiceResponseBodyCommodity Commodity { get; set; }
        public class GetServiceResponseBodyCommodity : TeaModel {
            /// <summary>
            /// <para>The billing method of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PREPAY</b> (default): subscription.</description></item>
            /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code of the service in Alibaba Cloud Marketplace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmjj00****</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The configuration metadata related to Lingxiao.</para>
            /// </summary>
            [NameInMap("CssMetadata")]
            [Validation(Required=false)]
            public GetServiceResponseBodyCommodityCssMetadata CssMetadata { get; set; }
            public class GetServiceResponseBodyCommodityCssMetadata : TeaModel {
                /// <summary>
                /// <para>The mapping information about the billing items.</para>
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
                    /// <para>Template one.</para>
                    /// </summary>
                    [NameInMap("TemplateName")]
                    [Validation(Required=false)]
                    public string TemplateName { get; set; }

                }

            }

            /// <summary>
            /// <para>The deploy page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Order： Order page
            /// Detail： Detail page</para>
            /// </summary>
            [NameInMap("DeployPage")]
            [Validation(Required=false)]
            public string DeployPage { get; set; }

            /// <summary>
            /// <para>The metadata of Alibaba Cloud Marketplace.</para>
            /// </summary>
            [NameInMap("MarketplaceMetadata")]
            [Validation(Required=false)]
            public GetServiceResponseBodyCommodityMarketplaceMetadata MarketplaceMetadata { get; set; }
            public class GetServiceResponseBodyCommodityMarketplaceMetadata : TeaModel {
                /// <summary>
                /// <para>The mappings between the service specifications and the template or package.</para>
                /// </summary>
                [NameInMap("SpecificationMappings")]
                [Validation(Required=false)]
                public List<GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings> SpecificationMappings { get; set; }
                public class GetServiceResponseBodyCommodityMarketplaceMetadataSpecificationMappings : TeaModel {
                    /// <summary>
                    /// <para>The specification code of the service in Alibaba Cloud Marketplace.</para>
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
                    /// <para>Package one.</para>
                    /// </summary>
                    [NameInMap("SpecificationName")]
                    [Validation(Required=false)]
                    public string SpecificationName { get; set; }

                    /// <summary>
                    /// <para>The template name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Template one.</para>
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
            /// <para>The configuration metadata related to Saas Boost.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;Enabled&quot;:false    &quot;PublicAccessUrl&quot;:&quot;<a href="https://example.com">https://example.com</a>&quot;
            /// }</para>
            /// </summary>
            [NameInMap("SaasBoostMetadata")]
            [Validation(Required=false)]
            public string SaasBoostMetadata { get; set; }

            /// <summary>
            /// <para>The specification details of the service in Alibaba Cloud Marketplace.</para>
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
                /// <para>The subscription duration. Unit: week or year.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// <para>The service type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>marketplace: Alibaba Cloud Marketplace.</description></item>
            /// <item><description>Css: Lingxiao.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Marketplace</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Compliance check metadata.</para>
        /// </summary>
        [NameInMap("ComplianceMetadata")]
        [Validation(Required=false)]
        public GetServiceResponseBodyComplianceMetadata ComplianceMetadata { get; set; }
        public class GetServiceResponseBodyComplianceMetadata : TeaModel {
            /// <summary>
            /// <para>The compliance pack list.</para>
            /// </summary>
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<string> CompliancePacks { get; set; }

        }

        /// <summary>
        /// <para>Service deployment approach, Valid values：</para>
        /// <list type="bullet">
        /// <item><description>NoWhere</description></item>
        /// <item><description>Marketplace</description></item>
        /// <item><description>ComputeNest</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Marketplace</para>
        /// </summary>
        [NameInMap("DeployFrom")]
        [Validation(Required=false)]
        public string DeployFrom { get; set; }

        /// <summary>
        /// <para>The storage configurations of the service. The format in which the deployment information of a service is stored varies based on the deployment type of the service. In this case, the deployment information is stored in the JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;TemplateUrl\&quot;: \&quot;<a href="http://tidbRosFile%5C%5C%22%7D">http://tidbRosFile\\&quot;}</a></para>
        /// </summary>
        [NameInMap("DeployMetadata")]
        [Validation(Required=false)]
        public string DeployMetadata { get; set; }

        /// <summary>
        /// <para>The deployment type of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ros: The service is deployed by using Resource Orchestration Service (ROS).</description></item>
        /// <item><description>terraform: The service is deployed by using Terraform.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ros</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>The duration for which hosted O\&amp;M is implemented. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>259200</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>Information about the ram role created in the service template.</para>
        /// </summary>
        [NameInMap("InstanceRoleInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyInstanceRoleInfos> InstanceRoleInfos { get; set; }
        public class GetServiceResponseBodyInstanceRoleInfos : TeaModel {
            /// <summary>
            /// <para>The content of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\n  \&quot;Version\&quot;: \&quot;1\&quot;,\n  \&quot;Statement\&quot;: [\n    {\n      \&quot;Effect\&quot;: \&quot;Allow\&quot;,\n      \&quot;Action\&quot;: \&quot;<em>\&quot;,\n      \&quot;Principal\&quot;: \&quot;</em>\&quot;,\n      \&quot;Resource\&quot;: \&quot;*\&quot;\n    }\n  ]\n}</para>
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <para>The information of the RAM entity.</para>
            /// </summary>
            [NameInMap("Principals")]
            [Validation(Required=false)]
            public List<string> Principals { get; set; }

            /// <summary>
            /// <para>The ram role name.</para>
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
            /// <para>Template one.</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the hosted O\&amp;M feature is enabled for the service. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned if you set <b>ServiceType</b> to <b>private</b>.</para>
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
        /// <para>{\&quot;PayType\&quot;:\&quot;CustomFixTime\&quot;,\&quot;DefaultLicenseDays\&quot;:7,\&quot;CustomMetadata\&quot;:[{\&quot;TemplateName\&quot;:\&quot;ECS\&quot;,\&quot;SpecificationName\&quot;:\&quot;bandwith-0\&quot;,\&quot;CustomData\&quot;:\&quot;1\&quot;}]}</para>
        /// </summary>
        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        /// <summary>
        /// <para>The logging configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Logstores\&quot;:[]}</para>
        /// </summary>
        [NameInMap("LogMetadata")]
        [Validation(Required=false)]
        public string LogMetadata { get; set; }

        /// <summary>
        /// <para>The operation metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PrometheusConfigMap\&quot;:{\&quot;New_Vpc_Ack_And_Jumpserver\&quot;:{}}}</para>
        /// </summary>
        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public string OperationMetadata { get; set; }

        /// <summary>
        /// <para>The permissions on the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Deployable: Permissions to deploy the service.</description></item>
        /// <item><description>Accessible: Permissions to access the service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Deployable</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>The policy name. The name can be up to 128 characters in length. Separate multiple names with commas (,). Only hosted O\&amp;M policies are supported.</para>
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
        /// <para>Service document information.</para>
        /// </summary>
        [NameInMap("ServiceDocumentInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceDocumentInfos> ServiceDocumentInfos { get; set; }
        public class GetServiceResponseBodyServiceDocumentInfos : TeaModel {
            /// <summary>
            /// <para>The URL that is used to access the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://help.aliyun.com/zh/compute-nest/use-cases/deploy-an-sd-painting-service-instance?spm=a2c4g.11186623.0.i2">https://help.aliyun.com/zh/compute-nest/use-cases/deploy-an-sd-painting-service-instance?spm=a2c4g.11186623.0.i2</a></para>
            /// </summary>
            [NameInMap("DocumentUrl")]
            [Validation(Required=false)]
            public string DocumentUrl { get; set; }

            /// <summary>
            /// <para>The language that you use for the query. Valid values: zh-CN and en-US.</para>
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
            /// <para>Template one.</para>
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
        /// <para>The information about the service.</para>
        /// </summary>
        [NameInMap("ServiceInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceInfos> ServiceInfos { get; set; }
        public class GetServiceResponseBodyServiceInfos : TeaModel {
            /// <summary>
            /// <para>The agreement information about the service.</para>
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
            /// <para>The language of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>zh-CN: Chinese</description></item>
            /// <item><description>en-US: English</description></item>
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
            /// <para>Service document information.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The description of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Docker Community Edition (CE) is a free version of the Docker project, aimed at developers, enthusiasts, and individuals and organizations who want to use container technology.</para>
            /// </summary>
            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

            /// <summary>
            /// <para>The list of the software in the service.</para>
            /// </summary>
            [NameInMap("Softwares")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyServiceInfosSoftwares> Softwares { get; set; }
            public class GetServiceResponseBodyServiceInfosSoftwares : TeaModel {
                /// <summary>
                /// <para>The name of the Software.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wordpress</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The version of the software.</para>
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
        /// <para>The URL of the service page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example1.com">http://example1.com</a></para>
        /// </summary>
        [NameInMap("ServiceProductUrl")]
        [Validation(Required=false)]
        public string ServiceProductUrl { get; set; }

        /// <summary>
        /// <para>The type of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>private: The service is a private service and is deployed within the account of a customer.</description></item>
        /// <item><description>managed: The service is a fully managed service and is deployed within the account of a service provider.</description></item>
        /// <item><description>operation: The service is a hosted O&amp;M service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The permission type of the deployment URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Public: All users can go to the URL to create a service instance or a trial service instance.</description></item>
        /// <item><description>Restricted: Only users in the whitelist can go to the URL to create a service instance or a trial service instance.</description></item>
        /// <item><description>OnlyFormalRestricted: Only users in the whitelist can go to the URL to create a service instance.</description></item>
        /// <item><description>OnlyTrailRestricted: Only users in the whitelist can go to the URL to create a trial service instance.</description></item>
        /// <item><description>Hidden: Users not in the whitelist cannot see the service details page when they go to the URL and cannot request deployment permissions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// <para>The deploy status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Draft</description></item>
        /// <item><description>Beta</description></item>
        /// <item><description>Submitted</description></item>
        /// <item><description>Approved</description></item>
        /// <item><description>Launching</description></item>
        /// <item><description>Online</description></item>
        /// <item><description>Offline</description></item>
        /// <item><description>Creating</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The description of service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Computing Nest Community service</para>
        /// </summary>
        [NameInMap("SupplierDesc")]
        [Validation(Required=false)]
        public string SupplierDesc { get; set; }

        /// <summary>
        /// <para>The Logo of service provider.</para>
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
        /// <para>Alibaba Cloud</para>
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
        /// <para>Contact information of the service provider</para>
        /// </summary>
        [NameInMap("SupportContacts")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodySupportContacts> SupportContacts { get; set; }
        public class GetServiceResponseBodySupportContacts : TeaModel {
            /// <summary>
            /// <para>The type of contact information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Email</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The value of contact information.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:supplier@example.com">supplier@example.com</a></para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The tags.</para>
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
        /// <para>The type of the tenant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SingleTenant</description></item>
        /// <item><description>MultiTenant</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SingleTenant</para>
        /// </summary>
        [NameInMap("TenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

        /// <summary>
        /// <para>The trial duration. Unit: day. The maximum trial duration cannot exceed 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TrialDuration")]
        [Validation(Required=false)]
        public long? TrialDuration { get; set; }

        /// <summary>
        /// <para>The trial policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Trial: Trials are supported.</description></item>
        /// <item><description>NotTrial: Trials are not supported.</description></item>
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
