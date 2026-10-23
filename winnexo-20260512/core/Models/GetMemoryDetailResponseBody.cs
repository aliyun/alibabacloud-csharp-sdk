// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetMemoryDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of groups for automatically collected memories. If no automatic memories exist, an empty array is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;user&quot;,&quot;items&quot;:[{&quot;id&quot;:&quot;user/example.md&quot;,&quot;title&quot;:&quot;Sample preference&quot;,&quot;content&quot;:&quot;Prefers concise answers&quot;,&quot;description&quot;:&quot;Preference summary from recent conversations&quot;}],&quot;gmtModified&quot;:1720000000}]</para>
        /// </summary>
        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<GetMemoryDetailResponseBodyGroups> Groups { get; set; }
        public class GetMemoryDetailResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>The last modification time of the group. The value is a UNIX timestamp in seconds. If no files exist, null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720000000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The list of automatic memory entries under this type. If no entries exist, an empty array is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;id&quot;:&quot;user/example.md&quot;,&quot;title&quot;:&quot;Sample preference&quot;,&quot;content&quot;:&quot;Prefers concise answers&quot;,&quot;description&quot;:&quot;Preference summary from recent conversations&quot;}]</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetMemoryDetailResponseBodyGroupsItems> Items { get; set; }
            public class GetMemoryDetailResponseBodyGroupsItems : TeaModel {
                /// <summary>
                /// <para>The body of the automatic memory, excluding the YAML frontmatter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prefers concise answers</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The additional description of the automatic memory. If no description is available, an empty string is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Preference summary from recent conversations</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The unique identifier of the automatic memory entry, which is a relative OSS path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user/example.md</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The title of the automatic memory, which is derived from the file metadata or file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample preference</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The type of the automatic memory. Valid values: user, feedback, reference, and project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The current user is not an active member of the group cg_12345</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The manually added memory from profile.md. It includes the full content, existence status, and modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;content&quot;:&quot;Sample manual memory&quot;,&quot;exists&quot;:true,&quot;gmtModified&quot;:1720000000}</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public GetMemoryDetailResponseBodyProfile Profile { get; set; }
        public class GetMemoryDetailResponseBodyProfile : TeaModel {
            /// <summary>
            /// <para>The full body of the manual memory. If the memory has never been saved, an empty string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample manual memory</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Indicates whether profile.md exists. If the memory has never been saved, false is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("exists")]
            [Validation(Required=false)]
            public bool? Exists { get; set; }

            /// <summary>
            /// <para>The last modification time of profile.md. The value is a UNIX timestamp in seconds. If the file does not exist or its metadata cannot be obtained, null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720000000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

        }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
