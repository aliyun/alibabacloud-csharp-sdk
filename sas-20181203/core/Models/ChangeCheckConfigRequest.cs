// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeCheckConfigRequest : TeaModel {
        /// <summary>
        /// The list of check items that you want to add to the policy.
        /// 
        /// >  If the ConfigStandardIds or ConfigRequirementIds parameter is configured, this parameter does not take effect.
        /// </summary>
        [NameInMap("AddedCheck")]
        [Validation(Required=false)]
        public List<ChangeCheckConfigRequestAddedCheck> AddedCheck { get; set; }
        public class ChangeCheckConfigRequestAddedCheck : TeaModel {
            /// <summary>
            /// The ID of the check item.
            /// 
            /// >  You can call the [ListCheckResult](~~ListCheckResult~~) operation to obtain the ID of the check item.
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// The section ID of the check item.
            /// </summary>
            [NameInMap("SectionId")]
            [Validation(Required=false)]
            public long? SectionId { get; set; }

        }

        /// <summary>
        /// The requirement IDs that you want to specify for the check policy.
        /// 
        /// >  You can call the [ListCheckResult](~~ListCheckResult~~) operation to obtain the requirement ID. If the ConfigStandardIds parameter is configured, this parameter does not take effect.
        /// </summary>
        [NameInMap("ConfigRequirementIds")]
        [Validation(Required=false)]
        public ChangeCheckConfigRequestConfigRequirementIds ConfigRequirementIds { get; set; }
        public class ChangeCheckConfigRequestConfigRequirementIds : TeaModel {
            /// <summary>
            /// The requirement IDs that you want to add to the policy.
            /// </summary>
            [NameInMap("AddIds")]
            [Validation(Required=false)]
            public List<long?> AddIds { get; set; }

            /// <summary>
            /// The requirement IDs that you want to remove from the policy.
            /// </summary>
            [NameInMap("RemoveIds")]
            [Validation(Required=false)]
            public List<long?> RemoveIds { get; set; }

        }

        /// <summary>
        /// The standard IDs that you want to specify for the check policy.
        /// 
        /// >  You can call the [ListCheckResult](~~ListCheckResult~~) operation to obtain the standard ID.
        /// </summary>
        [NameInMap("ConfigStandardIds")]
        [Validation(Required=false)]
        public ChangeCheckConfigRequestConfigStandardIds ConfigStandardIds { get; set; }
        public class ChangeCheckConfigRequestConfigStandardIds : TeaModel {
            /// <summary>
            /// The standard IDs that you want to add to the policy.
            /// </summary>
            [NameInMap("AddIds")]
            [Validation(Required=false)]
            public List<long?> AddIds { get; set; }

            /// <summary>
            /// The standard IDs that you want to remove from the policy.
            /// </summary>
            [NameInMap("RemoveIds")]
            [Validation(Required=false)]
            public List<long?> RemoveIds { get; set; }

        }

        /// <summary>
        /// The configuration of the check item. Valid values:
        /// - **all**
        /// </summary>
        [NameInMap("Configure")]
        [Validation(Required=false)]
        public string Configure { get; set; }

        /// <summary>
        /// The days in a week on which a check is performed.
        /// </summary>
        [NameInMap("CycleDays")]
        [Validation(Required=false)]
        public List<int?> CycleDays { get; set; }

        /// <summary>
        /// Specifies whether to check the new check items in the selected requirement item. Valid values:
        /// - **true**
        /// - **false**
        /// </summary>
        [NameInMap("EnableAddCheck")]
        [Validation(Required=false)]
        public bool? EnableAddCheck { get; set; }

        /// <summary>
        /// Specifies whether to enable the automatic periodical check feature. Valid values:
        /// 
        /// - **true**
        /// - **false**
        /// </summary>
        [NameInMap("EnableAutoCheck")]
        [Validation(Required=false)]
        public bool? EnableAutoCheck { get; set; }

        /// <summary>
        /// The end time of the check. The value specifies a point in time in a day. The time period that is specified by the start time and end time must be one of the following time periods:
        /// 
        /// *   **00:00 to 06:00:** If you set the StartTime parameter to 0, you must set the EndTime parameter to 6.
        /// *   **06:00 to 12:00**: If you set the StartTime parameter to 6, you must set the EndTime parameter to 12.
        /// *   **12:00 to 18:00**: If you set the StartTime parameter to 12, you must set the EndTime parameter to 18.
        /// *  **18:00 to 24:00:** If you set the StartTime parameter to 18, you must set the EndTime parameter to 24.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// The region ID of the bastion host to query.
        /// 
        /// >  For more information about the mapping between region IDs and region names, see [Regions and zones](https://help.aliyun.com/document_detail/40654.html).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The list of the check items that you want to remove from the policy.
        /// 
        /// >  If the ConfigStandardIds or ConfigRequirementIds parameter is configured, this parameter does not take effect.
        /// </summary>
        [NameInMap("RemovedCheck")]
        [Validation(Required=false)]
        public List<ChangeCheckConfigRequestRemovedCheck> RemovedCheck { get; set; }
        public class ChangeCheckConfigRequestRemovedCheck : TeaModel {
            /// <summary>
            /// The ID of the check item.
            /// 
            /// >  You can call the [ListCheckResult](~~ListCheckResult~~) operation to obtain the ID of the check item.
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// The section ID of the check item.
            /// </summary>
            [NameInMap("SectionId")]
            [Validation(Required=false)]
            public long? SectionId { get; set; }

        }

        /// <summary>
        /// An array that consists of the information about the check item.
        /// </summary>
        [NameInMap("StandardIds")]
        [Validation(Required=false)]
        public List<long?> StandardIds { get; set; }

        /// <summary>
        /// The start time of the check. The value specifies a point in time in a day.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        [NameInMap("SystemConfig")]
        [Validation(Required=false)]
        public bool? SystemConfig { get; set; }

        /// <summary>
        /// The service provider (SP) of the cloud asset.
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
