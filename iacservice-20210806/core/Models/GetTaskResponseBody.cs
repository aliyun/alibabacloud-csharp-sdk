// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C24C498A-09CF-54D3-8972-8DC074CF8614</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("task")]
        [Validation(Required=false)]
        public GetTaskResponseBodyTask Task { get; set; }
        public class GetTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>Indicates whether the task is automatically executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoApply")]
            [Validation(Required=false)]
            public bool? AutoApply { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic deletion is enabled. When enabled, resources are automatically destroyed after the task is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("autoDestroy")]
            [Validation(Required=false)]
            public bool? AutoDestroy { get; set; }

            /// <summary>
            /// <para>The time when the task was created, in UTC in the ISO 8601 format of YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-06-15T02:44:37Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The job ID of the current task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-absdf</para>
            /// </summary>
            [NameInMap("currentJobId")]
            [Validation(Required=false)]
            public string CurrentJobId { get; set; }

            /// <summary>
            /// <para>The current job status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Planned</para>
            /// </summary>
            [NameInMap("currentJobStatus")]
            [Validation(Required=false)]
            public string CurrentJobStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("deletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

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
            /// <para>The group information.</para>
            /// </summary>
            [NameInMap("groupInfo")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskGroupInfo GroupInfo { get; set; }
            public class GetTaskResponseBodyTaskGroupInfo : TeaModel {
                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>g-59d8d22e78792ffe3d3eb6154d727</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>p-433aead756057fff47ecbfd94d76</para>
                /// </summary>
                [NameInMap("projectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to use a state file. Default value: false. This parameter applies to templates that originate from resource export. Only one task can use this parameter at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("initModuleState")]
            [Validation(Required=false)]
            public bool? InitModuleState { get; set; }

            /// <summary>
            /// <para>The latest version number of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v3</para>
            /// </summary>
            [NameInMap("latestModuleVersion")]
            [Validation(Required=false)]
            public string LatestModuleVersion { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mod-4267dcfbf1b6d14625614ddbe15</para>
            /// </summary>
            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>moduleName</para>
            /// </summary>
            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <para>The template version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TaskName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of resource protection strategies.</para>
            /// </summary>
            [NameInMap("protectionStrategy")]
            [Validation(Required=false)]
            public List<string> ProtectionStrategy { get; set; }

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
            /// <para>Specifies whether to skip enumeration value validation. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("skipPropertyValidation")]
            [Validation(Required=false)]
            public bool? SkipPropertyValidation { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip region validation. Valid values: true and false.</para>
            /// </summary>
            [NameInMap("skipRegionValidation")]
            [Validation(Required=false)]
            public bool? SkipRegionValidation { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Available: the task is available and no job is running.</description></item>
            /// <item><description>Running: the task is running and a job is in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of task tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetTaskResponseBodyTaskTags> Tags { get; set; }
            public class GetTaskResponseBodyTaskTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The task backend configuration. After this parameter is configured, runtime log information is saved to the specified OSS bucket.</para>
            /// </summary>
            [NameInMap("taskBackend")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskTaskBackend TaskBackend { get; set; }
            public class GetTaskResponseBodyTaskTaskBackend : TeaModel {
                /// <summary>
                /// <para>The endpoint information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ss-cn-beijing.aliyuncs.com</para>
                /// </summary>
                [NameInMap("bucketEndpoint")]
                [Validation(Required=false)]
                public string BucketEndpoint { get; set; }

                /// <summary>
                /// <para>The bucket name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iac-runtime-test</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The object path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/log</para>
                /// </summary>
                [NameInMap("objectPath")]
                [Validation(Required=false)]
                public string ObjectPath { get; set; }

            }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-433aead756057154bda7f1c2e98</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

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
            /// <para>The Terraform version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5.7</para>
            /// </summary>
            [NameInMap("terraformVersion")]
            [Validation(Required=false)]
            public string TerraformVersion { get; set; }

            /// <summary>
            /// <para>The job trigger method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: manually triggered (default).</description></item>
            /// <item><description>NewVersion: triggered when a new template version is published.</description></item>
            /// <item><description>ParameterSetUpdated: triggered when the parameter set content changes or the parameter set attach relationship changes.</description></item>
            /// <item><description>Auto: automatically triggered when the task properties change, such as task creation, execution version change, or job trigger policy change (when changed from another value to Auto).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

        }

    }

}
