// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class AcceptHandshakeResponseBody : TeaModel {
        /// <summary>
        /// <para>The handshake information.</para>
        /// </summary>
        [NameInMap("Handshake")]
        [Validation(Required=false)]
        public AcceptHandshakeResponseBodyHandshake Handshake { get; set; }
        public class AcceptHandshakeResponseBodyHandshake : TeaModel {
            /// <summary>
            /// <para>The creation time of the handshake (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-06T02:15:40Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the handshake (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-20T02:15:40Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The handshake ID.</para>
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
            /// <para>The modification time of the handshake (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-06T02:16:40Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Welcome to join us</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The resource directory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-3G****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <para>The status of the handshake. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: waiting for confirmation.</description></item>
            /// <item><description>Accepted: accepted.</description></item>
            /// <item><description>Cancelled: canceled.</description></item>
            /// <item><description>Declined: rejected.</description></item>
            /// <item><description>Expired: expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Accepted</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID or logon email address of the invited account.</para>
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
            /// <item><description>Account: Alibaba Cloud account ID.</description></item>
            /// <item><description>Email: logon email address of the Alibaba Cloud account.</description></item>
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
