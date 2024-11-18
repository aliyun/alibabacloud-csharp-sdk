// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class RejectResourceShareInvitationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E446D6DE-BFC8-5F37-A494-33D7B118147D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the resource sharing invitation.</para>
        /// </summary>
        [NameInMap("ResourceShareInvitation")]
        [Validation(Required=false)]
        public RejectResourceShareInvitationResponseBodyResourceShareInvitation ResourceShareInvitation { get; set; }
        public class RejectResourceShareInvitationResponseBodyResourceShareInvitation : TeaModel {
            /// <summary>
            /// <para>The time when the invitation was created. The time is displayed in UTC.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-02T07:07:30.809Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the invitee.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>134254031178****</para>
            /// </summary>
            [NameInMap("ReceiverAccountId")]
            [Validation(Required=false)]
            public string ReceiverAccountId { get; set; }

            /// <summary>
            /// <para>The ID of the resource share.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rs-JoA1Ayjm****</para>
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            /// <summary>
            /// <para>The ID of the invitation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-yyTWbkjHArYh****</para>
            /// </summary>
            [NameInMap("ResourceShareInvitationId")]
            [Validation(Required=false)]
            public string ResourceShareInvitationId { get; set; }

            /// <summary>
            /// <para>The name of the resource share.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("ResourceShareName")]
            [Validation(Required=false)]
            public string ResourceShareName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the inviter.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>151266687691****</para>
            /// </summary>
            [NameInMap("SenderAccountId")]
            [Validation(Required=false)]
            public string SenderAccountId { get; set; }

            /// <summary>
            /// <para>The status of the invitation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The invitation is waiting for confirmation.</description></item>
            /// <item><description>Accepted: The invitation is accepted.</description></item>
            /// <item><description>Cancelled: The invitation is canceled.</description></item>
            /// <item><description>Rejected: The invitation is rejected.</description></item>
            /// <item><description>Expired: The invitation has expired.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Rejected</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
