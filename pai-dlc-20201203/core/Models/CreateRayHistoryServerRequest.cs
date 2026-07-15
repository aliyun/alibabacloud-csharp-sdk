// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CreateRayHistoryServerRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: visible to all members in the workspace.</description></item>
        /// <item><description>PRIVATE: visible only to you and administrators in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The display name of the job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-ray-history-server</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The hardware specifications of the public resource group. To access the detailed list of specifications, see <a href="https://help.aliyun.com/document_detail/171758.html">PAI-DLC billing</a>.&gt;Notice: Prices vary depending on the specifications..</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// <para>The maximum runtime in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxRuntimeMinutes")]
        [Validation(Required=false)]
        public int? MaxRuntimeMinutes { get; set; }

        /// <summary>
        /// <para>The resource group ID. This parameter is optional.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, the job is committed to the public resource group.</description></item>
        /// <item><description>If the current workspace is attached to a resource quota, you can specify the corresponding resource quota ID. For details about how to query the resource quota ID, see <a href="https://help.aliyun.com/document_detail/2651299.html">Manage resource quotas</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>quotaxxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The storage path for Ray logs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket-test-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/tmp</para>
        /// </summary>
        [NameInMap("StoragePath")]
        [Validation(Required=false)]
        public string StoragePath { get; set; }

        /// <summary>
        /// <para>The workspace ID. &lt;props=&quot;china&quot;&gt;For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>..</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
