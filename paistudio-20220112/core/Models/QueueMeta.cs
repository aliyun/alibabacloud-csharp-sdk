// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QueueMeta : TeaModel {
        /// <summary>
        /// <para>The time the entry was removed from the queue.</para>
        /// </summary>
        [NameInMap("GmtDequeuedTime")]
        [Validation(Required=false)]
        public string GmtDequeuedTime { get; set; }

        /// <summary>
        /// <para>The time the entry was added to the queue.</para>
        /// </summary>
        [NameInMap("GmtEnqueuedTime")]
        [Validation(Required=false)]
        public string GmtEnqueuedTime { get; set; }

        /// <summary>
        /// <para>The last time the position of the entry was modified.</para>
        /// </summary>
        [NameInMap("GmtPositionModifiedTime")]
        [Validation(Required=false)]
        public string GmtPositionModifiedTime { get; set; }

        /// <summary>
        /// <para>The name of the queue entry.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The position of the entry in the queue.</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public string Position { get; set; }

        /// <summary>
        /// <para>The queuing strategy for the entry.</para>
        /// </summary>
        [NameInMap("QueueStrategy")]
        [Validation(Required=false)]
        public string QueueStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the associated quota.</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The resources that the queue entry requires.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ResourceAmount Resource { get; set; }

        /// <summary>
        /// <para>The resources scheduled for the entry.</para>
        /// </summary>
        [NameInMap("ScheduledResource")]
        [Validation(Required=false)]
        public string ScheduledResource { get; set; }

        /// <summary>
        /// <para>The current status of the entry.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the entry can use oversold resources.</para>
        /// </summary>
        [NameInMap("UseOversoldResource")]
        [Validation(Required=false)]
        public bool? UseOversoldResource { get; set; }

    }

}
