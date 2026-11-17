// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateScheduledTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string DescriptionShrink { get; set; }

        /// <summary>
        /// <para>The list of digital employee names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;test&quot;]</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeNameShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether public access is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isOpen")]
        [Validation(Required=false)]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// <para>The execution model tier. If this parameter is not specified, the model tier is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quick</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output conversation mode. If this parameter is omitted, the current configuration is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAME_CONVERSATION</para>
        /// </summary>
        [NameInMap("outputMode")]
        [Validation(Required=false)]
        public string OutputMode { get; set; }

        /// <summary>
        /// <para>The segments.</para>
        /// </summary>
        [NameInMap("segments")]
        [Validation(Required=false)]
        public string SegmentsShrink { get; set; }

        /// <summary>
        /// <para>The task details.</para>
        /// </summary>
        [NameInMap("taskDetail")]
        [Validation(Required=false)]
        public string TaskDetailShrink { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleTaskId</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If this parameter is not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The trigger configuration. The configuration varies based on the trigger type.</para>
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfigShrink { get; set; }

        /// <summary>
        /// <para>The visibility scope adjustment for group tasks. Valid values: PRIVATE (visible only to the creator and group owner), COLLABORATIVE (visible to specified collaborators), and PUBLIC (visible to all group members). If this parameter is not specified, the visibility scope is not updated. This field is ignored for personal tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COLLABORATIVE</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The full replacement list of collaborators. This parameter takes effect only when visibility is set to COLLABORATIVE. When the visibility is changed from COLLABORATIVE to another value, the list is cleared. A maximum of 1,000 members are supported. If this parameter is not specified, the members are not updated. You do not need to specify the task creator and group creator because they are covered by the authentication layer. This field is ignored for personal tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;10001&quot;]</para>
        /// </summary>
        [NameInMap("visibleMemberUserIds")]
        [Validation(Required=false)]
        public string VisibleMemberUserIdsShrink { get; set; }

    }

}
