// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateKeyResponseBody : TeaModel {
        /// <summary>
        /// The metadata of the CMK.
        /// </summary>
        [NameInMap("KeyMetadata")]
        [Validation(Required=false)]
        public CreateKeyResponseBodyKeyMetadata KeyMetadata { get; set; }
        public class CreateKeyResponseBodyKeyMetadata : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the CMK.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// Indicates whether automatic key rotation is enabled. Valid values:
            /// 
            /// *   Enabled: Automatic key rotation is enabled.
            /// *   Disabled: Automatic key rotation is disabled.
            /// *   Suspended: Automatic key rotation is suspended. For more information, see [Automatic key rotation](~~134270~~).
            /// 
            /// >  Automatic key rotation is available only for symmetric CMKs.
            /// </summary>
            [NameInMap("AutomaticRotation")]
            [Validation(Required=false)]
            public string AutomaticRotation { get; set; }

            /// <summary>
            /// The date and time when the CMK was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }

            /// <summary>
            /// The creator of the CMK.
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The ID of the dedicated KMS instance.
            /// </summary>
            [NameInMap("DKMSInstanceId")]
            [Validation(Required=false)]
            public string DKMSInstanceId { get; set; }

            /// <summary>
            /// The time when the CMK is scheduled for deletion.
            /// 
            /// For more information, see [ScheduleKeyDeletion](~~44196~~).
            /// 
            /// >  This value is returned only when the value of the KeyState parameter is PendingDeletion.
            /// </summary>
            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            /// <summary>
            /// The description of the CMK.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the CMK. The ID must be globally unique.
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// The type of the CMK.
            /// </summary>
            [NameInMap("KeySpec")]
            [Validation(Required=false)]
            public string KeySpec { get; set; }

            /// <summary>
            /// The status of the CMK.
            /// 
            /// For more information, see [Impact of CMK status on API operations](~~44211~~).
            /// </summary>
            [NameInMap("KeyState")]
            [Validation(Required=false)]
            public string KeyState { get; set; }

            /// <summary>
            /// The usage of the CMK.
            /// </summary>
            [NameInMap("KeyUsage")]
            [Validation(Required=false)]
            public string KeyUsage { get; set; }

            /// <summary>
            /// The time when the last rotation was performed. The time is displayed in UTC.
            /// 
            /// For a new CMK, this parameter value is the time when the initial version of the CMK was generated.
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
            /// The time when the next rotation will be performed.
            /// 
            /// >  This value is returned only when the value of the AutomaticRotation parameter is Enabled or Suspended.
            /// </summary>
            [NameInMap("NextRotationDate")]
            [Validation(Required=false)]
            public string NextRotationDate { get; set; }

            /// <summary>
            /// The source of the key material for the CMK.
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// The ID of the current primary key version of the symmetric CMK.
            /// 
            /// > * The primary key version of a symmetric CMK is an active encryption key. KMS uses the primary key version of a specified CMK to encrypt data.
            /// > * This parameter is unavailable for asymmetric CMKs.
            /// </summary>
            [NameInMap("PrimaryKeyVersion")]
            [Validation(Required=false)]
            public string PrimaryKeyVersion { get; set; }

            /// <summary>
            /// The protection level of the CMK.
            /// </summary>
            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public string ProtectionLevel { get; set; }

            /// <summary>
            /// The period of automatic key rotation. Unit: seconds. The value is in the format of an integer followed by the letter s. For example, if the rotation period is seven days, this parameter is set to 604800s. This value is returned only when the value of the AutomaticRotation parameter is Enabled or Suspended.
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
