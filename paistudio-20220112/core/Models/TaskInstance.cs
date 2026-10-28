// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class TaskInstance : TeaModel {
        /// <summary>
        /// <para>The instance creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        /// <summary>
        /// <para>The instance end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:02:00Z</para>
        /// </summary>
        [NameInMap("GmtEndTime")]
        [Validation(Required=false)]
        public string GmtEndTime { get; set; }

        /// <summary>
        /// <para>The task instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>taskxxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-instance-xxxxx</para>
        /// </summary>
        [NameInMap("TaskInstanceId")]
        [Validation(Required=false)]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// <para>The cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The creator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
