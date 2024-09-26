// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConnectionStatusRequest : TeaModel {
        /// <summary>
        /// <para>You must specify this parameter only if the <b>SourceEndpointEngineName</b> parameter is set to <b>Oracle</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SID</b>: non-RAC architecture</description></item>
        /// <item><description><b>RAC</b>: Real Application Cluster (RAC) architecture</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is optional. The data type of this parameter is String.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SID</para>
        /// </summary>
        [NameInMap("DestinationEndpointArchitecture")]
        [Validation(Required=false)]
        public string DestinationEndpointArchitecture { get; set; }

        /// <summary>
        /// <para>The name of the destination database or the authentication database.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter if the <b>DestinationEndpointEngineName</b> parameter is set to <b>PostgreSQL</b>, <b>DRDS</b>, or <b>MongoDB</b>. You must also specify this parameter if the <b>DestinationEndpointInstanceType</b> parameter is set to <b>PolarDB_o</b>.</description></item>
        /// <item><description>If the <b>DestinationEndpointEngineName</b> parameter is set to <b>PostgreSQL</b> or <b>DRDS</b>, specify the name of the destination database. If the DestinationEndpointEngineName parameter is set to <b>MongoDB</b>, specify the name of the authentication database.</description></item>
        /// <item><description>If the <b>DestinationEndpointInstanceType</b> parameter is set to <b>PolarDB_o</b>, specify the name of the destination database.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dtstestdata</para>
        /// </summary>
        [NameInMap("DestinationEndpointDatabaseName")]
        [Validation(Required=false)]
        public string DestinationEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The engine type of the destination database. Valid values: <b>MySQL</b>, <b>DRDS</b>, <b>SQLServer</b>, <b>PostgreSQL</b>, <b>PPAS</b>, <b>MongoDB</b>, and <b>Redis</b>.</para>
        /// <remarks>
        /// <para> You must specify this parameter only if the <b>DestinationEndpointInstanceType</b> parameter is set to <b>RDS</b>, <b>DRDS</b>, <b>ECS</b>, <b>LocalInstance</b>, or <b>Express</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DestinationEndpointEngineName")]
        [Validation(Required=false)]
        public string DestinationEndpointEngineName { get; set; }

        /// <summary>
        /// <para>The endpoint of the destination database.</para>
        /// <remarks>
        /// <para> You must specify this parameter only if the <b>DestinationEndpointInstanceType</b> parameter is set to <b>LocalInstance</b> or <b>Express</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.88.***</para>
        /// </summary>
        [NameInMap("DestinationEndpointIP")]
        [Validation(Required=false)]
        public string DestinationEndpointIP { get; set; }

        /// <summary>
        /// <para>The ID of the destination instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testsid</para>
        /// </summary>
        [NameInMap("DestinationEndpointInstanceID")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The instance type of the destination database. Valid values:</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>ECS</b>: self-managed database that is hosted on Elastic Compute Service (ECS)</description></item>
        /// <item><description><b>LocalInstance</b>: self-managed database with a public IP address</description></item>
        /// <item><description><b>RDS</b>: ApsaraDB RDS instance</description></item>
        /// <item><description><b>DRDS</b>: PolarDB-X instance</description></item>
        /// <item><description><b>MongoDB</b>: ApsaraDB for MongoDB instance</description></item>
        /// <item><description><b>Redis</b>: ApsaraDB for Redis instance</description></item>
        /// <item><description><b>PetaData</b>: HybridDB for MySQL instance</description></item>
        /// <item><description><b>POLARDB</b>: PolarDB for MySQL cluster</description></item>
        /// <item><description><b>PolarDB_o</b>: PolarDB for Oracle cluster</description></item>
        /// <item><description><b>AnalyticDB</b>: AnalyticDB for MySQL cluster V3.0 or V2.0</description></item>
        /// <item><description><b>Greenplum</b>: AnalyticDB for PostgreSQL instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarDB_o</para>
        /// </summary>
        [NameInMap("DestinationEndpointInstanceType")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceType { get; set; }

        /// <summary>
        /// <para>You must specify this parameter only if the <b>DestinationEndpointEngineName</b> parameter is set to <b>Oracle</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SID</b>: non-RAC architecture</description></item>
        /// <item><description><b>RAC</b>: RAC architecture</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is optional. The data type of this parameter is String.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SID</para>
        /// </summary>
        [NameInMap("DestinationEndpointOracleSID")]
        [Validation(Required=false)]
        public string DestinationEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The password of the destination database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("DestinationEndpointPassword")]
        [Validation(Required=false)]
        public string DestinationEndpointPassword { get; set; }

        /// <summary>
        /// <para>The service port number of the source database.</para>
        /// <remarks>
        /// <para> You must specify this parameter only if the <b>SourceEndpointInstanceType</b> parameter is set to <b>ECS</b>, <b>LocalInstance</b>, or <b>Express</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DestinationEndpointPort")]
        [Validation(Required=false)]
        public string DestinationEndpointPort { get; set; }

        /// <summary>
        /// <para>The ID of the region where the destination instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestinationEndpointRegion")]
        [Validation(Required=false)]
        public string DestinationEndpointRegion { get; set; }

        /// <summary>
        /// <para>The database account of the destination database.</para>
        /// <remarks>
        /// <para> The permissions that are required for database accounts vary with the migration or synchronization scenario. For more information, see <a href="https://help.aliyun.com/document_detail/26618.html">Overview of data migration scenarios</a> and <a href="https://help.aliyun.com/document_detail/130744.html">Overview of data synchronization scenarios</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("DestinationEndpointUserName")]
        [Validation(Required=false)]
        public string DestinationEndpointUserName { get; set; }

        /// <summary>
        /// <para>The ID of the region where the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>You must specify this parameter only if the <b>SourceEndpointEngineName</b> parameter is set to <b>Oracle</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SID</b>: non-RAC architecture</description></item>
        /// <item><description><b>RAC</b>: RAC architecture</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is optional.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SID</para>
        /// </summary>
        [NameInMap("SourceEndpointArchitecture")]
        [Validation(Required=false)]
        public string SourceEndpointArchitecture { get; set; }

        /// <summary>
        /// <para>The name of the source database or the authentication database.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter if the <b>SourceEndpointEngineName</b> parameter is set to <b>PostgreSQL</b> or <b>MongoDB</b>. You must also specify this parameter if the <b>SourceEndpointInstanceType</b> parameter is set to <b>PolarDB_o</b>.</description></item>
        /// <item><description>If the <b>SourceEndpointEngineName</b> parameter is set to <b>PostgreSQL</b> or <b>DRDS</b>, specify the name of the source database. If the SourceEndpointEngineName parameter is set to <b>MongoDB</b>, specify the name of the authentication database.</description></item>
        /// <item><description>If the <b>SourceEndpointInstanceType</b> parameter is set to <b>PolarDB_o</b>, specify the name of the source database.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dtstestdata</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The engine type of the source database. Valid values: <b>MySQL</b>, <b>TiDB</b>, <b>SQLServer</b>, <b>PostgreSQL</b>, <b>Oracle</b>, <b>MongoDB</b>, and <b>Redis</b>.</para>
        /// <remarks>
        /// <para> Default value: <b>MySQL</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("SourceEndpointEngineName")]
        [Validation(Required=false)]
        public string SourceEndpointEngineName { get; set; }

        /// <summary>
        /// <para>The endpoint of the source database.</para>
        /// <remarks>
        /// <para> You must specify this parameter only if the <b>SourceEndpointInstanceType</b> parameter is set to <b>LocalInstance</b> or <b>Express</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.88.***</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The ID of the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1imrtn6fq7h****</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The type of the source instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: ApsaraDB RDS instance</description></item>
        /// <item><description><b>LocalInstance</b>: self-managed database with a public IP address</description></item>
        /// <item><description><b>ECS</b>: self-managed database that is hosted on ECS</description></item>
        /// <item><description><b>Express</b>: self-managed database that is connected over Express Connect</description></item>
        /// <item><description><b>dg</b>: self-managed database that is connected over Database Gateway</description></item>
        /// <item><description><b>MongoDB</b>: ApsaraDB for MongoDB instance</description></item>
        /// <item><description><b>POLARDB</b>: PolarDB for MySQL cluster</description></item>
        /// <item><description><b>PolarDB_o</b>: PolarDB for Oracle cluster</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceType")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceType { get; set; }

        /// <summary>
        /// <para>The SID of the Oracle database.</para>
        /// <remarks>
        /// <para> You must specify this parameter only if the <b>SourceEndpointEngineName</b> parameter is set to <b>Oracle</b> and the Oracle database is deployed in a non-RAC architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testsid</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The password of the source database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The service port number of the source database.</para>
        /// <remarks>
        /// <para> You must specify this parameter only if the <b>SourceEndpointInstanceType</b> parameter is set to <b>ECS</b>, <b>LocalInstance</b>, or <b>Express</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public string SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The ID of the region where the source instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// <para>The database account of the source database.</para>
        /// <remarks>
        /// <para> The permissions that are required for database accounts vary with the migration or synchronization scenario. For more information, see <a href="https://help.aliyun.com/document_detail/26618.html">Overview of data migration scenarios</a> and <a href="https://help.aliyun.com/document_detail/130744.html">Overview of data synchronization scenarios</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

    }

}
