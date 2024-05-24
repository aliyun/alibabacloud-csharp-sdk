// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class UploadCACertificateRequest : TeaModel {
        /// <summary>
        /// The name of this action.
        /// 
        /// Value: **UploadCACertificate**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CACertificate")]
        [Validation(Required=false)]
        public string CACertificate { get; set; }

        /// <summary>
        /// The ID of the region to which the CA certificate belongs.
        /// 
        /// To query the region ID, call [DescribeRegions](https://help.aliyun.com/document_detail/27584.html).
        /// </summary>
        [NameInMap("CACertificateName")]
        [Validation(Required=false)]
        public string CACertificateName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region id.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The content of the CA certificate to be uploaded.
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

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UploadCACertificateRequestTag> Tag { get; set; }
        public class UploadCACertificateRequestTag : TeaModel {
            /// <summary>
            /// The tag key. You can specify at most 20 tag keys.
            /// 
            /// The tag key cannot be an empty string. The tag key must be 1 to 64 characters in length and cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. Valid values of N: **1 to 20**. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. The tag value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
