// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateScheduledTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>所属协作群组 ID（如 cg_101）；传入时创建群空间任务（调用者需为有效群成员），为空创建个人任务</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleCollaborationGroupId</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string DescriptionShrink { get; set; }

        /// <summary>
        /// <para>数字员工名称列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeNameShrink { get; set; }

        /// <summary>
        /// <para>是否公开访问</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isOpen")]
        [Validation(Required=false)]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// <para>执行模型档位，不传默认 standard</para>
        /// 
        /// <b>Example:</b>
        /// <para>quick</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>文件名</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("segments")]
        [Validation(Required=false)]
        public string SegmentsShrink { get; set; }

        [NameInMap("taskDetail")]
        [Validation(Required=false)]
        public string TaskDetailShrink { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfigShrink { get; set; }

    }

}
