// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateConsumerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6c4b1f0317cd4fd7a5b446d3503d**</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-mqveroemc***</para>
        /// </summary>
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ApiKey</para>
        /// </summary>
        [NameInMap("KeyType")]
        [Validation(Required=false)]
        public string KeyType { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD3FA5F3-FAF3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
