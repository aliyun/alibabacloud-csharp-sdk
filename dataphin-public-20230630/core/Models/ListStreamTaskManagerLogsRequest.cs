// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStreamTaskManagerLogsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Flink deployment instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7db678957dc449aab0086b931c9f8218</para>
        /// </summary>
        [NameInMap("DeploymentInstanceId")]
        [Validation(Required=false)]
        public string DeploymentInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the operating tenant. The gateway verifies that the current identity has access to the tenant and then injects the TenantId into the backend.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The optional ID of the operator. This parameter follows the gateway identity verification rules and is not directly bound to the backend UserId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7299592831043008</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The TaskManager ID. This parameter can be omitted when retrieving log content. If omitted, the JobManager logs are returned.</para>
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
