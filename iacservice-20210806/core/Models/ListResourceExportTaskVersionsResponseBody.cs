// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListResourceExportTaskVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of export task versions.</para>
        /// </summary>
        [NameInMap("exportTasks")]
        [Validation(Required=false)]
        public List<ListResourceExportTaskVersionsResponseBodyExportTasks> ExportTasks { get; set; }
        public class ListResourceExportTaskVersionsResponseBodyExportTasks : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-11T02:18:50Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
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
            /// <para>4521</para>
            /// </summary>
            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ex-al1711jl6hd8u5crggeq6v</para>
            /// </summary>
            [NameInMap("exportTaskId")]
            [Validation(Required=false)]
            public string ExportTaskId { get; set; }

            /// <summary>
            /// <para>Saves the exported template as a module. If this parameter is not set, the template is automatically saved in the registry.</para>
            /// </summary>
            [NameInMap("exportToModule")]
            [Validation(Required=false)]
            public ListResourceExportTaskVersionsResponseBodyExportTasksExportToModule ExportToModule { get; set; }
            public class ListResourceExportTaskVersionsResponseBodyExportTasksExportToModule : TeaModel {
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
                /// <para>The path of the state file corresponding to the module.</para>
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
            /// <para>v3</para>
            /// </summary>
            [NameInMap("exportVersion")]
            [Validation(Required=false)]
            public string ExportVersion { get; set; }

            /// <summary>
            /// <para>The reason for the export failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reason</para>
            /// </summary>
            [NameInMap("failedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The list of inclusion rules used when exporting resources.</para>
            /// </summary>
            [NameInMap("includeRules")]
            [Validation(Required=false)]
            public List<ListResourceExportTaskVersionsResponseBodyExportTasksIncludeRules> IncludeRules { get; set; }
            public class ListResourceExportTaskVersionsResponseBodyExportTasksIncludeRules : TeaModel {
                /// <summary>
                /// <para>The name of the inclusion rule for resource export. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ResourceType: required. The resource type. Example: ALIYUN::VPC::VPC.</description></item>
                /// <item><description>RegionId: required. The region to which the resource belongs. Only one region is supported. Example: ap-southeast-1.</description></item>
                /// <item><description>\<ResourceType>:Id: the resource ID. Example: ALIYUN::VPC::VPC:Id.</description></item>
                /// <item><description>ResourceGroupId: the resource group ID. Example: rg-1234.</description></item>
                /// <item><description>ZoneId: the zone to which the resource belongs. Only one zone is supported. Example: ap-southeast-1h.</description></item>
                /// </list>
                /// <para>Multiple filter conditions are combined by using the AND operator. A resource is matched only if all filter conditions are met.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RegionId</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The values of the inclusion rules for resource export.</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The module configuration of the exported resources.</para>
            /// </summary>
            [NameInMap("modules")]
            [Validation(Required=false)]
            public List<ListResourceExportTaskVersionsResponseBodyExportTasksModules> Modules { get; set; }
            public class ListResourceExportTaskVersionsResponseBodyExportTasksModules : TeaModel {
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
                /// <para>v1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The name of the export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TaskName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version export status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Queue: queued</description></item>
            /// <item><description>Pending: preparing to run</description></item>
            /// <item><description>Success: succeeded</description></item>
            /// <item><description>Errored: failed</description></item>
            /// <item><description>Canceled: canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of variables. Parameters of the exported resources are set as variables.</para>
            /// </summary>
            [NameInMap("variables")]
            [Validation(Required=false)]
            public List<ListResourceExportTaskVersionsResponseBodyExportTasksVariables> Variables { get; set; }
            public class ListResourceExportTaskVersionsResponseBodyExportTasksVariables : TeaModel {
                /// <summary>
                /// <para>The list of Terraform resource properties corresponding to the resource type.</para>
                /// </summary>
                [NameInMap("properties")]
                [Validation(Required=false)]
                public List<string> Properties { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Vswitch</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of results per page. Default value: 20. Minimum value: 1. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>860FDEEE-1CA3-55F3-97F6-63FC40B7962D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
