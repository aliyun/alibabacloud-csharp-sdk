// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateUserPublicKeyRequest : TeaModel {
        /// <summary>
        /// The description of the public key. The description can be up to 500 characters in length.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The ID of the bastion host on which you want to create a public key for the user.
        /// 
        /// > You can call the [listinstances](~~204522~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The public key. Encode the value by using the Base64 algorithm.
        /// </summary>
        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// The name of the public key.
        /// </summary>
        [NameInMap("PublicKeyName")]
        [Validation(Required=false)]
        public string PublicKeyName { get; set; }

        /// <summary>
        /// Specifies the region ID of the bastion host on which you want to create a public key for the user.
        /// 
        /// > For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies the ID of the user for whom you want to create a public key.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
