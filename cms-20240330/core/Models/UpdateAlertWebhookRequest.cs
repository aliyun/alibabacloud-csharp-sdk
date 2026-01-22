// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateAlertWebhookRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>headers</para>
        /// </summary>
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://aliyun.com/test">http://aliyun.com/test</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
