// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTopUrlVisitResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of frequently requested URLs.</para>
        /// </summary>
        [NameInMap("AllUrlList")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlList AllUrlList { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlList : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyAllUrlListUrlList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. (Unit: bytes)</para>
                /// 
                /// <b>Example:</b>
                /// <para>460486880</para>
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// <para>The proportion of network traffic consumed to access the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// <para>The complete URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/nn_live/nn_x64/a0.m3u8">http://example.com/nn_live/nn_x64/a0.m3u8</a></para>
                /// </summary>
                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                /// <summary>
                /// <para>The number of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161673</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64D28B53-5902-409B-94F6-FD46680144FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-03T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>A list of URLs for which 2xx status codes were returned.</para>
        /// </summary>
        [NameInMap("Url200List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl200List Url200List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl200List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl200ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl200ListUrlList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. (Unit: bytes)</para>
                /// 
                /// <b>Example:</b>
                /// <para>460486880</para>
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// <para>The proportion of network traffic consumed to access the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// <para>The complete URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/nn_live/nn_x64/a0.m3u8">http://example.com/nn_live/nn_x64/a0.m3u8</a></para>
                /// </summary>
                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                /// <summary>
                /// <para>The number of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161673</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

        /// <summary>
        /// <para>A list of URLs for which 3xx status codes were returned.</para>
        /// </summary>
        [NameInMap("Url300List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl300List Url300List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl300List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl300ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl300ListUrlList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. (Unit: bytes)</para>
                /// 
                /// <b>Example:</b>
                /// <para>460486880</para>
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// <para>The proportion of network traffic consumed to access the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// <para>The complete URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/nn_live/nn_x64/a0.m3u8">http://example.com/nn_live/nn_x64/a0.m3u8</a></para>
                /// </summary>
                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                /// <summary>
                /// <para>The number of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161673</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

        /// <summary>
        /// <para>A list of URLs for which 4xx status codes were returned.</para>
        /// </summary>
        [NameInMap("Url400List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl400List Url400List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl400List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl400ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl400ListUrlList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. (Unit: bytes)</para>
                /// 
                /// <b>Example:</b>
                /// <para>460486880</para>
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// <para>The proportion of network traffic consumed to access the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// <para>The complete URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/nn_live/nn_x64/a0.m3u8">http://example.com/nn_live/nn_x64/a0.m3u8</a></para>
                /// </summary>
                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                /// <summary>
                /// <para>The number of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161673</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

        /// <summary>
        /// <para>A list of URLs for which 5xx status codes were returned.</para>
        /// </summary>
        [NameInMap("Url500List")]
        [Validation(Required=false)]
        public DescribeDcdnDomainTopUrlVisitResponseBodyUrl500List Url500List { get; set; }
        public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl500List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainTopUrlVisitResponseBodyUrl500ListUrlList> UrlList { get; set; }
            public class DescribeDcdnDomainTopUrlVisitResponseBodyUrl500ListUrlList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. (Unit: bytes)</para>
                /// 
                /// <b>Example:</b>
                /// <para>460486880</para>
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

                /// <summary>
                /// <para>The proportion of network traffic consumed to access the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("FlowProportion")]
                [Validation(Required=false)]
                public float? FlowProportion { get; set; }

                /// <summary>
                /// <para>The complete URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/nn_live/nn_x64/a0.m3u8">http://example.com/nn_live/nn_x64/a0.m3u8</a></para>
                /// </summary>
                [NameInMap("UrlDetail")]
                [Validation(Required=false)]
                public string UrlDetail { get; set; }

                /// <summary>
                /// <para>The number of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161673</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.35</para>
                /// </summary>
                [NameInMap("VisitProportion")]
                [Validation(Required=false)]
                public float? VisitProportion { get; set; }

            }

        }

    }

}
