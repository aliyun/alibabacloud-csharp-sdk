// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeGadInstancesRequest : TeaModel {
        /// <summary>
        /// The ID of the global active database cluster.
        /// 
        /// *   If you leave this parameter empty, this operation returns the details about all global active database clusters that are created within your Alibaba Cloud account.
        /// *   If you specify this parameter, this operation returns the details about the global active database cluster that you specify.
        /// 
        /// >  If you do not specify this parameter when you call this operation for the first time, the IDs of all clusters that are created by using the current account are returned. Then, you can specify the cluster ID to view the cluster details.
        /// </summary>
        [NameInMap("GadInstanceName")]
        [Validation(Required=false)]
        public string GadInstanceName { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
