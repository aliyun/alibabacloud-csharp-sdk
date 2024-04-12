// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyUserPublicKeyRequest : TeaModel {
        /// <summary>
        /// The new description of the user group. The description can be up to 500 characters in length.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The ID of the bastion host that is used to modify the public key of the user.
        /// 
        /// > You can call the [describeinstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The new public key.
        /// 
        /// > The public key must be encoded in Base64.
        /// </summary>
        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// The ID of the public key that you want to modify.
        /// </summary>
        [NameInMap("PublicKeyId")]
        [Validation(Required=false)]
        public string PublicKeyId { get; set; }

        /// <summary>
        /// The name of the public key that you want to modify. This name can be up to 128 characters in length.
        /// </summary>
        [NameInMap("PublicKeyName")]
        [Validation(Required=false)]
        public string PublicKeyName { get; set; }

        /// <summary>
        /// The region ID of the bastion host that is used to modify the public key of the user.
        /// 
        /// > For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
