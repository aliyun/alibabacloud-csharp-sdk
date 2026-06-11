// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateContextStoreAPIKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The value of the API key. This value is returned only upon creation. Store it in a secure location.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The display name of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production Service Key</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3B311FD9-A60B-55E0-A896-A0C73*********</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
