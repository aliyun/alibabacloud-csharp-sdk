// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListWuyingServerWorkloadTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The compatibility field. The current version does not read this parameter. This operation returns a fixed maximum of the first 100 templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The compatibility field. The current version does not read this parameter and does not support token-based pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unused</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the virtual node pool. This parameter is <b>required</b>. The node pool must belong to the current account. You can call <a href="~~ListWuyingServer~~">ListWuyingServer</a> to obtain the ID.</para>
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
