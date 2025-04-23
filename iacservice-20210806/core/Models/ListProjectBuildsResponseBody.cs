// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListProjectBuildsResponseBody : TeaModel {
        [NameInMap("ProjectBuilds")]
        [Validation(Required=false)]
        public List<ListProjectBuildsResponseBodyProjectBuilds> ProjectBuilds { get; set; }
        public class ListProjectBuildsResponseBodyProjectBuilds : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-26T02:10:48Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>apply</para>
            /// </summary>
            [NameInMap("projectBuildAction")]
            [Validation(Required=false)]
            public string ProjectBuildAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pb-433aead75605717728b6a27615f</para>
            /// </summary>
            [NameInMap("projectBuildId")]
            [Validation(Required=false)]
            public string ProjectBuildId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1661221432088</para>
            /// </summary>
            [NameInMap("projectBuildIndex")]
            [Validation(Required=false)]
            public long? ProjectBuildIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-14e80de4866bf7ffed0bab6154d737</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1661221432088</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>89154E16-FB0A-573D-8AF5-CF3F2FE28913</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
