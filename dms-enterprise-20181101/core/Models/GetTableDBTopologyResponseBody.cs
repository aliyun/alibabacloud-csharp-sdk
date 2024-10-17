// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableDBTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>The topology of the data table.</para>
        /// </summary>
        [NameInMap("DBTopology")]
        [Validation(Required=false)]
        public GetTableDBTopologyResponseBodyDBTopology DBTopology { get; set; }
        public class GetTableDBTopologyResponseBodyDBTopology : TeaModel {
            /// <summary>
            /// <para>The data sources.</para>
            /// </summary>
            [NameInMap("DataSourceList")]
            [Validation(Required=false)]
            public List<GetTableDBTopologyResponseBodyDBTopologyDataSourceList> DataSourceList { get; set; }
            public class GetTableDBTopologyResponseBodyDBTopologyDataSourceList : TeaModel {
                /// <summary>
                /// <para>The physical databases.</para>
                /// </summary>
                [NameInMap("DatabaseList")]
                [Validation(Required=false)]
                public List<GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseList> DatabaseList { get; set; }
                public class GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>489347</para>
                    /// </summary>
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public string DbId { get; set; }

                    /// <summary>
                    /// <para>The name of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>db-test</para>
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// <para>The type of the database. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL</para>
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// <para>The type of the environment to which the database belongs. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>product</b>: production environment</description></item>
                    /// <item><description><b>dev</b>: development environment</description></item>
                    /// <item><description><b>pre</b>: pre-release environment</description></item>
                    /// <item><description><b>test</b>: test environment</description></item>
                    /// <item><description><b>sit</b>: system integration testing (SIT) environment</description></item>
                    /// <item><description><b>uat</b>: user acceptance testing (UAT) environment</description></item>
                    /// <item><description><b>pet</b>: stress testing environment</description></item>
                    /// <item><description><b>stag</b>: staging environment</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/163309.html">Change the environment type of an instance</a>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pre</para>
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// <para>The physical tables.</para>
                    /// </summary>
                    [NameInMap("TableList")]
                    [Validation(Required=false)]
                    public List<GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseListTableList> TableList { get; set; }
                    public class GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseListTableList : TeaModel {
                        /// <summary>
                        /// <para>The ID of the table.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NORMAL</para>
                        /// </summary>
                        [NameInMap("TableId")]
                        [Validation(Required=false)]
                        public string TableId { get; set; }

                        /// <summary>
                        /// <para>The name of the physical table.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>151977812</para>
                        /// </summary>
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                        /// <summary>
                        /// <para>The type of the table. This is a reserved parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>yuyang_test_0000</para>
                        /// </summary>
                        [NameInMap("TableType")]
                        [Validation(Required=false)]
                        public string TableType { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of the database. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The endpoint of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.mysql.polardb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The port that is used to connect to the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The system ID (SID) of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>def</para>
                /// </summary>
                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

            }

            /// <summary>
            /// <para>The GUID of the table in DMS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IDB_L_9032.db-test.yuyang_test</para>
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>If a logical table is queried, the name of the logical table is returned.</para>
            /// </description></item>
            /// <item><description><para>If a physical table is queried, the name of the physical table is returned.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yuyang_test</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

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
        /// <para>853F7FD4-D922-4EFB-931C-D253EF159E06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
