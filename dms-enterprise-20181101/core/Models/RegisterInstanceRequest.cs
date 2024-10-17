// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class RegisterInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database link for cross-database queries.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if UseDsql is set to 1.</para>
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
        /// <para>The password that is used to log on to the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DatabasePassword")]
        [Validation(Required=false)]
        public string DatabasePassword { get; set; }

        /// <summary>
        /// <para>The account that is used to log on to the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dmstest</para>
        /// </summary>
        [NameInMap("DatabaseUser")]
        [Validation(Required=false)]
        public string DatabaseUser { get; set; }

        /// <summary>
        /// <para>The ID of the user who assumes the DBA role of the database instance. You can call the <a href="https://help.aliyun.com/document_detail/141938.html">ListUsers</a> or <a href="https://help.aliyun.com/document_detail/141567.html">GetInstance</a> operation to query the user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22275482072787****</para>
        /// </summary>
        [NameInMap("DbaUid")]
        [Validation(Required=false)]
        public long? DbaUid { get; set; }

        /// <summary>
        /// <para>The ID of the user who assumes the DBA role of the database instance. If the user ID is a non-numeric value such as a role or an account, you can use this parameter to replace DbaUid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22275482072787****</para>
        /// </summary>
        [NameInMap("DbaUidByString")]
        [Validation(Required=false)]
        public string DbaUidByString { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the lock-free schema change feature for the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables the lock-free schema change feature.</description></item>
        /// <item><description><b>1</b>: uses the online DDL of MySQL first.</description></item>
        /// <item><description><b>2</b>: uses the lock-free schema change feature of DMS first.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Supported database types: ApsaraDB RDS for MySQL, PolarDB for MySQL, ApsaraDB MyBase for MySQL, and third-party MySQL databases.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DdlOnline")]
        [Validation(Required=false)]
        public int? DdlOnline { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance on which the database instance is deployed.</para>
        /// <remarks>
        /// <para>This parameter is required if the InstanceSource parameter is set to ECS_OWN.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zei9gs1t7h8l7ac****</para>
        /// </summary>
        [NameInMap("EcsInstanceId")]
        [Validation(Required=false)]
        public string EcsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the database instance resides.</para>
        /// <remarks>
        /// <para>This parameter is required if the InstanceSource parameter is set to RDS, ECS_OWN, or VPC_IDC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("EcsRegion")]
        [Validation(Required=false)]
        public string EcsRegion { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>Y:</b> enables the sensitive data protection feature</description></item>
        /// <item><description><b>NULL or other:</b> disables the sensitive data protection feature</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("EnableSellSitd")]
        [Validation(Required=false)]
        public string EnableSellSitd { get; set; }

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
        /// <para>600</para>
        /// </summary>
        [NameInMap("ExportTimeout")]
        [Validation(Required=false)]
        public int? ExportTimeout { get; set; }

        /// <summary>
        /// <para>The host address that is used to connect to the database instance.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>Test instance</para>
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// <para>The source of the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLIC_OWN:</b> a self-managed database instance that is deployed on the Internet</description></item>
        /// <item><description><b>RDS:</b> an ApsaraDB RDS instance</description></item>
        /// <item><description><b>ECS_OWN:</b> a self-managed database that is deployed on an Elastic Compute Service (ECS) instance</description></item>
        /// <item><description><b>VPC_IDC:</b> a self-managed database instance that is deployed in a data center connected over a virtual private cloud (VPC)</description></item>
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
        /// <para>The type of the database. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The network type of the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLASSIC:</b> classic network</description></item>
        /// <item><description><b>VPC:</b> VPC</description></item>
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
        /// <para>The port that is used to connect to the database instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The timeout period for querying data in the database instance. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("QueryTimeout")]
        [Validation(Required=false)]
        public int? QueryTimeout { get; set; }

        /// <summary>
        /// <para>The name of the security rule set (GroupName) for the database instance. You can call the <a href="https://help.aliyun.com/document_detail/417891.html">ListStandardGroups</a> or <a href="https://help.aliyun.com/document_detail/141567.html">GetInstance</a> operation to query the name of the security rule set.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("SafeRule")]
        [Validation(Required=false)]
        public string SafeRule { get; set; }

        /// <summary>
        /// <para>The system ID (SID) of the database.</para>
        /// <remarks>
        /// <para>This parameter is required if the InstanceType parameter is set to ORACLE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the connectivity test. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> skips the connectivity test</description></item>
        /// <item><description><b>false:</b> does not skip the connectivity test</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SkipTest")]
        [Validation(Required=false)]
        public bool? SkipTest { get; set; }

        /// <summary>
        /// <para>The ID of the classification template. You can call the <a href="https://help.aliyun.com/document_detail/460613.html">ListClassificationTemplates</a> operation to query the template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31***</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The type of the classification template. You can call the <a href="https://help.aliyun.com/document_detail/460613.html">ListClassificationTemplates</a> operation to query the template type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INNER</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the cross-database query feature for the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables the cross-database query feature.</description></item>
        /// <item><description><b>1</b>: enables the cross-database query feature.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Supported database types: MySQL, SQL Server, PostgreSQL, PolarDB for PostgreSQL (compatible with Oracle), and ApsaraDB for Redis.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UseDsql")]
        [Validation(Required=false)]
        public int? UseDsql { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the database instance belongs.</para>
        /// <remarks>
        /// <para>This parameter is required if the InstanceSource parameter is set to VPC_IDC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
