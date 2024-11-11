// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceShrinkRequest : TeaModel {
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
        public string CommodityShrink { get; set; }

        [NameInMap("ComplianceMetadata")]
        [Validation(Required=false)]
        public string ComplianceMetadataShrink { get; set; }

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
        public List<UpdateServiceShrinkRequestServiceInfo> ServiceInfo { get; set; }
        public class UpdateServiceShrinkRequestServiceInfo : TeaModel {
            [NameInMap("Agreements")]
            [Validation(Required=false)]
            public List<UpdateServiceShrinkRequestServiceInfoAgreements> Agreements { get; set; }
            public class UpdateServiceShrinkRequestServiceInfoAgreements : TeaModel {
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
            public List<UpdateServiceShrinkRequestServiceInfoSoftwares> Softwares { get; set; }
            public class UpdateServiceShrinkRequestServiceInfoSoftwares : TeaModel {
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
        public string UpdateOptionShrink { get; set; }

        [NameInMap("UpgradeMetadata")]
        [Validation(Required=false)]
        public string UpgradeMetadata { get; set; }

        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
