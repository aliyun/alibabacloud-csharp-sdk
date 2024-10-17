// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDBTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>The topology of the data table.</para>
        /// </summary>
        [NameInMap("DBTopology")]
        [Validation(Required=false)]
        public GetDBTopologyResponseBodyDBTopology DBTopology { get; set; }
        public class GetDBTopologyResponseBodyDBTopology : TeaModel {
            /// <summary>
            /// <para>The alias of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logic_db_test</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The list of database splitting topology information.</para>
            /// </summary>
            [NameInMap("DBTopologyInfoList")]
            [Validation(Required=false)]
            public List<GetDBTopologyResponseBodyDBTopologyDBTopologyInfoList> DBTopologyInfoList { get; set; }
            public class GetDBTopologyResponseBodyDBTopologyDBTopologyInfoList : TeaModel {
                /// <summary>
                /// <para>The name of the catalog to which the database belongs.</para>
                /// <remarks>
                /// <para>If the database is a PostgreSQL database, the value of this parameter is the name of the database.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>def</para>
                /// </summary>
                [NameInMap("CatalogName")]
                [Validation(Required=false)]
                public string CatalogName { get; set; }

                /// <summary>
                /// <para>The ID of the database for which the schema design is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>423532</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>The type of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polardb</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The type of the environment to which the database belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>product: production environment</description></item>
                /// <item><description>dev: development environment</description></item>
                /// <item><description>pre: staging environment</description></item>
                /// <item><description>test: test environment</description></item>
                /// <item><description>sit: SIT environment</description></item>
                /// <item><description>uat: user acceptance testing (UAT) environment</description></item>
                /// <item><description>pet: stress testing environment</description></item>
                /// <item><description>stag: STAG environment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The ID of the instance. The valid value is returned if you call the ListInstances operation. The instance ID is not the ID of the RDS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4325325</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>Instance resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-xxx</para>
                /// </summary>
                [NameInMap("InstanceResourceId")]
                [Validation(Required=false)]
                public string InstanceResourceId { get; set; }

                /// <summary>
                /// <para>The source of the database instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PUBLIC_OWN:</b> a self-managed database instance that is deployed on the Internet</description></item>
                /// <item><description><b>RDS:</b> an ApsaraDB RDS instance</description></item>
                /// <item><description><b>ECS_OWN:</b> a self-managed database that is deployed on an Elastic Compute Service (ECS) instance</description></item>
                /// <item><description><b>VPC_IDC:</b> a self-managed database instance that is deployed in a data center connected over a virtual private cloud (VPC)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RDS</para>
                /// </summary>
                [NameInMap("InstanceSource")]
                [Validation(Required=false)]
                public string InstanceSource { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the logical database.</para>
                /// <remarks>
                /// <para>If the database is a PostgreSQL database, the value of this parameter is the name of the database schema.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>db_test@rm-xxx:3306</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The name of the saved search.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db_test</para>
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            /// <summary>
            /// <para>The type of the database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The type of the environment in which the database instance is deployed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>product: production environment</description></item>
            /// <item><description>dev: development environment</description></item>
            /// <item><description>pre: pre-release environment</description></item>
            /// <item><description>test: test environment</description></item>
            /// <item><description>sit: system integration testing (SIT) environment</description></item>
            /// <item><description>uat: user acceptance testing (UAT) environment</description></item>
            /// <item><description>pet: stress testing environment</description></item>
            /// <item><description>stag: staging environment</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The ID of the logical database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("LogicDbId")]
            [Validation(Required=false)]
            public long? LogicDbId { get; set; }

            /// <summary>
            /// <para>Logical database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logic_db_test</para>
            /// </summary>
            [NameInMap("LogicDbName")]
            [Validation(Required=false)]
            public string LogicDbName { get; set; }

            /// <summary>
            /// <para>The name of the saved search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logic_db_test</para>
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

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
        /// <para>The error message returned if the request failed.</para>
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
        /// <para>C5B8E84B-42B6-4374-AD5A-6264E1753378</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
