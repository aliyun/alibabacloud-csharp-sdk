// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class PushTimesUsageRequest : TeaModel {
        [NameInMap("Adjust")]
        [Validation(Required=false)]
        public bool? Adjust { get; set; }

        [NameInMap("AdjustDate")]
        [Validation(Required=false)]
        public long? AdjustDate { get; set; }

        /// <summary>
        /// <para>The client token used to ensure request idempotence. We recommend that you use a UUID. The same <c>ClientToken</c> can be submitted only once within 24 hours. Retries for the same operation must use the same <c>ClientToken</c>, and new operations must use a new <c>ClientToken</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6dff6c70-3484-4a39-b725-164e3ad9b20d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Marketplace instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000001</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Mark")]
        [Validation(Required=false)]
        public string Mark { get; set; }

        /// <summary>
        /// <para>The number of uses to deduct. The value must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Times")]
        [Validation(Required=false)]
        public long? Times { get; set; }

    }

}
