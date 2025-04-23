// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>98610149-488B-5E48-B981-8D4CE1AF77CD</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<ListTasksResponseBodyTasks> Tasks { get; set; }
        public class ListTasksResponseBodyTasks : TeaModel {
            [NameInMap("autoApply")]
            [Validation(Required=false)]
            public bool? AutoApply { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-11T15:09:53Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-123asd</para>
            /// </summary>
            [NameInMap("currentJobId")]
            [Validation(Required=false)]
            public string CurrentJobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("currentJobStatus")]
            [Validation(Required=false)]
            public string CurrentJobStatus { get; set; }

            [NameInMap("deletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            [NameInMap("groupInfo")]
            [Validation(Required=false)]
            public ListTasksResponseBodyTasksGroupInfo GroupInfo { get; set; }
            public class ListTasksResponseBodyTasksGroupInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>g-4267dcfbf1b6d1e0652bfbbe995</para>
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
                /// <para>p-433aead7560571cf1b2bfbbe92b</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>mod-518855d9a058c331e9c60bc0ce</para>
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
            /// <para>abc</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListTasksResponseBodyTasksTags> Tags { get; set; }
            public class ListTasksResponseBodyTasksTags : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-1525e992f1b621b0ca51647876e</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
