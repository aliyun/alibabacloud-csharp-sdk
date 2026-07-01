// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryShortUrlRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The short link to query. Obtain this URL by calling the <a href="https://help.aliyun.com/document_detail/186774.html">AddShortUrl</a> API.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This API is not currently supported by Short Message Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://****.cn/6y8uy7</para>
        /// </summary>
        [NameInMap("ShortUrl")]
        [Validation(Required=false)]
        public string ShortUrl { get; set; }

    }

}
