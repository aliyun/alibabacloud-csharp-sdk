// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListPortalMenuAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8749D65-E80A-433C-AF1B-CE9C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of authorization details for the BI portal menus.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListPortalMenuAuthorizationResponseBodyResult> Result { get; set; }
        public class ListPortalMenuAuthorizationResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the leaf-node menu in the BI portal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54kqgoa****</para>
            /// </summary>
            [NameInMap("MenuId")]
            [Validation(Required=false)]
            public string MenuId { get; set; }

            /// <summary>
            /// <para>The details of the authorization objects for the menu.</para>
            /// </summary>
            [NameInMap("Receivers")]
            [Validation(Required=false)]
            public List<ListPortalMenuAuthorizationResponseBodyResultReceivers> Receivers { get; set; }
            public class ListPortalMenuAuthorizationResponseBodyResultReceivers : TeaModel {
                /// <summary>
                /// <para>The authorization type for the menu. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: View</para>
                /// </description></item>
                /// <item><description><para>11: Edit</para>
                /// </description></item>
                /// <item><description><para>3: Export and view</para>
                /// </description></item>
                /// <item><description><para>10: Manage data entry</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("AuthPointsValue")]
                [Validation(Required=false)]
                public int? AuthPointsValue { get; set; }

                /// <summary>
                /// <para>The ID of the authorization object.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>If the authorization object is an organization, this ID is the organization ID.</para>
                /// </description></item>
                /// <item><description><para>If the authorization object is a workspace, this ID is the workspace ID.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>121344444790****</para>
                /// </summary>
                [NameInMap("ReceiverId")]
                [Validation(Required=false)]
                public string ReceiverId { get; set; }

                /// <summary>
                /// <para>The type of the authorization object. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: User</para>
                /// </description></item>
                /// <item><description><para>1: User group</para>
                /// </description></item>
                /// <item><description><para>2: Organization</para>
                /// </description></item>
                /// <item><description><para>3: Workspace</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public int? ReceiverType { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the menu is visible only to authorized users. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The menu is visible only to authorized users.</para>
            /// </description></item>
            /// <item><description><para>false: The menu is visible to all users.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ShowOnlyWithAccess")]
            [Validation(Required=false)]
            public bool? ShowOnlyWithAccess { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
