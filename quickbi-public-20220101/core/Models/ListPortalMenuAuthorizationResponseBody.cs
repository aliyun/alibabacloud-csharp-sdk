// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListPortalMenuAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8749D65-E80A-433C-AF1B-CE9C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of authorization details of the portal menu.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListPortalMenuAuthorizationResponseBodyResult> Result { get; set; }
        public class ListPortalMenuAuthorizationResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The menu ID of the BI portal leaf node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54kqgoa****</para>
            /// </summary>
            [NameInMap("MenuId")]
            [Validation(Required=false)]
            public string MenuId { get; set; }

            /// <summary>
            /// <para>The details of the object to which the menu is authorized.</para>
            /// </summary>
            [NameInMap("Receivers")]
            [Validation(Required=false)]
            public List<ListPortalMenuAuthorizationResponseBodyResultReceivers> Receivers { get; set; }
            public class ListPortalMenuAuthorizationResponseBodyResultReceivers : TeaModel {
                /// <summary>
                /// <para>The ID of the authorization object.</para>
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
                /// <item><description>0: user</description></item>
                /// <item><description>1: user group</description></item>
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
            /// <para>Whether only authorization is visible. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Only the authorization is visible.</description></item>
            /// <item><description>false: Both are visible.</description></item>
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
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
