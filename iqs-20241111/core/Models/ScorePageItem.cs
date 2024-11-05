// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ScorePageItem : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>structure_web_info</para>
        /// </summary>
        [NameInMap("cardType")]
        [Validation(Required=false)]
        public string CardType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baijiahao.baidu.com</para>
        /// </summary>
        [NameInMap("displayLink")]
        [Validation(Required=false)]
        public string DisplayLink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100km/h-0制动能力上，仅有33.3m，不黑不吹，单看这个，<em>小米SU7</em>确实表现不错。而续航方面，101kWh电池容量，实现CLTC续航800km，还有现5分钟补能220km，15分钟补能510km的800V高压平台。而在...</para>
        /// </summary>
        [NameInMap("htmlSnippet")]
        [Validation(Required=false)]
        public string HtmlSnippet { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em>小米</em>SU7售价22.99万元起 高管亲自辟谣：发布前不会有<em>价格</em>-百家号</para>
        /// </summary>
        [NameInMap("htmlTitle")]
        [Validation(Required=false)]
        public string HtmlTitle { get; set; }

        [NameInMap("images")]
        [Validation(Required=false)]
        public List<IncludeImage> Images { get; set; }

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
        /// <para>昨天	，	小米	汽车	没有	发布	，	但	相关	的	信息	透露	的	差	不	多	了	。		
        ///         在	发布	会	现场	，	雷军	直接	称	小米	S	U	7	对	标	特斯拉	保时捷	，	有	100	项	行业	领先	，	可见	“	遥遥	领先	”	已经	不再	是	华为	专利	了	？		</para>
        /// <pre><c>    而	在	介绍	技术	时	，	雷军	也	从	电机	、	电池	、	大	压铸	、	自动	驾驶	、	智能	座舱	等	五	大	方面	展开	，	充分	展示	了	小米	汽车	的	技术	以及	技术	储备	，		 		能	堆	的	料	，	全都	堆	上去	了	…	…		
        ///     大家	比较	感	兴趣	的	性能	方面	，	2	.	78	s	的	0	-	100	km	/	h	加速	，	265	km	/	h	的	最高	时速
        /// </c></pre>
        /// </summary>
        [NameInMap("mainText")]
        [Validation(Required=false)]
        public string MainText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>text/html</para>
        /// </summary>
        [NameInMap("mime")]
        [Validation(Required=false)]
        public string Mime { get; set; }

        [NameInMap("pageMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> PageMap { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1704426524000</para>
        /// </summary>
        [NameInMap("publishTime")]
        [Validation(Required=false)]
        public long? PublishTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.234325235</para>
        /// </summary>
        [NameInMap("score")]
        [Validation(Required=false)]
        public double? Score { get; set; }

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
