// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddSasModuleTrialResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddSasModuleTrialResponseBodyData Data { get; set; }
        public class AddSasModuleTrialResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the trial use.
            /// </summary>
            [NameInMap("TrialRecordList")]
            [Validation(Required=false)]
            public List<AddSasModuleTrialResponseBodyDataTrialRecordList> TrialRecordList { get; set; }
            public class AddSasModuleTrialResponseBodyDataTrialRecordList : TeaModel {
                /// <summary>
                /// The purchased quota.
                /// </summary>
                [NameInMap("AuthLimit")]
                [Validation(Required=false)]
                public long? AuthLimit { get; set; }

                /// <summary>
                /// List of purchased quotas.
                /// </summary>
                [NameInMap("AuthLimitList")]
                [Validation(Required=false)]
                public string AuthLimitList { get; set; }

                /// <summary>
                /// The end time of the trial use.
                /// </summary>
                [NameInMap("GmtEnd")]
                [Validation(Required=false)]
                public long? GmtEnd { get; set; }

                /// <summary>
                /// The start time of the trial use.
                /// </summary>
                [NameInMap("GmtStart")]
                [Validation(Required=false)]
                public long? GmtStart { get; set; }

                /// <summary>
                /// The code of the module. Valid values:
                /// 
                /// *   **vulFix**: vulnerability fixing
                /// *   **cloudSiem**: threat analysis
                /// </summary>
                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                /// <summary>
                /// The status of the trial use. Valid values:
                /// 
                /// *   **1**: enabled
                /// *   **0**: finished
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

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
