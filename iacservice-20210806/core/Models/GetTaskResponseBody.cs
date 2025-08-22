// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C24C498A-09CF-54D3-8972-8DC074CF8614</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("task")]
        [Validation(Required=false)]
        public GetTaskResponseBodyTask Task { get; set; }
        public class GetTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoApply")]
            [Validation(Required=false)]
            public bool? AutoApply { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("autoDestroy")]
            [Validation(Required=false)]
            public bool? AutoDestroy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-15T02:44:37Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-absdf</para>
            /// </summary>
            [NameInMap("currentJobId")]
            [Validation(Required=false)]
            public string CurrentJobId { get; set; }

            [NameInMap("currentJobStatus")]
            [Validation(Required=false)]
            public string CurrentJobStatus { get; set; }

            [NameInMap("deletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("groupInfo")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskGroupInfo GroupInfo { get; set; }
            public class GetTaskResponseBodyTaskGroupInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>g-59d8d22e78792ffe3d3eb6154d727</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>p-433aead756057fff47ecbfd94d76</para>
                /// </summary>
                [NameInMap("projectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            [NameInMap("initModuleState")]
            [Validation(Required=false)]
            public bool? InitModuleState { get; set; }

            [NameInMap("latestModuleVersion")]
            [Validation(Required=false)]
            public string LatestModuleVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mod-4267dcfbf1b6d14625614ddbe15</para>
            /// </summary>
            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("protectionStrategy")]
            [Validation(Required=false)]
            public List<string> ProtectionStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ramRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            [NameInMap("skipPropertyValidation")]
            [Validation(Required=false)]
            public bool? SkipPropertyValidation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetTaskResponseBodyTaskTags> Tags { get; set; }
            public class GetTaskResponseBodyTaskTags : TeaModel {
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            [NameInMap("taskBackend")]
            [Validation(Required=false)]
            public GetTaskResponseBodyTaskTaskBackend TaskBackend { get; set; }
            public class GetTaskResponseBodyTaskTaskBackend : TeaModel {
                [NameInMap("bucketEndpoint")]
                [Validation(Required=false)]
                public string BucketEndpoint { get; set; }

                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("objectPath")]
                [Validation(Required=false)]
                public string ObjectPath { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-433aead756057154bda7f1c2e98</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("taskOutputPath")]
            [Validation(Required=false)]
            public string TaskOutputPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.2.6</para>
            /// </summary>
            [NameInMap("terraformVersion")]
            [Validation(Required=false)]
            public string TerraformVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

        }

    }

}
