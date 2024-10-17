// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncJobAnalyzeResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1810E635-A2D7-428B-BAA9-85DAEB9B1A77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The analysis result of the schema synchronization task.</para>
        /// </summary>
        [NameInMap("StructSyncJobAnalyzeResult")]
        [Validation(Required=false)]
        public GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResult StructSyncJobAnalyzeResult { get; set; }
        public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResult : TeaModel {
            /// <summary>
            /// <para>The details of the analysis results.</para>
            /// </summary>
            [NameInMap("ResultList")]
            [Validation(Required=false)]
            public List<GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultResultList> ResultList { get; set; }
            public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultResultList : TeaModel {
                /// <summary>
                /// <para>The SQL script.</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public string Script { get; set; }

                /// <summary>
                /// <para>The name of the source table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>helloz_bak</para>
                /// </summary>
                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                /// <summary>
                /// <para>The name of the destination table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>helloz_bak</para>
                /// </summary>
                [NameInMap("TargetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

            }

            /// <summary>
            /// <para>The statistics on the analysis results.</para>
            /// </summary>
            [NameInMap("SummaryList")]
            [Validation(Required=false)]
            public List<GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultSummaryList> SummaryList { get; set; }
            public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultSummaryList : TeaModel {
                /// <summary>
                /// <para>The type of the comparison. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CREATE_TABLE</b>: compares the created tables.</description></item>
                /// <item><description><b>ALTER_TABLE</b>: compares the modified tables.</description></item>
                /// <item><description><b>EQUAL_TABLE</b>: compares the identical tables.</description></item>
                /// <item><description><b>PASS_TABLE</b>: compares the tables that are skipped during schema synchronization.</description></item>
                /// <item><description><b>NOT_COMPARE</b>: does not compare tables.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE_TABLE</para>
                /// </summary>
                [NameInMap("CompareType")]
                [Validation(Required=false)]
                public string CompareType { get; set; }

                /// <summary>
                /// <para>The number of tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
