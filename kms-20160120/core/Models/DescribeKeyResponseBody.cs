// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeKeyResponseBody : TeaModel {
        /// <summary>
        /// The metadata of the CMK.
        /// </summary>
        [NameInMap("KeyMetadata")]
        [Validation(Required=false)]
        public DescribeKeyResponseBodyKeyMetadata KeyMetadata { get; set; }
        public class DescribeKeyResponseBodyKeyMetadata : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the CMK.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// Indicates whether automatic key rotation is enabled. Valid values:
            /// 
            /// *   Enabled
            /// *   Disabled
            /// *   Suspended
            /// 
            /// For more information, see [Automatic key rotation](https://help.aliyun.com/document_detail/134270.html).
            /// 
            /// >  Only symmetric CMKs support automatic key rotation.
            /// </summary>
            [NameInMap("AutomaticRotation")]
            [Validation(Required=false)]
            public string AutomaticRotation { get; set; }

            /// <summary>
            /// The time when the CMK was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }

            /// <summary>
            /// The Alibaba Cloud account that is used to create the CMK.
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
            /// The time at which the CMK is scheduled for deletion. The time is displayed in UTC.
            /// 
            /// For more information, see [ScheduleKeyDeletion](https://help.aliyun.com/document_detail/44196.html).
            /// 
            /// >  This parameter is returned only when the value of the KeyState parameter is PendingDeletion.
            /// </summary>
            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            /// <summary>
            /// Indicates whether deletion protection is enabled. Valid values:
            /// 
            /// *   Enabled
            /// *   Disabled
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public string DeletionProtection { get; set; }

            /// <summary>
            /// The description of deletion protection.
            /// </summary>
            [NameInMap("DeletionProtectionDescription")]
            [Validation(Required=false)]
            public string DeletionProtectionDescription { get; set; }

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
            /// For more information, see [Impact of CMK status on API operations](https://help.aliyun.com/document_detail/44211.html).
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
            /// The time when the last rotation was performed. The time is displayed in UTC. For a new CMK, the value of this parameter is the time when the initial version of the CMK was generated.
            /// </summary>
            [NameInMap("LastRotationDate")]
            [Validation(Required=false)]
            public string LastRotationDate { get; set; }

            /// <summary>
            /// The time when the key material expires. The time is displayed in UTC. If this parameter value is empty, the key material does not expire.
            /// </summary>
            [NameInMap("MaterialExpireTime")]
            [Validation(Required=false)]
            public string MaterialExpireTime { get; set; }

            /// <summary>
            /// The time when the next rotation will be performed.
            /// 
            /// >  This parameter is returned only when the value of the AutomaticRotation parameter is Enabled or Suspended.
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
            /// The ID of the current primary key version for the symmetric CMK.
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
            /// The interval for automatic key rotation.
            /// 
            /// Unit: seconds.
            /// 
            /// For example, if the value is 604800s, automatic key rotation is performed at a 7-day interval.
            /// 
            /// >  This parameter is returned only when the value of the AutomaticRotation parameter is Enabled or Suspended.
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
