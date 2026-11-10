// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListResourceExportTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of export tasks.</para>
        /// </summary>
        [NameInMap("exportTasks")]
        [Validation(Required=false)]
        public List<ListResourceExportTasksResponseBodyExportTasks> ExportTasks { get; set; }
        public class ListResourceExportTasksResponseBodyExportTasks : TeaModel {
            /// <summary>
            /// <para>The creation time. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-20T02:10:06Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the export task.</para>
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
            /// <para>4243</para>
            /// </summary>
            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <para>The export status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Queue: queued</description></item>
            /// <item><description>Pending: pending</description></item>
            /// <item><description>Success: succeeded</description></item>
            /// <item><description>Errored: failed</description></item>
            /// <item><description>Canceled: canceled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("exportStatus")]
            [Validation(Required=false)]
            public string ExportStatus { get; set; }

            /// <summary>
            /// <para>The ID of the resource export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ex-kw1a1ol8c0pngjav17q8eri</para>
            /// </summary>
            [NameInMap("exportTaskId")]
            [Validation(Required=false)]
            public string ExportTaskId { get; set; }

            /// <summary>
            /// <para>Saves the exported template as a module. If this parameter is not specified, the template is automatically saved in the registry.</para>
            /// </summary>
            [NameInMap("exportToModule")]
            [Validation(Required=false)]
            public ListResourceExportTasksResponseBodyExportTasksExportToModule ExportToModule { get; set; }
            public class ListResourceExportTasksResponseBodyExportTasksExportToModule : TeaModel {
                /// <summary>
                /// <para>The module type where the exported template is saved. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: OSS</description></item>
                /// <item><description>Registry: Terraform Registry</description></item>
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
                /// <item><description>When Source is Registry, the format is: &quot;cloudregistry::iacservice//&quot;.</description></item>
                /// <item><description>When Source is OSS, the format is: &quot;oss::https://.oss-cn-hangzhou.aliyuncs.com/xxx.zip&quot;.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss::https://.oss-cn-hangzhou.aliyuncs.com/xxx.zip</para>
                /// </summary>
                [NameInMap("sourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                /// <summary>
                /// <para>The path where the state file of the template is saved.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("statePath")]
                [Validation(Required=false)]
                public string StatePath { get; set; }

            }

            /// <summary>
            /// <para>The export version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("exportVersion")]
            [Validation(Required=false)]
            public string ExportVersion { get; set; }

            /// <summary>
            /// <para>The values of the inclusion rules for resource export.</para>
            /// </summary>
            [NameInMap("includeRules")]
            [Validation(Required=false)]
            public List<ListResourceExportTasksResponseBodyExportTasksIncludeRules> IncludeRules { get; set; }
            public class ListResourceExportTasksResponseBodyExportTasksIncludeRules : TeaModel {
                /// <summary>
                /// <para>The name of the inclusion rule for resource export. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ResourceType: required. The resource type. Example: ALIYUN::VPC::VPC.</description></item>
                /// <item><description>RegionId: required. The region to which the resource belongs. Only one region is supported. Example: cn-chengdu.</description></item>
                /// <item><description>\<ResourceType>:Id: the resource ID. Example: ALIYUN::VPC::VPC:Id.</description></item>
                /// <item><description>ResourceGroupId: the resource group ID. Example: rg-1234.</description></item>
                /// <item><description>ZoneId: the zone to which the resource belongs. Only one zone is supported. Example: cn-hangzhou-h.</description></item>
                /// </list>
                /// <para>By default, multiple filter conditions use the AND logical operator. A resource matches the filter conditions only when it meets all the conditions.</para>
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
            /// <para>The module configurations for the exported resources.</para>
            /// </summary>
            [NameInMap("modules")]
            [Validation(Required=false)]
            public List<ListResourceExportTasksResponseBodyExportTasksModules> Modules { get; set; }
            public class ListResourceExportTasksResponseBodyExportTasksModules : TeaModel {
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
                /// <item><description>When Source is CloudRegistry, the format is: &quot;cloudregistry::iacservice/<exportTaskId>/<Provider Name>&quot;.</description></item>
                /// <item><description>When Source is OSS, the format is: &quot;oss::https://<BucketName>.oss-cn-hangzhou.aliyuncs.com/xxx.zip&quot;.</description></item>
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
            /// <para>The name of the export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TaskName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Available: available</description></item>
            /// <item><description>Running: running</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of variables. The parameters of the exported resources are set as variables.</para>
            /// </summary>
            [NameInMap("variables")]
            [Validation(Required=false)]
            public List<ListResourceExportTasksResponseBodyExportTasksVariables> Variables { get; set; }
            public class ListResourceExportTasksResponseBodyExportTasksVariables : TeaModel {
                /// <summary>
                /// <para>The list of properties for the Terraform resource that corresponds to the resource type.</para>
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

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of results to return per page. Default value: 20. Minimum value: 1. Maximum value: 100.</para>
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
        /// <para>65287CB9-AC46-5FE7-B785-0106C159DA42</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
