// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdatePipelineRequest : TeaModel {
        [NameInMap("ExtendConfig")]
        [Validation(Required=false)]
        public string ExtendConfig { get; set; }

        /// <summary>
        /// <para>The new name of the MPS queue. The value can contain letters, digits, and special characters such as hyphens (-) and can be up to 128 bytes in size. The value cannot start with a special character.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-pipeline-****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Message Service (MNS) configuration, such as the information about the MNS queue or topic. For more information, see the &quot;NotifyConfig&quot; section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Topic&quot;:&quot;example-topic-****&quot;}</para>
        /// </summary>
        [NameInMap("NotifyConfig")]
        [Validation(Required=false)]
        public string NotifyConfig { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the MPS queue that you want to update. To view the MPS queue ID, log on to the <b>MPS console</b> and choose <b>Global Settings</b> &gt; <b>Pipelines</b> in the left-side navigation pane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d1ce4d3efcb549419193f50f1fcd****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The role that is assigned to the current RAM user. To obtain the role, you can log on to the <b>Resource Access Management (RAM) console</b> and choose <b>Identities</b> &gt; <b>Roles</b> in the left-side navigation pane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunMTSDefaultRole</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The new state of the MPS queue.</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b>: The MPS queue is active. Jobs in the MPS queue can be scheduled and run by MPS.</description></item>
        /// <item><description><b>Paused</b>: The MPS queue is paused. Jobs in the MPS queue cannot be scheduled or run by MPS, and all jobs remain in the Submitted state. Jobs that are running will not be affected.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Paused</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
