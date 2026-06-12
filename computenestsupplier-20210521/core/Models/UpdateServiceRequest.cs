// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceRequest : TeaModel {
        /// <summary>
        /// <para>The alert configurations for the service.</para>
        /// <remarks>
        /// <para>This configuration takes effect only after you configure an alert-related access policy for <b>PolicyNames</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;CmsTemplateId\&quot;:1162921,\&quot;TemplateUrl\&quot;:\&quot;<a href="https://service-info-private.oss-cn-hangzhou.aliyuncs.com/1760465342xxxxxx/template/c072ef50-6c03-4d9c-8f0e-d1c440xxxxxx.json%5C%5C%22%7D">https://service-info-private.oss-cn-hangzhou.aliyuncs.com/1760465342xxxxxx/template/c072ef50-6c03-4d9c-8f0e-d1c440xxxxxx.json\\&quot;}</a></para>
        /// </summary>
        [NameInMap("AlarmMetadata")]
        [Validation(Required=false)]
        public string AlarmMetadata { get; set; }

        /// <summary>
        /// <para>The approval type for service usage requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Manual: The request is manually approved.</para>
        /// </description></item>
        /// <item><description><para>AutoPass: The request is automatically approved.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public string ApprovalType { get; set; }

        /// <summary>
        /// <para>The parameters for building the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;ServiceTemplateId&quot;: &quot;st-xxxxx&quot;}</para>
        /// </summary>
        [NameInMap("BuildParameters")]
        [Validation(Required=false)]
        public string BuildParameters { get; set; }

        /// <summary>
        /// <para>A client token to ensure that the request is idempotent. You can use a client to generate the token. Make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>788E7CP0EN9D51P</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The commodity information.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public UpdateServiceRequestCommodity Commodity { get; set; }
        public class UpdateServiceRequestCommodity : TeaModel {
            /// <summary>
            /// <para>This parameter is not available.</para>
            /// </summary>
            [NameInMap("ComponentsMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityComponentsMappings> ComponentsMappings { get; set; }
            public class UpdateServiceRequestCommodityComponentsMappings : TeaModel {
                /// <summary>
                /// <para>This parameter is not available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This parameter is not publicly available.</para>
                /// </summary>
                [NameInMap("Mappings")]
                [Validation(Required=false)]
                public Dictionary<string, string> Mappings { get; set; }

                /// <summary>
                /// <para>This parameter is not available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This parameter is not publicly available.</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <para>The configuration information of the metering item. This parameter is used in the pay-as-you-go scenario of Alibaba Cloud Marketplace.</para>
            /// </summary>
            [NameInMap("MeteringEntityExtraInfos")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityMeteringEntityExtraInfos> MeteringEntityExtraInfos { get; set; }
            public class UpdateServiceRequestCommodityMeteringEntityExtraInfos : TeaModel {
                /// <summary>
                /// <para>The metering item ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmgj0006xxxx-Memory-1</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The metric name. This parameter is required when Type is set to ComputeNestBill or ComputeNestPrometheus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VirtualCpu/ecs.InstanceType</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The Prometheus statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>avg_over_time(sum(rate(container_cpu_usage_seconds_total{namespace=~&quot;ALIYUN::StackName&quot;}[2m]))[1h:10s])</para>
                /// </summary>
                [NameInMap("Promql")]
                [Validation(Required=false)]
                public string Promql { get; set; }

                /// <summary>
                /// <para>The type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Custom</b></para>
                /// </description></item>
                /// <item><description><para><b>ComputeNestBill</b></para>
                /// </description></item>
                /// <item><description><para><b>ComputeNestPrometheus</b></para>
                /// </description></item>
                /// <item><description><para><b>ComputeNestTime</b></para>
                /// </description></item>
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
            /// <para>The mapping between templates or packages and metering dimensions. This parameter is used in the pay-as-you-go scenario of Alibaba Cloud Marketplace.</para>
            /// </summary>
            [NameInMap("MeteringEntityMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommodityMeteringEntityMappings> MeteringEntityMappings { get; set; }
            public class UpdateServiceRequestCommodityMeteringEntityMappings : TeaModel {
                /// <summary>
                /// <para>The metering item ID.</para>
                /// </summary>
                [NameInMap("EntityIds")]
                [Validation(Required=false)]
                public List<string> EntityIds { get; set; }

                /// <summary>
                /// <para>The package name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>低配版</para>
                /// </summary>
                [NameInMap("SpecificationName")]
                [Validation(Required=false)]
                public string SpecificationName { get; set; }

                /// <summary>
                /// <para>The template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>模板1</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <para>The configuration of Software as a Service (SaaS) Boost.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("SaasBoostConfig")]
            [Validation(Required=false)]
            public string SaasBoostConfig { get; set; }

            /// <summary>
            /// <para>The mapping between commodity specifications and templates or packages. This parameter is used in the subscription scenario of Alibaba Cloud Marketplace.</para>
            /// </summary>
            [NameInMap("SpecificationMappings")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestCommoditySpecificationMappings> SpecificationMappings { get; set; }
            public class UpdateServiceRequestCommoditySpecificationMappings : TeaModel {
                /// <summary>
                /// <para>The specification code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yuncode5767800001</para>
                /// </summary>
                [NameInMap("SpecificationCode")]
                [Validation(Required=false)]
                public string SpecificationCode { get; set; }

                /// <summary>
                /// <para>The package name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Basic edition</para>
                /// </summary>
                [NameInMap("SpecificationName")]
                [Validation(Required=false)]
                public string SpecificationName { get; set; }

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

        }

        /// <summary>
        /// <para>The compliance check metadata.</para>
        /// </summary>
        [NameInMap("ComplianceMetadata")]
        [Validation(Required=false)]
        public UpdateServiceRequestComplianceMetadata ComplianceMetadata { get; set; }
        public class UpdateServiceRequestComplianceMetadata : TeaModel {
            /// <summary>
            /// <para>The selected compliance package.</para>
            /// </summary>
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<string> CompliancePacks { get; set; }

        }

        /// <summary>
        /// <para>The information about the service deployment configuration. The data format varies based on the deployment type. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EstimateTime\&quot;:null,\&quot;SupplierDeployMetadata\&quot;:{\&quot;DeployTimeout\&quot;:7200},\&quot;EnableVnc\&quot;:false}</para>
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
        /// <item><description><para>spi: The service is deployed by calling an SPI.</para>
        /// </description></item>
        /// <item><description><para>operation: The service is an O\&amp;M service.</para>
        /// </description></item>
        /// <item><description><para>container: The service is deployed using containers.</para>
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
        /// <para>Specifies whether to perform a dry run for the request. A dry run checks the permissions and the instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: sends the request but does not update the service.</para>
        /// </description></item>
        /// <item><description><para>false: sends the request. If the check is successful, the service is updated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The O\&amp;M duration. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>259200</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable O\&amp;M. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables O\&amp;M.</para>
        /// </description></item>
        /// <item><description><para>false: disables O\&amp;M.</para>
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
        /// <para>The application log configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Logstores&quot;: [
        ///     {
        ///     &quot;LogstoreName&quot;: &quot;access-log&quot;,
        ///   &quot;LogPath&quot;: &quot;/home/admin/app/logs&quot;, # Not required for containers. Configure in YAML
        ///   &quot;FilePattern&quot;: &quot;access.log*&quot; # Not required for containers. Configure in YAML
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("LogMetadata")]
        [Validation(Required=false)]
        public string LogMetadata { get; set; }

        /// <summary>
        /// <para>The O\&amp;M configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PrometheusConfigMap\&quot;:{\&quot;Custom_Image_Ecs\&quot;:{\&quot;EnablePrometheus\&quot;:false}}}</para>
        /// </summary>
        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public string OperationMetadata { get; set; }

        /// <summary>
        /// <para>The policy name. The name of a single policy can be up to 128 characters in length. If you specify multiple policies, separate them with commas (,). Only O\&amp;M-related policies are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policyName1, policyName2</para>
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable distribution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: Distribution is not enabled.</para>
        /// </description></item>
        /// <item><description><para>true: Distribution is enabled.</para>
        /// </description></item>
        /// </list>
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
            /// <para>The information about the service agreements.</para>
            /// </summary>
            [NameInMap("Agreements")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestServiceInfoAgreements> Agreements { get; set; }
            public class UpdateServiceRequestServiceInfoAgreements : TeaModel {
                /// <summary>
                /// <para>The name of the agreement document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The URL of the agreement.</para>
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
            /// <para>Database B</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The description of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B is an open-source distributed relational database independently designed and developed by Company A.</para>
            /// </summary>
            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

            /// <summary>
            /// <para>The information about the software used in the service.</para>
            /// </summary>
            [NameInMap("Softwares")]
            [Validation(Required=false)]
            public List<UpdateServiceRequestServiceInfoSoftwares> Softwares { get; set; }
            public class UpdateServiceRequestServiceInfoSoftwares : TeaModel {
                /// <summary>
                /// <para>The software name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The software version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.7</para>
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
        public List<UpdateServiceRequestServiceLocaleConfigs> ServiceLocaleConfigs { get; set; }
        public class UpdateServiceRequestServiceLocaleConfigs : TeaModel {
            /// <summary>
            /// <para>The English value of the business information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service Name</para>
            /// </summary>
            [NameInMap("EnValue")]
            [Validation(Required=false)]
            public string EnValue { get; set; }

            /// <summary>
            /// <para>The raw data value of the business information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service Name</para>
            /// </summary>
            [NameInMap("OriginalValue")]
            [Validation(Required=false)]
            public string OriginalValue { get; set; }

            /// <summary>
            /// <para>The Chinese value of the business information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>服务名称</para>
            /// </summary>
            [NameInMap("ZhValue")]
            [Validation(Required=false)]
            public string ZhValue { get; set; }

        }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>private: The service instance is deployed in the user account.</para>
        /// </description></item>
        /// <item><description><para>managed: The service instance is deployed in the service provider account.</para>
        /// </description></item>
        /// <item><description><para>operation: The service instance is an O\&amp;M instance.</para>
        /// </description></item>
        /// <item><description><para>poc: The service instance is a trial instance.</para>
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
        /// <para>The service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// <para>The sharing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Public: The service is public. Formal and trial deployments are not restricted.</para>
        /// </description></item>
        /// <item><description><para>Restricted: The service is restricted. Formal and trial deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>OnlyFormalRestricted: Only formal deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>OnlyTrailRestricted: Only trial deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>Hidden: The service is hidden. You cannot view the service or request deployment permissions.</para>
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
        /// <para>The tenant type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SingleTenant: The service is single-tenant.</para>
        /// </description></item>
        /// <item><description><para>MultiTenant: The service is multi-tenant.</para>
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
        /// <para>The trial duration. Unit: days. The maximum trial duration is 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TrialDuration")]
        [Validation(Required=false)]
        public int? TrialDuration { get; set; }

        /// <summary>
        /// <para>The update options.</para>
        /// </summary>
        [NameInMap("UpdateOption")]
        [Validation(Required=false)]
        public UpdateServiceRequestUpdateOption UpdateOption { get; set; }
        public class UpdateServiceRequestUpdateOption : TeaModel {
            /// <summary>
            /// <para>Specifies whether to update the deployment file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UpdateArtifact")]
            [Validation(Required=false)]
            public bool? UpdateArtifact { get; set; }

            /// <summary>
            /// <para>The update option. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CODE: code.</para>
            /// </description></item>
            /// <item><description><para>PARAMETERS: parameters.</para>
            /// </description></item>
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
        /// <para>The upgrade metadata.</para>
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
