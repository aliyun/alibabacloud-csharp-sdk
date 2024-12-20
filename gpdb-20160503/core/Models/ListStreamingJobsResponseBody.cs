// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListStreamingJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried jobs.</para>
        /// </summary>
        [NameInMap("JobItems")]
        [Validation(Required=false)]
        public List<ListStreamingJobsResponseBodyJobItems> JobItems { get; set; }
        public class ListStreamingJobsResponseBodyJobItems : TeaModel {
            /// <summary>
            /// <para>The name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-account</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>The delivery guarantee setting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ATLEAST / EXACTLY</para>
            /// </summary>
            [NameInMap("Consistency")]
            [Validation(Required=false)]
            public string Consistency { get; set; }

            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-08T16:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>58</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-kafka</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>The mapped fields in the destination table.</para>
            /// </summary>
            [NameInMap("DestColumns")]
            [Validation(Required=false)]
            public List<string> DestColumns { get; set; }

            /// <summary>
            /// <para>The name of the destination database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dest-db</para>
            /// </summary>
            [NameInMap("DestDatabase")]
            [Validation(Required=false)]
            public string DestDatabase { get; set; }

            /// <summary>
            /// <para>The name of the destination namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dest-schema</para>
            /// </summary>
            [NameInMap("DestSchema")]
            [Validation(Required=false)]
            public string DestSchema { get; set; }

            /// <summary>
            /// <para>The name of the destination table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dest-table</para>
            /// </summary>
            [NameInMap("DestTable")]
            [Validation(Required=false)]
            public string DestTable { get; set; }

            /// <summary>
            /// <para>The error message returned.</para>
            /// <para>This parameter is returned only when the return value of <b>Status</b> is <b>false</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The fallback offset for data consumption.</para>
            /// <list type="bullet">
            /// <item><description>This parameter indicates the starting offset from which data consumption resumes when a consumer does not request a consumption offset or requests a consumption offset that is beyond the range of the offset information recorded in the current Kafka cluster. Valid values: EARLIEST and LATEST.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EARLIEST /  LATEST</para>
            /// </summary>
            [NameInMap("FallbackOffset")]
            [Validation(Required=false)]
            public string FallbackOffset { get; set; }

            /// <summary>
            /// <para>The description of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test job</para>
            /// </summary>
            [NameInMap("JobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-job</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The update condition columns that are used to join the source data and the destination table. Typically, the columns are all the primary key columns of the destination table. If the values of all columns specified by this parameter in different rows are the same, the rows are considered duplicates.</para>
            /// </summary>
            [NameInMap("MatchColumns")]
            [Validation(Required=false)]
            public List<string> MatchColumns { get; set; }

            /// <summary>
            /// <para>The configuration mode. Valid values:</para>
            /// <ol>
            /// <item><description>basic: In basic mode, you must configure the configuration parameters.</description></item>
            /// <item><description>professional: In professional mode, you can submit a YAML configuration file.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>Basic / Professional</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The time when the job was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-08T17:00:00Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The password of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pwd123</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The source fields.</para>
            /// </summary>
            [NameInMap("SrcColumns")]
            [Validation(Required=false)]
            public List<string> SrcColumns { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Init</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Exception</description></item>
            /// <item><description>Paused</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The columns to be updated if a row of data meets the update condition. Typically, the columns are all non-primary key columns of the destination table. When the columns specified by the MatchColumns parameter are used as conditions to join the source data and the destination table, data in columns of the UpdateColumns type is updated if data is matched.</para>
            /// </summary>
            [NameInMap("UpdateColumns")]
            [Validation(Required=false)]
            public List<string> UpdateColumns { get; set; }

            /// <summary>
            /// <para>The write mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSERT/UPDATE/MERGE</para>
            /// </summary>
            [NameInMap("WriteMode")]
            [Validation(Required=false)]
            public string WriteMode { get; set; }

        }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
