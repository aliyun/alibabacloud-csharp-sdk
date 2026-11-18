// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class WeiboItem : TeaModel {
        /// <summary>
        /// <para>The search result template. Fixed as weibo_strong for Weibo scenarios.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weibo_strong</para>
        /// </summary>
        [NameInMap("cardType")]
        [Validation(Required=false)]
        public string CardType { get; set; }

        /// <summary>
        /// <para>The Weibo homepage of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://m.weibo.cn/u/7761793874?luicode=20000061&lfid=5024099350350075">https://m.weibo.cn/u/7761793874?luicode=20000061&amp;lfid=5024099350350075</a></para>
        /// </summary>
        [NameInMap("homepageLink")]
        [Validation(Required=false)]
        public string HomepageLink { get; set; }

        /// <summary>
        /// <para>The content of the Weibo post.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[Quick poll: Would you buy the Xiaomi SU7?]
        /// #Xiaomi SU7 road tests now cover more than 300 cities#
        /// On April 17, @Xiaomi Auto posted that SU7 road testing now covers over 300 cities nationwide, including tests in extremely cold and extremely hot weather. The total test mileage has reached 5.4 million kilometers and is still ongoing. Web link</para>
        /// </summary>
        [NameInMap("htmlSnippet")]
        [Validation(Required=false)]
        public string HtmlSnippet { get; set; }

        /// <summary>
        /// <para>The image information.</para>
        /// </summary>
        [NameInMap("images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// <para>The Weibo URL of the search result.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://m.weibo.cn/detail/5024099350350075?wm=90194_90009">https://m.weibo.cn/detail/5024099350350075?wm=90194_90009</a></para>
        /// </summary>
        [NameInMap("link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        /// <summary>
        /// <para>The publish time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An hour ago</para>
        /// </summary>
        [NameInMap("publishDisplayTime")]
        [Validation(Required=false)]
        public string PublishDisplayTime { get; set; }

        /// <summary>
        /// <para>The Weibo username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bailu Tech</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
