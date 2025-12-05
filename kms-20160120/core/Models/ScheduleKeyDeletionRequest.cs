// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ScheduleKeyDeletionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the customer master key (CMK). The ID must be globally unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7906979c-8e06-46a2-be2d-68e3ccbc****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The scheduled period after which the CMK is deleted. During this period, the CMK is in the PendingDeletion state. After this period ends, you cannot cancel the key deletion task.</para>
        /// <para>Valid values: 7 to 366.</para>
        /// <para>Unit: days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PendingWindowInDays")]
        [Validation(Required=false)]
        public int? PendingWindowInDays { get; set; }

    }

}
