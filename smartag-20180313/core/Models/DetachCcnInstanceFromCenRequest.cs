// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DetachCcnInstanceFromCenRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Connect Network (CCN) that is bound to the CEN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccn-isdjvvkexkrpk*****</para>
        /// </summary>
        [NameInMap("CcnId")]
        [Validation(Required=false)]
        public string CcnId { get; set; }

        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance from which you want to revoke the authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-9j8gkkj7z9vie9a8z9</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

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
