// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetStreamLogContentRequest : TeaModel {
        /// <summary>
        /// <para>The deployment instance ID. Obtain the value from the deploymentInstanceId parameter returned in the operation record or historical running instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7db678957dc449aab0086b931c9f8218</para>
        /// </summary>
        [NameInMap("DeploymentInstanceId")]
        [Validation(Required=false)]
        public string DeploymentInstanceId { get; set; }

        /// <summary>
        /// <para>The original name of the log file. Obtain the value from the logName parameter in the corresponding JobManager or TaskManager log file list. Pass the value as is.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flink--standalonesession-0-dataphin-session-7db678957dc449aab0086b931c9f8218-jobmanager.log</para>
        /// </summary>
        [NameInMap("LogName")]
        [Validation(Required=false)]
        public string LogName { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The ID of the Dataphin project to which the task belongs. This parameter is used for permission verification in the production environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7299592831043008</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The optional ID of the TaskManager. Obtain the value from the taskmanagerId parameter returned by the ListStreamTaskManagers operation. If this parameter is not specified or is empty, the JobManager logs are retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataphin-session-7db678957dc449aab0086b931c9f8218-taskmanazjkxq</para>
        /// </summary>
        [NameInMap("TaskmanagerId")]
        [Validation(Required=false)]
        public string TaskmanagerId { get; set; }

    }

}
