// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeMongoDBLogConfigResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether to enable the audit log feature is enabled.
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        /// <summary>
        /// Indicates whether a rule to distribute logs to Logtail is created. For more information, see [Logtail overview](~~28979~~). Valid values:
        /// 
        /// *   **1**: A rule to distribute logs to Logtail is created.
        /// *   **0** or **null**: A rule to distribute logs to Logtail is not created.
        /// </summary>
        [NameInMap("IsEtlMetaExist")]
        [Validation(Required=false)]
        public int? IsEtlMetaExist { get; set; }

        /// <summary>
        /// Indicates whether a Log Service project exists in the current region. Valid values:
        /// 
        /// *   **1**: A Log Service project exists in the current region.
        /// *   **0** or **null**: A Log Service project does not exist in the current region.
        /// </summary>
        [NameInMap("IsUserProjectLogstoreExist")]
        [Validation(Required=false)]
        public int? IsUserProjectLogstoreExist { get; set; }

        /// <summary>
        /// The maximum storage space for the formal edition of the audit log feature. If the value is **-1**, no maximum is set.
        /// </summary>
        [NameInMap("PreserveStorageForStandard")]
        [Validation(Required=false)]
        public long? PreserveStorageForStandard { get; set; }

        /// <summary>
        /// The maximum storage space for the free trial edition of the audit log feature. Unit: bytes. You can set the maximum up to 107,374,182,400 bytes.
        /// </summary>
        [NameInMap("PreserveStorageForTrail")]
        [Validation(Required=false)]
        public long? PreserveStorageForTrail { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of the audit log feature. Valid values:
        /// 
        /// *   **Trail**: the free trial edition
        /// *   **Standard**: the official edition
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// The retention period for the official edition of the audit log feature. Valid values: 1 to 365 days.
        /// </summary>
        [NameInMap("TtlForStandard")]
        [Validation(Required=false)]
        public long? TtlForStandard { get; set; }

        /// <summary>
        /// The retention period for the free trial edition of the audit log feature.
        /// </summary>
        [NameInMap("TtlForTrail")]
        [Validation(Required=false)]
        public long? TtlForTrail { get; set; }

        /// <summary>
        /// The used storage space for the formal edition of the audit log feature. Unit: bytes.
        /// </summary>
        [NameInMap("UsedStorageForStandard")]
        [Validation(Required=false)]
        public long? UsedStorageForStandard { get; set; }

        /// <summary>
        /// The used storage space for the free trial edition of the audit log feature. Unit: bytes.
        /// </summary>
        [NameInMap("UsedStorageForTrail")]
        [Validation(Required=false)]
        public long? UsedStorageForTrail { get; set; }

        /// <summary>
        /// The name of the Log Service project.
        /// </summary>
        [NameInMap("UserProjectName")]
        [Validation(Required=false)]
        public string UserProjectName { get; set; }

    }

}
