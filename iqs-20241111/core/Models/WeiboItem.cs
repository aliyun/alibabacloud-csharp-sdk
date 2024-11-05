// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class WeiboItem : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weibo_strong</para>
        /// </summary>
        [NameInMap("cardType")]
        [Validation(Required=false)]
        public string CardType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://m.weibo.cn/u/7761793874?luicode=20000061&lfid=5024099350350075">https://m.weibo.cn/u/7761793874?luicode=20000061&amp;lfid=5024099350350075</a></para>
        /// </summary>
        [NameInMap("homepageLink")]
        [Validation(Required=false)]
        public string HomepageLink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>【小调查：你会买<em>小米SU7</em>吗？】#小米SU7路测覆盖300多城市#4月17日，@小米汽车 发文称SU7道路测试覆盖全国300多个城市，涵盖极寒，极热天气，总里程数高达540万公里，目前仍在进行中。  网页链接</para>
        /// </summary>
        [NameInMap("htmlSnippet")]
        [Validation(Required=false)]
        public string HtmlSnippet { get; set; }

        [NameInMap("images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://m.weibo.cn/detail/5024099350350075?wm=90194_90009">https://m.weibo.cn/detail/5024099350350075?wm=90194_90009</a></para>
        /// </summary>
        [NameInMap("link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1小时前</para>
        /// </summary>
        [NameInMap("publishDisplayTime")]
        [Validation(Required=false)]
        public string PublishDisplayTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>白鹿科技</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
