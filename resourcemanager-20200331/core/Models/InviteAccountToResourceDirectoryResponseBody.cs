// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class InviteAccountToResourceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the invitation.</para>
        /// </summary>
        [NameInMap("Handshake")]
        [Validation(Required=false)]
        public InviteAccountToResourceDirectoryResponseBodyHandshake Handshake { get; set; }
        public class InviteAccountToResourceDirectoryResponseBodyHandshake : TeaModel {
            /// <summary>
            /// <para>The time when the invitation was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-08-10T09:55:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the invitation expires. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-08-24T09:55:41Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the invitation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>h-ycm4rp****</para>
            /// </summary>
            [NameInMap("HandshakeId")]
            [Validation(Required=false)]
            public string HandshakeId { get; set; }

            /// <summary>
            /// <para>The ID of the management account of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172841235500****</para>
            /// </summary>
            [NameInMap("MasterAccountId")]
            [Validation(Required=false)]
            public string MasterAccountId { get; set; }

            /// <summary>
            /// <para>The name of the management account of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("MasterAccountName")]
            [Validation(Required=false)]
            public string MasterAccountName { get; set; }

            /// <summary>
            /// <para>The time when the invitation was modified. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-08-10T09:55:41Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The comment on the invitation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Welcome</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-abcdef****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <para>The status of the invitation.</para>
            /// <list type="bullet">
            /// <item><description>Pending: The invitation is waiting for confirmation.</description></item>
            /// <item><description>Accepted: The invitation is accepted.</description></item>
            /// <item><description>Cancelled: The invitation is canceled.</description></item>
            /// <item><description>Declined: The invitation is rejected.</description></item>
            /// <item><description>Expired: The invitation expires.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID or logon email address of the invited account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
            /// </summary>
            [NameInMap("TargetEntity")]
            [Validation(Required=false)]
            public string TargetEntity { get; set; }

            /// <summary>
            /// <para>The type of the invited account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Account: indicates the ID of the account.</description></item>
            /// <item><description>Email: indicates the logon email address of the account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Email</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B34724D-54B0-4A51-B34D-4512372FE1BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
