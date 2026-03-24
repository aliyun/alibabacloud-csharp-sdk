// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateAlertWebhookRequest : TeaModel {
        /// <summary>
        /// <para>The content type of the data. Supported values:</para>
        /// <list type="bullet">
        /// <item><description><para>JSON</para>
        /// </description></item>
        /// <item><description><para>FORM</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The headers.</para>
        /// </summary>
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// <para>The language. Supported values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh_CN</para>
        /// </description></item>
        /// <item><description><para>en_US</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The request method. Supported values:</para>
        /// <list type="bullet">
        /// <item><description><para>GET</para>
        /// </description></item>
        /// <item><description><para>POST</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The name of the webhook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The URL of the alert callback.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://aliyun.com/test">http://aliyun.com/test</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
