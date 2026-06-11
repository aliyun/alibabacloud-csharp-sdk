// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListWhitePortalMenuResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC4E1**********0DF67E2C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The whitelist.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListWhitePortalMenuResponseBodyResult> Result { get; set; }
        public class ListWhitePortalMenuResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The authorization type for the menu. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: View</para>
            /// </description></item>
            /// <item><description><para>3: Export and view</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuthPointsValue")]
            [Validation(Required=false)]
            public int? AuthPointsValue { get; set; }

            /// <summary>
            /// <para>The ID of the authorization object. If the authorization is at the workspace or organization level, this parameter returns the workspace ID or organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8a4***********1e769</para>
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
            /// <item><description><para>3: Workspace or organization level</para>
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
