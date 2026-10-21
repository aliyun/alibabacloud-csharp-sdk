// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateAirflowRequest : TeaModel {
        /// <summary>
        /// <para>The unique key ID of the Airflow instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af-test****</para>
        /// </summary>
        [NameInMap("AirflowId")]
        [Validation(Required=false)]
        public string AirflowId { get; set; }

        /// <summary>
        /// <para>The name of the Airflow instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testairflow</para>
        /// </summary>
        [NameInMap("AirflowName")]
        [Validation(Required=false)]
        public string AirflowName { get; set; }

        /// <summary>
        /// <para>The specification description of the Airflow instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMALL</para>
        /// </summary>
        [NameInMap("AppSpec")]
        [Validation(Required=false)]
        public string AppSpec { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The DAG directory scanned by Airflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/dags</para>
        /// </summary>
        [NameInMap("DagsDir")]
        [Validation(Required=false)]
        public string DagsDir { get; set; }

        /// <summary>
        /// <para>The list of data mount information.</para>
        /// </summary>
        [NameInMap("DataMountInfoList")]
        [Validation(Required=false)]
        public List<DataMountInfo> DataMountInfoList { get; set; }

        /// <summary>
        /// <para>The description of the Airflow instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test airflow</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable serverless workers.</para>
        /// </summary>
        [NameInMap("EnableServerless")]
        [Validation(Required=false)]
        public bool? EnableServerless { get; set; }

        /// <summary>
        /// <para>The timeout period for a worker to exit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("GracefulShutdownTimeout")]
        [Validation(Required=false)]
        public int? GracefulShutdownTimeout { get; set; }

        /// <summary>
        /// <para>The plugin directory scanned by Airflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/plugins</para>
        /// </summary>
        [NameInMap("PluginsDir")]
        [Validation(Required=false)]
        public string PluginsDir { get; set; }

        /// <summary>
        /// <para>The installation file for package dependencies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/requirements.txt</para>
        /// </summary>
        [NameInMap("RequirementFile")]
        [Validation(Required=false)]
        public string RequirementFile { get; set; }

        /// <summary>
        /// <para>The script loaded at startup of the Airflow instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/startup.sh</para>
        /// </summary>
        [NameInMap("StartupFile")]
        [Validation(Required=false)]
        public string StartupFile { get; set; }

        /// <summary>
        /// <para>The number of worker nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WorkerServerlessReplicas")]
        [Validation(Required=false)]
        public int? WorkerServerlessReplicas { get; set; }

        /// <summary>
        /// <para>The ID of the Data Management (DMS) workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>863024238280****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
