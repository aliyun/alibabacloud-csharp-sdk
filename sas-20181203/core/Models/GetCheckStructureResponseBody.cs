// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckStructureResponseBody : TeaModel {
        /// <summary>
        /// The structure information about check items provided by the configuration assessment feature.
        /// </summary>
        [NameInMap("CheckStructureResponse")]
        [Validation(Required=false)]
        public List<GetCheckStructureResponseBodyCheckStructureResponse> CheckStructureResponse { get; set; }
        public class GetCheckStructureResponseBodyCheckStructureResponse : TeaModel {
            /// <summary>
            /// The type of the check item.
            /// 
            /// *   RISK: security risk.
            /// *   IDENTITY_PERMISSION: Cloud Infrastructure Entitlement Management (CIEM).
            /// *   COMPLIANCE: security compliance.
            /// </summary>
            [NameInMap("StandardType")]
            [Validation(Required=false)]
            public string StandardType { get; set; }

            /// <summary>
            /// The structure information about the check items of the business type.
            /// </summary>
            [NameInMap("Standards")]
            [Validation(Required=false)]
            public List<GetCheckStructureResponseBodyCheckStructureResponseStandards> Standards { get; set; }
            public class GetCheckStructureResponseBodyCheckStructureResponseStandards : TeaModel {
                /// <summary>
                /// The standard ID of the check item.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The standards of the check items.
                /// </summary>
                [NameInMap("Requirements")]
                [Validation(Required=false)]
                public List<GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirements> Requirements { get; set; }
                public class GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirements : TeaModel {
                    /// <summary>
                    /// The ID of the requirement item for the check item.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The information about the sections of check items.
                    /// </summary>
                    [NameInMap("Sections")]
                    [Validation(Required=false)]
                    public List<GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirementsSections> Sections { get; set; }
                    public class GetCheckStructureResponseBodyCheckStructureResponseStandardsRequirementsSections : TeaModel {
                        /// <summary>
                        /// The ID of the section for the check item.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// The display name of the section for the check item.
                        /// </summary>
                        [NameInMap("ShowName")]
                        [Validation(Required=false)]
                        public string ShowName { get; set; }

                    }

                    /// <summary>
                    /// The display name of the requirement item for the check item.
                    /// </summary>
                    [NameInMap("ShowName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                    /// <summary>
                    /// The total number of check items for the requirement.
                    /// </summary>
                    [NameInMap("TotalCheckCount")]
                    [Validation(Required=false)]
                    public int? TotalCheckCount { get; set; }

                }

                /// <summary>
                /// The display name of the standard for the check item.
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// The standard type of the check item. Valid values:
                /// 
                /// *   RISK: security risk.
                /// *   IDENTITY_PERMISSION: CIEM.
                /// *   COMPLIANCE: security compliance.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
