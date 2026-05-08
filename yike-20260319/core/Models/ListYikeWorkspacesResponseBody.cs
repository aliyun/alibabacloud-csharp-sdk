// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class ListYikeWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E84BE44-58A7-<b><b>-</b></b>-FBEBEA16EF94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>54</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("WorkspaceList")]
        [Validation(Required=false)]
        public List<ListYikeWorkspacesResponseBodyWorkspaceList> WorkspaceList { get; set; }
        public class ListYikeWorkspacesResponseBodyWorkspaceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ABCD12</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-04-29T10:22:44Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pd_1234***</para>
            /// </summary>
            [NameInMap("DefaultProductionId")]
            [Validation(Required=false)]
            public string DefaultProductionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public string UserCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ws_1243****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
