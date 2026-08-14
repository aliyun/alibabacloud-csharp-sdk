// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>The start time of change tracking, in the format of a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>You can use a search engine to find a UNIX timestamp converter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1616902385</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>The objects to be tracked, in JSON format. For more information, see <a href="https://help.aliyun.com/document_detail/209545.html">Objects of DTS tasks</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dtstest&quot;:{&quot;name&quot;:&quot;dtstest&quot;,&quot;all&quot;:true}}</para>
        /// </summary>
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public string DbList { get; set; }

        /// <summary>
        /// <para>The ID of the DTS dedicated cluster. This parameter is used to schedule the change tracking task to the specified DTS dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_atyl3b5214uk***</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor the latency status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: monitors the latency status.</description></item>
        /// <item><description><b>false</b>: does not monitor the latency status.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DelayNotice")]
        [Validation(Required=false)]
        public bool? DelayNotice { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers for receiving latency alerts. Separate multiple phone numbers with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is supported only on the China site (aliyun.com). Only Chinese mainland phone numbers are supported, and you can specify up to 10 phone numbers.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The China site (Chinese mainland) does not support phone alerts. You can only <a href="https://help.aliyun.com/document_detail/175876.html">configure alert rules for DTS tasks in CloudMonitor</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("DelayPhone")]
        [Validation(Required=false)]
        public string DelayPhone { get; set; }

        /// <summary>
        /// <para>The threshold for triggering latency alerts. Unit: seconds. The value must be an integer. Set the threshold based on your business requirements. To avoid alert fluctuations caused by network conditions or database loads, set the threshold to 10 seconds or more.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DelayNotice</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DelayRuleTime")]
        [Validation(Required=false)]
        public long? DelayRuleTime { get; set; }

        /// <summary>
        /// <para>The environment tag of the DTS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: normal</description></item>
        /// <item><description><b>online</b>: online.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DtsBisLabel")]
        [Validation(Required=false)]
        public string DtsBisLabel { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking instance. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsy0zz3t13h7d****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking task. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the task ID.</para>
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
        /// <para>Specify a descriptive name that makes it easy to identify the task. The name does not need to be unique.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL订阅</para>
        /// </summary>
        [NameInMap("DtsJobName")]
        [Validation(Required=false)]
        public string DtsJobName { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor the error status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: monitors the error status.</description></item>
        /// <item><description><b>false</b>: does not monitor the error status.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ErrorNotice")]
        [Validation(Required=false)]
        public bool? ErrorNotice { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers for receiving error alerts. Separate multiple phone numbers with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is supported only on the China site (aliyun.com). Only Chinese mainland phone numbers are supported, and you can specify up to 10 phone numbers.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The China site (Chinese mainland) does not support phone alerts. You can only <a href="https://help.aliyun.com/document_detail/175876.html">configure alert rules for DTS tasks in CloudMonitor</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("ErrorPhone")]
        [Validation(Required=false)]
        public string ErrorPhone { get; set; }

        /// <summary>
        /// <para>The maximum number of DUs for a serverless instance. Valid values: 2, 4, 8, and 16.
        /// &lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This feature is currently not supported. Do not specify this parameter..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("MaxDu")]
        [Validation(Required=false)]
        public double? MaxDu { get; set; }

        /// <summary>
        /// <para>The minimum number of DTS Units (DUs) for a serverless instance. Valid values: 1, 2, 4, 8, and 16.
        /// &lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This feature is currently not supported. Do not specify this parameter..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinDu")]
        [Validation(Required=false)]
        public double? MinDu { get; set; }

        /// <summary>
        /// <para>The region in which the change tracking instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The reserved parameter of DTS, in JSON format. You can specify this parameter to add information about the source and destination databases, such as the data storage format of the destination Kafka database or the CEN instance ID. For more information, see the <a href="https://help.aliyun.com/document_detail/176470.html">Reserve metric description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{      &quot;srcInstanceId&quot;: &quot;cen-9kqshqum*******&quot;  }</para>
        /// </summary>
        [NameInMap("Reserve")]
        [Validation(Required=false)]
        public string Reserve { get; set; }

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
        /// <para>The name of the database to be tracked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtstestdata</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The engine type of the source database. Valid values: <b>MySQL</b>, <b>PostgreSQL</b>, and <b>Oracle</b>.</para>
        /// <remarks>
        /// <para>This parameter is required if the source database is a self-managed database.</para>
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
        /// <para>This parameter is available and required only when the source database is a self-managed database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.8*.***</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The instance ID of the source instance.</para>
        /// <remarks>
        /// <para>This parameter is active and required only when the source database is an ApsaraDB RDS for MySQL instance, a PolarDB-X 1.0 instance, or a PolarDB for MySQL cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1zc3iyqe3qw****</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The instance type of the source database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: ApsaraDB RDS instance.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster.</description></item>
        /// <item><description><b>DRDS</b>: PolarDB-X 1.0 instance.</description></item>
        /// <item><description><b>LocalInstance</b>: self-managed database with a public IP address.</description></item>
        /// <item><description><b>ECS</b>: self-managed database hosted on an ECS instance.</description></item>
        /// <item><description><b>Express</b>: self-managed database connected over Express Connect.</description></item>
        /// <item><description><b>CEN</b>: self-managed database connected over Cloud Enterprise Network (CEN).</description></item>
        /// <item><description><b>dg</b>: self-managed database connected over Database Gateway.</description></item>
        /// </list>
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
        /// <para>This parameter is available and required only when the source database is a self-managed Oracle database that is not a Real Application Cluster (RAC) instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testsid</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the account to which the source instance belongs.</para>
        /// <remarks>
        /// <para>This parameter is active and required only when you configure cross-Alibaba Cloud account change tracking. You must subscribe to the task.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>140692647406****</para>
        /// </summary>
        [NameInMap("SourceEndpointOwnerID")]
        [Validation(Required=false)]
        public string SourceEndpointOwnerID { get; set; }

        /// <summary>
        /// <para>The password of the database account for the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The service port of the source database.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the source database is a self-managed database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public string SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The region of the source instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <remarks>
        /// <para>If the source instance is a self-managed database with a public IP address, you can set this parameter to <b>cn-hangzhou</b> or the region ID closest to the self-managed database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// <para>The authorized role of the source instance. If the source instance and the change tracking task belong to different Alibaba Cloud accounts, specify this parameter to allow the Alibaba Cloud account that owns the change tracking task to access the source instance.</para>
        /// <remarks>
        /// <para>For more information about the permissions and authorization methods required for the role, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account data migration or synchronization</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("SourceEndpointRole")]
        [Validation(Required=false)]
        public string SourceEndpointRole { get; set; }

        /// <summary>
        /// <para>The database account of the source instance.</para>
        /// <remarks>
        /// <para>The permissions required for change tracking vary depending on the database type. For more information, see the account permissions section in <a href="https://help.aliyun.com/document_detail/212653.html">Prepare database accounts for change tracking</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        /// <summary>
        /// <para>The path of the CA certificate when the source database uses an SSL connection.</para>
        /// <remarks>
        /// <para>This feature is currently not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcCaCertificateOssUrl")]
        [Validation(Required=false)]
        public string SrcCaCertificateOssUrl { get; set; }

        /// <summary>
        /// <para>The key of the CA certificate when the source database uses an SSL connection.</para>
        /// <remarks>
        /// <para>This feature is currently not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcCaCertificatePassword")]
        [Validation(Required=false)]
        public string SrcCaCertificatePassword { get; set; }

        /// <summary>
        /// <para>The path of the client certificate when the source database uses an SSL connection.</para>
        /// <remarks>
        /// <para>This feature is currently not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcClientCertOssUrl")]
        [Validation(Required=false)]
        public string SrcClientCertOssUrl { get; set; }

        /// <summary>
        /// <para>The path of the client certificate private key when the source database uses an SSL connection.</para>
        /// <remarks>
        /// <para>This feature is currently not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcClientKeyOssUrl")]
        [Validation(Required=false)]
        public string SrcClientKeyOssUrl { get; set; }

        /// <summary>
        /// <para>The password of the client certificate private key when the source database uses an SSL connection.</para>
        /// <remarks>
        /// <para>This feature is currently not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcClientPassword")]
        [Validation(Required=false)]
        public string SrcClientPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to track DDL data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): tracks DDL data.</description></item>
        /// <item><description><b>false</b>: does not track DDL data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SubscriptionDataTypeDDL")]
        [Validation(Required=false)]
        public bool? SubscriptionDataTypeDDL { get; set; }

        /// <summary>
        /// <para>Specifies whether to track DML data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): tracks DML data.</description></item>
        /// <item><description><b>false</b>: does not track DML data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SubscriptionDataTypeDML")]
        [Validation(Required=false)]
        public bool? SubscriptionDataTypeDML { get; set; }

        /// <summary>
        /// <para>The network type of the change tracking task. The only valid value is <b>vpc</b>, which indicates virtual private cloud (VPC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, the change tracking task is defined as the new version. You must also correctly set the <b>SubscriptionInstanceVPCId</b> and <b>SubscriptionInstanceVSwitchID</b> parameters. If you do not specify this parameter, the change tracking task is defined as the legacy version.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Legacy change tracking tasks support tracking data from self-managed MySQL, ApsaraDB RDS for MySQL, and PolarDB-X 1.0. New-version change tracking tasks support tracking data from self-managed MySQL, ApsaraDB RDS for MySQL, PolarDB for MySQL, and Oracle.</description></item>
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
        /// <para>The VPC ID of the change tracking instance.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when <b>SubscriptionInstanceNetworkType</b> is set to <b>vpc</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1vwnn14rqpyiczj****</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceVPCId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceVPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the change tracking instance.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when <b>SubscriptionInstanceNetworkType</b> is set to <b>vpc</b>.</para>
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
