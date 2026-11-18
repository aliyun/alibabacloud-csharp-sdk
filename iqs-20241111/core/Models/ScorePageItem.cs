// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ScorePageItem : TeaModel {
        /// <summary>
        /// <para>The search result template. Different templates return different fields.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>structure_web_info</para>
        /// </summary>
        [NameInMap("cardType")]
        [Validation(Required=false)]
        public string CardType { get; set; }

        /// <summary>
        /// <para>The relevance tag. A value of 0 indicates low relevance, and 1 indicates non-low relevance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("correlationTag")]
        [Validation(Required=false)]
        public int? CorrelationTag { get; set; }

        /// <summary>
        /// <para>The abbreviated URL of this search result.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baijiahao.baidu.com</para>
        /// </summary>
        [NameInMap("displayLink")]
        [Validation(Required=false)]
        public string DisplayLink { get; set; }

        /// <summary>
        /// <para>The dynamic authority score, which ranges from 0 to 2 and is calculated based on the relevance of the query content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.923339</para>
        /// </summary>
        [NameInMap("hostAuthorityScore")]
        [Validation(Required=false)]
        public double? HostAuthorityScore { get; set; }

        /// <summary>
        /// <para>The site logo.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://s2.zimgs.cn/ims?kt=url&at=smstruct&key=aHR0cHM6Ly9ndy5hbGljZG4uY29tL0wxLzcyMy8xNTY1MjU2NjAwLzJhL2YwL2I0LzJhZjBiNDQxMGI5YmVlMDVjOGVlNGJmODk3MTNkNTFjLnBuZw==&sign=yx:CUlNNQVJQjFrk3Kxt2F3KWhTOFU=&tv=400_400">https://s2.zimgs.cn/ims?kt=url&amp;at=smstruct&amp;key=aHR0cHM6Ly9ndy5hbGljZG4uY29tL0wxLzcyMy8xNTY1MjU2NjAwLzJhL2YwL2I0LzJhZjBiNDQxMGI5YmVlMDVjOGVlNGJmODk3MTNkNTFjLnBuZw==&amp;sign=yx:CUlNNQVJQjFrk3Kxt2F3KWhTOFU=&amp;tv=400_400</a></para>
        /// </summary>
        [NameInMap("hostLogo")]
        [Validation(Required=false)]
        public string HostLogo { get; set; }

        /// <summary>
        /// <para>The site name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Xinhua News</para>
        /// </summary>
        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The description snippet of the search result in HTML format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>In terms of 100 km/h-0 braking capability, it is only 33.3m. Without bias, just looking at this, the <em>Xiaomi SU7</em> indeed performs well. As for range, with a 101 kWh battery capacity, it achieves a CLTC range of 800 km, and features an 800V high-voltage platform that can add 220 km of range in 5 minutes and 510 km in 15 minutes. And..</para>
        /// </summary>
        [NameInMap("htmlSnippet")]
        [Validation(Required=false)]
        public string HtmlSnippet { get; set; }

        /// <summary>
        /// <para>The search result title in HTML format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em>Xiaomi</em> SU7 priced from 229,900 yuan, executive personally dispels rumors: no <em>price</em> before launch - Baijiahao</para>
        /// </summary>
        [NameInMap("htmlTitle")]
        [Validation(Required=false)]
        public string HtmlTitle { get; set; }

        /// <summary>
        /// <para>The image information.</para>
        /// </summary>
        [NameInMap("images")]
        [Validation(Required=false)]
        public List<IncludeImage> Images { get; set; }

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
        /// <para>The full text of the search result, which is available in some scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Yesterday, Xiaomi Auto was not launched, but related information has been mostly revealed. At the launch event, Lei Jun directly stated that Xiaomi SU7 benchmarks Tesla and Porsche, with 100 industry-leading features. It seems that &quot;far ahead&quot; is no longer a Huawei patent? When introducing the technology, Lei Jun also expanded on five major aspects: motor, battery, mega casting, autonomous driving, and smart cockpit, fully demonstrating Xiaomi Auto\&quot;s technology and technical reserves. All the materials that can be stacked are stacked... Regarding the performance that everyone is interested in, 0-100 km/h acceleration in 2.78s, and a top speed of 265 km/h</para>
        /// </summary>
        [NameInMap("mainText")]
        [Validation(Required=false)]
        public string MainText { get; set; }

        /// <summary>
        /// <para>The web page body in Markdown format.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>2022 Apsara Conference Homepage</h1>
        /// </summary>
        [NameInMap("markdownText")]
        [Validation(Required=false)]
        public string MarkdownText { get; set; }

        /// <summary>
        /// <para>The MIME type of the search result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text/html</para>
        /// </summary>
        [NameInMap("mime")]
        [Validation(Required=false)]
        public string Mime { get; set; }

        /// <summary>
        /// <para>The supplementary page information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("pageMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> PageMap { get; set; }

        /// <summary>
        /// <para>The publish time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1704426524000</para>
        /// </summary>
        [NameInMap("publishTime")]
        [Validation(Required=false)]
        public long? PublishTime { get; set; }

        /// <summary>
        /// <para>The full rich text body, which preserves the order of text, images, audio, video, tables, and code in the web page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><quark-ocr> 24 hx 3 </quark-ocr></para>
        /// </summary>
        [NameInMap("richMainBody")]
        [Validation(Required=false)]
        public string RichMainBody { get; set; }

        /// <summary>
        /// <para>The score.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.234325235</para>
        /// </summary>
        [NameInMap("score")]
        [Validation(Required=false)]
        public double? Score { get; set; }

        /// <summary>
        /// <para>The site label. Two types are currently supported:</para>
        /// <list type="bullet">
        /// <item><description>Authoritative media</description></item>
        /// <item><description>Party and government organs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Authoritative media</para>
        /// </summary>
        [NameInMap("siteLabel")]
        [Validation(Required=false)]
        public string SiteLabel { get; set; }

        /// <summary>
        /// <para>The description snippet of the search result in text format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>In terms of 100 km/h-0 braking capability, it is only 33.3m. Without bias, just looking at this, the Xiaomi SU7 indeed performs well. As for range, with a 101 kWh battery capacity, it achieves a CLTC range of 800 km, and features an 800V high-voltage platform that can add 220 km of range in 5 minutes and 510 km in 15 minutes. And..</para>
        /// </summary>
        [NameInMap("snippet")]
        [Validation(Required=false)]
        public string Snippet { get; set; }

        /// <summary>
        /// <para>The enhanced summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tomorrow</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The search result title in plain text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Xiaomi SU7 priced from 229,900 yuan, executive personally dispels rumors: no price before launch</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The static authority score, which is determined solely by the authority of the website itself and is independent of the query content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("websiteAuthorityScore")]
        [Validation(Required=false)]
        public int? WebsiteAuthorityScore { get; set; }

    }

}
