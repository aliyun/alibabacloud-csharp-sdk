// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ResetConsumerApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The complete API key. This value is returned only in the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c4b1f0317cd4fd7a5b446d3503d**</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The ID of the consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-mqveroemc***</para>
        /// </summary>
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AA69096-757C-4647-B36C-29EBC2******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
