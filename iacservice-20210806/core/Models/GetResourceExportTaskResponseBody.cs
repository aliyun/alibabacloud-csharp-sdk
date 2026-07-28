// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetResourceExportTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC49AA8C-0A19-5556-8929-E7447F18D529</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("task")]
        [Validation(Required=false)]
        public GetResourceExportTaskResponseBodyTask Task { get; set; }
        public class GetResourceExportTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-06-15T02:44:37Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The task description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The execution duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4533</para>
            /// </summary>
            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ex-al1111jlfh53i6mo4o94jj</para>
            /// </summary>
            [NameInMap("exportTaskId")]
            [Validation(Required=false)]
            public string ExportTaskId { get; set; }

            /// <summary>
            /// <para>Saves the exported template as a module. If this parameter is not set, the template is automatically saved in the registry.</para>
            /// </summary>
            [NameInMap("exportToModule")]
            [Validation(Required=false)]
            public GetResourceExportTaskResponseBodyTaskExportToModule ExportToModule { get; set; }
            public class GetResourceExportTaskResponseBodyTaskExportToModule : TeaModel {
                /// <summary>
                /// <para>The module type in which the exported template is saved. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: OSS</description></item>
                /// <item><description>Registry: Terraform Registry.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The path where the template content is saved.</para>
                /// <list type="bullet">
                /// <item><description><para>If Source is set to Registry, the format is: &quot;cloudregistry::iacservice//&quot;</para>
                /// </description></item>
                /// <item><description><para>If Source is set to OSS, the format is: &quot;oss::https://.oss-ap-southeast-1.aliyuncs.com/xxx.zip&quot;.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss::https://.oss-cn-hangzhou.aliyuncs.com/xxx.zip</para>
                /// </summary>
                [NameInMap("sourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                /// <summary>
                /// <para>The path of the state file that corresponds to the module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("statePath")]
                [Validation(Required=false)]
                public string StatePath { get; set; }

            }

            /// <summary>
            /// <para>The resource export version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("exportVersion")]
            [Validation(Required=false)]
            public string ExportVersion { get; set; }

            /// <summary>
            /// <para>The failure reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reason</para>
            /// </summary>
            [NameInMap("failedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The values of the include rules for resource export.</para>
            /// </summary>
            [NameInMap("includeRules")]
            [Validation(Required=false)]
            public List<GetResourceExportTaskResponseBodyTaskIncludeRules> IncludeRules { get; set; }
            public class GetResourceExportTaskResponseBodyTaskIncludeRules : TeaModel {
                /// <summary>
                /// <para>The name of the include rule for resource export. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ResourceType: required. The resource type. Example: ALIYUN::VPC::VPC.</description></item>
                /// <item><description>RegionId: required. The region to which the resource belongs. Only one region is supported. Example: ap-southeast-1.</description></item>
                /// <item><description>\<ResourceType>:Id: the resource ID. Example: ALIYUN::VPC::VPC:Id.</description></item>
                /// <item><description>ResourceGroupId: the resource group ID. Example: rg-1234.</description></item>
                /// <item><description>ZoneId: the zone to which the resource belongs. Only one zone is supported. Example: ap-southeast-1a.</description></item>
                /// </list>
                /// <para>By default, the relationship between multiple filter conditions is AND. A resource is considered matched only if all filter conditions are met.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RegionId</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The values of the include rules for resource export.</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The module configuration for the exported resources.</para>
            /// </summary>
            [NameInMap("modules")]
            [Validation(Required=false)]
            public List<GetResourceExportTaskResponseBodyTaskModules> Modules { get; set; }
            public class GetResourceExportTaskResponseBodyTaskModules : TeaModel {
                /// <summary>
                /// <para>The module type where the exported template is stored. Two formats are supported: CloudRegistry and OSS. If the ExportToModule parameter is specified, both formats are returned. Otherwise, only CloudRegistry is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The download URL of the module where the exported template is stored.</para>
                /// <list type="bullet">
                /// <item><description><para>If Source is set to CloudRegistry, the format is: &quot;cloudregistry::iacservice//&quot;</para>
                /// </description></item>
                /// <item><description><para>If Source is set to OSS, the format is: &quot;oss::https://.oss-ap-southeast-1.aliyuncs.com/xxx.zip&quot;.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss::https://.oss-cn-hangzhou.aliyuncs.com/xxx.zip</para>
                /// </summary>
                [NameInMap("sourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                /// <summary>
                /// <para>The version of the module where the exported template is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v3</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc_all</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>role</para>
            /// </summary>
            [NameInMap("ramRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Available: the task is available and no job is running.</description></item>
            /// <item><description>Running: a job is currently running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task output path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("taskOutputPath")]
            [Validation(Required=false)]
            public string TaskOutputPath { get; set; }

            /// <summary>
            /// <para>The Terraform context.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("terraformContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> TerraformContext { get; set; }

            /// <summary>
            /// <para>The Terraform provider version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.246.0</para>
            /// </summary>
            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

            /// <summary>
            /// <para>The Terraform version.</para>
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
            /// <item><description>Auto: triggered automatically when rules are modified or the trigger strategy is changed to Auto.</description></item>
            /// <item><description>Manual: triggered manually.</description></item>
            /// </list>
            /// <para>Default value: Manual.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

            /// <summary>
            /// <para>The list of variables. Parameters in the exported resources are set as variables.</para>
            /// </summary>
            [NameInMap("variables")]
            [Validation(Required=false)]
            public List<GetResourceExportTaskResponseBodyTaskVariables> Variables { get; set; }
            public class GetResourceExportTaskResponseBodyTaskVariables : TeaModel {
                /// <summary>
                /// <para>The list of properties of the Terraform resource that corresponds to the resource type.</para>
                /// </summary>
                [NameInMap("properties")]
                [Validation(Required=false)]
                public List<string> Properties { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
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

}
