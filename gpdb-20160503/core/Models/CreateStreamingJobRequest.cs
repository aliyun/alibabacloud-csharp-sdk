// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateStreamingJobRequest : TeaModel {
        /// <summary>
        /// The name of the database account.
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// The delivery guarantee setting.
        /// 
        /// Valid values:
        /// 
        /// *   ATLEAST
        /// *   EXACTLY
        /// </summary>
        [NameInMap("Consistency")]
        [Validation(Required=false)]
        public string Consistency { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The data source ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// The destination fields.
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
        /// The number of allowed error rows. Write failures occur when Kafka data does not match the destination table in AnalyticDB for PostgreSQL. If the specified value is exceeded, the job fails.
        /// </summary>
        [NameInMap("ErrorLimitCount")]
        [Validation(Required=false)]
        public long? ErrorLimitCount { get; set; }

        [NameInMap("FallbackOffset")]
        [Validation(Required=false)]
        public string FallbackOffset { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The YAML configuration file of the job. This parameter must be specified when Mode is set to professional.
        /// </summary>
        [NameInMap("JobConfig")]
        [Validation(Required=false)]
        public string JobConfig { get; set; }

        /// <summary>
        /// The description of the job.
        /// </summary>
        [NameInMap("JobDescription")]
        [Validation(Required=false)]
        public string JobDescription { get; set; }

        /// <summary>
        /// The name of the job.
        /// 
        /// This parameter is required.
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
        /// The password of the database account.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The source fields.
        /// </summary>
        [NameInMap("SrcColumns")]
        [Validation(Required=false)]
        public List<string> SrcColumns { get; set; }

        /// <summary>
        /// Specifies whether to test the real-time job. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("TryRun")]
        [Validation(Required=false)]
        public bool? TryRun { get; set; }

        /// <summary>
        /// The columns to be updated if a row of data meets the update condition. Typically, the columns are all non-primary key columns of the destination table. When the columns specified by the MatchColumns parameter are used as conditions to join the source data and the destination table, data in columns of the UpdateColumns type is updated if data is matched.
        /// </summary>
        [NameInMap("UpdateColumns")]
        [Validation(Required=false)]
        public List<string> UpdateColumns { get; set; }

        /// <summary>
        /// The write mode.
        /// 
        /// Valid values:
        /// 
        /// *   insert
        /// *   update
        /// *   merge
        /// </summary>
        [NameInMap("WriteMode")]
        [Validation(Required=false)]
        public string WriteMode { get; set; }

    }

}
