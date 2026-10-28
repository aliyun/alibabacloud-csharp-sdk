// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QueueMeta : TeaModel {
        /// <summary>
        /// <para>The time when the task was dequeued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtDequeuedTime")]
        [Validation(Required=false)]
        public string GmtDequeuedTime { get; set; }

        /// <summary>
        /// <para>The time when the task was enqueued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtEnqueuedTime")]
        [Validation(Required=false)]
        public string GmtEnqueuedTime { get; set; }

        /// <summary>
        /// <para>The time when the position of the task in the queue was changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtPositionModifiedTime")]
        [Validation(Required=false)]
        public string GmtPositionModifiedTime { get; set; }

        /// <summary>
        /// <para>The name of the task in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlcxxxx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The position of the task in the queue. This parameter takes effect only when the task is queued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public string Position { get; set; }

        /// <summary>
        /// <para>The dequeue strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PaiStrategyIntelligent</para>
        /// </summary>
        [NameInMap("QueueStrategy")]
        [Validation(Required=false)]
        public string QueueStrategy { get; set; }

        /// <summary>
        /// <para>The resource quota queue to which the task belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotad2kd8ljpsno</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The resources occupied by the task in the queue.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ResourceAmount Resource { get; set; }

        /// <summary>
        /// <para>The scheduled resources occupied by the task in the queue.</para>
        /// </summary>
        [NameInMap("ScheduledResource")]
        [Validation(Required=false)]
        public string ScheduledResource { get; set; }

        /// <summary>
        /// <para>The status of the task in the queue, such as enqueued or dequeued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enqueued</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Specifies whether the task uses idle resources.</para>
        /// </summary>
        [NameInMap("UseOversoldResource")]
        [Validation(Required=false)]
        public bool? UseOversoldResource { get; set; }

    }

}
