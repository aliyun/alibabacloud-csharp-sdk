// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GlobalPageItem : TeaModel {
        /// <summary>
        /// <para>The full URL that the search result points to.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://baijiahao.baidu.com/s?id=1787881554557805096">https://baijiahao.baidu.com/s?id=1787881554557805096</a></para>
        /// </summary>
        [NameInMap("link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        /// <summary>
        /// <para>The truncated description of the search result in text format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>In terms of 100 km/h to 0 braking performance, the distance is only 33.3 m. Objectively speaking, the Xiaomi SU7 performs really well in this regard. As for range, it features a 101 kWh battery capacity, achieving a CLTC range of 800 km, and an 800 V high-voltage platform that supports 220 km of range in 5 minutes and 510 km in 15 minutes. And in..</para>
        /// </summary>
        [NameInMap("snippet")]
        [Validation(Required=false)]
        public string Snippet { get; set; }

        /// <summary>
        /// <para>The title of the search result in plain text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Xiaomi SU7 priced from 229,900 CNY, executive personally dispels rumors: no price will be announced before launch</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
