// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateKmsInstanceBindVpcRequest : TeaModel {
        /// <summary>
        /// The VPC configuration. The configuration of each VPC contains the following content:
        /// 
        /// *   VpcId: the ID of the VPC.
        /// *   VSwitchId: the vSwitch in the VPC.
        /// *   RegionID: the ID of the region to which the VPC belongs.
        /// *   VpcOwnerId: the Alibaba Cloud account to which the VPC belongs.
        /// 
        /// Format: `[{"VpcId":"${VpcId}","VSwitchId":"${VSwitchId}","RegionId":"${RegionId}","VpcOwnerId":${VpcOwnerId}},..]`.
        /// </summary>
        [NameInMap("BindVpcs")]
        [Validation(Required=false)]
        public string BindVpcs { get; set; }

        /// <summary>
        /// The ID of the KMS instance.
        /// </summary>
        [NameInMap("KmsInstanceId")]
        [Validation(Required=false)]
        public string KmsInstanceId { get; set; }

    }

}
