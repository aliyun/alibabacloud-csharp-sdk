// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class AcceptResourceShareInvitationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08F18B04-47CB-5C0E-A6D2-37DEF5C2A961</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the resource sharing invitation.</para>
        /// </summary>
        [NameInMap("ResourceShareInvitation")]
        [Validation(Required=false)]
        public AcceptResourceShareInvitationResponseBodyResourceShareInvitation ResourceShareInvitation { get; set; }
        public class AcceptResourceShareInvitationResponseBodyResourceShareInvitation : TeaModel {
            /// <summary>
            /// <para>The information about the failure.</para>
            /// </summary>
            [NameInMap("AcceptInvitationFailedDetails")]
            [Validation(Required=false)]
            public List<AcceptResourceShareInvitationResponseBodyResourceShareInvitationAcceptInvitationFailedDetails> AcceptInvitationFailedDetails { get; set; }
            public class AcceptResourceShareInvitationResponseBodyResourceShareInvitationAcceptInvitationFailedDetails : TeaModel {
                /// <summary>
                /// <para>This parameter is deprecated. The OperationType parameter is used instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Associate</para>
                /// </summary>
                [NameInMap("AssociateType")]
                [Validation(Required=false)]
                public string AssociateType { get; set; }

                /// <summary>
                /// <para>The failure description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>You cannot access the specified resource at this time.</para>
                /// </summary>
                [NameInMap("FailureDescription")]
                [Validation(Required=false)]
                public string FailureDescription { get; set; }

                /// <summary>
                /// <para>The failure cause. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Unavailable: The resource cannot be shared.</description></item>
                /// <item><description>LimitExceeded: The number of shared resources within the Alibaba Cloud account exceeds the upper limit.</description></item>
                /// <item><description>ZonalResourceInaccessible: The resource is unavailable in this region.</description></item>
                /// <item><description>InternalError: An internal error occurred during the check.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unavailable</para>
                /// </summary>
                [NameInMap("FailureReason")]
                [Validation(Required=false)]
                public string FailureReason { get; set; }

                /// <summary>
                /// <para>The operation type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Associate</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Associate</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>The ID of the shared resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-7xvh46nx5oqlre0wv***</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The type of the shared resource.</para>
                /// <para>For more information about the types of resources that can be shared, see <a href="https://help.aliyun.com/document_detail/450526.html">Services that work with Resource Sharing</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Snapshot</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated. The FailureReason parameter is used instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Unavailable</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated. The FailureDescription parameter is used instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>You cannot access the specified resource at this time.</para>
                /// </summary>
                [NameInMap("StatusMessage")]
                [Validation(Required=false)]
                public string StatusMessage { get; set; }

            }

            /// <summary>
            /// <para>The time when the invitation was created. The time is displayed in UTC.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-02T06:43:12.353Z</para>
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
            /// <para>rs-ysGRci9z****</para>
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            /// <summary>
            /// <para>The ID of the resource sharing invitation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-pMnItMX19fBJ****</para>
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
            /// <item><description>Pending</description></item>
            /// <item><description>Accepted</description></item>
            /// <item><description>Cancelled</description></item>
            /// <item><description>Rejected</description></item>
            /// <item><description>Expired</description></item>
            /// <item><description>AcceptFailed</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AcceptFailed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
