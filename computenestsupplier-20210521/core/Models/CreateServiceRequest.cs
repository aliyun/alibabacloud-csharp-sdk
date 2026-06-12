// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateServiceRequest : TeaModel {
        /// <summary>
        /// <para>The alert configurations for the service.</para>
        /// <remarks>
        /// <para>This configuration takes effect only after an alert-related access policy is configured in \<c>PolicyNames\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;TemplateUrl&quot;: &quot;<a href="http://template.file.url">http://template.file.url</a>&quot;,
        ///   // Application group level alarm metadata
        ///   &quot;ApplicationGroups&quot;: [
        ///     {
        ///       &quot;Name&quot;: &quot;applicationGroup1&quot;,
        ///       &quot;TemplateUrl&quot;: &quot;url1&quot;
        ///     },
        ///     {
        ///       &quot;Name&quot;: &quot;applicationGroup2&quot;,
        ///       &quot;TemplateUrl&quot;: &quot;url2&quot;
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("AlarmMetadata")]
        [Validation(Required=false)]
        public string AlarmMetadata { get; set; }

        /// <summary>
        /// <para>The approval type for service usage requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Manual: The request requires manual approval.</para>
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
        /// <para>A client token used to ensure the idempotence of the request. Generate a unique value for this parameter from your client. \<c>ClientToken\\</c> supports only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The compliance check metadata.</para>
        /// </summary>
        [NameInMap("ComplianceMetadata")]
        [Validation(Required=false)]
        public CreateServiceRequestComplianceMetadata ComplianceMetadata { get; set; }
        public class CreateServiceRequestComplianceMetadata : TeaModel {
            /// <summary>
            /// <para>The selected compliance packages.</para>
            /// </summary>
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<string> CompliancePacks { get; set; }

        }

        /// <summary>
        /// <para>The deployment configuration of the service. The information stored varies by deployment type. Different deployment types have different data formats. The data is stored in a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TemplateConfigs&quot;:[{&quot;Name&quot;:&quot;Template 1&quot;,&quot;Url&quot;:&quot;oss://computenest-test/template.json?RegionId=cn-beijing&quot;,&quot;PredefinedParameters&quot;:[{&quot;Name&quot;:&quot;Basic&quot;,&quot;Parameters&quot;:{&quot;InstanceType&quot;:&quot;ecs.g5.large&quot;,&quot;DataDiskSize&quot;:40}},{&quot;Name&quot;:&quot;Advanced&quot;,&quot;Parameters&quot;:{&quot;InstanceType&quot;:&quot;ecs.g5.large&quot;,&quot;DataDiskSize&quot;:200}}]}]}</para>
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
        /// <item><description><para>ack: The service is deployed using ACK.</para>
        /// </description></item>
        /// <item><description><para>spi: The service is deployed by invoking an SPI.</para>
        /// </description></item>
        /// <item><description><para>operation: The service is an O\&amp;M service.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ros</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run to check the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The O\&amp;M duration. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable O\&amp;M. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when \<c>ServiceType\\</c> is set to \<c>private\\</c>.</para>
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
        /// <para>{\&quot;PrometheusConfigMap\&quot;:{\&quot;New_Vpc_Ack_And_Jumpserver\&quot;:{}}}</para>
        /// </summary>
        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public string OperationMetadata { get; set; }

        /// <summary>
        /// <para>The policy name. The name of a single policy can be up to 128 characters in length. Separate multiple names with commas (,). Only policies related to O\&amp;M parameters are supported.</para>
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
        /// <para>Specifies whether the service can be distributed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: The service cannot be distributed.</para>
        /// </description></item>
        /// <item><description><para>true: The service can be distributed.</para>
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
        /// <para>The resource group ID.</para>
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
            /// <para>The information about the service agreements.</para>
            /// </summary>
            [NameInMap("Agreements")]
            [Validation(Required=false)]
            public List<CreateServiceRequestServiceInfoAgreements> Agreements { get; set; }
            public class CreateServiceRequestServiceInfoAgreements : TeaModel {
                /// <summary>
                /// <para>The name of the agreement.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("Locale")]
            [Validation(Required=false)]
            public string Locale { get; set; }

            /// <summary>
            /// <para>The detailed description of the service.</para>
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
            /// <para>A brief description of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TiDB is an open-source distributed relational database designed and developed by Company A.</para>
            /// </summary>
            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

            /// <summary>
            /// <para>The information about the software used in the service.</para>
            /// </summary>
            [NameInMap("Softwares")]
            [Validation(Required=false)]
            public List<CreateServiceRequestServiceInfoSoftwares> Softwares { get; set; }
            public class CreateServiceRequestServiceInfoSoftwares : TeaModel {
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
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>private: The service instance is deployed in the user\&quot;s account.</para>
        /// </description></item>
        /// <item><description><para>managed: The service instance is managed in the service provider\&quot;s account.</para>
        /// </description></item>
        /// <item><description><para>operation: An O\&amp;M service instance.</para>
        /// </description></item>
        /// <item><description><para>poc: A trial service instance.</para>
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
        /// <para>The sharing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Public: The service is public. Full and trial deployments are not restricted.</para>
        /// </description></item>
        /// <item><description><para>Restricted: The service is restricted. Full and trial deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>OnlyFormalRestricted: Only full deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>OnlyTrailRestricted: Only trial deployments are restricted.</para>
        /// </description></item>
        /// <item><description><para>Hidden: The service is hidden. It is not visible and you cannot request deployment permissions.</para>
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
        /// <para>The ID of the source service for distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-70a3b15bb62643xxxxxx</para>
        /// </summary>
        [NameInMap("SourceServiceId")]
        [Validation(Required=false)]
        public string SourceServiceId { get; set; }

        /// <summary>
        /// <para>The version of the source service for distribution.</para>
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
        /// <para>The tenant type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SingleTenant: Single-tenant.</para>
        /// </description></item>
        /// <item><description><para>MultiTenant: Multitenant.</para>
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
        public long? TrialDuration { get; set; }

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
