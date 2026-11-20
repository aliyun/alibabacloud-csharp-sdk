// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListWuyingServerWorkloadTemplateRequest : TeaModel {
        /// <summary>
        /// <para>A compatibility field. The current version does not read this parameter. The operation returns a maximum of the first 100 templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A compatibility field. The current version does not read this parameter and does not support token-based pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unused</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The virtual node pool ID. <b>Required</b>. The node pool must already exist and belong to the current account, but it is not required to be attached to a workstation.</para>
        /// <para>If you already have a valid node pool ID, you can directly pass it. If a workstation is already associated with a node pool, you can also obtain the corresponding non-empty <c>VirtualNodePoolId</c> by invoking <a href="~~ListWuyingServer~~">ListWuyingServer</a>. If you do not have a valid ID, do not use an empty value, workstation ID, cluster ID, or the character string <c>null</c> as a substitute.</para>
        /// <para><a href="~~CreateWuyingServer~~">CreateWuyingServer</a> only associates existing node pools and does not support automatic creation of node pools. If the node pool does not exist or does not belong to the current account, <c>InvalidParameter.VirtualNodePoolId</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vnp-bp1234567890abcde</para>
        /// </summary>
        [NameInMap("VirtualNodePoolId")]
        [Validation(Required=false)]
        public string VirtualNodePoolId { get; set; }

    }

}
