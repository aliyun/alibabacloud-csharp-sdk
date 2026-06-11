// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MergeWebhook : TeaModel {
        /// <summary>
        /// <para>The content type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/json</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>An extension field used to store additional configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;timeout&quot;: 3000}</para>
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58.789Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The last modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58.789Z</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public Dictionary<string, object> GmtModified { get; set; }

        /// <summary>
        /// <para>The request header.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Authorization&quot;: &quot;Bearer abc123&quot;}</para>
        /// </summary>
        [NameInMap("headers")]
        [Validation(Required=false)]
        public string Headers { get; set; }

        /// <summary>
        /// <para>The unique identifier of the webhook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>webhook-12345</para>
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The language preference.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The HTTP request method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POST</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The name of the webhook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>运维告警通知</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source system of the webhook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The type of the webhook. It indicates the destination platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The webhook URL used to send requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=abc123">https://oapi.dingtalk.com/robot/send?access_token=abc123</a></para>
        /// </summary>
        [NameInMap("webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
