// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListRecallManagementTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is reserved for future use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is reserved for future use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>A list of recall management tables.</para>
        /// </summary>
        [NameInMap("RecallManagementTables")]
        [Validation(Required=false)]
        public List<ListRecallManagementTablesResponseBodyRecallManagementTables> RecallManagementTables { get; set; }
        public class ListRecallManagementTablesResponseBodyRecallManagementTables : TeaModel {
            /// <summary>
            /// <para>Indicates whether the table can be deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CanDelete")]
            [Validation(Required=false)]
            public bool? CanDelete { get; set; }

            /// <summary>
            /// <para>The data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Api</para>
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// <para>The description of the recall management table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the table was created. The time is in the ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the table was last modified. The time is in the ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The time when the index takes effect. The time is in the ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("IndexEffectiveTime")]
            [Validation(Required=false)]
            public string IndexEffectiveTime { get; set; }

            /// <summary>
            /// <para>The ID of the index version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250701</para>
            /// </summary>
            [NameInMap("IndexVersionId")]
            [Validation(Required=false)]
            public string IndexVersionId { get; set; }

            /// <summary>
            /// <para>The name of the MaxCompute project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MaxcomputeProjectName")]
            [Validation(Required=false)]
            public string MaxcomputeProjectName { get; set; }

            /// <summary>
            /// <para>The schema of the MaxCompute table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("MaxcomputeSchema")]
            [Validation(Required=false)]
            public string MaxcomputeSchema { get; set; }

            /// <summary>
            /// <para>The name of the table in MaxCompute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table-1</para>
            /// </summary>
            [NameInMap("MaxcomputeTableName")]
            [Validation(Required=false)]
            public string MaxcomputeTableName { get; set; }

            /// <summary>
            /// <para>The name of the recall management table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table-123</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The partition fields of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dt</para>
            /// </summary>
            [NameInMap("PartitionFields")]
            [Validation(Required=false)]
            public string PartitionFields { get; set; }

            /// <summary>
            /// <para>The ID of the recall management table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RecallManagementTableId")]
            [Validation(Required=false)]
            public string RecallManagementTableId { get; set; }

            /// <summary>
            /// <para>The recall type of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>X2I</para>
            /// </summary>
            [NameInMap("RecallType")]
            [Validation(Required=false)]
            public string RecallType { get; set; }

            /// <summary>
            /// <para>The type of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Recall</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of recall management tables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
