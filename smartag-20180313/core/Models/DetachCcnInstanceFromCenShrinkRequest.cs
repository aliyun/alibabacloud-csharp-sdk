// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DetachCcnInstanceFromCenShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the attached Cloud Connect Network (CCN).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccn-isdjvvkexkrpk*****</para>
        /// </summary>
        [NameInMap("CcnId")]
        [Validation(Required=false)]
        public string CcnId { get; set; }

        /// <summary>
        /// <para>The ID of the CEN instance from which you want to revoke authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-9j8gkkj7z9vie9a8z9</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The list of transit routers to be disassociated from the CCN.</para>
        /// </summary>
        [NameInMap("RegionBindingList")]
        [Validation(Required=false)]
        public string RegionBindingListShrink { get; set; }

        /// <summary>
        /// <para>The region ID of the Smart Access Gateway instance. You can call the DescribeRegions operation to query the regions supported by Smart Access Gateway and the corresponding region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
