// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeUserStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the current account.
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public DescribeUserStatusResponseBodyUserStatus UserStatus { get; set; }
        public class DescribeUserStatusResponseBodyUserStatus : TeaModel {
            /// <summary>
            /// The AccessKey ID of the current account.
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// Indicates whether the SQL Explorer feature can be disabled. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("AuditClosable")]
            [Validation(Required=false)]
            public bool? AuditClosable { get; set; }

            /// <summary>
            /// Indicates whether the audit resources can be released.
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("AuditReleasable")]
            [Validation(Required=false)]
            public bool? AuditReleasable { get; set; }

            /// <summary>
            /// Indicates whether DSC has permission to access user resources within the current account. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Authed")]
            [Validation(Required=false)]
            public bool? Authed { get; set; }

            /// <summary>
            /// The billing method of DCS that is purchased by using the current account. Valid values:
            /// 
            /// *   **PREPAY**: subscription
            /// *   **POSTPAY**: pay-as-you-go
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The permissions that the current account has. Valid values:
            /// 
            /// *   **0**: The current account has the administrative permissions or read-only permissions on Data Security Center.
            /// *   **1**: The current account has the permissions to manage data domains.
            /// </summary>
            [NameInMap("DataManagerRole")]
            [Validation(Required=false)]
            public int? DataManagerRole { get; set; }

            /// <summary>
            /// The ID of the data security center instance purchased by the main account.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The number of instances within the current account.
            /// </summary>
            [NameInMap("InstanceNum")]
            [Validation(Required=false)]
            public int? InstanceNum { get; set; }

            /// <summary>
            /// The total number of instances.
            /// </summary>
            [NameInMap("InstanceTotalCount")]
            [Validation(Required=false)]
            public long? InstanceTotalCount { get; set; }

            /// <summary>
            /// Indicates whether the data security lab feature is enabled. Valid values:
            /// 
            /// *   **1**: yes
            /// *   **0**: no
            /// </summary>
            [NameInMap("LabStatus")]
            [Validation(Required=false)]
            public int? LabStatus { get; set; }

            /// <summary>
            /// OSS total storage capacity. Unit: Bytes.
            /// </summary>
            [NameInMap("OssTotalSize")]
            [Validation(Required=false)]
            public long? OssTotalSize { get; set; }

            /// <summary>
            /// Accumulate the number of days to protect user assets.
            /// </summary>
            [NameInMap("ProtectionDays")]
            [Validation(Required=false)]
            public int? ProtectionDays { get; set; }

            /// <summary>
            /// Indicates whether DSC is purchased. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Purchased")]
            [Validation(Required=false)]
            public bool? Purchased { get; set; }

            /// <summary>
            /// The grace period between when DSC is expired and when DSC is released. Unit: days.
            /// </summary>
            [NameInMap("ReleaseDays")]
            [Validation(Required=false)]
            public int? ReleaseDays { get; set; }

            /// <summary>
            /// The time when the audit resources are released. Unit: milliseconds.
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// The remaining period for which the data assets within the current account can be protected by DSC.
            /// </summary>
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public int? RemainDays { get; set; }

            /// <summary>
            /// Indicates whether the current account uses a free trial of DSC. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Trail")]
            [Validation(Required=false)]
            public bool? Trail { get; set; }

            /// <summary>
            /// Indicates whether the agent audit feature is used. Valid values:
            /// 
            /// *   **1**: yes
            /// *   **0**: no
            /// </summary>
            [NameInMap("UseAgentAudit")]
            [Validation(Required=false)]
            public bool? UseAgentAudit { get; set; }

            /// <summary>
            /// The number of instances that are used.
            /// </summary>
            [NameInMap("UseInstanceNum")]
            [Validation(Required=false)]
            public int? UseInstanceNum { get; set; }

            /// <summary>
            /// The occupied space of the Object Storage Service (OSS) bucket. Unit: bytes.
            /// </summary>
            [NameInMap("UseOssSize")]
            [Validation(Required=false)]
            public long? UseOssSize { get; set; }

        }

    }

}
