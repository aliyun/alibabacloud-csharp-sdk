// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedPageItem : TeaModel {
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
        /// <para>The dynamic authority score, which ranges from 0 to 2 and is calculated based on the relevance to the query content.</para>
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
        /// <para><a href="https://www.china.com/zh_cn/img1905/2023/logo.png">https://www.china.com/zh_cn/img1905/2023/logo.png</a></para>
        /// </summary>
        [NameInMap("hostLogo")]
        [Validation(Required=false)]
        public string HostLogo { get; set; }

        /// <summary>
        /// <para>The site name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China.com</para>
        /// </summary>
        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The images from the search result web page, up to three.</para>
        /// </summary>
        [NameInMap("images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// <para>The full URL pointed to by the search result.</para>
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
        /// <para>During the 2025 Shanghai Auto Show, the AITO brand was undoubtedly the most popular, becoming the center of attention for many industry leaders. Zhang Xinghai, Chairman and Founder of SERES Group, Yu Chengdong, Managing Director of Huawei and Chairman of Terminal BG, Chen Daoming, a famous actor, and Zeng Yuqun, Chairman of CATL, all shared their experiences using AITO.\n&quot;AITO M9 and M8 are reshaping the landscape of China\&quot;s luxury car market,&quot; Zhang Xinghai said, (omitted here....).\nEditor: kj005\n Article complaint hotline: 157 3889 8464 Complaint email: 7983347 <a href="mailto:16@qq.com">16@qq.com</a>\nKeywords:</para>
        /// </summary>
        [NameInMap("mainText")]
        [Validation(Required=false)]
        public string MainText { get; set; }

        /// <summary>
        /// <para>The Markdown content.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>Industry leaders gather at the Shanghai Auto Show as AITO becomes the center of attention<b>Source</b>: Caixun.com</h1>
        /// <para><b>Time</b>: 2025-04-27 20:36:04<br>During the 2025 Shanghai Auto Show, the AITO brand was undoubtedly the most popular, becoming the center of attention for many industry leaders. Zhang Xinghai, Chairman and Founder of SERES Group, Yu Chengdong, Managing Director of Huawei and Chairman of Terminal BG, Chen Daoming, a famous actor, and Zeng Yuqun, Chairman of CATL, all shared their experiences using AITO.
        /// <img src="http://objectnsg.oss-cn-beijing.aliyuncs.com/yhdoc/202504/27/202504272025531927023138.png" alt="Image">Yu Chengdong stated that AITO M9, M8, M7, and M5 are all deeply loved by consumers! AITO M9 has ranked first in the residual value rate of pure electric models in China for three consecutive months! Pure electric and extended-range models took the top two spots in the residual value rate of new energy large SUVs!
        /// <img src="http://objectnsg.oss-cn-beijing.aliyuncs.com/yhdoc/202504/27/202504272025531312025791.jpeg" alt="Image">&quot;I am an AITO M9 user
        /// <em>Editor: kj005</em>Article complaint hotline: 157 3889 8464<br>Complaint email: <a href="mailto:798334716@qq.com">798334716@qq.com</a></para>
        /// </summary>
        [NameInMap("markdownText")]
        [Validation(Required=false)]
        public string MarkdownText { get; set; }

        /// <summary>
        /// <para>The publish time of the web page in ISO format.</para>
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

        /// <summary>
        /// <para>The full rich text body, which preserves the order of text, images, audio, video, tables, and code on the web page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Salute	to	the	workers	!	\n	[	Building	dreams	for	modernization	 	and	drawing	a	new	picture	together	·	Song	of	the	workers	]	Make	new	contributions	to	promoting	Chinese	modernization	\n	<quark-image available_status="3" caption="CCTV news studio" fetch_status="0" is_broken="0" is_high_quality_chart="0" is_high_quality_text="0" is_watermark="0" ori_height="1080" ori_width="1920" phash="13061254655082448525" relevant_score="0.5" render_height="137.046875" render_width="243.65625" tag="CCTV logo, studio, architecture, scenery" url="http://s2.zimgs.cn/ims?kt=url&amp;key=aHR0cHM6Ly92Mi5jcmkuY24vTTAwLzg2LzAyL3JCQUJDbVkzRzhDQVhFR0pBQUFBQUFBQUFBQTQ0LjE5MjB4MTA4MC5qcGVn&amp;sign=yx:G3TGlZZMQhnxU2bJSDcb_g8xPQ0=&amp;tv=0_0&amp;p=" value_score="0.5"><quark-ocr>	CCTV	 	13	 	News	 	CTVR	 	Morning	World	</quark-ocr></quark-image>	\n	More	&gt;	&gt;	&gt;	 	Most	beautiful	workers	\n</para>
        /// </summary>
        [NameInMap("richMainBody")]
        [Validation(Required=false)]
        public string RichMainBody { get; set; }

        /// <summary>
        /// <para>The summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>During the 2025 Shanghai Auto Show, the AITO brand was undoubtedly the most popular, becoming the center of attention for many industry leaders. Zhang Xinghai, Chairman and Founder of SERES Group, Yu Chengdong, Managing Director of Huawei and Chairman of Terminal BG, Chen Daoming, a famous actor, and Zeng Yuqun, Chairman of CATL, all shared their experiences using AITO. ..</para>
        /// </summary>
        [NameInMap("snippet")]
        [Validation(Required=false)]
        public string Snippet { get; set; }

        /// <summary>
        /// <para>The enhanced summary, 400 words or more.</para>
        /// 
        /// <b>Example:</b>
        /// <para>During the 2025 Shanghai Auto Show, the AITO brand was undoubtedly the most popular, becoming the center of attention for many industry leaders. Zhang Xinghai, Chairman and Founder of SERES Group, Yu Chengdong, Managing Director of Huawei and Chairman of Terminal BG, Chen Daoming, a famous actor, and Zeng Yuqun, Chairman of CATL, all shared their experiences using AITO. &quot;I am an AITO M9 user, and the driving experience is excellent,&quot; Chen Daoming said, adding that he only dared to recommend it on the spot after experiencing it himself. In the future, he hopes to achieve special customization of the AITO M9, making the exterior, interior, and seat layout more in line with his own needs. It is reported that the 2025 AITO M9 delivered over 10,000 units within 25 days of its launch, and has been the sales champion of 500,000 RMB luxury cars for 11 consecutive months; the AITO M8 received over 50,000 firm orders within 4 days of its launch, and is deeply loved by the market and users... &quot;AITO M9 and M8 are reshaping the landscape of China\&quot;s luxury car market,&quot; Zhang Xinghai said. He recently test-drove the AITO M8 to the limit, departing from Chongqing and arriving at Mount Kailash after 55 hours and over 3,500 kilometers. Throughout the journey, the safety and experience of the vehicle performed excellently</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The web page tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;genre&quot;:&quot;NewsPortal&quot;}</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The full URL pointed to by the search result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Industry leaders gather at the Shanghai Auto Show as AITO becomes the center of attention</para>
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
