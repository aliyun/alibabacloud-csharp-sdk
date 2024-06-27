// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListStreamingJobsResponseBody : TeaModel {
        /// <summary>
        /// The queried jobs.
        /// </summary>
        [NameInMap("JobItems")]
        [Validation(Required=false)]
        public List<ListStreamingJobsResponseBodyJobItems> JobItems { get; set; }
        public class ListStreamingJobsResponseBodyJobItems : TeaModel {
            /// <summary>
            /// The name of the database account.
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// The delivery guarantee setting.
            /// </summary>
            [NameInMap("Consistency")]
            [Validation(Required=false)]
            public string Consistency { get; set; }

            /// <summary>
            /// The time when the job was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The data source ID.
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// The name of the data source.
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// The mapped fields in the destination table.
            /// </summary>
            [NameInMap("DestColumns")]
            [Validation(Required=false)]
            public List<string> DestColumns { get; set; }

            /// <summary>
            /// The name of the destination database.
            /// </summary>
            [NameInMap("DestDatabase")]
            [Validation(Required=false)]
            public string DestDatabase { get; set; }

            /// <summary>
            /// The name of the destination namespace.
            /// </summary>
            [NameInMap("DestSchema")]
            [Validation(Required=false)]
            public string DestSchema { get; set; }

            /// <summary>
            /// The name of the destination table.
            /// </summary>
            [NameInMap("DestTable")]
            [Validation(Required=false)]
            public string DestTable { get; set; }

            /// <summary>
            /// The error message returned.
            /// 
            /// This parameter is returned only when the return value of **Status** is **false**.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The fallback offset for data consumption.
            /// 
            /// *   This parameter indicates the starting offset from which data consumption resumes when a consumer does not request a consumption offset or requests a consumption offset that is beyond the range of the offset information recorded in the current Kafka cluster. Valid values: EARLIEST and LATEST.
            /// </summary>
            [NameInMap("FallbackOffset")]
            [Validation(Required=false)]
            public string FallbackOffset { get; set; }

            /// <summary>
            /// The description of the job.
            /// </summary>
            [NameInMap("JobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            /// <summary>
            /// The job ID.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The name of the job.
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// The update condition columns that are used to join the source data and the destination table. Typically, the columns are all the primary key columns of the destination table. If the values of all columns specified by this parameter in different rows are the same, the rows are considered duplicates.
            /// </summary>
            [NameInMap("MatchColumns")]
            [Validation(Required=false)]
            public List<string> MatchColumns { get; set; }

            /// <summary>
            /// The configuration mode. Valid values:
            /// 
            /// 1.  basic: In basic mode, you must configure the configuration parameters.
            /// 2.  professional: In professional mode, you can submit a YAML configuration file.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The time when the job was last modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The password of the database account.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The source fields.
            /// </summary>
            [NameInMap("SrcColumns")]
            [Validation(Required=false)]
            public List<string> SrcColumns { get; set; }

            /// <summary>
            /// The status of the job. Valid values:
            /// 
            /// *   Init
            /// *   Running
            /// *   Exception
            /// *   Paused
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The columns to be updated if a row of data meets the update condition. Typically, the columns are all non-primary key columns of the destination table. When the columns specified by the MatchColumns parameter are used as conditions to join the source data and the destination table, data in columns of the UpdateColumns type is updated if data is matched.
            /// </summary>
            [NameInMap("UpdateColumns")]
            [Validation(Required=false)]
            public List<string> UpdateColumns { get; set; }

            /// <summary>
            /// The write mode.
            /// </summary>
            [NameInMap("WriteMode")]
            [Validation(Required=false)]
            public string WriteMode { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
