// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GlobalPageItem : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://baijiahao.baidu.com/s?id=1787881554557805096">https://baijiahao.baidu.com/s?id=1787881554557805096</a></para>
        /// </summary>
        [NameInMap("link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100km/h-0制动能力上，仅有33.3m，不黑不吹，单看这个，小米SU7确实表现不错。而续航方面，101kWh电池容量，实现CLTC续航800km，还有现5分钟补能220km，15分钟补能510km的800V高压平台。而在...</para>
        /// </summary>
        [NameInMap("snippet")]
        [Validation(Required=false)]
        public string Snippet { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>小米SU7售价22.99万元起 高管亲自辟谣：发布前不会有价格</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
