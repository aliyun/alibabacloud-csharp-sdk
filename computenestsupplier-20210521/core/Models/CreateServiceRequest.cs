// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateServiceRequest : TeaModel {
        /// <summary>
        /// <para>The alert configurations of the service.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when you specify an alert policy for <b>PolicyNames</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;TemplateUrl&quot;: &quot;<a href="http://template.file.url">http://template.file.url</a>&quot;,
        ///   // 应用分组级别告警元数据
        ///   &quot;ApplicationGroups&quot;: [
        ///     {
        ///       &quot;Name&quot;: &quot;applicationGroup1&quot;,
        ///       &quot;TemplateUrl&quot;: &quot;url1&quot;
        ///     },
        ///     {
        ///       &quot;Name&quot;: &quot;applicationGroup2&quot;,
        ///       &quot;TemplateUrl&quot;: &quot;url2&quot;
        ///     }
        ///   ]
        /// }</para>
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
        /// <para>The parameters for building the service</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;ServiceTemplateId&quot;: &quot;st-xxxxx&quot;}</para>
        /// </summary>
        [NameInMap("BuildParameters")]
        [Validation(Required=false)]
        public string BuildParameters { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ComplianceMetadata")]
        [Validation(Required=false)]
        public CreateServiceRequestComplianceMetadata ComplianceMetadata { get; set; }
        public class CreateServiceRequestComplianceMetadata : TeaModel {
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<string> CompliancePacks { get; set; }

        }

        /// <summary>
        /// <para>The storage configurations of the service. The format in which the deployment information of a service is stored varies based on the deployment type of the service. In this case, the deployment information is stored in the JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;TemplateConfigs\&quot;:[{\&quot;Name\&quot;:\&quot;模板1\&quot;,\&quot;Url\&quot;:\&quot;oss://computenest-test/template&quot; 
        ///             + &quot;.json?RegionId=cn-beijing\&quot;,\&quot;PredefinedParameters\&quot;:[{\&quot;Name\&quot;:\&quot;低配版\&quot;,&quot; 
        ///             + &quot;\&quot;Parameters\&quot;:{\&quot;InstanceType\&quot;:\&quot;ecs.g5.large\&quot;,\&quot;DataDiskSize\&quot;:40}},{\&quot;Name\&quot;:\&quot;高配版\&quot;,&quot; 
        ///             + &quot;\&quot;Parameters\&quot;:{\&quot;InstanceType\&quot;:\&quot;ecs.g5.large\&quot;,\&quot;DataDiskSize\&quot;:200}}]}]}</para>
        /// </summary>
        [NameInMap("DeployMetadata")]
        [Validation(Required=false)]
        public string DeployMetadata { get; set; }

        /// <summary>
        /// <para>The deployment type of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ros: The service is deployed by using Resource Orchestration Service (ROS).</description></item>
        /// <item><description>terraform: The service is deployed by using Terraform.</description></item>
        /// <item><description>ack: The service is deployed by using Container Service for Kubernetes (ACK).</description></item>
        /// <item><description>spi: The service is deployed by calling a service provider interface (SPI).</description></item>
        /// <item><description>operation: The service is deployed by using a hosted O\&amp;M service.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>The duration for which hosted O\&amp;M is implemented. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <para>{\&quot;RetentionDays\&quot;:3}</para>
        /// </summary>
        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        /// <summary>
        /// <para>The logging configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Logstores&quot;: [ { &quot;LogstoreName&quot;: &quot;access-log&quot;, &quot;LogPath&quot;: &quot;/home/admin/app/logs&quot;, # This parameter is not required for containers. Configure the parameter in the YAML file. &quot;FilePattern&quot;: &quot;access.log\*&quot; # This parameter is not required for containers. Configure the parameter in the YAML file. } ] }</para>
        /// </summary>
        [NameInMap("LogMetadata")]
        [Validation(Required=false)]
        public string LogMetadata { get; set; }

        /// <summary>
        /// <para>The hosted O\&amp;M configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PrometheusConfigMap\&quot;:{\&quot;New_Vpc_Ack_And_Jumpserver\&quot;:{}}}</para>
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
        /// <para>Whether resell is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Resellable")]
        [Validation(Required=false)]
        public bool? Resellable { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek25refu7r3opq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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
        /// <para>The service details.</para>
        /// </summary>
        [NameInMap("ServiceInfo")]
        [Validation(Required=false)]
        public List<CreateServiceRequestServiceInfo> ServiceInfo { get; set; }
        public class CreateServiceRequestServiceInfo : TeaModel {
            /// <summary>
            /// <para>Protocol document information about the service.</para>
            /// </summary>
            [NameInMap("Agreements")]
            [Validation(Required=false)]
            public List<CreateServiceRequestServiceInfoAgreements> Agreements { get; set; }
            public class CreateServiceRequestServiceInfoAgreements : TeaModel {
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
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TiDB Database</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The description of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TiDB是A公司自主设计、研发的开源分布式关系型数据库。</para>
            /// </summary>
            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

            [NameInMap("Softwares")]
            [Validation(Required=false)]
            public List<CreateServiceRequestServiceInfoSoftwares> Softwares { get; set; }
            public class CreateServiceRequestServiceInfoSoftwares : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

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
        /// <para>The source service ID for resell。</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-70a3b15bb62643xxxxxx</para>
        /// </summary>
        [NameInMap("SourceServiceId")]
        [Validation(Required=false)]
        public string SourceServiceId { get; set; }

        /// <summary>
        /// <para>The source service version for resell。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SourceServiceVersion")]
        [Validation(Required=false)]
        public string SourceServiceVersion { get; set; }

        /// <summary>
        /// <para>The custom tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServiceRequestTag> Tag { get; set; }
        public class CreateServiceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Usage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Web</para>
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
