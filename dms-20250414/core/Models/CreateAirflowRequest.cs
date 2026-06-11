// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateAirflowRequest : TeaModel {
        /// <summary>
        /// <para>The name of the Airflow instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testairflow</para>
        /// </summary>
        [NameInMap("AirflowName")]
        [Validation(Required=false)]
        public string AirflowName { get; set; }

        /// <summary>
        /// <para>The Airflow version. Supported versions: 2.10 and 3.1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.1</para>
        /// </summary>
        [NameInMap("AirflowVersion")]
        [Validation(Required=false)]
        public string AirflowVersion { get; set; }

        /// <summary>
        /// <para>The compute specifications for the Airflow instance. Valid values: <b>SMALL</b>, <b>MEDIUM</b>, <b>LARGE</b>, <b>XLARGE</b>, or <b>X2LARGE</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMALL</para>
        /// </summary>
        [NameInMap("AppSpec")]
        [Validation(Required=false)]
        public string AppSpec { get; set; }

        /// <summary>
        /// <para>A client token to ensure request idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The path to the DAG directory for Airflow to scan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/dags</para>
        /// </summary>
        [NameInMap("DagsDir")]
        [Validation(Required=false)]
        public string DagsDir { get; set; }

        /// <summary>
        /// <para>A list of data mount configurations.</para>
        /// </summary>
        [NameInMap("DataMountInfoList")]
        [Validation(Required=false)]
        public List<DataMountInfo> DataMountInfoList { get; set; }

        /// <summary>
        /// <para>The description of the Airflow instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order scheduler</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable worker elasticity.</para>
        /// </summary>
        [NameInMap("EnableServerless")]
        [Validation(Required=false)]
        public bool? EnableServerless { get; set; }

        /// <summary>
        /// <para>The graceful shutdown timeout for workers, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("GracefulShutdownTimeout")]
        [Validation(Required=false)]
        public int? GracefulShutdownTimeout { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-test</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The OSS path for log storage.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/airflow</para>
        /// </summary>
        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        /// <summary>
        /// <para>The path to the plugin directory for the Airflow instance to scan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/plugins</para>
        /// </summary>
        [NameInMap("PluginsDir")]
        [Validation(Required=false)]
        public string PluginsDir { get; set; }

        /// <summary>
        /// <para>The path to the Python requirements file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/requirements.txt</para>
        /// </summary>
        [NameInMap("RequirementFile")]
        [Validation(Required=false)]
        public string RequirementFile { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp108t8ldzeyk1****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The path to the startup script in the Airflow container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/startup.sh</para>
        /// </summary>
        [NameInMap("StartupFile")]
        [Validation(Required=false)]
        public string StartupFile { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-8vbaf073jawozfp****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf63r6coyiw9o5****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The number of elastic worker nodes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WorkerServerlessReplicas")]
        [Validation(Required=false)]
        public int? WorkerServerlessReplicas { get; set; }

        /// <summary>
        /// <para>The ID of the DMS workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8630242382****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The ID of the zone where the instance will be created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
