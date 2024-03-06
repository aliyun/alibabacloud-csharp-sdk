// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateKeyResponseBody : TeaModel {
        /// <summary>
        /// The metadata of the key.
        /// </summary>
        [NameInMap("KeyMetadata")]
        [Validation(Required=false)]
        public CreateKeyResponseBodyKeyMetadata KeyMetadata { get; set; }
        public class CreateKeyResponseBodyKeyMetadata : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the key.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The status of automatic key rotation. Valid values:
            /// 
            /// - Enabled
            /// - Disabled
            /// - Suspended
            /// </summary>
            [NameInMap("AutomaticRotation")]
            [Validation(Required=false)]
            public string AutomaticRotation { get; set; }

            /// <summary>
            /// The date and time (UTC) when the key was created.
            /// </summary>
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }

            /// <summary>
            /// The user who created the key.
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The ID of the KMS instance.
            /// </summary>
            [NameInMap("DKMSInstanceId")]
            [Validation(Required=false)]
            public string DKMSInstanceId { get; set; }

            /// <summary>
            /// The time when the key is scheduled for deletion. For more information, see ScheduleKeyDeletion.
            /// 
            /// This parameter is returned only when the value of KeyState is PendingDeletion.
            /// </summary>
            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            /// <summary>
            /// The description of the key.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The globally unique ID of the key.
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// The specification of the key.
            /// </summary>
            [NameInMap("KeySpec")]
            [Validation(Required=false)]
            public string KeySpec { get; set; }

            /// <summary>
            /// The status of the key.
            /// 
            /// For more information, see [Impacts of key status on API operations](~~44211~~).
            /// </summary>
            [NameInMap("KeyState")]
            [Validation(Required=false)]
            public string KeyState { get; set; }

            /// <summary>
            /// The usage of the key.
            /// </summary>
            [NameInMap("KeyUsage")]
            [Validation(Required=false)]
            public string KeyUsage { get; set; }

            /// <summary>
            /// The time when the last rotation was performed. The time is displayed in UTC.
            /// 
            /// For a new key, this parameter value is the time when the initial version of the key was generated.
            /// </summary>
            [NameInMap("LastRotationDate")]
            [Validation(Required=false)]
            public string LastRotationDate { get; set; }

            /// <summary>
            /// The time when the key material expires. The time is displayed in UTC.
            /// 
            /// If this parameter value is empty, the key material does not expire.
            /// </summary>
            [NameInMap("MaterialExpireTime")]
            [Validation(Required=false)]
            public string MaterialExpireTime { get; set; }

            /// <summary>
            /// The time when the key is next rotated.
            /// 
            /// This value is returned only when the value of AutomaticRotation is Enabled or Suspended.
            /// </summary>
            [NameInMap("NextRotationDate")]
            [Validation(Required=false)]
            public string NextRotationDate { get; set; }

            /// <summary>
            /// The key material origin.
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// The current primary version identifier of the key.
            /// </summary>
            [NameInMap("PrimaryKeyVersion")]
            [Validation(Required=false)]
            public string PrimaryKeyVersion { get; set; }

            /// <summary>
            /// The protection level of the key.
            /// </summary>
            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public string ProtectionLevel { get; set; }

            /// <summary>
            /// The interval for automatic key rotation. Unit: seconds. The format is an integer value followed by the character s. For example, if the rotation period is seven days, this parameter is set to 604800s.
            /// 
            /// This value is returned only when the value of AutomaticRotation is Enabled or Suspended.
            /// </summary>
            [NameInMap("RotationInterval")]
            [Validation(Required=false)]
            public string RotationInterval { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
