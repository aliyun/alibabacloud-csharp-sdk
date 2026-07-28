// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateResourceExportTaskRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token. Format: [0-9a-zA-Z-]{1,64}. We recommend that you use a UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the resource export task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Saves the exported template as a module. If this parameter is not specified, the template is automatically saved in the Registry.</para>
        /// </summary>
        [NameInMap("exportToModule")]
        [Validation(Required=false)]
        public CreateResourceExportTaskRequestExportToModule ExportToModule { get; set; }
        public class CreateResourceExportTaskRequestExportToModule : TeaModel {
            /// <summary>
            /// <para>The module type in which the exported template is saved. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS: OSS.</description></item>
            /// <item><description>Registry: Terraform Registry.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Registry</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The path for saving the template content. Set this parameter when source is set to OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss::<a href="https://iac-daily.oss-ap-southeast-1.aliyuncs.com/iacservice/vpc.zip">https://iac-daily.oss-ap-southeast-1.aliyuncs.com/iacservice/vpc.zip</a></para>
            /// </summary>
            [NameInMap("sourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }

            /// <summary>
            /// <para>The path for saving the template state file. Set this parameter when source is set to OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss::<a href="https://iac-daily.oss-ap-southeast-1.aliyuncs.com/default/terraform.tfstate">https://iac-daily.oss-ap-southeast-1.aliyuncs.com/default/terraform.tfstate</a></para>
            /// </summary>
            [NameInMap("statePath")]
            [Validation(Required=false)]
            public string StatePath { get; set; }

        }

        /// <summary>
        /// <para>The list of inclusion rules used when exporting resources.</para>
        /// </summary>
        [NameInMap("includeRules")]
        [Validation(Required=false)]
        public List<CreateResourceExportTaskRequestIncludeRules> IncludeRules { get; set; }
        public class CreateResourceExportTaskRequestIncludeRules : TeaModel {
            /// <summary>
            /// <para>The name of the inclusion rule used when exporting resources. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ResourceType: required. The resource type. Call <b>ListResourceTypes</b> to view the list of supported resources. Example: ALIYUN::VPC::VPC.</description></item>
            /// <item><description>RegionId: required. The region to which the resource belongs. Only one region is supported. Example: cn-chengdu.</description></item>
            /// <item><description>\<ResourceType>:Id: the resource ID. Example: ALIYUN::VPC::VPC:Id.</description></item>
            /// <item><description>ResourceGroupId: the resource group ID. Example: rg-1234.</description></item>
            /// <item><description>ZoneId: the zone to which the resource belongs. Only one zone is supported. Example: cn-hangzhou-h.</description></item>
            /// </list>
            /// <para>By default, multiple filter conditions are evaluated using the AND operator. A resource is considered a match only when all filter conditions are met.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegionId</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The list of values for the inclusion rule used when exporting resources.</para>
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The name of the resource export task. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 3 to 63 characters in length.</description></item>
        /// <item><description>The name can contain letters, digits, Chinese characters, hyphens (-), underscores (_), and periods (.). The name cannot start or end with a hyphen, underscore, or period.</description></item>
        /// <item><description>The name must be unique among resource export tasks within the current account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The RAM role (1 to 128 characters). The system assumes this role to execute the template when a new job is triggered. This parameter is required when the job trigger method is not manual.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role-name</para>
        /// </summary>
        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>The Terraform provider version. Call <b>ListTerraformProviderVersions</b> to view the list of supported versions. Default value: the latest version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.247.0</para>
        /// </summary>
        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

        /// <summary>
        /// <para>The Terraform version. Call <b>ListAvailableTerraformVersions</b> to view the list of supported versions. Default value: 1.5.7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.5.7</para>
        /// </summary>
        [NameInMap("terraformVersion")]
        [Validation(Required=false)]
        public string TerraformVersion { get; set; }

        /// <summary>
        /// <para>The trigger strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Auto: triggered when rules are modified or the trigger strategy is changed to Auto.</description></item>
        /// <item><description>Manual: manually triggered.</description></item>
        /// </list>
        /// <para>Default value: Manual.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("triggerStrategy")]
        [Validation(Required=false)]
        public string TriggerStrategy { get; set; }

        /// <summary>
        /// <para>The list of variables. Exported resource parameters are set as variables.</para>
        /// </summary>
        [NameInMap("variables")]
        [Validation(Required=false)]
        public List<CreateResourceExportTaskRequestVariables> Variables { get; set; }
        public class CreateResourceExportTaskRequestVariables : TeaModel {
            /// <summary>
            /// <para>The list of properties of the Terraform resource that corresponds to the resource type.</para>
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public List<string> Properties { get; set; }

            /// <summary>
            /// <para>The resource type. Call <b>ListResourceTypes</b> to view the list of supported resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::VPC::VSwitch</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
