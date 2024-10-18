// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetRelatedWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

        [NameInMap("workspaces")]
        [Validation(Required=false)]
        public List<GetRelatedWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class GetRelatedWorkspacesResponseBodyWorkspaces : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1638256965936</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>知识库</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Q2xwPOKiSLxxxx</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("RecentList")]
            [Validation(Required=false)]
            public List<GetRelatedWorkspacesResponseBodyWorkspacesRecentList> RecentList { get; set; }
            public class GetRelatedWorkspacesResponseBodyWorkspacesRecentList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1638256965936</para>
                /// </summary>
                [NameInMap("LastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>知识库</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nb9XxxxxxxmyAp</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://alidocs.xxxx/nb9XJKdxxxxmyAp">https://alidocs.xxxx/nb9XJKdxxxxmyAp</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OWNER</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://alidocs.xxxx/nb9XJKdxxxxmyAp/docs/nb9XxxxxxxmyAp">https://alidocs.xxxx/nb9XJKdxxxxmyAp/docs/nb9XxxxxxxmyAp</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nb9XJKdxxxxmyAp</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
