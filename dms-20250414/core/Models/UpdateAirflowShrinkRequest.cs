// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateAirflowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the Airflow instance.</para>
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
        /// <para>The specifications of the Airflow instance.</para>
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
        /// <para>The directory path where Airflow scans for DAGs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/dags</para>
        /// </summary>
        [NameInMap("DagsDir")]
        [Validation(Required=false)]
        public string DagsDir { get; set; }

        [NameInMap("DataMountInfoList")]
        [Validation(Required=false)]
        public string DataMountInfoListShrink { get; set; }

        /// <summary>
        /// <para>The description of the Airflow instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test airflow</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnableServerless")]
        [Validation(Required=false)]
        public bool? EnableServerless { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("GracefulShutdownTimeout")]
        [Validation(Required=false)]
        public int? GracefulShutdownTimeout { get; set; }

        /// <summary>
        /// <para>The directory path where Airflow scans for plugins.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/plugins</para>
        /// </summary>
        [NameInMap("PluginsDir")]
        [Validation(Required=false)]
        public string PluginsDir { get; set; }

        /// <summary>
        /// <para>The path to the requirements file for package dependencies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/requirements.txt</para>
        /// </summary>
        [NameInMap("RequirementFile")]
        [Validation(Required=false)]
        public string RequirementFile { get; set; }

        /// <summary>
        /// <para>The path to the startup script for the Airflow instance.</para>
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
        /// <para>The Data Management Service (DMS) workspace ID.</para>
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
