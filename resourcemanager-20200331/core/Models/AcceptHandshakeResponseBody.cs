// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class AcceptHandshakeResponseBody : TeaModel {
        /// <summary>
        /// <para>The invitation information.</para>
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
            /// <para>The expiration time of the invitation. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-20T02:15:40Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The invitation ID.</para>
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
            /// <para>The note.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Welcome to join</para>
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
            /// <para>The invitation status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: pending confirmation</description></item>
            /// <item><description>Accepted: accepted</description></item>
            /// <item><description>Cancelled: canceled</description></item>
            /// <item><description>Declined: declined</description></item>
            /// <item><description>Expired: expired</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Accepted</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID or logon mailbox of the invited Alibaba Cloud account.</para>
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
            /// <item><description>Account: the Alibaba Cloud account ID</description></item>
            /// <item><description>Email: the logon mailbox of the Alibaba Cloud account</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5828C836-3286-49A6-9006-15231BB19342</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
