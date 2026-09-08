// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ProcessCustomIMCallbackRequest : TeaModel {
        /// <summary>
        /// <para>The channel ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cf584733-<em><b>-</b></em>-9699-cb77aa3b7aa6</para>
        /// </summary>
        [NameInMap("AccessChannelId")]
        [Validation(Required=false)]
        public string AccessChannelId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d165de4f-9851-445e-9535-66ebfa72fa51</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9cfad875-6260-4a53-ab6e-b13e3fb31f7d</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The message content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>消息内容，格式如下：</para>
        /// <para>文本消息：
        /// { &quot;contentType&quot;:&quot;Text&quot;, &quot;text&quot;:&quot;你好  &quot; }</para>
        /// <para>图片消息：
        /// { &quot;contentType&quot;:&quot;Image&quot;, &quot;mediaId&quot;: &quot;xxx-xxx-xxx&quot;, &quot;fileType&quot;: &quot;png&quot;, &quot;fileSize&quot;: 1233 }</para>
        /// <para>视频消息：
        /// { &quot;contentType&quot;:&quot;Video&quot;, &quot;mediaId&quot;: &quot;xxx-xxx-xxx&quot; &quot;duration&quot;: 12, &quot;fileSize&quot;: 1233, }</para>
        /// <para>音频消息：
        /// { &quot;contentType&quot;:&quot;Audio&quot;, &quot;mediaId&quot;: &quot;xxx-xxx-xxx&quot; &quot;duration&quot;: 12, &quot;fileSize&quot;: 1233 }</para>
        /// <para>文件消息：
        /// { &quot;contentType&quot;:&quot;File&quot;, &quot;mediaId&quot;: &quot;xxx-xxx-xxx&quot;, &quot;fileSize&quot;: 223232, &quot;filename&quot;: &quot;xyz. zip&quot; }</para>
        /// </summary>
        [NameInMap("MessageContent")]
        [Validation(Required=false)]
        public string MessageContent { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03C67DAD-EB26-41D8-949D-9B0C470FB716</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The profile picture ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("SenderAvatarMediaId")]
        [Validation(Required=false)]
        public string SenderAvatarMediaId { get; set; }

        /// <summary>
        /// <para>The user ID of the message sender.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63061274befd6b545aab4c83</para>
        /// </summary>
        [NameInMap("SenderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// <para>The name of the sender.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tom</para>
        /// </summary>
        [NameInMap("SenderName")]
        [Validation(Required=false)]
        public string SenderName { get; set; }

    }

}
