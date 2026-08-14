// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAppliedAdvicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAppliedAdvicesResponseBodyItems> Items { get; set; }
        public class DescribeAppliedAdvicesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The advice ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7417db9c-914d-43f3-a123-4d0e448f****</para>
            /// </summary>
            [NameInMap("AdviceId")]
            [Validation(Required=false)]
            public string AdviceId { get; set; }

            /// <summary>
            /// <para>The benefit of the advice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Save 0.4 GB of storage space.</para>
            /// </summary>
            [NameInMap("Benefit")]
            [Validation(Required=false)]
            public string Benefit { get; set; }

            /// <summary>
            /// <para>The SQL statement that is used to run the build task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>build table <c>schema1</c>.<c>table1</c></para>
            /// </summary>
            [NameInMap("BuildSQL")]
            [Validation(Required=false)]
            public string BuildSQL { get; set; }

            /// <summary>
            /// <para>The index fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>index</para>
            /// </summary>
            [NameInMap("IndexFields")]
            [Validation(Required=false)]
            public string IndexFields { get; set; }

            /// <summary>
            /// <para>The state of the task that is run to apply the advice. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>SUCCEED</b>: The task is successful.</para>
            /// </description></item>
            /// <item><description><para><b>FAILED</b>: The task fails.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEED</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <para>The page number. The value is an integer that is greater than 0. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>30</b> (default)</para>
            /// </description></item>
            /// <item><description><para><b>50</b></para>
            /// </description></item>
            /// <item><description><para><b>100</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The SQL statement that is used to roll back the advice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alter table <c>schema1</c>.<c>table1</c> add key col1_1_idx(col1)</para>
            /// </summary>
            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }

            /// <summary>
            /// <para>The SQL statement that is used to apply the advice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alter table <c>schema1</c>.<c>table1</c> drop key col1_1_idx</para>
            /// </summary>
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public string SQL { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb_demo</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The submission status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>SUCCEED</b>: The submission is successful.</para>
            /// </description></item>
            /// <item><description><para><b>FAILED</b>: The submission fails.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEED</para>
            /// </summary>
            [NameInMap("SubmitStatus")]
            [Validation(Required=false)]
            public string SubmitStatus { get; set; }

            /// <summary>
            /// <para>The submission time. This value is a UTC time that is formatted as <c>yyMMddHHmm</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2208131600</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The total number of returned suggestions. The value is an integer that is greater than or equal to 0. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The page number. The value is an integer that is greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84489769-3065-5A28-A4CB-977CD426F1C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of concatenated strings of database and table names.</para>
        /// </summary>
        [NameInMap("SchemaTableNames")]
        [Validation(Required=false)]
        public List<string> SchemaTableNames { get; set; }

        /// <summary>
        /// <para>The total number of returned results. The value is an integer that is greater than or equal to 0. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
