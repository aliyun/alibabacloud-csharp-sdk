// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class AcceptHandshakeResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the invitation.</para>
        /// </summary>
        [NameInMap("Handshake")]
        [Validation(Required=false)]
        public AcceptHandshakeResponseBodyHandshake Handshake { get; set; }
        public class AcceptHandshakeResponseBodyHandshake : TeaModel {
            /// <summary>
            /// <para>The time when the invitation was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-06T02:15:40Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the invitation expires. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-20T02:15:40Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the invitation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>h-Ih8IuPfvV0t0****</para>
            /// </summary>
            [NameInMap("HandshakeId")]
            [Validation(Required=false)]
            public string HandshakeId { get; set; }

            /// <summary>
            /// <para>The ID of the management account of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>151266687691****</para>
            /// </summary>
            [NameInMap("MasterAccountId")]
            [Validation(Required=false)]
            public string MasterAccountId { get; set; }

            /// <summary>
            /// <para>The name of the management account of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CompanyA</para>
            /// </summary>
            [NameInMap("MasterAccountName")]
            [Validation(Required=false)]
            public string MasterAccountName { get; set; }

            /// <summary>
            /// <para>The time when the invitation was modified. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-06T02:16:40Z</para>
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
            /// <para>rd-3G****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <para>The status of the invitation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The invitation is waiting for confirmation.</description></item>
            /// <item><description>Accepted: The invitation is accepted.</description></item>
            /// <item><description>Cancelled: The invitation is canceled.</description></item>
            /// <item><description>Declined: The invitation is rejected.</description></item>
            /// <item><description>Expired: The invitation expires.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Accepted</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID or logon email address of the invited Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>177242285274****</para>
            /// </summary>
            [NameInMap("TargetEntity")]
            [Validation(Required=false)]
            public string TargetEntity { get; set; }

            /// <summary>
            /// <para>The type of the invited Alibaba Cloud account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Account: indicates the ID of the Alibaba Cloud account.</description></item>
            /// <item><description>Email: indicates the logon email address of the Alibaba Cloud account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Account</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5828C836-3286-49A6-9006-15231BB19342</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
