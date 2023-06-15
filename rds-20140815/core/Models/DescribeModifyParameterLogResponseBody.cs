// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeModifyParameterLogResponseBody : TeaModel {
        /// <summary>
        /// The ID of the RDS instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The database engine that the RDS instance runs.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The version of the database engine that the RDS instance runs.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// An array that consists of parameter reconfiguration log entries.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeModifyParameterLogResponseBodyItems Items { get; set; }
        public class DescribeModifyParameterLogResponseBodyItems : TeaModel {
            [NameInMap("ParameterChangeLog")]
            [Validation(Required=false)]
            public List<DescribeModifyParameterLogResponseBodyItemsParameterChangeLog> ParameterChangeLog { get; set; }
            public class DescribeModifyParameterLogResponseBodyItemsParameterChangeLog : TeaModel {
                /// <summary>
                /// The time when the parameter was reconfigured. This value is a UNIX timestamp. Unit: milliseconds.
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// The new value of the parameter.
                /// </summary>
                [NameInMap("NewParameterValue")]
                [Validation(Required=false)]
                public string NewParameterValue { get; set; }

                /// <summary>
                /// The original value of the parameter.
                /// </summary>
                [NameInMap("OldParameterValue")]
                [Validation(Required=false)]
                public string OldParameterValue { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The status of the new value specified for the parameter. Valid values:
                /// 
                /// *   **Applied:** The new value has taken effect.
                /// *   **Syncing:** The new value is being applied and has not taken effect.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
