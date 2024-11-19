// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceShareInvitationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30EC8328-1BDE-51D5-BFAB-039508BD91A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the resource sharing invitations.</para>
        /// </summary>
        [NameInMap("ResourceShareInvitations")]
        [Validation(Required=false)]
        public List<ListResourceShareInvitationsResponseBodyResourceShareInvitations> ResourceShareInvitations { get; set; }
        public class ListResourceShareInvitationsResponseBodyResourceShareInvitations : TeaModel {
            /// <summary>
            /// <para>The time when the invitation was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-18T05:36:45.024Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The information about the failure.</para>
            /// </summary>
            [NameInMap("InvitationFailedDetails")]
            [Validation(Required=false)]
            public List<ListResourceShareInvitationsResponseBodyResourceShareInvitationsInvitationFailedDetails> InvitationFailedDetails { get; set; }
            public class ListResourceShareInvitationsResponseBodyResourceShareInvitationsInvitationFailedDetails : TeaModel {
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
                /// <item><description>UnsupportedOperation: You cannot perform this operation.</description></item>
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
                /// <item><description>Disassociate</description></item>
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
            /// <para>The Alibaba Cloud account ID of the invitee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>134254031178****</para>
            /// </summary>
            [NameInMap("ReceiverAccountId")]
            [Validation(Required=false)]
            public string ReceiverAccountId { get; set; }

            /// <summary>
            /// <para>The ID of the resource share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rs-ysGRci9z****</para>
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            /// <summary>
            /// <para>The ID of the invitation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-p6eRytrkjVvM****</para>
            /// </summary>
            [NameInMap("ResourceShareInvitationId")]
            [Validation(Required=false)]
            public string ResourceShareInvitationId { get; set; }

            /// <summary>
            /// <para>The name of the resource share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("ResourceShareName")]
            [Validation(Required=false)]
            public string ResourceShareName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the inviter.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
