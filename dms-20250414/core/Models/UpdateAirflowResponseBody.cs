// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateAirflowResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NOT_FOUND</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unknown error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D21075-CD3E-4D98-8264-F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the updated Airflow instance.</para>
        /// </summary>
        [NameInMap("Root")]
        [Validation(Required=false)]
        public UpdateAirflowResponseBodyRoot Root { get; set; }
        public class UpdateAirflowResponseBodyRoot : TeaModel {
            /// <summary>
            /// <para>The name of the Airflow instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test airflow</para>
            /// </summary>
            [NameInMap("AirflowName")]
            [Validation(Required=false)]
            public string AirflowName { get; set; }

            /// <summary>
            /// <para>The version of Airflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.1</para>
            /// </summary>
            [NameInMap("AirflowVersion")]
            [Validation(Required=false)]
            public string AirflowVersion { get; set; }

            /// <summary>
            /// <para>The instance specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SMALL</para>
            /// </summary>
            [NameInMap("AppSpec")]
            [Validation(Required=false)]
            public string AppSpec { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AIRFLOW</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>A list of custom configuration items.</para>
            /// </summary>
            [NameInMap("CustomAirflowCfg")]
            [Validation(Required=false)]
            public List<string> CustomAirflowCfg { get; set; }

            /// <summary>
            /// <para>The directory where DAGs are scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default/dags</para>
            /// </summary>
            [NameInMap("DagsDir")]
            [Validation(Required=false)]
            public string DagsDir { get; set; }

            /// <summary>
            /// <para>A data mount item.</para>
            /// </summary>
            [NameInMap("DataMountInfoList")]
            [Validation(Required=false)]
            public List<DataMountInfo> DataMountInfoList { get; set; }

            /// <summary>
            /// <para>The error message returned upon deployment failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quota exists</para>
            /// </summary>
            [NameInMap("DeployErrorMsg")]
            [Validation(Required=false)]
            public string DeployErrorMsg { get; set; }

            /// <summary>
            /// <para>The description of the Airflow instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order schedule</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether serverless mode is enabled.</para>
            /// </summary>
            [NameInMap("EnableServerless")]
            [Validation(Required=false)]
            public bool? EnableServerless { get; set; }

            /// <summary>
            /// <para>The environment variables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k=v</para>
            /// </summary>
            [NameInMap("Environments")]
            [Validation(Required=false)]
            public string Environments { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-07T15:10:32+08:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The graceful shutdown timeout, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("GracefulShutdownTimeout")]
            [Validation(Required=false)]
            public int? GracefulShutdownTimeout { get; set; }

            /// <summary>
            /// <para>The name of the Object Storage Service (OSS) bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>osstest</para>
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <para>The path in OSS where logs are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/airflow</para>
            /// </summary>
            [NameInMap("OssPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

            /// <summary>
            /// <para>The directory where Airflow plugins are scanned.</para>
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
            /// <para>The Python package requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jieba==0.42</para>
            /// </summary>
            [NameInMap("Requirements")]
            [Validation(Required=false)]
            public string Requirements { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2ze1nak7h0alg1w5****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The startup script for the Airflow container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default/startup.sh</para>
            /// </summary>
            [NameInMap("StartupFile")]
            [Validation(Required=false)]
            public string StartupFile { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEPLOYED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The Airflow instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>af-xxx</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-hp3hyga33aur8tj36****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp16ko44pgciwv0****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The number of worker node replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WorkerServerlessReplicas")]
            [Validation(Required=false)]
            public int? WorkerServerlessReplicas { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86302423828****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
