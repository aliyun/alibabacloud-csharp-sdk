// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class AttachCcnInstanceToCenShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Connect Network (CCN) to attach.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccn-isdjvvkexkrpk*****</para>
        /// </summary>
        [NameInMap("CcnId")]
        [Validation(Required=false)]
        public string CcnId { get; set; }

        /// <summary>
        /// <para>The ID of the CEN instance to which you want to attach the CCN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-joimmi1s2ob3rdxw79</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The CIDR block allocation mode. Valid values: - PER_REGION: Custom CIDR blocks are allocated for each region. - UNIFIED: A unified CIDR block is allocated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNIFIED</para>
        /// </summary>
        [NameInMap("CidrAllocationMode")]
        [Validation(Required=false)]
        public string CidrAllocationMode { get; set; }

        /// <summary>
        /// <para>The list of transit routers to be newly attached to the CCN instance.</para>
        /// </summary>
        [NameInMap("RegionBindingList")]
        [Validation(Required=false)]
        public string RegionBindingListShrink { get; set; }

        /// <summary>
        /// <para>The region ID of the Cloud Connect Network (CCN) instance. You can invoke the DescribeRegions operation to query the regions supported by Smart Access Gateway and the corresponding region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Internet CIDR block used to attach the Cloud Connect Network (CCN) to the Cloud Enterprise Network (CEN).</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.55.0/24</para>
        /// </summary>
        [NameInMap("Subnet")]
        [Validation(Required=false)]
        public string Subnet { get; set; }

    }

}
