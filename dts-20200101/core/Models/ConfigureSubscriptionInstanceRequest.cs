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
            /// <para>待订阅的数据库名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdata</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>源数据库的连接地址。</para>
            /// <remarks>
            /// <para>当源数据库为自建数据库时，本参数才可用且必须传入。</para>
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
            /// <remarks>
            /// <para>源数据库的实例类型为RDS MySQL、PolarDB-X 1.0、PolarDB MySQL时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1zc3iyqe3qw****</para>
            /// </summary>
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            /// <summary>
            /// <para>源数据库的实例类型，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>RDS</b>：RDS MySQL。</description></item>
            /// <item><description><b>PolarDB</b>：PolarDB MySQL。</description></item>
            /// <item><description><b>LocalInstance</b>：有公网IP的自建数据库。</description></item>
            /// <item><description><b>ECS</b>：ECS上的自建数据库。</description></item>
            /// <item><description><b>Express</b>：通过专线接入的自建数据库。</description></item>
            /// <item><description><b>CEN</b>：通过云企业网CEN接入的自建数据库。</description></item>
            /// <item><description><b>dg</b>：通过数据库网关接入的自建数据库。</description></item>
            /// </list>
            /// <remarks>
            /// <para>支持自建数据库的数据库类型为MySQL、Oracle，您需要提前调用<a href="https://help.aliyun.com/document_detail/49436.html">CreateSubscriptionInstance</a>设置。</para>
            /// </remarks>
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
            /// <para>当源数据库为自建Oracle时，且Oracle数据库为非RAC实例时，本参数才可用且必须传入。</para>
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
            /// <para>仅在配置跨阿里云账号的数据订阅时本参数才可用，且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>140692647406****</para>
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// <para>源实例的数据库账号密码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test123456</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>源数据库的服务端口。</para>
            /// <remarks>
            /// <para>当源数据库为自建数据库时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>源实例的授权角色。当源实例与配置订阅任务所属阿里云账号不同时，需传入该参数，来指定源实例的授权角色，以允许配置订阅任务所属阿里云账号访问源实例的实例信息。</para>
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
            /// <para>源实例的数据库账号。</para>
            /// <remarks>
            /// <para>订阅不同的数据库所需的权限有所差异，详情请参见<a href="https://help.aliyun.com/document_detail/145715.html">DTS数据订阅方案概览</a>中对应的配置案例。</para>
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
            /// <para>是否订阅DDL类型的数据，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>：是，为默认值。</description></item>
            /// <item><description><b>false</b>：否。</description></item>
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
            /// <para>是否订阅DML类型的数据，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>：是，为默认值。</description></item>
            /// <item><description><b>false</b>：否。</description></item>
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
            /// <para>订阅实例的专有网络ID。</para>
            /// <remarks>
            /// <para>当<b>SubscriptionInstanceNetworkType</b>取值为<b>vpc</b>时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1vwnn14rqpyiczj****</para>
            /// </summary>
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }

            /// <summary>
            /// <para>订阅实例的虚拟交换机ID。</para>
            /// <remarks>
            /// <para>当<b>SubscriptionInstanceNetworkType</b>取值为<b>vpc</b>时，本参数才可用且必须传入。</para>
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
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because it will be deprecated.</para>
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

        /// <summary>
        /// <para>The ID of the region where the change tracking instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
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
        /// <para>The ID of the change tracking instance. You can call the <a href="https://help.aliyun.com/document_detail/49442.html">DescribeSubscriptionInstances</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtshp8n2ze4r5x****</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the change tracking instance.</para>
        /// <remarks>
        /// <para>Specify a descriptive name for easy identification. The name does not need to be unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL订阅</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceName")]
        [Validation(Required=false)]
        public string SubscriptionInstanceName { get; set; }

        /// <summary>
        /// <para>The network type of the change tracking instance. The only valid value is <b>vpc</b>, which indicates a virtual private cloud (VPC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, the change tracking instance is defined as the new version. You must also correctly set the <b>SubscriptionInstance.VPCId</b> and <b>SubscriptionInstance.VSwitchID</b> parameters. If you do not specify this parameter, the change tracking instance is defined as the legacy version.</description></item>
        /// <item><description>The legacy version supports change tracking for self-managed MySQL, ApsaraDB RDS for MySQL, and DRDS. The new version supports change tracking for self-managed MySQL, ApsaraDB RDS for MySQL, PolarDB for MySQL, and Oracle.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceNetworkType")]
        [Validation(Required=false)]
        public string SubscriptionInstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The objects to be subscribed to. The value is a JSON string that supports regular expressions. For more information, see <a href="https://help.aliyun.com/document_detail/141902.html">Subscription object configuration</a>.</para>
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
