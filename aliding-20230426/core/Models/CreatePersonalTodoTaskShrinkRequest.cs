// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreatePersonalTodoTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>待办备注信息</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1703750708595</para>
        /// </summary>
        [NameInMap("DueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ &quot;012345&quot; ]</para>
        /// </summary>
        [NameInMap("ExecutorIds")]
        [Validation(Required=false)]
        public string ExecutorIdsShrink { get; set; }

        [NameInMap("NotifyConfigs")]
        [Validation(Required=false)]
        public string NotifyConfigsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[ &quot;012345&quot; ]</para>
        /// </summary>
        [NameInMap("ParticipantIds")]
        [Validation(Required=false)]
        public string ParticipantIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1703750708595</para>
        /// </summary>
        [NameInMap("ReminderTimeStamp")]
        [Validation(Required=false)]
        public long? ReminderTimeStamp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>待办标题</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

    }

}
