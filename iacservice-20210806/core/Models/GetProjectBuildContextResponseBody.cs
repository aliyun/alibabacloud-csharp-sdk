// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetProjectBuildContextResponseBody : TeaModel {
        [NameInMap("ProjectBuild")]
        [Validation(Required=false)]
        public GetProjectBuildContextResponseBodyProjectBuild ProjectBuild { get; set; }
        public class GetProjectBuildContextResponseBodyProjectBuild : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1646719546155</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("failCnt")]
            [Validation(Required=false)]
            public long? FailCnt { get; set; }

            [NameInMap("jobList")]
            [Validation(Required=false)]
            public List<GetProjectBuildContextResponseBodyProjectBuildJobList> JobList { get; set; }
            public class GetProjectBuildContextResponseBodyProjectBuildJobList : TeaModel {
                [NameInMap("elapsedTime")]
                [Validation(Required=false)]
                public long? ElapsedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("isDeleted")]
                [Validation(Required=false)]
                public long? IsDeleted { get; set; }

                [NameInMap("isPassAssertCheck")]
                [Validation(Required=false)]
                public bool? IsPassAssertCheck { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-518855d9a058cfff262b993646d12</para>
                /// </summary>
                [NameInMap("jobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mod-3b6cb9fa4751a107afd6c2c3eb9</para>
                /// </summary>
                [NameInMap("moduleId")]
                [Validation(Required=false)]
                public string ModuleId { get; set; }

                [NameInMap("moduleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("moduleVersion")]
                [Validation(Required=false)]
                public string ModuleVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test7</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Pending</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>task-433aead756057ffe67aefed4aa75d</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("terraformProviderVersion")]
                [Validation(Required=false)]
                public string TerraformProviderVersion { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("jobTotalCnt")]
            [Validation(Required=false)]
            public long? JobTotalCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pb-4267dcfbf1b6d13c7d2386cba7</para>
            /// </summary>
            [NameInMap("projectBuildId")]
            [Validation(Required=false)]
            public string ProjectBuildId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-4267dcfbf1b6d1e0652bfbbe994</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("resourceCnt")]
            [Validation(Required=false)]
            public long? ResourceCnt { get; set; }

            [NameInMap("resourceList")]
            [Validation(Required=false)]
            public List<GetProjectBuildContextResponseBodyProjectBuildResourceList> ResourceList { get; set; }
            public class GetProjectBuildContextResponseBodyProjectBuildResourceList : TeaModel {
                [NameInMap("info")]
                [Validation(Required=false)]
                public Dictionary<string, string> Info { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("resourceCnt")]
                [Validation(Required=false)]
                public long? ResourceCnt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Module</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("resourceTypeCnt")]
            [Validation(Required=false)]
            public long? ResourceTypeCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("successCnt")]
            [Validation(Required=false)]
            public long? SuccessCnt { get; set; }

            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C54F3939-9112-5795-A5A7-5322E2FB2257</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
