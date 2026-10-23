// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateCollectorRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The client generates the token, which must be unique across different requests. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The collector configuration to update, represented as a JSON string.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
