// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateBatchTaskRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateBatchTaskRequestCreateCommand CreateCommand { get; set; }
        public class CreateBatchTaskRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The catalog for a database SQL node. This parameter takes effect only for data source types that require a catalog, such as Presto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql_catalog</para>
            /// </summary>
            [NameInMap("DataSourceCatalog")]
            [Validation(Required=false)]
            public string DataSourceCatalog { get; set; }

            /// <summary>
            /// <para>The data source ID for a database SQL node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12131111</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The schema for a database SQL node. This parameter takes effect only for data source types that require a schema, such as Oracle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>erp</para>
            /// </summary>
            [NameInMap("DataSourceSchema")]
            [Validation(Required=false)]
            public string DataSourceSchema { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The folder path in the menu tree to which the node belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/a/b</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The execution engine for the node, such as a Python node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: PYTHON2_7</description></item>
            /// <item><description>2: PYTHON3_7</description></item>
            /// <item><description>3: PYTHON3_11.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PYTHON3_7</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The name of the batch task.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test111</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the node belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10121101</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The list of third-party Python packages that the node depends on.</para>
            /// </summary>
            [NameInMap("PythonModuleList")]
            [Validation(Required=false)]
            public List<string> PythonModuleList { get; set; }

            /// <summary>
            /// <para>The scheduling type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: periodic node.</description></item>
            /// <item><description>3: manual node.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public int? ScheduleType { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Hive_SQL: 1</description></item>
            /// <item><description>Hive_SQL_23X: 101</description></item>
            /// <item><description>HIVE_SQL_FUSION_INSIGHT_80X: 111</description></item>
            /// <item><description>COMMON_HIVE_SQL: 131</description></item>
            /// <item><description>HADOOP_MR: 2</description></item>
            /// <item><description>MaxCompute_SQL: 5</description></item>
            /// <item><description>MaxCompute_MR: 6</description></item>
            /// <item><description>SPARK_SQL_ON_MAX_COMPUTE: 7</description></item>
            /// <item><description>SPARK_JAR_ON_MAX_COMPUTE: 8</description></item>
            /// <item><description>SPARK_SQL_ON_HIVE: 17</description></item>
            /// <item><description>Spark_JAR_ON_HIVE: 18</description></item>
            /// <item><description>Shell: 10</description></item>
            /// <item><description>PAI_DESIGNER: 71</description></item>
            /// <item><description>DataX: 15</description></item>
            /// <item><description>Merge: 16</description></item>
            /// <item><description>Python: 21</description></item>
            /// <item><description>Python37x: 22</description></item>
            /// <item><description>Perl: 23</description></item>
            /// <item><description>Python311x: 24</description></item>
            /// <item><description>OneService_SQL: 25</description></item>
            /// <item><description>ONE_SERVICE_SQL_ADB_FOR_PG: 26</description></item>
            /// <item><description>OneService_SQL_Hive11x: 27</description></item>
            /// <item><description>OneService_SQL_Hive23x: 29</description></item>
            /// <item><description>ONE_SERVICE_SQL_TDH_INCEPTOR: 75</description></item>
            /// <item><description>ONE_SERVICE_SQL_HIVE_CDP: 91</description></item>
            /// <item><description>ONE_SERVICE_SQL_HIVE_ASIA_INFO_DP_53X: 92</description></item>
            /// <item><description>Dlink: 30</description></item>
            /// <item><description>ONE_SERVICE_SQL_ADB_FOR_MYSQL: 33</description></item>
            /// <item><description>Logical: 31</description></item>
            /// <item><description>Flink_Streaming: 41</description></item>
            /// <item><description>Flink_Batch: 42</description></item>
            /// <item><description>ADB_FOR_PG: 51</description></item>
            /// <item><description>DryRun: 100</description></item>
            /// <item><description>CHECK: 902</description></item>
            /// <item><description>VIRTUAL: 999</description></item>
            /// <item><description>INCEPTOR_SQL: 10000</description></item>
            /// <item><description>HOLOGRES_SQL: 28</description></item>
            /// <item><description>ARGODB_SQL: 76</description></item>
            /// <item><description>IMPALA_SQL: 78</description></item>
            /// <item><description>STARROCKS_SQL: 79</description></item>
            /// <item><description>SPARK_SQL: 80</description></item>
            /// <item><description>GAUSS_SQL: 81</description></item>
            /// <item><description>DATABASE_SQL: 998</description></item>
            /// <item><description>EXTERNAL_TRIGGER: 997.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
