// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>A response field retained for backward compatibility. This field is not used for pagination. Do not rely on this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A response field retained for backward compatibility. This field is not used for pagination. Do not rely on this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of projects on the current page.</para>
        /// </summary>
        [NameInMap("ProjectList")]
        [Validation(Required=false)]
        public List<ListProjectsResponseBodyProjectList> ProjectList { get; set; }
        public class ListProjectsResponseBodyProjectList : TeaModel {
            /// <summary>
            /// <para>The permissions of the current caller in the project. For example, Manage indicates management permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manage</para>
            /// </summary>
            [NameInMap("Auth")]
            [Validation(Required=false)]
            public string Auth { get; set; }

            /// <summary>
            /// <para>The URL of the cover image.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/cover.png">https://example.com/cover.png</a></para>
            /// </summary>
            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in UTC and follows the ISO 8601 standard, ending with Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-07T02:21:36Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The username of the user who created the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_183320****</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>The description of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product demo project</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pd_061716****</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The name of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product Demo</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws_zna577pdximv***</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
