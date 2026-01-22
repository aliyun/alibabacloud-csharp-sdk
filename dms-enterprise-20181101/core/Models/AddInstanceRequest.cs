// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database link for cross-database queries.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This property must be specified when UseDsql is set to 1.</para>
        /// </description></item>
        /// <item><description><para>The name can contain only lowercase letters and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>The name must be unique within a tenant.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dblink_test</para>
        /// </summary>
        [NameInMap("DataLinkName")]
        [Validation(Required=false)]
        public string DataLinkName { get; set; }

        /// <summary>
        /// <para>The password of the database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test***</para>
        /// </summary>
        [NameInMap("DatabasePassword")]
        [Validation(Required=false)]
        public string DatabasePassword { get; set; }

        /// <summary>
        /// <para>The name of the database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testsdb</para>
        /// </summary>
        [NameInMap("DatabaseUser")]
        [Validation(Required=false)]
        public string DatabaseUser { get; set; }

        /// <summary>
        /// <para>The ID of the user who assumes the database administrator (DBA) role. You can call the <a href="https://help.aliyun.com/document_detail/141938.html">ListUsers</a> or <a href="https://help.aliyun.com/document_detail/141567.html">GetInstance</a> operation to obtain the value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27****</para>
        /// </summary>
        [NameInMap("DbaId")]
        [Validation(Required=false)]
        public long? DbaId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Lock-free Schema Change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: does not enable lock-free schema change.</description></item>
        /// <item><description><b>1</b>: uses the native online DDL operations of MySQL first.</description></item>
        /// <item><description><b>2:</b> uses lock-free schema change first.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Supported databases include ApsaraDB RDS for MySQL, PolarDB for MySQL, ApsaraDB MyBase for MySQL, and third-party MySQL databases.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DdlOnline")]
        [Validation(Required=false)]
        public int? DdlOnline { get; set; }

        /// <summary>
        /// <para>The ID of the instance. If your instance is a database instance connected by using a database gateway, specify the gateway ID for this parameter.</para>
        /// <remarks>
        /// <para>This parameter is required if InstanceSource is set to ECS_OWN or GATEWAY.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zei9gs1t7h8l7ac****</para>
        /// </summary>
        [NameInMap("EcsInstanceId")]
        [Validation(Required=false)]
        public string EcsInstanceId { get; set; }

        /// <summary>
        /// <para>The region in which the ECS instance resides.</para>
        /// <remarks>
        /// <para>This parameter is required if InstanceSource is set to RDS, ECS_OWN, GATEWAY, or VPC_IDC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("EcsRegion")]
        [Validation(Required=false)]
        public string EcsRegion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Security Collaboration for the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: enables Security Collaboration.</description></item>
        /// <item><description>N: disables Security Collaboration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("EnableSellCommon")]
        [Validation(Required=false)]
        public string EnableSellCommon { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable sensitive data protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: enables the sensitive data protection feature for the database instance.</description></item>
        /// <item><description>N: disables the sensitive data protection feature for the database instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("EnableSellSitd")]
        [Validation(Required=false)]
        public string EnableSellSitd { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Stable Change for the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: Enables Stable Change.</description></item>
        /// <item><description>N: Disables Stable Change.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NULL</para>
        /// </summary>
        [NameInMap("EnableSellStable")]
        [Validation(Required=false)]
        public string EnableSellStable { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the security hosting feature for the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: enables the security hosting feature for the database instance.</description></item>
        /// <item><description>N: disables the security hosting feature for the database instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("EnableSellTrust")]
        [Validation(Required=false)]
        public string EnableSellTrust { get; set; }

        /// <summary>
        /// <para>The type of the environment to which the database instance belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>product:</b> the production environment.</description></item>
        /// <item><description><b>dev</b>: development environment.</description></item>
        /// <item><description><b>pre</b>: pre-release environment.</description></item>
        /// <item><description><b>test</b>: test environment.</description></item>
        /// <item><description><b>sit</b>: system integration testing (SIT) environment.</description></item>
        /// <item><description><b>uat</b>: user acceptance testing (UAT) environment.</description></item>
        /// <item><description><b>pet</b>: stress testing environment.</description></item>
        /// <item><description><b>stag</b>: staging environment.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The timeout period for exporting data from the database instance. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("ExportTimeout")]
        [Validation(Required=false)]
        public int? ExportTimeout { get; set; }

        /// <summary>
        /// <para>The endpoint that is used to connect to the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XXX.254</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The alias of the database instance. Specify an alias that can help you identify the database instance in DMS.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// <para>The source of the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLIC_OWN</b>: a self-managed database instance that is deployed on the Internet.</description></item>
        /// <item><description><b>RDS</b>: an ApsaraDB RDS instance.</description></item>
        /// <item><description><b>ECS_OWN</b>: a self-managed database instance that is deployed on an Elastic Compute Service (ECS) instance.</description></item>
        /// <item><description><b>VPC_IDC</b>: a self-managed database instance that is deployed in a data center connected over a virtual private cloud (VPC).</description></item>
        /// <item><description><b>GATEWAY</b>: a database instance connected by using a database gateway.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("InstanceSource")]
        [Validation(Required=false)]
        public string InstanceSource { get; set; }

        /// <summary>
        /// <para>The type of the database instance. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLASSIC:</b> the classic network.</description></item>
        /// <item><description><b>VPC</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The port that is used to connect to the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The timeout period for querying data from the database instance. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7200</para>
        /// </summary>
        [NameInMap("QueryTimeout")]
        [Validation(Required=false)]
        public int? QueryTimeout { get; set; }

        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The name of the security rule set for the database instance. This parameter is required if Security Collaboration is enabled. You can call the<a href="https://help.aliyun.com/document_detail/465940.html">ListStandardGroups</a> or <a href="https://help.aliyun.com/document_detail/465826.html">GetInstance</a> operation to obtain the name of the security rule set from GroupName.</para>
        /// </summary>
        [NameInMap("SafeRule")]
        [Validation(Required=false)]
        public string SafeRule { get; set; }

        /// <summary>
        /// <para>The system ID (SID) of the database instance.</para>
        /// <remarks>
        /// <para>This parameter is required if InstanceType is set to ORACLE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testSid</para>
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the connectivity test. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SkipTest")]
        [Validation(Required=false)]
        public bool? SkipTest { get; set; }

        /// <summary>
        /// <para>The ID of the classification and grading template. You can call the <a href="https://help.aliyun.com/document_detail/465947.html">ListClassificationTemplates</a> operation to query the template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31***</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The type of the classification and grading template. You can call the <a href="https://help.aliyun.com/document_detail/465947.html">ListClassificationTemplates</a> operation to query the template type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INNER</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>You can move the pointer over the profile picture in the upper-right corner of the DMS console to obtain the tenant ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23****</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cross-database query for the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0: does not enable cross-database query.</b></description></item>
        /// <item><description><b>1</b>: enables cross-database query.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Supported databases include MySQL, SQL Server, PostgreSQL, PolarDB for Oracle, and Redis.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UseDsql")]
        [Validation(Required=false)]
        public int? UseDsql { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow Data Management Service (DMS) to connect to the database instance by using SSL connections. Before you use SSL connections, make sure that the SSL encryption feature is enabled for the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): DMS automatically checks whether self-negotiation is enabled for the database instance. DMS automatically checks whether the SSL encryption feature is enabled for the database instance. If the SSL encryption feature is enabled, DMS connects to the database instance by using SSL connections. Otherwise, DMS connects to the database instance without encryption.</description></item>
        /// <item><description><b>1</b>: DMS connects to the database instance by using SSL connections. This value is invalid if the SSL encryption feature is disabled for the database instance.</description></item>
        /// <item><description><b>-1</b>: DMS does not connect to the database instance by using SSL connections.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available only for a MySQL or Redis database instance.</para>
        /// </description></item>
        /// <item><description><para>SSL encrypts network connections at the transport layer to improve the security and integrity of data in transmission. However, SSL increases the response time of network connections.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("UseSsl")]
        [Validation(Required=false)]
        public int? UseSsl { get; set; }

        /// <summary>
        /// <para>The ID of the instance connected over a VPC.</para>
        /// <remarks>
        /// <para>This parameter is required if InstanceSource is set to VPC_IDC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zef4o1hu7ljd****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
