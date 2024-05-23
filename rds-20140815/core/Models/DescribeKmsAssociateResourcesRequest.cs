// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeKmsAssociateResourcesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the KMS resource. Only key IDs are supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KmsResourceId")]
        [Validation(Required=false)]
        public string KmsResourceId { get; set; }

        /// <summary>
        /// The ID of the region to which the KMS resource belongs.
        /// </summary>
        [NameInMap("KmsResourceRegionId")]
        [Validation(Required=false)]
        public string KmsResourceRegionId { get; set; }

        /// <summary>
        /// The type of the KMS resource. Only key is supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KmsResourceType")]
        [Validation(Required=false)]
        public string KmsResourceType { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the KMS resource belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KmsResourceUser")]
        [Validation(Required=false)]
        public string KmsResourceUser { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
