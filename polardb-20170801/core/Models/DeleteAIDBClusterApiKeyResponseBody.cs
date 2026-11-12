// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteAIDBClusterApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The API key for the model service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c4b1f0317cd4fd7a5b446d3503d**</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>068F730C-9130-596E-B696-5B4388C840DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
