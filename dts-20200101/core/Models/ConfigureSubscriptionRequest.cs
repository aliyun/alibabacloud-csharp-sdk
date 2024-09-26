// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>The UNIX timestamp that represents the start time of change tracking. Unit: seconds.</para>
        /// <remarks>
        /// <para> You can use a search engine to obtain a UNIX timestamp converter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1616902385</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>The objects for which you want to track data changes. The value must be a JSON string. For more information, see <a href="https://help.aliyun.com/document_detail/209545.html">Objects of DTS tasks</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dtstest&quot;:{&quot;name&quot;:&quot;dtstest&quot;,&quot;all&quot;:true}}</para>
        /// </summary>
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public string DbList { get; set; }

        /// <summary>
        /// <para>The ID of the DTS dedicated cluster on which the change tracking task is scheduled to run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_atyl3b5214uk***</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor the task latency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: monitors the task latency.</description></item>
        /// <item><description><b>false</b>: does not monitor the task latency.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DelayNotice")]
        [Validation(Required=false)]
        public bool? DelayNotice { get; set; }

        /// <summary>
        /// <para>The mobile numbers to which latency-related alerts are sent. Separate multiple mobile numbers with commas (,).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for users of the China site (aliyun.com). Only mobile numbers in the Chinese mainland are supported. You can specify up to 10 mobile numbers.</description></item>
        /// <item><description>Users of the international site (alibabacloud.com) cannot receive alerts by using mobile phones, but can <a href="https://help.aliyun.com/document_detail/175876.html">configure alert rules for DTS tasks in the CloudMonitor console</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("DelayPhone")]
        [Validation(Required=false)]
        public string DelayPhone { get; set; }

        /// <summary>
        /// <para>The threshold for triggering latency-related alerts. Unit: seconds. The value must be an integer. You can set the threshold based on your business needs. To prevent jitters caused by network and database overloads, we recommend that you set the threshold to more than 10 seconds.</para>
        /// <remarks>
        /// <para> If the <b>DelayNotice</b> parameter is set to <b>true</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DelayRuleTime")]
        [Validation(Required=false)]
        public long? DelayRuleTime { get; set; }

        [NameInMap("DtsBisLabel")]
        [Validation(Required=false)]
        public string DtsBisLabel { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking instance. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsy0zz3t13h7d****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking task. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>y0zz3t13h7d****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The name of the change tracking task.</para>
        /// <remarks>
        /// <para> We recommend that you specify a descriptive name for easy identification. You do not need to use a unique name.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DtsJobName")]
        [Validation(Required=false)]
        public string DtsJobName { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor the task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: monitors the task status.</description></item>
        /// <item><description><b>false</b>: does not monitor the task status.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ErrorNotice")]
        [Validation(Required=false)]
        public bool? ErrorNotice { get; set; }

        /// <summary>
        /// <para>The mobile numbers to which status-related alerts are sent. Separate multiple mobile numbers with commas (,).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for users of the China site (aliyun.com). Only mobile numbers in the Chinese mainland are supported. You can specify up to 10 mobile numbers.</description></item>
        /// <item><description>Users of the international site (alibabacloud.com) cannot receive alerts by using mobile phones, but can <a href="https://help.aliyun.com/document_detail/175876.html">configure alert rules for DTS tasks in the CloudMonitor console</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("ErrorPhone")]
        [Validation(Required=false)]
        public string ErrorPhone { get; set; }

        [NameInMap("MaxDu")]
        [Validation(Required=false)]
        public double? MaxDu { get; set; }

        [NameInMap("MinDu")]
        [Validation(Required=false)]
        public double? MinDu { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the Data Transmission Service (DTS) instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The reserved parameter of DTS. The value must be a JSON string. You can specify this parameter to add more configurations of the source or destination database to the DTS task. For example, you can specify the data storage format of the destination Kafka database and the ID of the CEN instance. For more information, see <a href="https://help.aliyun.com/document_detail/176470.html">MigrationReserved</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{      &quot;srcInstanceId&quot;: &quot;cen-9kqshqum*******&quot;  }</para>
        /// </summary>
        [NameInMap("Reserve")]
        [Validation(Required=false)]
        public string Reserve { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the source database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtstestdata</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The engine of the source database. Valid values: <b>MySQL</b>, <b>PostgreSQL</b>, and <b>Oracle</b>.</para>
        /// <remarks>
        /// <para> If the source database is a self-managed database, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PostgreSQL</para>
        /// </summary>
        [NameInMap("SourceEndpointEngineName")]
        [Validation(Required=false)]
        public string SourceEndpointEngineName { get; set; }

        /// <summary>
        /// <para>The endpoint of the source database.</para>
        /// <remarks>
        /// <para> This parameter is required only when the source database is a self-managed database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.8*.***</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The ID of the source database.</para>
        /// <remarks>
        /// <para> This parameter is required only when the source database is an ApsaraDB RDS for MySQL instance, a PolarDB-X 1.0 instance, or a PolarDB for MySQL cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1zc3iyqe3qw****</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The type of the source database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: ApsaraDB RDS for MySQL instance</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster</description></item>
        /// <item><description><b>DRDS</b>: PolarDB-X 1.0 instance</description></item>
        /// <item><description><b>LocalInstance</b>: self-managed database with a public IP address</description></item>
        /// <item><description><b>ECS</b>: self-managed database hosted on an Elastic Compute Service (ECS) instance</description></item>
        /// <item><description><b>Express</b>: self-managed database connected over Express Connect</description></item>
        /// <item><description><b>CEN</b>: self-managed database connected over Cloud Enterprise Network (CEN)</description></item>
        /// <item><description><b>dg</b>: self-managed database connected over Database Gateway</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceType")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceType { get; set; }

        /// <summary>
        /// <para>The system ID (SID) of the Oracle database.</para>
        /// <remarks>
        /// <para> This parameter is required only when the source database is a self-managed Oracle database and is not deployed in the Real Application Clusters (RAC) architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testsid</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the source database belongs.</para>
        /// <remarks>
        /// <para> This parameter is required only when you track data changes across different Alibaba Cloud accounts.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>140692647406****</para>
        /// </summary>
        [NameInMap("SourceEndpointOwnerID")]
        [Validation(Required=false)]
        public string SourceEndpointOwnerID { get; set; }

        /// <summary>
        /// <para>The password of the account that is used to connect to the source database.</para>
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
        /// <para> This parameter is required only when the source database is a self-managed database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public string SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the source database resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <remarks>
        /// <para> If the source database is a self-managed database with a public IP address, you can set the value of this parameter to <b>cn-hangzhou</b> or the ID of the region that is closest to the region in which the self-managed database resides.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// <para>The RAM role that is authorized to access the source database. This parameter is required if the source database does not belong to the Alibaba Cloud account that you use to configure the change tracking task. In this case, you must authorize the Alibaba Cloud account to access the source database by using a RAM role.</para>
        /// <remarks>
        /// <para> For more information about the permissions that are required for the RAM role and how to grant the permissions to the RAM role, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account data migration and synchronization</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("SourceEndpointRole")]
        [Validation(Required=false)]
        public string SourceEndpointRole { get; set; }

        /// <summary>
        /// <para>The username of the account that is used to connect to the source database.</para>
        /// <remarks>
        /// <para> The permissions that are required for the database account vary with the change tracking scenario. For more information, see <a href="https://help.aliyun.com/document_detail/212653.html">Prepare the source database account for change tracking</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        [NameInMap("SrcCaCertificateOssUrl")]
        [Validation(Required=false)]
        public string SrcCaCertificateOssUrl { get; set; }

        [NameInMap("SrcCaCertificatePassword")]
        [Validation(Required=false)]
        public string SrcCaCertificatePassword { get; set; }

        [NameInMap("SrcClientCertOssUrl")]
        [Validation(Required=false)]
        public string SrcClientCertOssUrl { get; set; }

        [NameInMap("SrcClientKeyOssUrl")]
        [Validation(Required=false)]
        public string SrcClientKeyOssUrl { get; set; }

        [NameInMap("SrcClientPassword")]
        [Validation(Required=false)]
        public string SrcClientPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to track DDL statements. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: tracks DDL statements.</description></item>
        /// <item><description><b>false</b>: does not track DDL statements.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SubscriptionDataTypeDDL")]
        [Validation(Required=false)]
        public bool? SubscriptionDataTypeDDL { get; set; }

        /// <summary>
        /// <para>Specifies whether to track DML statements. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: tracks DML statements.</description></item>
        /// <item><description><b>false</b>: does not track DML statements.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SubscriptionDataTypeDML")]
        [Validation(Required=false)]
        public bool? SubscriptionDataTypeDML { get; set; }

        /// <summary>
        /// <para>The network type of the change tracking task. Set the value to <b>vpc</b>. A value of vpc indicates the Virtual Private Cloud (VPC) network type.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>To use the new version of the change tracking feature, you must specify the SubscriptionInstanceNetworkType parameter. You must also specify the <b>SubscriptionInstanceVPCId</b> and <b>SubscriptionInstanceVSwitchID</b> parameters. If you do not specify the SubscriptionInstanceNetworkType parameter, the previous version of the change tracking feature is used.</description></item>
        /// <item><description>The previous version of the change tracking feature supports self-managed MySQL databases, ApsaraDB RDS for MySQL instances, and PolarDB-X 1.0 instances. The new version of the change tracking feature supports self-managed MySQL databases, ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and Oracle databases.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceNetworkType")]
        [Validation(Required=false)]
        public string SubscriptionInstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The ID of the VPC in which the change tracking instance is deployed.</para>
        /// <remarks>
        /// <para> This parameter is required only when the <b>SubscriptionInstanceNetworkType</b> parameter is set to <b>vpc</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1vwnn14rqpyiczj****</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceVPCId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceVPCId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the specified VPC.</para>
        /// <remarks>
        /// <para> This parameter is required only when the <b>SubscriptionInstanceNetworkType</b> parameter is set to <b>vpc</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp10df3mxae6lpmku****</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceVSwitchId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceVSwitchId { get; set; }

    }

}
