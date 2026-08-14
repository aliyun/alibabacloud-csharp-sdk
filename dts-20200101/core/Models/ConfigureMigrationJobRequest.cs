// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureMigrationJobRequest : TeaModel {
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public ConfigureMigrationJobRequestDestinationEndpoint DestinationEndpoint { get; set; }
        public class ConfigureMigrationJobRequestDestinationEndpoint : TeaModel {
            /// <summary>
            /// <para>待迁入的数据库名称或鉴权数据库名称。 </para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>当<b>DestinationEndpoint.EngineName</b>取值为<b>PostgreSQL</b>、<b>DRDS</b>或<b>MongoDB</b>时，本参数才可用且必须传入。</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>当<b>DestinationEndpoint.EngineName</b>取值为<b>PostgreSQL</b>或<b>DRDS</b>时，传入待迁移的数据库名称；取值为<b>MongoDB</b>时，传入数据库账号的鉴权数据库名称。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdatabase</para>
            /// </summary>
            [NameInMap("DataBaseName")]
            [Validation(Required=false)]
            public string DataBaseName { get; set; }

            /// <summary>
            /// <para>目标库的数据库类型。取值：<b>MySQL</b>、<b>DRDS</b>、<b>SQLServer</b>、<b>PostgreSQL</b>、<b>PPAS</b>、<b>MongoDB</b>、<b>Redis</b>、<b>POLARDB</b>、<b>polardb_pg</b></para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>取值为<b>RDS</b>、<b>POLARDB</b>、<b>ECS</b>、<b>LocalInstance</b>或<b>Express</b>时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }

            /// <summary>
            /// <para>目标库的连接地址。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>取值为<b>LocalInstance</b>或<b>Express</b>时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.88.***</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>目标实例ID。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>取值为<b>RDS</b>、<b>ECS</b>、<b>MongoDB</b>、<b>Redis</b>、<b>DRDS</b>、<b>PetaData</b>、<b>OceanBase</b>、<b>POLARDB</b>、<b>PolarDB_o</b>、<b>AnalyticDB</b>或<b>Greenplum</b>时，本参数才可用且必须传入对应的实例ID（例如取值为<b>ECS</b>，则需要传入ECS实例ID）。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1r46452ai50****</para>
            /// </summary>
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            /// <summary>
            /// <para>目标库的实例类型，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>ECS</b>：ECS上的自建数据库。</description></item>
            /// <item><description><b>LocalInstance</b>：有公网IP的自建数据库。</description></item>
            /// <item><description><b>RDS</b>：阿里云RDS实例。</description></item>
            /// <item><description><b>DRDS</b>：阿里云PolarDB-X实例。</description></item>
            /// <item><description><b>MongoDB</b>：阿里云MongoDB实例。</description></item>
            /// <item><description><b>Redis</b>：阿里云Redis实例。</description></item>
            /// <item><description><b>PetaData</b>：阿里云HybridDB for MySQL实例。</description></item>
            /// <item><description><b>POLARDB</b>：阿里云PolarDB MySQL、PolarDB PostgreSQL。</description></item>
            /// <item><description><b>PolarDB_o</b>：阿里云PolarDB O引擎集群。</description></item>
            /// <item><description><b>AnalyticDB</b>：阿里云云原生数据仓库AnalyticDB MySQL 3.0和2.0版本。</description></item>
            /// <item><description><b>Greenplum</b>：阿里云云原生数据仓库AnalyticDB PostgreSQL。</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Oracle数据库的SID信息。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.EngineName</b>取值为<b>Oracle</b>，且<b>Oracle</b>数据库为非RAC实例时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testsid</para>
            /// </summary>
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

            /// <summary>
            /// <para>目标库数据库账号的密码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test123456</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>目标库的服务端口。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>取值为<b>ECS</b>、<b>LocalInstance</b>或<b>Express</b>时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>目标库所属的地域ID。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>取值为<b>LocalInstance</b>时，您可以传入<b>cn-hangzhou</b>或者离自建数据库地物理距离最近的地域ID，详情请参见<a href="https://help.aliyun.com/document_detail/141033.html">支持的地域列表</a>。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>目标库的数据库账号。</para>
            /// <para>说明 迁移不同的数据库所需的权限有所差异，详情请参见迁移方案概览中对应的配置案例。</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestaccount</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("MigrationMode")]
        [Validation(Required=false)]
        public ConfigureMigrationJobRequestMigrationMode MigrationMode { get; set; }
        public class ConfigureMigrationJobRequestMigrationMode : TeaModel {
            /// <summary>
            /// <para>是否进行全量数据迁移，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>：是。</description></item>
            /// <item><description><b>false</b>：否。</description></item>
            /// </list>
            /// <remarks>
            /// <para>DTS对全量数据迁移的支持情况因数据库类型不同而有所差异，详情请参见<a href="https://help.aliyun.com/document_detail/26618.html">支持的数据库和迁移类型</a>。</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataIntialization")]
            [Validation(Required=false)]
            public bool? DataIntialization { get; set; }

            /// <summary>
            /// <para>是否进行增量数据迁移，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>：是。</description></item>
            /// <item><description><b>false</b>：否。</description></item>
            /// </list>
            /// <remarks>
            /// <para>DTS对增量数据迁移的支持情况因数据库类型不同而有所差异，详情请参见<a href="https://help.aliyun.com/document_detail/26618.html">支持的数据库和迁移类型</a>。</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataSynchronization")]
            [Validation(Required=false)]
            public bool? DataSynchronization { get; set; }

            /// <summary>
            /// <para>是否进行结构迁移，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>：是。</description></item>
            /// <item><description><b>false</b>：否。</description></item>
            /// </list>
            /// <remarks>
            /// <para>DTS对结构迁移的支持情况因数据库类型不同而有所差异，详情请参见<a href="https://help.aliyun.com/document_detail/26618.html">支持的数据库和迁移类型</a>。</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StructureIntialization")]
            [Validation(Required=false)]
            public bool? StructureIntialization { get; set; }

        }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigureMigrationJobRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigureMigrationJobRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// <para>待迁移的数据库名称或鉴权数据库名称。</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>当<b>SourceEndpoint.EngineName</b>取值为<b>PostgreSQL</b>或<b>MongoDB</b>时，本参数才可用且必须传入。</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>当<b>SourceEndpoint.EngineName</b>取值为<b>PostgreSQL</b>时，传入待迁移的数据库名称；取值为<b>MongoDB</b>时，传入数据库账号的鉴权数据库名称。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdatabase</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>源库的数据库类型，取值：<b>MySQL</b>、<b>TiDB</b>、<b>SQLServer</b>、<b>PostgreSQL</b>、<b>Oracle</b>、<b>MongoDB</b>、<b>Redis</b>、<b>POLARDB</b>、<b>polardb_pg</b>。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>取值为<b>RDS</b>、<b>POLARDB</b>、<b>ECS</b>、<b>LocalInstance</b>或<b>Express</b>时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }

            /// <summary>
            /// <para>源库的连接地址。</para>
            /// <remarks>
            /// <para>当<b>SourceEndpoint.InstanceType</b>取值为<b>LocalInstance</b>或<b>Express</b>时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.88.***</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>源库的实例ID。</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>当<b>SourceEndpoint.InstanceType</b>取值为<b>RDS</b>、<b>ECS</b>、<b>Express</b>、<b>MongoDB</b>、<b>POLARDB</b>或<b>PolarDB_o</b>时，本参数才可用且必须传入对应的实例ID（例如取值为<b>ECS</b>，则本参数传入ECS实例的ID）。</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>当<b>SourceEndpoint.InstanceType</b>取值为<b>Express</b>时，本参数传入VPC ID（即专有网络ID）。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>bp-rmxxxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            /// <summary>
            /// <para>源库的实例类型，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>RDS</b>：阿里云RDS实例。</description></item>
            /// <item><description><b>ECS</b>：ECS上的自建数据库。</description></item>
            /// <item><description><b>LocalInstance</b>：有公网IP的自建数据库。</description></item>
            /// <item><description><b>Express</b>：通过专线/VPN网关/智能接入网关接入的自建数据库。</description></item>
            /// <item><description><b>dg</b>：通过数据库网关DG接入的自建数据库。</description></item>
            /// <item><description><b>cen</b>：通过云企业网CEN接入的自建数据库。</description></item>
            /// <item><description><b>MongoDB</b>：阿里云MongoDB实例。</description></item>
            /// <item><description><b>POLARDB</b>：阿里云PolarDB MySQL、PolarDB PostgreSQL。</description></item>
            /// <item><description><b>PolarDB_o</b>：阿里云PolarDB O引擎集群。</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Oracle数据库的SID信息。</para>
            /// <remarks>
            /// <para>当<b>SourceEndpoint.EngineName</b>取值为<b>Oracle</b>，且Oracle数据库为非RAC实例时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testsid</para>
            /// </summary>
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

            /// <summary>
            /// <para>源实例所属的阿里云账号ID。</para>
            /// <remarks>
            /// <para>仅在配置跨阿里云账号的数据迁移时本参数才可用，且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>140692647406****</para>
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// <para>源库数据库账号对应的密码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test123456</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>源库的服务端口。</para>
            /// <remarks>
            /// <para>当<b>SourceEndpoint.InstanceType</b>取值为<b>ECS</b>、<b>LocalInstance</b>或<b>Express</b>时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>源库所属的地域ID。</para>
            /// <remarks>
            /// <para>当<b>SourceEndpoint.InstanceType</b>取值为<b>LocalInstance</b>时，您可以传入<b>cn-hangzhou</b>或者离自建数据库地物理距离最近的地域ID，详情请参见<a href="https://help.aliyun.com/document_detail/141033.html">支持的地域列表</a>。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>当源实例与目标实例所属阿里云账号不同时，需传入该参数，来指定源实例的授权角色，以允许目标实例阿里云账号访问源实例的实例信息。</para>
            /// <remarks>
            /// <para>角色所需的权限及授权方式，请参见<a href="https://help.aliyun.com/document_detail/48468.html">跨阿里云账号数据迁移或同步时如何配置RAM授权</a>。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ram-for-dts</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>源库的数据库账号。</para>
            /// <para>说明 迁移不同的数据库所需的权限有所差异，详情请参见迁移方案概览中对应的配置案例。</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestaccount</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The Alibaba Cloud account ID. You do not need to specify this parameter because it will be deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The start position of incremental data migration. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>The ID of the data migration instance. You can call the <b>DescribeMigrationJobs</b> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsxxxxxxxx</para>
        /// </summary>
        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        /// <summary>
        /// <para>The name of the migration task. The name can be up to 32 characters in length. Specify a descriptive name for easy identification. Uniqueness is not required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL_TO_RDS</para>
        /// </summary>
        [NameInMap("MigrationJobName")]
        [Validation(Required=false)]
        public string MigrationJobName { get; set; }

        /// <summary>
        /// <para>The objects to be migrated. The value is a JSON string that supports regular expressions. For more information, see <a href="~141901~">Migration object configuration</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;DBName&quot;:&quot;dtstestdata&quot;,&quot;TableIncludes&quot;:[{&quot;TableName&quot;:&quot;customer&quot;}]}]</para>
        /// </summary>
        [NameInMap("MigrationObject")]
        [Validation(Required=false)]
        public string MigrationObject { get; set; }

        /// <summary>
        /// <para>The reserved parameter of DTS. The value is a JSON string. You can specify this parameter to meet special requirements, such as whether to automatically start the precheck. For more information, see <a href="https://help.aliyun.com/document_detail/176470.html">MigrationReserved parameter description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;autoStartModulesAfterConfig&quot;: &quot;none&quot;,     &quot;targetTableMode&quot;: 2 }</para>
        /// </summary>
        [NameInMap("MigrationReserved")]
        [Validation(Required=false)]
        public string MigrationReserved { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the data migration instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <remarks>
        /// <para>The region ID must be the same as the region ID of the destination database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
