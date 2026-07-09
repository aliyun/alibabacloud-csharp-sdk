// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class AllocateCostCenterResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the source cost center. This parameter is required.</para>
        /// <list type="bullet">
        /// <item><description>0 indicates that the cost center is unallocated.</description></item>
        /// <item><description>A value greater than 0 indicates an allocated cost center ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>637180</para>
        /// </summary>
        [NameInMap("FromCostCenterId")]
        [Validation(Required=false)]
        public long? FromCostCenterId { get; set; }

        /// <summary>
        /// <para>The ID of the owner of the source cost center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1529600453335198</para>
        /// </summary>
        [NameInMap("FromOwnerAccountId")]
        [Validation(Required=false)]
        public long? FromOwnerAccountId { get; set; }

        /// <summary>
        /// <para>The primary sales channel ID. If this parameter is left empty, the sales channel ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>The list of resource instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceInstanceList")]
        [Validation(Required=false)]
        public string ResourceInstanceListShrink { get; set; }

        /// <summary>
        /// <para>The ID of the destination cost center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: moves the allocated resource to the unallocated state.</description></item>
        /// <item><description>A value greater than 0: allocates the resource to the specified cost center.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>638288</para>
        /// </summary>
        [NameInMap("ToCostCenterId")]
        [Validation(Required=false)]
        public long? ToCostCenterId { get; set; }

    }

}
