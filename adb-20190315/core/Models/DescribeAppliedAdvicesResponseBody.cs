// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAppliedAdvicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried suggestions.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAppliedAdvicesResponseBodyItems> Items { get; set; }
        public class DescribeAppliedAdvicesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The suggestion ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7417db9c-914d-43f3-a123-4d0e448f****</para>
            /// </summary>
            [NameInMap("AdviceId")]
            [Validation(Required=false)]
            public string AdviceId { get; set; }

            /// <summary>
            /// <para>The benefit of the suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.4 GB of storage saved</para>
            /// </summary>
            [NameInMap("Benefit")]
            [Validation(Required=false)]
            public string Benefit { get; set; }

            /// <summary>
            /// <para>The SQL statement that is used to execute the BUILD job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>build table <c>schema1</c>.<c>table1</c></para>
            /// </summary>
            [NameInMap("BuildSQL")]
            [Validation(Required=false)]
            public string BuildSQL { get; set; }

            [NameInMap("IndexFields")]
            [Validation(Required=false)]
            public string IndexFields { get; set; }

            /// <summary>
            /// <para>The state of the suggestion execution job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SUCCEED</b></description></item>
            /// <item><description><b>FAILED</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEED</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <para>The page number. Pages start from 1. Default value: 1.</para>
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
            /// <item><description><b>30</b> (default)</description></item>
            /// <item><description><b>50</b></description></item>
            /// <item><description><b>100</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The SQL statement that is used to roll back the suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alter table <c>schema1</c>.<c>table1</c> add key col1_1_idx(col1)</para>
            /// </summary>
            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }

            /// <summary>
            /// <para>The SQL statement that is used to apply the suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alter table <c>schema1</c>.<c>table1</c> drop key col1_1_idx</para>
            /// </summary>
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public string SQL { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb_demo</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The submission state of the suggestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SUCCEED</b></description></item>
            /// <item><description><b>FAILED</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEED</para>
            /// </summary>
            [NameInMap("SubmitStatus")]
            [Validation(Required=false)]
            public string SubmitStatus { get; set; }

            /// <summary>
            /// <para>The time when the suggestion was submitted. The time follows the ISO 8601 standard in the yyMMddHHmm format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2208131600</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The total number of entries returned. Minimum value: 0. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
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
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
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
        /// <para>The names of the tables in the DatabaseName.TableName format.</para>
        /// </summary>
        [NameInMap("SchemaTableNames")]
        [Validation(Required=false)]
        public List<string> SchemaTableNames { get; set; }

        /// <summary>
        /// <para>The total number of entries returned. The value is an integer that is greater than or equal to 0. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
