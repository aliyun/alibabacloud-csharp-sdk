// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ReInitDiskRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically start the instance after the disk is re-initialized.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("AutoStartInstance")]
        [Validation(Required=false)]
        public bool? AutoStartInstance { get; set; }

        /// <summary>
        /// The ID of the disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The name of the key pair. This parameter is empty by default.
        /// 
        /// > The parameter is applicable only to Linux instances. You can bind an SSH key pair to an instance as the logon credential when you re-initialize the system disk of the instance. After the SSH key pair is bound, the username and password-based logon method is disabled for the instance.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies whether to reset the password of the instance when you re-initialize its system disk. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include:
        /// 
        ///     ()`~!@#$%^&*-_+=|{}[]:;\\"<>,.?/
        /// 
        /// For Windows instances, passwords cannot start with a forward slash (/).
        /// 
        /// > If the `Password` parameter is specified, we recommend that you send requests over HTTPS to prevent password leaks.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to use Security Center for free after the system disk is re-initialized. Valid values:
        /// 
        /// *   Active: Security Center is activated for free after the system disk is replaced. This value is applicable to only public images.
        /// *   Deactive: Security Center is not activated after the system disk is replaced. This value is applicable to all images.
        /// 
        /// Default value: Deactive.
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

    }

}
