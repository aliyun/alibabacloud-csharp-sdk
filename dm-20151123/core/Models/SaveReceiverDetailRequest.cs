// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SaveReceiverDetailRequest : TeaModel {
        /// <summary>
        /// <para>The recipient\&quot;s email address and template parameters, in an array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{ &quot;Email&quot;: &quot;<a href="mailto:example@alimail.com">example@alimail.com</a>&quot;,&quot;CustomData&quot;: {&quot;name&quot;:&quot;Tom&quot;,&quot;age&quot;:&quot;30&quot;}}]</para>
        /// </summary>
        [NameInMap("CustomDetail")]
        [Validation(Required=false)]
        public string CustomDetail { get; set; }

        /// <summary>
        /// <para>The recipient details. You can upload up to 500 recipients in a single request. The value is a string in a JSON array format. Each object in the array represents a recipient. For example: \<c>[{ },{ },{ }...]\\</c>. The format for each recipient object is \<c>[{&quot;b&quot;:&quot;birthday&quot;,&quot;e&quot;:&quot;xxx\\@example.net&quot;,&quot;g&quot;:&quot;gender&quot;,&quot;m&quot;:&quot;mobile&quot;,&quot;n&quot;:&quot;nickname&quot;,&quot;u&quot;:&quot;name&quot;}]\\</c>. If you add a duplicate recipient address, the system returns \<c>&quot;ErrorCount&quot;: 1\\</c>.</para>
        /// <para>The format is \<c>[{ },{ },{ }...]\\</c>. The format of the content within each \<c>{}\\</c> is as follows:</para>
        /// <para>[{&quot;b&quot;:&quot;birthday&quot;,&quot;e&quot;:&quot;xxx\@example.net&quot;,&quot;g&quot;:&quot;gender&quot;,&quot;m&quot;:&quot;mobile&quot;,&quot;n&quot;:&quot;nickname&quot;,&quot;u&quot;:&quot;name&quot;}]. Pass the value as a string, not a list.</para>
        /// <para>Inserting a duplicate recipient address returns &quot;ErrorCount&quot;: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;b&quot;:&quot;birthday&quot;,&quot;e&quot;:&quot;<a href="mailto:xxx@alibaba-inc.com">xxx@alibaba-inc.com</a>&quot;,&quot;g&quot;:&quot;gender&quot;,&quot;m&quot;:&quot;mobile&quot;,&quot;n&quot;:&quot;nickname&quot;,&quot;u&quot;:&quot;name&quot;}]</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the recipient list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34642</para>
        /// </summary>
        [NameInMap("ReceiverId")]
        [Validation(Required=false)]
        public string ReceiverId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
