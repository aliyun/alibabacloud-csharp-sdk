// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class CreateOutboundCallRestrictionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The outbound call restriction.</para>
        /// </summary>
        [NameInMap("OutboundCallRestriction")]
        [Validation(Required=false)]
        public string OutboundCallRestrictionShrink { get; set; }

        /// <summary>
        /// <para>The policy. Valid values:
        /// 0: blacklist.
        /// 1: whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public int? Policy { get; set; }

    }

}
