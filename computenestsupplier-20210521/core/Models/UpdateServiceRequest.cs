// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceRequest : TeaModel {
        /// <summary>
        /// <para>Is need to update the artifacts</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;CmsTemplateId\&quot;:1162921,\&quot;TemplateUrl\&quot;:\&quot;<a href="https://service-info-private.oss-cn-hangzhou.aliyuncs.com/1760465342xxxxxx/template/c072ef50-6c03-4d9c-8f0e-d1c440xxxxxx.json%5C%5C%22%7D">https://service-info-private.oss-cn-hangzhou.aliyuncs.com/1760465342xxxxxx/template/c072ef50-6c03-4d9c-8f0e-d1c440xxxxxx.json\\&quot;}</a></para>
        /// </summary>
        [NameInMap("AlarmMetadata")]
        [Validation(Required=false)]
        public string AlarmMetadata { get; set; }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>private: The service is a private service and is deployed within the account of a customer.</description></item>
        /// <item><description>managed: The service is a fully managed service and is deployed within the account of a service provider.</description></item>
        /// <item><description>operation: The service is a hosted O\&amp;M service.</description></item>
        /// <item><description>poc: The service is a trial service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public string ApprovalType { get; set; }

        /// <summary>
        /// <para>The options for update the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>788E7CP0EN9D51P</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is not publicly accessible.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public UpdateServiceRequestCommodity Commodity { get; set; }
        public class UpdateServiceRequestCommodity : TeaModel {
            /// <summary>
            /// <para>The ID of the entity.</para>
            /// </summary>
            [NameInMap("ComponentsMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityComponentsMappings> ComponentsMappings { get; set; }
            public class UpdateServiceRequestCommodityComponentsMappings : TeaModel {
                /// <summary>
                /// <para>The language of the service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>zh-CN: Chinese</description></item>
                /// <item><description>en-US: English</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Mappings")]
                [Validation(Required=false)]
                public Dictionary<string, string> Mappings { get; set; }

                /// <summary>
                /// <para>{ &quot;Logstores&quot;: [ { &quot;LogstoreName&quot;: &quot;access-log&quot;, &quot;LogPath&quot;: &quot;/home/admin/app/logs&quot;, # This parameter is not required for containers. Configure the parameter in the YAML file. &quot;FilePattern&quot;: &quot;access.log\*&quot; # This parameter is not required for containers. Configure the parameter in the YAML file. } ] }</para>
                /// 
                /// <b>Example:</b>
                /// <para>此参数不对外开放</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <para>This parameter is not publicly accessible.</para>
            /// </summary>
            [NameInMap("MeteringEntityExtraInfos")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
            public class UpdateServiceRequestCommodityMeteringEntityExtraInfos : TeaModel {
                /// <summary>
                /// <para>The description of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmgj0006xxxx-Memory-1</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>Metering Item Configuration Information (Cloud Marketplace - Pay-As-You-Go Use)</para>
                /// 
                /// <b>Example:</b>
                /// <para>VirtualCpu/ecs.InstanceType</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The service details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>avg_over_time(sum(rate(container_cpu_usage_seconds_total{namespace=~&quot;ALIYUN::StackName&quot;}[2m]))[1h:10s])</para>
                /// </summary>
                [NameInMap("Promql")]
                [Validation(Required=false)]
                public string Promql { get; set; }

                /// <summary>
                /// <para>Product Specifications and Template/specification mapping Relationships (Cloud Marketplace - Pay-As-You-Go Use)</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The template name.</para>
            /// </summary>
            [NameInMap("MeteringEntityMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityMeteringEntityMappings> MeteringEntityMappings { get; set; }
            public class UpdateServiceRequestCommodityMeteringEntityMappings : TeaModel {
                /// <summary>
                /// <para>计量项ID</para>
                /// </summary>
                [NameInMap("EntityIds")]
                [Validation(Required=false)]
                public List<string> EntityIds { get; set; }

                /// <summary>
                /// <para>套餐名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>This parameter is not publicly accessible.</para>
                /// </summary>
                [NameInMap("SpecificationName")]
                [Validation(Required=false)]
                public string SpecificationName { get; set; }

                /// <summary>
                /// <para>模板名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>The service ID.</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <para>SaaS Boost配置信息</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("SaasBoostConfig")]
            [Validation(Required=false)]
            public string SaasBoostConfig { get; set; }

            /// <summary>
            /// <para>avg_over_time(sum(rate(container_cpu_usage_seconds_total{namespace=~&quot;ALIYUN::StackName&quot;}[2m]))[1h:10s])</para>
            /// </summary>
            [NameInMap("SpecificationMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommoditySpecificationMappings> SpecificationMappings { get; set; }
            public class UpdateServiceRequestCommoditySpecificationMappings : TeaModel {
                /// <summary>
                /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yuncode5767800001</para>
                /// </summary>
                [NameInMap("SpecificationCode")]
                [Validation(Required=false)]
                public string SpecificationCode { get; set; }

                /// <summary>
                /// <para>套餐名称</para>
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
                /// <para>模板名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product Specifications and Template/specification mapping Relationships (Cloud Marketplace - Subscription/Permanent Use)</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

        }

        [NameInMap("ComplianceMetadata")]
        [Validation(Required=false)]
        public UpdateServiceRequestComplianceMetadata ComplianceMetadata { get; set; }
        public class UpdateServiceRequestComplianceMetadata : TeaModel {
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<string> CompliancePacks { get; set; }

        }

        /// <summary>
        /// <para>The policy name. The name can be up to 128 characters in length. Separate multiple names with commas (,). Only hosted O\&amp;M policies are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EstimateTime\&quot;:null,\&quot;SupplierDeployMetadata\&quot;:{\&quot;DeployTimeout\&quot;:7200},\&quot;EnableVnc\&quot;:false}</para>
        /// </summary>
        [NameInMap("DeployMetadata")]
        [Validation(Required=false)]
        public string DeployMetadata { get; set; }

        /// <summary>
        /// <para>WB01286039</para>
        /// 
        /// <b>Example:</b>
        /// <para>ros</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The deployment type of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ros: The service is deployed by using Resource Orchestration Service (ROS).</description></item>
        /// <item><description>terraform: The service is deployed by using Terraform.</description></item>
        /// <item><description>spi: The service is deployed by calling a service provider interface (SPI).</description></item>
        /// <item><description>operation: The service is deployed by using a hosted O\&amp;M service.</description></item>
        /// <item><description>container: The service is deployed by using a container.</description></item>
        /// <item><description>pkg: The service is deployed by using a package.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>259200</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The version name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSupportOperated")]
        [Validation(Required=false)]
        public bool? IsSupportOperated { get; set; }

        /// <summary>
        /// <para>The duration for which hosted O\&amp;M is implemented. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Metering Item Configuration Information (Cloud Marketplace - Pay-As-You-Go Use)</para>
        /// </summary>
        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        /// <summary>
        /// <para>This parameter is not publicly accessible.</para>
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
        /// <para>{\&quot;RetentionDays\&quot;:3}</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PrometheusConfigMap\&quot;:{\&quot;Custom_Image_Ecs\&quot;:{\&quot;EnablePrometheus\&quot;:false}}}</para>
        /// </summary>
        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public string OperationMetadata { get; set; }

        /// <summary>
        /// <para>The package name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policyName1, policyName2</para>
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Resellable")]
        [Validation(Required=false)]
        public bool? Resellable { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceInfo")]
        [Validation(Required=false)]
        public List<UpdateServiceRequestServiceInfo> ServiceInfo { get; set; }
        public class UpdateServiceRequestServiceInfo : TeaModel {
            [NameInMap("Agreements")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestServiceInfoAgreements> Agreements { get; set; }
            public class UpdateServiceRequestServiceInfoAgreements : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("Locale")]
            [Validation(Required=false)]
            public string Locale { get; set; }

            [NameInMap("LongDescriptionUrl")]
            [Validation(Required=false)]
            public string LongDescriptionUrl { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

            [NameInMap("Softwares")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestServiceInfoSoftwares> Softwares { get; set; }
            public class UpdateServiceRequestServiceInfoSoftwares : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        [NameInMap("TenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

        [NameInMap("TrialDuration")]
        [Validation(Required=false)]
        public int? TrialDuration { get; set; }

        [NameInMap("UpdateOption")]
        [Validation(Required=false)]
        public UpdateServiceRequestUpdateOption UpdateOption { get; set; }
        public class UpdateServiceRequestUpdateOption : TeaModel {
            [NameInMap("UpdateArtifact")]
            [Validation(Required=false)]
            public bool? UpdateArtifact { get; set; }

            [NameInMap("UpdateFrom")]
            [Validation(Required=false)]
            public string UpdateFrom { get; set; }

        }

        [NameInMap("UpgradeMetadata")]
        [Validation(Required=false)]
        public string UpgradeMetadata { get; set; }

        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
