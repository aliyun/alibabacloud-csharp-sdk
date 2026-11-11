// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class AttachCcnInstanceToCenRequest : TeaModel {
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
        public List<AttachCcnInstanceToCenRequestRegionBindingList> RegionBindingList { get; set; }
        public class AttachCcnInstanceToCenRequestRegionBindingList : TeaModel {
            /// <summary>
            /// <para>The custom CIDR block for each region when the CidrAllocationMode parameter is set to PER_REGION.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.60.0/24</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The region ID of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-finance-1</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The instance ID of the transit router used for forward routing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-wz9h1y152p7bajkehs5a3</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

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
