// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SaveReceiverDetailRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {         &quot;Email&quot;: &quot;<a href="mailto:example@alimail.com">example@alimail.com</a>&quot;,         &quot;CustomData&quot;: {&quot;name&quot;:&quot;Tom&quot;,&quot;age&quot;:&quot;30&quot;}&quot;     } ]</para>
        /// </summary>
        [NameInMap("CustomDetail")]
        [Validation(Required=false)]
        public string CustomDetail { get; set; }

        /// <summary>
        /// <para>Content, supports uploading multiple recipients at once, with a limit of 500 records per upload. Each record is separated by {} and commas, example:</para>
        /// <para>[{ },{ },{ }...], the format within {} is as follows:</para>
        /// <para>[{&quot;b&quot;:&quot;birthday&quot;,&quot;e&quot;:&quot;<a href="mailto:xxx@example.net">xxx@example.net</a>&quot;,&quot;g&quot;:&quot;gender&quot;,&quot;m&quot;:&quot;mobile&quot;,&quot;n&quot;:&quot;nickname&quot;,&quot;u&quot;:&quot;name&quot;}], when passing values, pass it as a string, not a list.</para>
        /// <para>If a duplicate recipient address is inserted, it will return &quot;ErrorCount&quot;: 1</para>
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
        /// <para>Recipient list ID</para>
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
