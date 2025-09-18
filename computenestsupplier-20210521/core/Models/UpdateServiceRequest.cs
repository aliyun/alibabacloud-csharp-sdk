// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceRequest : TeaModel {
        /// <summary>
        /// <para>The alert configurations of the service.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when you specify an alert policy for <b>PolicyNames</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;CmsTemplateId\&quot;:1162921,\&quot;TemplateUrl\&quot;:\&quot;<a href="https://service-info-private.oss-cn-hangzhou.aliyuncs.com/1760465342xxxxxx/template/c072ef50-6c03-4d9c-8f0e-d1c440xxxxxx.json%5C%5C%22%7D">https://service-info-private.oss-cn-hangzhou.aliyuncs.com/1760465342xxxxxx/template/c072ef50-6c03-4d9c-8f0e-d1c440xxxxxx.json\\&quot;}</a></para>
        /// </summary>
        [NameInMap("AlarmMetadata")]
        [Validation(Required=false)]
        public string AlarmMetadata { get; set; }

        /// <summary>
        /// <para>The approval type of the service usage application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Manual: The application is manually approved.</description></item>
        /// <item><description>AutoPass: The application is automatically approved.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public string ApprovalType { get; set; }

        /// <summary>
        /// <para>The Parameters to build service parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;ServiceTemplateId&quot;: &quot;st-xxxxx&quot;}</para>
        /// </summary>
        [NameInMap("BuildParameters")]
        [Validation(Required=false)]
        public string BuildParameters { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>788E7CP0EN9D51P</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The commodity details.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public UpdateServiceRequestCommodity Commodity { get; set; }
        public class UpdateServiceRequestCommodity : TeaModel {
            /// <summary>
            /// <para>This parameter is not available to the public.</para>
            /// </summary>
            [NameInMap("ComponentsMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityComponentsMappings> ComponentsMappings { get; set; }
            public class UpdateServiceRequestCommodityComponentsMappings : TeaModel {
                /// <summary>
                /// <para>This parameter is not available to the public.</para>
                /// </summary>
                [NameInMap("Mappings")]
                [Validation(Required=false)]
                public Dictionary<string, string> Mappings { get; set; }

                /// <summary>
                /// <para>This parameter is not available to the public.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This parameter is not available to the public.</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <para>Metering entity extra information.</para>
            /// </summary>
            [NameInMap("MeteringEntityExtraInfos")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
            public class UpdateServiceRequestCommodityMeteringEntityExtraInfos : TeaModel {
                /// <summary>
                /// <para>Metering entity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmgj0006xxxx-Memory-1</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>Metric name, required when type is ComputeNestBill or ComputeNestPrometheus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VirtualCpu/ecs.InstanceType</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>Promql statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>avg_over_time(sum(rate(container_cpu_usage_seconds_total{namespace=~&quot;ALIYUN::StackName&quot;}[2m]))[1h:10s])</para>
                /// </summary>
                [NameInMap("Promql")]
                [Validation(Required=false)]
                public string Promql { get; set; }

                /// <summary>
                /// <para>Type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Custom</description></item>
                /// <item><description>ComputeNestBill</description></item>
                /// <item><description>ComputeNestPrometheus</description></item>
                /// <item><description>ComputeNestTime</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Binding relationship between templates/specifications and metering dimensions (marketplace - PayAsYouGo)</para>
            /// </summary>
            [NameInMap("MeteringEntityMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityMeteringEntityMappings> MeteringEntityMappings { get; set; }
            public class UpdateServiceRequestCommodityMeteringEntityMappings : TeaModel {
                /// <summary>
                /// <para>Metering entity IDs.</para>
                /// </summary>
                [NameInMap("EntityIds")]
                [Validation(Required=false)]
                public List<string> EntityIds { get; set; }

                /// <summary>
                /// <para>The specification name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This parameter is not publicly accessible.</para>
                /// </summary>
                [NameInMap("SpecificationName")]
                [Validation(Required=false)]
                public string SpecificationName { get; set; }

                /// <summary>
                /// <para>The template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The service ID.</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <para>SaaS Boost configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("SaasBoostConfig")]
            [Validation(Required=false)]
            public string SaasBoostConfig { get; set; }

            /// <summary>
            /// <para>Product specifications and template/package mappings (Used in marketplace - subscription scenario)</para>
            /// </summary>
            [NameInMap("SpecificationMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommoditySpecificationMappings> SpecificationMappings { get; set; }
            public class UpdateServiceRequestCommoditySpecificationMappings : TeaModel {
                /// <summary>
                /// <para>Specification code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yuncode5767800001</para>
                /// </summary>
                [NameInMap("SpecificationCode")]
                [Validation(Required=false)]
                public string SpecificationCode { get; set; }

                /// <summary>
                /// <para>The name of the package specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Type, value：</para>
                /// <list type="bullet">
                /// <item><description><b>Custom</b></description></item>
                /// <item><description><b>ComputeNestBill</b></description></item>
                /// <item><description><b>ComputeNestPrometheus</b></description></item>
                /// <item><description><b>ComputeNestTime</b></description></item>
                /// </list>
                /// </summary>
                [NameInMap("SpecificationName")]
                [Validation(Required=false)]
                public string SpecificationName { get; set; }

                /// <summary>
                /// <para>The template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product Specifications and Template/specification mapping Relationships (Cloud Marketplace - Subscription/Permanent Use)</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

        }

        /// <summary>
        /// <para>Compliance check metadata.</para>
        /// </summary>
        [NameInMap("ComplianceMetadata")]
        [Validation(Required=false)]
        public UpdateServiceRequestComplianceMetadata ComplianceMetadata { get; set; }
        public class UpdateServiceRequestComplianceMetadata : TeaModel {
            /// <summary>
            /// <para>The compliance pack.</para>
            /// </summary>
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<string> CompliancePacks { get; set; }

        }

        /// <summary>
        /// <para>The deployment configurations of the service. The format in which the deployment information of a service is stored varies based on the deployment type of the service. In this case, the deployment information is stored in the JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EstimateTime\&quot;:null,\&quot;SupplierDeployMetadata\&quot;:{\&quot;DeployTimeout\&quot;:7200},\&quot;EnableVnc\&quot;:false}</para>
        /// </summary>
        [NameInMap("DeployMetadata")]
        [Validation(Required=false)]
        public string DeployMetadata { get; set; }

        /// <summary>
        /// <para>The deployment type of the service. Valid values:</para>
        /// <para>ros: The service is deployed by using Resource Orchestration Service (ROS).
        /// terraform: The service is deployed by using Terraform.
        /// ack: The service is deployed by using Container Service for Kubernetes (ACK).
        /// spi: The service is deployed by calling a service provider interface (SPI).
        /// operation: The service is deployed by using a hosted O&amp;M service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ros</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run for the request to check information such as the permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run for the request, but does not update a service.</description></item>
        /// <item><description>false: performs a dry run for the request, and update a service if the request passes the dry run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

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
        /// <para>Specifies whether to enable the hosted O\&amp;M feature for the service. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if you set <b>ServiceType</b> to <b>private</b>.</para>
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
        /// <para>Metering Item Configuration Information (Cloud Marketplace - Pay-As-You-Go Use)</para>
        /// </summary>
        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        /// <summary>
        /// <para>The logging configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specifies whether to support distribution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// </summary>
        [NameInMap("LogMetadata")]
        [Validation(Required=false)]
        public string LogMetadata { get; set; }

        /// <summary>
        /// <para>The hosted O\&amp;M configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PrometheusConfigMap\&quot;:{\&quot;Custom_Image_Ecs\&quot;:{\&quot;EnablePrometheus\&quot;:false}}}</para>
        /// </summary>
        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public string OperationMetadata { get; set; }

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
        /// <para>Region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Whether resell is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Resellable")]
        [Validation(Required=false)]
        public bool? Resellable { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-1dda29c3eca648xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service details.</para>
        /// </summary>
        [NameInMap("ServiceInfo")]
        [Validation(Required=false)]
        public List<UpdateServiceRequestServiceInfo> ServiceInfo { get; set; }
        public class UpdateServiceRequestServiceInfo : TeaModel {
            /// <summary>
            /// <para>Protocol document information about the service.</para>
            /// </summary>
            [NameInMap("Agreements")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestServiceInfoAgreements> Agreements { get; set; }
            public class UpdateServiceRequestServiceInfoAgreements : TeaModel {
                /// <summary>
                /// <para>Protocol name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Protocol url.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://aliyun.com/xxxxxxxx.html">https://aliyun.com/xxxxxxxx.html</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The URL of the service icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://img.tidb.oss.url">http://img.tidb.oss.url</a></para>
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
            /// <para>The URL of the detailed description of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://description.tidb.oss.url">http://description.tidb.oss.url</a></para>
            /// </summary>
            [NameInMap("LongDescriptionUrl")]
            [Validation(Required=false)]
            public string LongDescriptionUrl { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric Name, filled in when Type is ComputeNestBill or ComputeNestPrometheus</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The description of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The URL of the detailed description of the service.</para>
            /// </summary>
            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

            /// <summary>
            /// <para>The list of the software in the service.</para>
            /// </summary>
            [NameInMap("Softwares")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestServiceInfoSoftwares> Softwares { get; set; }
            public class UpdateServiceRequestServiceInfoSoftwares : TeaModel {
                /// <summary>
                /// <para>The name of the software.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The version of the software.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("ServiceLocaleConfigs")]
        [Validation(Required=false)]
        public List<UpdateServiceRequestServiceLocaleConfigs> ServiceLocaleConfigs { get; set; }
        public class UpdateServiceRequestServiceLocaleConfigs : TeaModel {
            [NameInMap("EnValue")]
            [Validation(Required=false)]
            public string EnValue { get; set; }

            [NameInMap("OriginalValue")]
            [Validation(Required=false)]
            public string OriginalValue { get; set; }

            [NameInMap("ZhValue")]
            [Validation(Required=false)]
            public string ZhValue { get; set; }

        }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>private: The service is a private service and is deployed within the account of a customer.</description></item>
        /// <item><description>managed: The service is a fully managed service and is deployed within the account of a service provider.</description></item>
        /// <item><description>operation: The service is a hosted O\&amp;M service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

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
        public int? TrialDuration { get; set; }

        /// <summary>
        /// <para>The update option.</para>
        /// </summary>
        [NameInMap("UpdateOption")]
        [Validation(Required=false)]
        public UpdateServiceRequestUpdateOption UpdateOption { get; set; }
        public class UpdateServiceRequestUpdateOption : TeaModel {
            /// <summary>
            /// <para>Whether to update artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UpdateArtifact")]
            [Validation(Required=false)]
            public bool? UpdateArtifact { get; set; }

            /// <summary>
            /// <para>Update from. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CODE</description></item>
            /// <item><description>PARAMETERS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PARAMETERS</para>
            /// </summary>
            [NameInMap("UpdateFrom")]
            [Validation(Required=false)]
            public string UpdateFrom { get; set; }

        }

        /// <summary>
        /// <para>The metadata about the upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Description\&quot;:\&quot;xxx\&quot;,\&quot;SupportRollback\&quot;:true,\&quot;SupportUpgradeFromVersions\&quot;:[],\&quot;UpgradeComponents\&quot;:[\&quot;Configuration\&quot;]}</para>
        /// </summary>
        [NameInMap("UpgradeMetadata")]
        [Validation(Required=false)]
        public string UpgradeMetadata { get; set; }

        /// <summary>
        /// <para>The version name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Draft</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
