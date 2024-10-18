// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateTodoTaskShrinkRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>应用可以调用该接口发起一个钉钉待办任务，该待办事项会出现在钉钉客户端“待办”页面，需要注意的是，通过开放接口发起的待办，目前仅支持直接跳转ISV应用详情页（ISV在调该接口时需传入自身应用详情页链接）。</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("done")]
        [Validation(Required=false)]
        public bool? Done { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1617675000000</para>
        /// </summary>
        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public string ExecutorIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("participantIds")]
        [Validation(Required=false)]
        public string ParticipantIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>更新钉钉待办</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>taskId</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
