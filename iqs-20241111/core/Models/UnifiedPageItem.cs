// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedPageItem : TeaModel {
        [NameInMap("correlationTag")]
        [Validation(Required=false)]
        public int? CorrelationTag { get; set; }

        [NameInMap("hostAuthorityScore")]
        [Validation(Required=false)]
        public double? HostAuthorityScore { get; set; }

        /// <summary>
        /// <para>The site logo.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.china.com/zh_cn/img1905/2023/logo.png">https://www.china.com/zh_cn/img1905/2023/logo.png</a></para>
        /// </summary>
        [NameInMap("hostLogo")]
        [Validation(Required=false)]
        public string HostLogo { get; set; }

        /// <summary>
        /// <para>The site name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中华网</para>
        /// </summary>
        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The images in the search result URL. A maximum of three images are returned.</para>
        /// </summary>
        [NameInMap("images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// <para>The full URL that the search result points to.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://hea.china.com/articles/20250427/202504271666343.html">https://hea.china.com/articles/20250427/202504271666343.html</a></para>
        /// </summary>
        [NameInMap("link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        /// <summary>
        /// <para>The full text of the searched web page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025上海车展期间，最火爆的无疑是问界品牌，成为众多大佬的话题中心。赛力斯集团董事长（创始人）张兴海、华为常务董事、终端BG董事长余承东、著名演员陈道明、宁德时代董事长曾毓群都分享了对问界的使用体验。\n“问界M9、M8正重构 中国 豪华汽车市场格局。”张兴海说， (此处省略....)。\n责任编辑：kj005\n 文章投诉热线:157 3889 8464 投诉邮箱:7983347 <a href="mailto:16@qq.com">16@qq.com</a>\n关键词：</para>
        /// </summary>
        [NameInMap("mainText")]
        [Validation(Required=false)]
        public string MainText { get; set; }

        /// <summary>
        /// <para>The Markdown content.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>上海车展大佬齐聚 问界成为话题中心<b>来源</b>：财讯网</h1>
        /// <para><b>时间</b>：2025-04-27 20:36:04<br>2025上海车展期间，最火爆的无疑是问界品牌，成为众多大佬的话题中心。赛力斯集团董事长（创始人）张兴海、华为常务董事、终端BG董事长余承东、著名演员陈道明、宁德时代董事长曾毓群都分享了对问界的使用体验。
        /// <img src="http://objectnsg.oss-cn-beijing.aliyuncs.com/yhdoc/202504/27/202504272025531927023138.png" alt="图片">余承东表示，问界M9、M8、M7和M5，都深受消费者喜爱！问界M9连续3个月中国纯电车型保值率第一！纯电、增程车型包揽新能源大型SUV保值率前两名！
        /// <img src="http://objectnsg.oss-cn-beijing.aliyuncs.com/yhdoc/202504/27/202504272025531312025791.jpeg" alt="图片">“自己是问界M9的用户
        /// <em>责任编辑：kj005</em>文章投诉热线: 157 3889 8464<br>投诉邮箱: <a href="mailto:798334716@qq.com">798334716@qq.com</a></para>
        /// </summary>
        [NameInMap("markdownText")]
        [Validation(Required=false)]
        public string MarkdownText { get; set; }

        /// <summary>
        /// <para>The time when the web page was published, in ISO time format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-27T20:36:04+08:00</para>
        /// </summary>
        [NameInMap("publishedTime")]
        [Validation(Required=false)]
        public string PublishedTime { get; set; }

        /// <summary>
        /// <para>The rerank score.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7786493301391602</para>
        /// </summary>
        [NameInMap("rerankScore")]
        [Validation(Required=false)]
        public double? RerankScore { get; set; }

        [NameInMap("richMainBody")]
        [Validation(Required=false)]
        public string RichMainBody { get; set; }

        /// <summary>
        /// <para>The text summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025上海车展期间，最火爆的无疑是问界品牌，成为众多大佬的话题中心。赛力斯集团董事长（创始人）张兴海、华为常务董事、终端BG董事长余承东、著名演员陈道明、宁德时代董事长曾毓群都分享了对问界的使用体验。 ...</para>
        /// </summary>
        [NameInMap("snippet")]
        [Validation(Required=false)]
        public string Snippet { get; set; }

        /// <summary>
        /// <para>The enhanced summary, which contains 400 or more characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025上海车展期间，最火爆的无疑是问界品牌，成为众多大佬的话题中心。赛力斯集团董事长（创始人）张兴海、华为常务董事、终端BG董事长余承东、著名演员陈道明、宁德时代董事长曾毓群都分享了对问界的使用体验。“自己是问界M9的用户，用车感受非常好。”陈道明表示，体验后才敢现场给大家推荐。未来，希望能实现问界M9的特别定制，让外观、内饰、座椅布局等，更符合自己的使用需求。据悉，2025款问界M9上市25天就交付超1万，已连续11个月蝉联50万元级豪车车销冠；问界M8上市4天，大定就突破了五万 台 ，深受市场任何和用户喜爱...“问界M9、M8正重构 中国 豪华汽车市场格局。”张兴海说， 近 期曾极限试驾问界M8，从重庆出发，历时55小时、行驶超3500公里抵达冈仁波齐。整个行程中，车辆的安全 性 和体验感都表现出色。</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The full URL that the search result points to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>上海车展大佬齐聚 问界成为话题中心</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("websiteAuthorityScore")]
        [Validation(Required=false)]
        public int? WebsiteAuthorityScore { get; set; }

    }

}
