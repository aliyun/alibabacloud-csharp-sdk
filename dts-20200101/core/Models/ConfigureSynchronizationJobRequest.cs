// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSynchronizationJobRequest : TeaModel {
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestDestinationEndpoint DestinationEndpoint { get; set; }
        public class ConfigureSynchronizationJobRequestDestinationEndpoint : TeaModel {
            /// <summary>
            /// <para>目标实例中的同步对象所属数据库名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DataBaseName")]
            [Validation(Required=false)]
            public string DataBaseName { get; set; }

            /// <summary>
            /// <para>目标库的IP地址。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>取值为<b>Express</b>、<b>dg</b>或<b>cen</b>时，本参数必须传入本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.88.***</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>同步目标实例的实例ID</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>取值为<b>MaxCompute</b>或<b>DataHub</b>时，本参数传入MaxCompute实例或DataHub的Project名称。
            /// 当目标实例为阿里云分析型数据库MySQL版时，传入分析型数据库MySQL版的集群ID。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1r46452ai50****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>目标实例类型，取值为：</para>
            /// <list type="bullet">
            /// <item><description><b>Redis</b>：阿里云Redis实例。</description></item>
            /// <item><description><b>RDS</b>：阿里云RDS实例。</description></item>
            /// <item><description><b>PolarDB</b>：阿里云PolarDB集群（仅支持MySQL或兼容Oracle语法的引擎）。</description></item>
            /// <item><description><b>ECS</b>：ECS上的自建数据库。</description></item>
            /// <item><description><b>Express</b>：通过专线接入的本地数据库。</description></item>
            /// <item><description><b>DataHub</b>：阿里云DataHub实例。</description></item>
            /// <item><description><b>MaxCompute</b>：阿里云MaxCompute实例。</description></item>
            /// <item><description><b>AnalyticDB</b>：云原生数据仓库AnalyticDB MySQL  3.0和2.0版本。</description></item>
            /// <item><description><b>Greenplum</b>：云原生数据仓库ADB PostgreSQL版（原分析型数据库PostgreSQL版）。</description></item>
            /// </list>
            /// <remarks>
            /// <para>默认取值为<b>RDS</b>。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>目标库数据库账号密码。</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>当<b>DestinationEndpoint.InstanceType</b>取值为<b>ECS</b>、<b>Express</b>、<b>dg</b>或<b>cen</b>时，本参数必须传入。</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Test654321</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>目标库的数据库服务端口。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>取值为<b>ECS</b>、<b>Express</b>、<b>dg</b>或<b>cen</b>时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>目标库的数据库账号。</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>同步不同的数据库所需的权限有所差异，详情请参见<a href="https://help.aliyun.com/document_detail/140954.html">DTS数据同步方案概览</a>中对应的配置案例。</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>当<b>DestinationEndpoint.InstanceType</b>取值为<b>ECS</b>、<b>Express</b>、<b>dg</b>或<b>cen</b>时，本参数必须传入。</description></item>
            /// <item><description>当<b>DestinationEndpoint.InstanceType</b>取值为RDS且数据库版本为MySQL 5.5或MySQL 5.6，无需传入本参数和<b>DestinationEndpoint.Password</b>参数。</description></item>
            /// <item><description>当<b>DestinationEndpoint.InstanceType</b>取值为<b>Redis</b>时，无需传入本参数。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestaccount</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("PartitionKey")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestPartitionKey PartitionKey { get; set; }
        public class ConfigureSynchronizationJobRequestPartitionKey : TeaModel {
            /// <summary>
            /// <para>设置增量日志表是否包含以增量更新时间对应日期信息定义的分区，取值：<b>true</b>或<b>false</b>。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>参数取值为<b>Maxcompute</b>时，本参数才可用。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModifyTime_Day")]
            [Validation(Required=false)]
            public bool? ModifyTimeDay { get; set; }

            /// <summary>
            /// <para>设置增量日志表是否包含以增量更新时间对应小时信息定义的分区，取值：<b>true</b>或<b>false</b>。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>参数取值为<b>Maxcompute</b>时，本参数才可用。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModifyTime_Hour")]
            [Validation(Required=false)]
            public bool? ModifyTimeHour { get; set; }

            /// <summary>
            /// <para>设置增量日志表是否包含以增量更新时间对应分钟信息定义的分区，取值：<b>true</b>或<b>false</b>。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>参数取值为<b>Maxcompute</b>时，本参数才可用。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModifyTime_Minute")]
            [Validation(Required=false)]
            public bool? ModifyTimeMinute { get; set; }

            /// <summary>
            /// <para>设置增量日志表是否包含以增量更新时间对应月份信息定义的分区，取值：<b>true</b>或<b>false</b>。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>参数取值为<b>Maxcompute</b>时，本参数才可用。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModifyTime_Month")]
            [Validation(Required=false)]
            public bool? ModifyTimeMonth { get; set; }

            /// <summary>
            /// <para>设置增量日志表是否包含以增量更新时间对应年份信息定义的分区，取值：<b>true</b>或<b>false</b>。</para>
            /// <remarks>
            /// <para>当<b>DestinationEndpoint.InstanceType</b>参数取值为<b>Maxcompute</b>时，本参数才可用。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ModifyTime_Year")]
            [Validation(Required=false)]
            public bool? ModifyTimeYear { get; set; }

        }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigureSynchronizationJobRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// <para>源实例中的同步对象所属数据库名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>源库的IP地址。</para>
            /// <remarks>
            /// <para>当<b>SourceEndpoint.InstanceType</b>取值为<b>ECS</b>、<b>Express</b>、<b>dg</b>或<b>cen</b>时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.88.***</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>源实例ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1i99e8l7913****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>源实例类型，取值为：</para>
            /// <list type="bullet">
            /// <item><description><b>RDS</b>：阿里云RDS实例。</description></item>
            /// <item><description><b>Redis</b>：阿里云Redis实例。</description></item>
            /// <item><description><b>PolarDB</b>：阿里云PolarDB集群（仅支持MySQL或兼容Oracle语法的引擎）。</description></item>
            /// <item><description><b>ECS</b>：ECS上的自建数据库。</description></item>
            /// <item><description><b>Express</b>：通过专线接入的自建数据库。</description></item>
            /// <item><description><b>dg</b>：通过数据库网关DG接入的自建数据库。</description></item>
            /// <item><description><b>cen</b>：通过云企业网CEN接入的自建数据库。</description></item>
            /// </list>
            /// <remarks>
            /// <para>默认取值为<b>RDS</b>。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>源RDS实例所属的阿里云账号ID。</para>
            /// <remarks>
            /// <para>传入本参数即代表执行跨阿里云账号的数据同步，同时您还需要传入<b>SourceEndpoint.Role</b>参数。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>140692647406****</para>
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// <para>源库数据库账号密码。</para>
            /// <remarks>
            /// <para>当<b>SourceEndpoint.InstanceType</b>取值为<b>ECS</b>、<b>Express</b>、<b>dg</b>或<b>cen</b>时，本参数必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Test123456</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>源库的数据库服务端口。</para>
            /// <remarks>
            /// <para>当<b>SourceEndpoint.InstanceType</b>取值为<b>ECS</b>、<b>Express</b>、<b>dg</b>或<b>cen</b>时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>源实例所属云账号配置的角色名称。</para>
            /// <remarks>
            /// <para>执行跨阿里云账号的数据同步时须传入本参数，该角色所需的权限及授权方式请参见<a href="https://help.aliyun.com/document_detail/48468.html">跨阿里云账号数据迁移或同步时如何配置RAM授权</a>。</para>
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
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>当<b>SourceEndpoint.InstanceType</b>取值为<b>ECS</b>、<b>Express</b>、<b>dg</b>或<b>cen</b>时，本参数才可用且必须传入。</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>当<b>SourceEndpoint.InstanceType</b>取值为<b>Redis</b>时，本参数无需传入。</description></item>
            /// <item><description>同步不同的数据库所需的权限有所差异，详情请参见<a href="https://help.aliyun.com/document_detail/140954.html">DTS数据同步方案概览</a>中对应的配置案例。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestaccount</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because it will be discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The synchronization checkpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1610540493</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform initial full data synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b>: no.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>true</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataInitialization")]
        [Validation(Required=false)]
        public bool? DataInitialization { get; set; }

        /// <summary>
        /// <para>The reserved parameter of DTS. The value is a JSON string. You can specify this parameter to meet special requirements, such as specifying whether to automatically start the precheck. For more information, see <a href="https://help.aliyun.com/document_detail/176470.html">MigrationReserved parameter description</a>.</para>
        /// <remarks>
        /// <para>For example, you can use this parameter for data synchronization between ApsaraDB for Redis Enhanced Edition (Tair) instances. For more information, see <a href="https://help.aliyun.com/document_detail/155967.html">Use OpenAPI to configure one-way or bidirectional data synchronization between ApsaraDB for Redis Enhanced Edition instances</a>.</para>
        /// </remarks>
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
        /// <para>The ID of the region where the data synchronization instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
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

        /// <summary>
        /// <para>Specifies whether to perform initial schema synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b>: no.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>true</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StructureInitialization")]
        [Validation(Required=false)]
        public bool? StructureInitialization { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b>: forward.</description></item>
        /// <item><description><b>Reverse</b>: reverse.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>Forward</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if you set it to <b>Reverse</b> and the synchronization topology of the data synchronization instance is two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>The ID of the data synchronization instance. You can call the <a href="https://help.aliyun.com/document_detail/49454.html">DescribeSynchronizationJobs</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsz4ao1dor13d****</para>
        /// </summary>
        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        /// <summary>
        /// <para>The name of the synchronization task.</para>
        /// <remarks>
        /// <para>Specify a descriptive name that makes it easy to identify the task. It does not need to be unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL同步</para>
        /// </summary>
        [NameInMap("SynchronizationJobName")]
        [Validation(Required=false)]
        public string SynchronizationJobName { get; set; }

        /// <summary>
        /// <para>The objects to be synchronized. The value is a JSON string and supports certain regular expressions. For more information, see <a href="https://help.aliyun.com/document_detail/141901.html">Synchronization object configuration</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;DBName&quot;:&quot;dtstestdata&quot;,&quot;TableIncludes&quot;:[{&quot;TableName&quot;:&quot;customer&quot;}]}]</para>
        /// </summary>
        [NameInMap("SynchronizationObjects")]
        [Validation(Required=false)]
        public string SynchronizationObjects { get; set; }

    }

}
