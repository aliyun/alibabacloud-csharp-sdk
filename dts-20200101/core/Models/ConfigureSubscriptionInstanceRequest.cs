// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSubscriptionInstanceRequest : TeaModel {
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigureSubscriptionInstanceRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigureSubscriptionInstanceRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// <para>The name of the source database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The IP address of the source database.</para>
            /// <remarks>
            /// <para> This parameter is required only when the source database is a self-managed database.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.88.***</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The ID of the source database.</para>
            /// <remarks>
            /// <para> This parameter is required only when the source database is an ApsaraDB RDS for MySQL instance, a PolarDB-X 1.0 instance, or a PolarDB for MySQL cluster.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1zc3iyqe3qw****</para>
            /// </summary>
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            /// <summary>
            /// <para>The type of the source database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RDS</b>: ApsaraDB RDS for MySQL instance</description></item>
            /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster</description></item>
            /// <item><description><b>LocalInstance</b>: self-managed database with a public IP address</description></item>
            /// <item><description><b>ECS</b>: self-managed database hosted on an Elastic Compute Service (ECS) instance</description></item>
            /// <item><description><b>Express</b>: self-managed database connected over Express Connect</description></item>
            /// <item><description><b>CEN</b>: self-managed database connected over Cloud Enterprise Network (CEN)</description></item>
            /// <item><description><b>dg</b>: self-managed database connected over Database Gateway</description></item>
            /// </list>
            /// <remarks>
            /// <para> The engine of a self-managed database can be MySQL or Oracle. You must specify the engine type when you call the <a href="https://help.aliyun.com/document_detail/49436.html">CreateSubscriptionInstance</a> operation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The system ID (SID) of the Oracle database.</para>
            /// <remarks>
            /// <para> This parameter is required only when the source database is a self-managed Oracle database and is not deployed in the Real Application Clusters (RAC) architecture.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testsid</para>
            /// </summary>
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the source database belongs.</para>
            /// <remarks>
            /// <para> This parameter is required only when you track data changes across different Alibaba Cloud accounts.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>140692647406****</para>
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// <para>The password of the account that is used to connect to the source database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test123456</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The service port number of the source database.</para>
            /// <remarks>
            /// <para> This parameter is required only when the source database is a self-managed database.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The RAM role that is authorized to access the source database. This parameter is required if the source database does not belong to the Alibaba Cloud account that you use to configure the change tracking instance. In this case, you must authorize the Alibaba Cloud account to access the source database by using a RAM role.</para>
            /// <remarks>
            /// <para> For more information about the permissions that are required for the RAM role and how to grant permissions to the RAM role, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account data migration and synchronization</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ram-for-dts</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The username of the account that is used to connect to the source database.</para>
            /// <remarks>
            /// <para> The permissions that are required for the database account vary with the change tracking scenario. For more information, see <a href="https://help.aliyun.com/document_detail/145715.html">Overview of change tracking scenarios</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestaccount</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("SubscriptionDataType")]
        [Validation(Required=false)]
        public ConfigureSubscriptionInstanceRequestSubscriptionDataType SubscriptionDataType { get; set; }
        public class ConfigureSubscriptionInstanceRequestSubscriptionDataType : TeaModel {
            /// <summary>
            /// <para>Specifies whether to track DDL statements. Default value: true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: tracks DDL statements.</description></item>
            /// <item><description><b>false</b>: does not track DDL statements.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DDL")]
            [Validation(Required=false)]
            public bool? DDL { get; set; }

            /// <summary>
            /// <para>Specifies whether to track DML statements. Default value: true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: tracks DML statements.</description></item>
            /// <item><description><b>false</b>: does not tack DML statements.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DML")]
            [Validation(Required=false)]
            public bool? DML { get; set; }

        }

        [NameInMap("SubscriptionInstance")]
        [Validation(Required=false)]
        public ConfigureSubscriptionInstanceRequestSubscriptionInstance SubscriptionInstance { get; set; }
        public class ConfigureSubscriptionInstanceRequestSubscriptionInstance : TeaModel {
            /// <summary>
            /// <para>The ID of the VPC in which the change tracking instance is deployed.</para>
            /// <remarks>
            /// <para> This parameter is required only when the <b>SubscriptionInstanceNetworkType</b> parameter is set to <b>vpc</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1vwnn14rqpyiczj****</para>
            /// </summary>
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch in the specified VPC.</para>
            /// <remarks>
            /// <para> This parameter is required only when the <b>SubscriptionInstanceNetworkType</b> parameter is set to <b>vpc</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp10df3mxae6lpmku****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter is discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the change tracking instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtshp8n2ze4r5x****</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking instance. You can call the <a href="https://help.aliyun.com/document_detail/49442.html">DescribeSubscriptionInstances</a> operation to query the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The name of the change tracking instance.</para>
        /// <remarks>
        /// <para> We recommend that you specify an informative name for easy identification. You do not need to use a unique name.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SubscriptionInstanceName")]
        [Validation(Required=false)]
        public string SubscriptionInstanceName { get; set; }

        /// <summary>
        /// <para>The network type of the change tracking instance. Set the value to <b>vpc</b>. A value of vpc indicates the Virtual Private Cloud (VPC) network type.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>To use the new version of the change tracking feature, you must specify the SubscriptionInstanceNetworkType parameter. You must also specify the <b>SubscriptionInstance.VPCId</b> and <b>SubscriptionInstance.VSwitchID</b> parameters. If you do not specify the SubscriptionInstanceNetworkType parameter, the previous version of the change tracking feature is used.</description></item>
        /// <item><description>The previous version of the change tracking feature supports self-managed MySQL databases, ApsaraDB RDS for MySQL instances, and PolarDB-X 1.0 instances. The new version of the change tracking feature supports self-managed MySQL databases, ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and Oracle databases.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceNetworkType")]
        [Validation(Required=false)]
        public string SubscriptionInstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The objects for which you want to track data changes. The value is a JSON string and can contain regular expressions. For more information, see <a href="https://help.aliyun.com/document_detail/141902.html">SubscriptionObjects</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{     &quot;DBName&quot;: &quot;dtstestdata&quot; }]</para>
        /// </summary>
        [NameInMap("SubscriptionObject")]
        [Validation(Required=false)]
        public string SubscriptionObject { get; set; }

    }

}
