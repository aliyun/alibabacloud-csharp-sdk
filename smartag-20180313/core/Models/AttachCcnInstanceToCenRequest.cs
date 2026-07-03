// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class AttachCcnInstanceToCenRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Connect Network (CCN) instance to attach.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccn-isdjvvkexkrpk*****</para>
        /// </summary>
        [NameInMap("CcnId")]
        [Validation(Required=false)]
        public string CcnId { get; set; }

        /// <summary>
        /// <para>The ID of the CEN instance to authorize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-joimmi1s2ob3rdxw79</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

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
        /// <para>The Internet CIDR block used when the Cloud Connect Network (CCN) instance is attached to the CEN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.55.0/24</para>
        /// </summary>
        [NameInMap("Subnet")]
        [Validation(Required=false)]
        public string Subnet { get; set; }

    }

}
