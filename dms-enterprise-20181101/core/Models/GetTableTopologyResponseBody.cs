// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableTopologyResponseBody : TeaModel {
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
        /// <para>F5ED6A40-F344-4C7D-A8F0-5685CA584CA7</para>
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

        /// <summary>
        /// <para>The topology information.</para>
        /// </summary>
        [NameInMap("TableTopology")]
        [Validation(Required=false)]
        public GetTableTopologyResponseBodyTableTopology TableTopology { get; set; }
        public class GetTableTopologyResponseBodyTableTopology : TeaModel {
            /// <summary>
            /// <para>Indicates whether the table is a logical table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// <para>The GUID of the table in DMS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IDB_L_308302.yuyang_test.test_ch</para>
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_ch</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>Information of the topology of the table.</para>
            /// </summary>
            [NameInMap("TableTopologyInfoList")]
            [Validation(Required=false)]
            public List<GetTableTopologyResponseBodyTableTopologyTableTopologyInfoList> TableTopologyInfoList { get; set; }
            public class GetTableTopologyResponseBodyTableTopologyTableTopologyInfoList : TeaModel {
                /// <summary>
                /// <para>The ID of the physical database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43215</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yuyang_test</para>
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <para>The name that is used to search for the database.</para>
                /// <remarks>
                /// <para>We recommend that you do not use this parameter for business development. The format of the parameter value may be modified in later versions.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>yuyang_test@localhost:3306
                /// [yuyang_test_dev]</para>
                /// </summary>
                [NameInMap("DbSearchName")]
                [Validation(Required=false)]
                public string DbSearchName { get; set; }

                /// <summary>
                /// <para>The database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The ID of the instance to which the physical database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4325325</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the resource related to the instance. The resource corresponds with the database instance type returned in the InstanceSource parameter.</para>
                /// <list type="bullet">
                /// <item><description><b>RDS</b>:The ID of the ApsaraDB RDS instance.</description></item>
                /// <item><description><b>ECS_OWN</b>: The ID of the Elastic Compute Service (ECS) instance.</description></item>
                /// <item><description><b>PUBLIC_OWN</b>: This parameter is left empty for self-managed database instances that are connected over the Internet.</description></item>
                /// <item><description><b>VPC_ID</b>:The ID of the virtual private cloud (VPC).</description></item>
                /// <item><description><b>GATEWAY</b>: The ID of the database gateway.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>rm-xxx</para>
                /// </summary>
                [NameInMap("InstanceResourceId")]
                [Validation(Required=false)]
                public string InstanceResourceId { get; set; }

                /// <summary>
                /// <para>The type of the database instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RDS</b>: an ApsaraDB RDS instance.</description></item>
                /// <item><description><b>ECS_OWN</b>: a self-managed database that is deployed on an ECS instance</description></item>
                /// <item><description><b>PUBLIC_OWN</b>: a self-managed database instance that is connected over the Internet.</description></item>
                /// <item><description><b>VPC_ID</b>: a self-managed database instance in a VPC that is connected over Express Connect circuits.</description></item>
                /// <item><description><b>GATEWAY</b>: a database instance connected by using a database gateway.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RDS</para>
                /// </summary>
                [NameInMap("InstanceSource")]
                [Validation(Required=false)]
                public string InstanceSource { get; set; }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The number of tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("TableCount")]
                [Validation(Required=false)]
                public long? TableCount { get; set; }

                /// <summary>
                /// <para>The expression of the names of logical tables.</para>
                /// <para>**</para>
                /// <para><b>Description</b> This parameter is not returned for physical tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_ch_[0000-0005]</para>
                /// </summary>
                [NameInMap("TableNameExpr")]
                [Validation(Required=false)]
                public string TableNameExpr { get; set; }

                /// <summary>
                /// <para>The names of tables.</para>
                /// <remarks>
                /// <para>The table names are separated by commas (,).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test_ch_0000,test_ch_0001,test_ch_0002,test_ch_0003,test_ch_0004,test_ch_0005</para>
                /// </summary>
                [NameInMap("TableNameList")]
                [Validation(Required=false)]
                public string TableNameList { get; set; }

            }

        }

    }

}
