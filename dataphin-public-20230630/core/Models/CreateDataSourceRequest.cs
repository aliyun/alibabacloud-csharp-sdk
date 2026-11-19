// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The request object.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateDataSourceRequestCreateCommand CreateCommand { get; set; }
        public class CreateDataSourceRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The development environment data source.</para>
            /// </summary>
            [NameInMap("DevDataSourceCreate")]
            [Validation(Required=false)]
            public CreateDataSourceRequestCreateCommandDevDataSourceCreate DevDataSourceCreate { get; set; }
            public class CreateDataSourceRequestCreateCommandDevDataSourceCreate : TeaModel {
                /// <summary>
                /// <para>The development environment data source.</para>
                /// </summary>
                [NameInMap("DataSourceCreate")]
                [Validation(Required=false)]
                public CreateDataSourceRequestCreateCommandDevDataSourceCreateDataSourceCreate DataSourceCreate { get; set; }
                public class CreateDataSourceRequestCreateCommandDevDataSourceCreateDataSourceCreate : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to check the connectivity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CheckActivity")]
                    [Validation(Required=false)]
                    public bool? CheckActivity { get; set; }

                    /// <summary>
                    /// <para>The list of connection configuration items.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("ConfigItemList")]
                    [Validation(Required=false)]
                    public List<CreateDataSourceRequestCreateCommandDevDataSourceCreateDataSourceCreateConfigItemList> ConfigItemList { get; set; }
                    public class CreateDataSourceRequestCreateCommandDevDataSourceCreateDataSourceCreateConfigItemList : TeaModel {
                        /// <summary>
                        /// <para>The configuration item key. For the key values required by different databases, refer to the supplementary instructions below.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>jdbc.username</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the configuration item.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>username</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>datasource for xxx in dev</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the data source.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dp_test_dev</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The data source type.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MAX_COMPUTE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The ID of the associated production environment data source. This parameter is required if you only create a compute source for the development environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1011</para>
                /// </summary>
                [NameInMap("ProdDataSourceId")]
                [Validation(Required=false)]
                public long? ProdDataSourceId { get; set; }

            }

            /// <summary>
            /// <para>The production environment data source.</para>
            /// </summary>
            [NameInMap("ProdDataSourceCreate")]
            [Validation(Required=false)]
            public CreateDataSourceRequestCreateCommandProdDataSourceCreate ProdDataSourceCreate { get; set; }
            public class CreateDataSourceRequestCreateCommandProdDataSourceCreate : TeaModel {
                /// <summary>
                /// <para>Specifies whether to check the connectivity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CheckActivity")]
                [Validation(Required=false)]
                public bool? CheckActivity { get; set; }

                /// <summary>
                /// <para>The list of connection configuration items.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ConfigItemList")]
                [Validation(Required=false)]
                public List<CreateDataSourceRequestCreateCommandProdDataSourceCreateConfigItemList> ConfigItemList { get; set; }
                public class CreateDataSourceRequestCreateCommandProdDataSourceCreateConfigItemList : TeaModel {
                    /// <summary>
                    /// <para>The configuration item key. For the key values required by different databases, refer to the supplementary instructions below.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>jdbc.username</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the configuration item.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>username</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The description of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datasource for xx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the data source.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dp_test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The data source type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MAX_COMPUTE</description></item>
                /// <item><description>HDFS</description></item>
                /// <item><description>LOG_HUB</description></item>
                /// <item><description>POLARDB</description></item>
                /// <item><description>HBASE_0_9_4</description></item>
                /// <item><description>HBASE_1_1_X</description></item>
                /// <item><description>DRDS</description></item>
                /// <item><description>HIVE</description></item>
                /// <item><description>FTP</description></item>
                /// <item><description>ELASTIC_SEARCH</description></item>
                /// <item><description>MYSQL</description></item>
                /// <item><description>MONGODB</description></item>
                /// <item><description>OSS</description></item>
                /// <item><description>HANA</description></item>
                /// <item><description>SQL_SERVER</description></item>
                /// <item><description>POSTGRE_SQL</description></item>
                /// <item><description>ANALYTICDB</description></item>
                /// <item><description>ADB_FOR_MYSQL_V3</description></item>
                /// <item><description>ADB_FOR_PG</description></item>
                /// <item><description>ORACLE</description></item>
                /// <item><description>VERTICA</description></item>
                /// <item><description>DB2</description></item>
                /// <item><description>TERA_DATA</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MAX_COMPUTE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

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

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
