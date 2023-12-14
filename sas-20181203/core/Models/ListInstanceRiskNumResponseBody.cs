// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceRiskNumResponseBody : TeaModel {
        /// <summary>
        /// The information about the risks in the instance.
        /// </summary>
        [NameInMap("InstanceRiskNum")]
        [Validation(Required=false)]
        public List<ListInstanceRiskNumResponseBodyInstanceRiskNum> InstanceRiskNum { get; set; }
        public class ListInstanceRiskNumResponseBodyInstanceRiskNum : TeaModel {
            /// <summary>
            /// The information about the instance.
            /// </summary>
            [NameInMap("InstanceItem")]
            [Validation(Required=false)]
            public ListInstanceRiskNumResponseBodyInstanceRiskNumInstanceItem InstanceItem { get; set; }
            public class ListInstanceRiskNumResponseBodyInstanceRiskNumInstanceItem : TeaModel {
                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The UUID of the instance.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// The statistics about the risks.
            /// </summary>
            [NameInMap("RiskNumEntity")]
            [Validation(Required=false)]
            public ListInstanceRiskNumResponseBodyInstanceRiskNumRiskNumEntity RiskNumEntity { get; set; }
            public class ListInstanceRiskNumResponseBodyInstanceRiskNumRiskNumEntity : TeaModel {
                /// <summary>
                /// The number of high-risk alerts.
                /// </summary>
                [NameInMap("SuspiciousHighCount")]
                [Validation(Required=false)]
                public int? SuspiciousHighCount { get; set; }

                /// <summary>
                /// The number of low-risk alerts.
                /// </summary>
                [NameInMap("SuspiciousLowCount")]
                [Validation(Required=false)]
                public int? SuspiciousLowCount { get; set; }

                /// <summary>
                /// The number of medium-risk alerts.
                /// </summary>
                [NameInMap("SuspiciousMediumCount")]
                [Validation(Required=false)]
                public int? SuspiciousMediumCount { get; set; }

                /// <summary>
                /// The number of high-risk vulnerabilities.
                /// </summary>
                [NameInMap("VulHighCount")]
                [Validation(Required=false)]
                public int? VulHighCount { get; set; }

                /// <summary>
                /// The number of low-risk vulnerabilities.
                /// </summary>
                [NameInMap("VulLowCount")]
                [Validation(Required=false)]
                public int? VulLowCount { get; set; }

                /// <summary>
                /// The number of medium-risk vulnerabilities.
                /// </summary>
                [NameInMap("VulMediumCount")]
                [Validation(Required=false)]
                public int? VulMediumCount { get; set; }

                /// <summary>
                /// The number of weak passwords exposed on the Internet.
                /// </summary>
                [NameInMap("WeakPassWordCount")]
                [Validation(Required=false)]
                public int? WeakPassWordCount { get; set; }

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
