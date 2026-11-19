// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStreamTaskManagerLogsRequest : TeaModel {
        /// <summary>
        /// <para>The deployment instance ID. Set this parameter to the deploymentInstanceId value returned in the operation record or historical running instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7db678957dc449aab0086b931c9f8218</para>
        /// </summary>
        [NameInMap("DeploymentInstanceId")]
        [Validation(Required=false)]
        public string DeploymentInstanceId { get; set; }

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
        /// <para>The user ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The ID of the Dataphin project to which the node belongs. This parameter is used for permission verification in the production environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7299592831043008</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The identifier of the TaskManager. Set this parameter to the taskmanagerId value returned by the ListStreamTaskManagers operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataphin-session-7db678957dc449aab0086b931c9f8218-taskmanazjkxq</para>
        /// </summary>
        [NameInMap("TaskmanagerId")]
        [Validation(Required=false)]
        public string TaskmanagerId { get; set; }

    }

}
