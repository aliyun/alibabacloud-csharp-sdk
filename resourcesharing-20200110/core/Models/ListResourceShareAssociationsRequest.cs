// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceShareAssociationsRequest : TeaModel {
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
        /// <para>The association type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Resource</description></item>
        /// <item><description>Target</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource</para>
        /// </summary>
        [NameInMap("AssociationType")]
        [Validation(Required=false)]
        public string AssociationType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for a single request.</para>
        /// <para>Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The <c>token</c> that is used to initiate the next request if the response of the current request is truncated. You can use the token to initiate another request and obtain the remaining records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ResourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// <para>The ID of the resource.</para>
        /// <remarks>
        /// <para> This parameter is unavailable if you set the <c>AssociationType</c> parameter to <c>Target</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp183p93qs667muql****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The IDs of the resource shares.</para>
        /// <para>Valid values of N: 1 to 5. This indicates that a maximum of five resource shares can be specified at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rs-6GRmdD3X****</para>
        /// </summary>
        [NameInMap("ResourceShareIds")]
        [Validation(Required=false)]
        public List<string> ResourceShareIds { get; set; }

        /// <summary>
        /// <para>The ID of the principal.</para>
        /// <remarks>
        /// <para> This parameter is unavailable if you set the <c>AssociationType</c> parameter to <c>Resource</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172050525300****</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
