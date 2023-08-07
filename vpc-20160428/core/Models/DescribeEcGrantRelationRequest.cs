// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEcGrantRelationRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// *   If you set **InstanceType** to **VBR**, specify a VBR ID.
        /// *   If you set **InstanceType** to **VPC**, specify a VPC ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of instance. Valid values:
        /// 
        /// *   **VBR**: queries the permissions that are granted to a VBR.
        /// *   **VPC**: queries the permissions that are granted from a VPC.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the region where the instance is deployed.
        /// 
        /// *   If **InstanceType** is set to **VBR**, this parameter is required.
        /// *   If **InstanceType** is set to **VPC**, you can ignore this parameter.
        /// </summary>
        [NameInMap("VbrRegionNo")]
        [Validation(Required=false)]
        public string VbrRegionNo { get; set; }

    }

}
