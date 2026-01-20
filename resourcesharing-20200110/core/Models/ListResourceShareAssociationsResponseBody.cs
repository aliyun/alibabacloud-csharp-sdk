// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceShareAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The <c>token</c> that is used to initiate the next request if the response of the current request is truncated. You can use the token to initiate another request and obtain the remaining records.</para>
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
        /// <para>11BA57B5-7301-4E2F-BBA5-2AE4C2F4FCDB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the entities.</para>
        /// </summary>
        [NameInMap("ResourceShareAssociations")]
        [Validation(Required=false)]
        public List<ListResourceShareAssociationsResponseBodyResourceShareAssociations> ResourceShareAssociations { get; set; }
        public class ListResourceShareAssociationsResponseBodyResourceShareAssociations : TeaModel {
            /// <summary>
            /// <para>The information about the failure.</para>
            /// </summary>
            [NameInMap("AssociationFailedDetails")]
            [Validation(Required=false)]
            public List<ListResourceShareAssociationsResponseBodyResourceShareAssociationsAssociationFailedDetails> AssociationFailedDetails { get; set; }
            public class ListResourceShareAssociationsResponseBodyResourceShareAssociationsAssociationFailedDetails : TeaModel {
                /// <summary>
                /// <para>This parameter is deprecated. The OperationType parameter is used instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("AssociateType")]
                [Validation(Required=false)]
                public string AssociateType { get; set; }

                /// <summary>
                /// <para>The ID of the entity. The value of this parameter depends on the value of the AssociationType parameter:</para>
                /// <list type="bullet">
                /// <item><description>If the value of AssociationType is Resource, the value of this parameter is the ID of the principal.</description></item>
                /// <item><description>If the value of AssociationType is Target, the value of this parameter is the ID of the resource.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>172050525300****</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The type of the entity. The value of this parameter depends on the value of the AssociationType parameter:</para>
                /// <list type="bullet">
                /// <item><description>If the value of AssociationType is Resource, the value of this parameter is the type of the resource. For information about the types of resources that can be shared, see Services that work with Resource Sharing.</description></item>
                /// <item><description>If the value of AssociationType is Target, the value of this parameter is <c>ResourceDirectory</c>, <c>Folder</c>, <c>Account</c>, or <c>Service</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Account</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

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
                /// <item><description>Unavailable: The resource does not exist.</description></item>
                /// <item><description>LimitExceeded: The number of principals for the resource exceeds the upper limit.</description></item>
                /// <item><description>ZonalResourceInaccessible: The resource is unavailable in this region.</description></item>
                /// <item><description>InternalError: An internal error occurred.</description></item>
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

                [NameInMap("ResourceArn")]
                [Validation(Required=false)]
                public string ResourceArn { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated. The FailureReason parameter is used instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated. The FailureDescription parameter is used instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("StatusMessage")]
                [Validation(Required=false)]
                public string StatusMessage { get; set; }

            }

            /// <summary>
            /// <para>The association status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Associating: The entity is being associated.</description></item>
            /// <item><description>Associated: The entity is associated.</description></item>
            /// <item><description>Failed: The entity fails to be associated.</description></item>
            /// <item><description>Disassociating: The entity is being disassociated.</description></item>
            /// <item><description>Disassociated: The entity is disassociated.</description></item>
            /// </list>
            /// <remarks>
            /// <para> The system deletes the records of entities in the <c>Failed</c> or <c>Disassociated</c> state within 48 hours to 96 hours.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Associated</para>
            /// </summary>
            [NameInMap("AssociationStatus")]
            [Validation(Required=false)]
            public string AssociationStatus { get; set; }

            /// <summary>
            /// <para>The cause of the association failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The reason for the association failure.</para>
            /// </summary>
            [NameInMap("AssociationStatusMessage")]
            [Validation(Required=false)]
            public string AssociationStatusMessage { get; set; }

            /// <summary>
            /// <para>The association type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Resource</description></item>
            /// <item><description>Target</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Resource</para>
            /// </summary>
            [NameInMap("AssociationType")]
            [Validation(Required=false)]
            public string AssociationType { get; set; }

            /// <summary>
            /// <para>The time when the association of the entity was created. The value of this parameter depends on the value of the AssociationType parameter:</para>
            /// <list type="bullet">
            /// <item><description>If the value of <c>AssociationType</c> is <c>Resource</c>, the value of this parameter is the time when the shared resource was associated with or disassociated from the resource share.</description></item>
            /// <item><description>If the value of <c>AssociationType</c> is <c>Target</c>, the value of this parameter is the time when the principal was associated with or disassociated from the resource share.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-07T07:39:01.818Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the entity. The value of this parameter depends on the value of the AssociationType parameter:</para>
            /// <list type="bullet">
            /// <item><description>If the value of <c>AssociationType</c> is <c>Resource</c>, the value of this parameter is the ID of the resource.</description></item>
            /// <item><description>If the value of <c>AssociationType</c> is <c>Target</c>, the value of this parameter is the ID of the principal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1upw03qyz8n7us9****</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The type of the entity. The value of this parameter depends on the value of the AssociationType parameter:</para>
            /// <list type="bullet">
            /// <item><description>If the value of AssociationType is Resource, the value of this parameter is the type of the resource. For information about the types of resources that can be shared, see <a href="https://help.aliyun.com/document_detail/450526.html">Services that work with Resource Sharing</a>.</description></item>
            /// <item><description>If the value of AssociationType is Target, the value of this parameter is <c>Account</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VSwitch</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>Indicates whether the principal is outside the resource directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("External")]
            [Validation(Required=false)]
            public bool? External { get; set; }

            [NameInMap("ResourceArn")]
            [Validation(Required=false)]
            public string ResourceArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;sharePrincipals&quot;:true,&quot;shareTagOptions&quot;:false}</para>
            /// </summary>
            [NameInMap("ResourceProperty")]
            [Validation(Required=false)]
            public string ResourceProperty { get; set; }

            /// <summary>
            /// <para>The ID of the resource share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rs-6GRmdD3X****</para>
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

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
            /// <para>The properties of the principal, such as the time range within which the resource is shared. Valid values of <c>timeRangeType</c>:</para>
            /// <list type="bullet">
            /// <item><description>timeRange: a specific time range</description></item>
            /// <item><description>day: all day</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned only if the principal is an Alibaba Cloud service.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;timeRange&quot;:{
            ///         &quot;timeRangeType&quot;:&quot;timeRange&quot;,
            ///         &quot;beginAtTime&quot;:&quot;00:00&quot;,
            ///         &quot;timezone&quot;:&quot;UTC+8&quot;,
            ///         &quot;endAtTime&quot;:&quot;19:59&quot;
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("TargetProperty")]
            [Validation(Required=false)]
            public string TargetProperty { get; set; }

            /// <summary>
            /// <para>The time when the association of the entity was updated. The value of this parameter depends on the value of the AssociationType parameter:</para>
            /// <list type="bullet">
            /// <item><description>If the value of <c>AssociationType</c> is <c>Resource</c>, the value of this parameter is the time when the association of the shared resource was updated.</description></item>
            /// <item><description>If the value of <c>AssociationType</c> is <c>Target</c>, the value of this parameter is the time when the association of the principal was updated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-07T07:39:02.920Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
