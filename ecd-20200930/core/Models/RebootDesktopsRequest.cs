// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RebootDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to create a snapshot.</para>
        /// </summary>
        [NameInMap("CreateSnapshot")]
        [Validation(Required=false)]
        public bool? CreateSnapshot { get; set; }

        /// <summary>
        /// <para>The cloud computer ID. You can specify 1 to 100 IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>Specifies whether to install system patches.</para>
        /// </summary>
        [NameInMap("OsUpdate")]
        [Validation(Required=false)]
        public bool? OsUpdate { get; set; }

        /// <summary>
        /// <para>The patch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KB5082063</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public string PatchId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
