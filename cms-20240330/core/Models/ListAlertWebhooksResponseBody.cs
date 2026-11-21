// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertWebhooksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8A33DBEA-<em><b><b>-</b></b></em>-<em><b><b>-</b></b></em></para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// <para>The list of webhooks.</para>
        /// </summary>
        [NameInMap("webhooks")]
        [Validation(Required=false)]
        public List<ListAlertWebhooksResponseBodyWebhooks> Webhooks { get; set; }
        public class ListAlertWebhooksResponseBodyWebhooks : TeaModel {
            /// <summary>
            /// <para>The content type of the data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>JSON</description></item>
            /// <item><description>FORM</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>JSON</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The collection of HTTP request headers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;X-Total-Count&quot;:&quot;0&quot;}</para>
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, object> Headers { get; set; }

            /// <summary>
            /// <para>The language. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>zh_CN</description></item>
            /// <item><description>en_US</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh_CN</para>
            /// </summary>
            [NameInMap("lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The request method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GET</description></item>
            /// <item><description>POST</description></item>
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
            /// <para>The alert callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://aliyun.com/test">http://aliyun.com/test</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The unique identifiers of the webhooks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("webhookId")]
            [Validation(Required=false)]
            public string WebhookId { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-cms-0000000000000000-cn-hangzhou</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

    }

}
