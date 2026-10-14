// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PreloadRegionSDGShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of destination edge zones.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DestinationRegionIds")]
        [Validation(Required=false)]
        public string DestinationRegionIdsShrink { get; set; }

        /// <summary>
        /// <para>The type of the shared cloud disk to be created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>standard: standard cloud disk.</para>
        /// </description></item>
        /// <item><description><para>rbd: rbd cloud disk.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify the shared cloud disk type, a standard cloud disk is created by default.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rbd</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The list of namespaces.</para>
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public string NamespacesShrink { get; set; }

        /// <summary>
        /// <para>The redundancy count to support fast deployment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RedundantNum")]
        [Validation(Required=false)]
        public int? RedundantNum { get; set; }

        /// <summary>
        /// <para>The ID of the SDG that you want to preload.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sdg-xxxx</para>
        /// </summary>
        [NameInMap("SDGId")]
        [Validation(Required=false)]
        public string SDGId { get; set; }

    }

}
