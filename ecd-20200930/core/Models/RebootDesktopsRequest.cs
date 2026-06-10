// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RebootDesktopsRequest : TeaModel {
        [NameInMap("CreateSnapshot")]
        [Validation(Required=false)]
        public bool? CreateSnapshot { get; set; }

        /// <summary>
        /// <para>An array of 1 to 100 desktop IDs.</para>
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
        /// <b>Example:</b>
        /// <para>KB5082063</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public string PatchId { get; set; }

        /// <summary>
        /// <para>The ID of the region. Call <a href="~~DescribeRegions~~">DescribeRegions</a> to get a list of regions where Elastic Desktop Service is available.</para>
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
