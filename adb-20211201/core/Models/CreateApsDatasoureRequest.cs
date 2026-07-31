// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateApsDatasoureRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-xxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The Databricks data source information.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("DatabricksInfo")]
        [Validation(Required=false)]
        public CreateApsDatasoureRequestDatabricksInfo DatabricksInfo { get; set; }
        public class CreateApsDatasoureRequestDatabricksInfo : TeaModel {
            /// <summary>
            /// <para>The access token.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            /// <summary>
            /// <para>The workspace URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("WorkspaceURL")]
            [Validation(Required=false)]
            public string WorkspaceURL { get; set; }

        }

        /// <summary>
        /// <para>The data source description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("DatasourceDescription")]
        [Validation(Required=false)]
        public string DatasourceDescription { get; set; }

        /// <summary>
        /// <para>The data source name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls-******</para>
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// <para>The data source type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KAFKA</para>
        /// </summary>
        [NameInMap("DatasourceType")]
        [Validation(Required=false)]
        public string DatasourceType { get; set; }

        /// <summary>
        /// <para>The Hive data source information.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("HiveInfo")]
        [Validation(Required=false)]
        public CreateApsDatasoureRequestHiveInfo HiveInfo { get; set; }
        public class CreateApsDatasoureRequestHiveInfo : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The host configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("HostConfig")]
            [Validation(Required=false)]
            public string HostConfig { get; set; }

            /// <summary>
            /// <para>The MetaStore endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("MetaStoreUri")]
            [Validation(Required=false)]
            public string MetaStoreUri { get; set; }

            /// <summary>
            /// <para>The security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-uf*******h</para>
            /// </summary>
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public string SecurityGroup { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1*****k</para>
            /// </summary>
            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public string Vswitch { get; set; }

        }

        /// <summary>
        /// <para>The Kafka information.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("KafkaInfo")]
        [Validation(Required=false)]
        public CreateApsDatasoureRequestKafkaInfo KafkaInfo { get; set; }
        public class CreateApsDatasoureRequestKafkaInfo : TeaModel {
            /// <summary>
            /// <para>The Kafka instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("KafkaClusterId")]
            [Validation(Required=false)]
            public string KafkaClusterId { get; set; }

            /// <summary>
            /// <para>The assigned Kafka topic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("KafkaTopic")]
            [Validation(Required=false)]
            public string KafkaTopic { get; set; }

        }

        /// <summary>
        /// <para>The mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALI_CLOUD_INSTANCE</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The PolarDB for MySQL data source information.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("PolarDBMysqlInfo")]
        [Validation(Required=false)]
        public CreateApsDatasoureRequestPolarDBMysqlInfo PolarDBMysqlInfo { get; set; }
        public class CreateApsDatasoureRequestPolarDBMysqlInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether cross-account access is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The current network instance is a cross-account resource.</description></item>
            /// <item><description><b>false</b>: The current network instance is a resource within the current account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Across")]
            [Validation(Required=false)]
            public bool? Across { get; set; }

            /// <summary>
            /// <para>The cross-account role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-role</para>
            /// </summary>
            [NameInMap("AcrossRole")]
            [Validation(Required=false)]
            public string AcrossRole { get; set; }

            /// <summary>
            /// <para>The UID of the cross-account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789*</para>
            /// </summary>
            [NameInMap("AcrossUid")]
            [Validation(Required=false)]
            public string AcrossUid { get; set; }

            /// <summary>
            /// <para>The custom RDS endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ConnectUrl")]
            [Validation(Required=false)]
            public string ConnectUrl { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp*********</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The password.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-******</para>
            /// </summary>
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public string SecurityGroup { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-user-name</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The PolarDB-X data source information.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("PolarDBXInfo")]
        [Validation(Required=false)]
        public CreateApsDatasoureRequestPolarDBXInfo PolarDBXInfo { get; set; }
        public class CreateApsDatasoureRequestPolarDBXInfo : TeaModel {
            /// <summary>
            /// <para>The OceanBase cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The ApsaraDB RDS for MySQL data source information.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("RdsMysqlInfo")]
        [Validation(Required=false)]
        public CreateApsDatasoureRequestRdsMysqlInfo RdsMysqlInfo { get; set; }
        public class CreateApsDatasoureRequestRdsMysqlInfo : TeaModel {
            /// <summary>
            /// <para>The read-only instance endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ConnectUrl")]
            [Validation(Required=false)]
            public string ConnectUrl { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-xxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The password.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-******</para>
            /// </summary>
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public string SecurityGroup { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Username.</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Simple Log Service (SLS) information for the data source to be created.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("SlsInfo")]
        [Validation(Required=false)]
        public CreateApsDatasoureRequestSlsInfo SlsInfo { get; set; }
        public class CreateApsDatasoureRequestSlsInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether cross-account access is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Across")]
            [Validation(Required=false)]
            public bool? Across { get; set; }

            /// <summary>
            /// <para>The role name for cross-account access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yyy</para>
            /// </summary>
            [NameInMap("AcrossRole")]
            [Validation(Required=false)]
            public string AcrossRole { get; set; }

            /// <summary>
            /// <para>The UID of the cross-account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("AcrossUid")]
            [Validation(Required=false)]
            public string AcrossUid { get; set; }

            /// <summary>
            /// <para>The Simple Log Service (SLS) project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-project</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The region ID of the source cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("SourceRegionId")]
            [Validation(Required=false)]
            public string SourceRegionId { get; set; }

            /// <summary>
            /// <para>sls logstore。</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-store</para>
            /// </summary>
            [NameInMap("Store")]
            [Validation(Required=false)]
            public string Store { get; set; }

        }

    }

}
