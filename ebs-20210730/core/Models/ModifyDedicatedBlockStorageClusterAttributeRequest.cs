// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ModifyDedicatedBlockStorageClusterAttributeRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests.
        /// 
        /// The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How do I ensure idempotence ](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the dedicated block storage cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbscId")]
        [Validation(Required=false)]
        public string DbscId { get; set; }

        /// <summary>
        /// The new name of the dedicated block storage cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbscName")]
        [Validation(Required=false)]
        public string DbscName { get; set; }

        /// <summary>
        /// The new description of dedicated block storage cluster.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The region ID of the dedicated block storage cluster. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
