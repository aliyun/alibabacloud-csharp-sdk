// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class AssociateResourceShareResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111FB84A-60A9-403E-9067-E55D7EE95BD1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the entities that are associated with the resource share.</para>
        /// </summary>
        [NameInMap("ResourceShareAssociations")]
        [Validation(Required=false)]
        public List<AssociateResourceShareResponseBodyResourceShareAssociations> ResourceShareAssociations { get; set; }
        public class AssociateResourceShareResponseBodyResourceShareAssociations : TeaModel {
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
            /// <para>Associating</para>
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
            /// <item><description>If the value of <c>AssociationType</c> is <c>Resource</c>, the value of this parameter is the time when the shared resource was associated with the resource share.</description></item>
            /// <item><description>If the value of <c>AssociationType</c> is <c>Target</c>, the value of this parameter is the time when the principal was associated with the resource share.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-04T09:40:41.246Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the entity. The value of this parameter depends on the value of the AssociationType parameter:</para>
            /// <list type="bullet">
            /// <item><description>If the value of <c>AssociationType</c> is <c>Resource</c>, the value of this parameter is the ID of the shared resource.</description></item>
            /// <item><description>If the value of <c>AssociationType</c> is <c>Target</c>, the value of this parameter is the ID of the principal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp183p93qs667muql****</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The type of the entity. The value of this parameter depends on the value of the AssociationType parameter:</para>
            /// <list type="bullet">
            /// <item><description>If the value of AssociationType is Resource, the value of this parameter is the type of the shared resource. For information about the types of resources that can be shared, see <a href="https://help.aliyun.com/document_detail/450526.html">Services that work with Resource Sharing</a>.</description></item>
            /// <item><description>If the value of AssociationType is Target, the value of this parameter is <c>Account</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VSwitch</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

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
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceShareName")]
            [Validation(Required=false)]
            public string ResourceShareName { get; set; }

            /// <summary>
            /// <para>The properties of the principal, such as the time range within which the resource is shared.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the principal is an Alibaba Cloud service.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;plan&quot;:{
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
            /// <para>2020-12-04T09:40:41.246Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
