// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListSkillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of skill cards.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListSkillsResponseBodyItems> Items { get; set; }
        public class ListSkillsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The description of the to-do card type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The execution mode, such as CODE_AGENT or SYSTEM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("executeMode")]
            [Validation(Required=false)]
            public string ExecuteMode { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill is globally accessible.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("globalAccess")]
            [Validation(Required=false)]
            public bool? GlobalAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether unpublished draft modifications exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasDraftChanges")]
            [Validation(Required=false)]
            public bool? HasDraftChanges { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The actual skill code for execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("skillCode")]
            [Validation(Required=false)]
            public string SkillCode { get; set; }

            /// <summary>
            /// <para>The skill definition ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("skillHubDefinitionId")]
            [Validation(Required=false)]
            public long? SkillHubDefinitionId { get; set; }

            /// <summary>
            /// <para>The skill source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BUILTIN</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The task status. Running is returned upon submission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <para>The update timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("updatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// <para>The workflow definition version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("versionNumber")]
            [Validation(Required=false)]
            public string VersionNumber { get; set; }

        }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Minimum value: 1. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
