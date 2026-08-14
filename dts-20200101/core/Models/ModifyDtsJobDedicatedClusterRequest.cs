// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobDedicatedClusterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsxxxx</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>The task ID. You can specify multiple task IDs in a JSON array. Separate the IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;dtsxxxx01&quot;, &quot;dtsxxx02&quot;]</para>
        /// </summary>
        [NameInMap("DtsJobIds")]
        [Validation(Required=false)]
        public string DtsJobIds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The region in which the DTS instance resides.</para>
        /// <remarks>
        /// <para>For the regions supported by dedicated clusters, see <a href="https://help.aliyun.com/document_detail/417481.html">DTS dedicated cluster</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
