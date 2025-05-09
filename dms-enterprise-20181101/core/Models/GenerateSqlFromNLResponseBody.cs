// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GenerateSqlFromNLResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateSqlFromNLResponseBodyData Data { get; set; }
        public class GenerateSqlFromNLResponseBodyData : TeaModel {
            [NameInMap("KnowledgeReferences")]
            [Validation(Required=false)]
            public List<GenerateSqlFromNLResponseBodyDataKnowledgeReferences> KnowledgeReferences { get; set; }
            public class GenerateSqlFromNLResponseBodyDataKnowledgeReferences : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;Status\&quot;: \&quot;OK\&quot;}</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>verified</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sample_tbl</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            [NameInMap("SimilarSql")]
            [Validation(Required=false)]
            public List<GenerateSqlFromNLResponseBodyDataSimilarSql> SimilarSql { get; set; }
            public class GenerateSqlFromNLResponseBodyDataSimilarSql : TeaModel {
                [NameInMap("Question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.52</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SELECT * WHERE ResourceType = \&quot;ACS::ECS::Instance\&quot; AND ResourceGroupId != \&quot;rg-xxx\&quot;</para>
                /// </summary>
                [NameInMap("Sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                [NameInMap("Thought")]
                [Validation(Required=false)]
                public string Thought { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SELECT * FROM table WHERE condition;</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<GenerateSqlFromNLResponseBodyDataTables> Tables { get; set; }
            public class GenerateSqlFromNLResponseBodyDataTables : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ins_1.db1.table1</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>通过分析用户的问题和提供的知识，生成了相应的SQL语句。</para>
            /// </summary>
            [NameInMap("Thought")]
            [Validation(Required=false)]
            public string Thought { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
