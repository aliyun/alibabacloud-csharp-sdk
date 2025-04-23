// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListModulesResponseBody : TeaModel {
        [NameInMap("modules")]
        [Validation(Required=false)]
        public List<ListModulesResponseBodyModules> Modules { get; set; }
        public class ListModulesResponseBodyModules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-30T02:14:16Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("deletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("groupInfo")]
            [Validation(Required=false)]
            public ListModulesResponseBodyModulesGroupInfo GroupInfo { get; set; }
            public class ListModulesResponseBodyModulesGroupInfo : TeaModel {
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("projectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("latestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            [NameInMap("meta")]
            [Validation(Required=false)]
            public Dictionary<string, object> Meta { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mod-518855d9a058cdbd3fd6951d59</para>
            /// </summary>
            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("sourceConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> SourceConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListModulesResponseBodyModulesTags> Tags { get; set; }
            public class ListModulesResponseBodyModulesTags : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

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
        /// <para>C617E03B-3DD2-5F0C-A6CF-3028B499A2D5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2790</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
