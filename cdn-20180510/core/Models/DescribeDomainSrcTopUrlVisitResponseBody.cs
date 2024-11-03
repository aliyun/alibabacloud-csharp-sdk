// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainSrcTopUrlVisitResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of frequently requested URLs.</para>
        /// </summary>
        [NameInMap("AllUrlList")]
        [Validation(Required=false)]
        public DescribeDomainSrcTopUrlVisitResponseBodyAllUrlList AllUrlList { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyAllUrlList : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyAllUrlListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyAllUrlListUrlList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. Unit: bytes.</para>
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
                /// <para>The number of visits to the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161673</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits to the URL.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64D28B53-5902-409B-94F6-FD46680144FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range that was queried.</para>
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
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl200List Url200List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl200List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl200ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl200ListUrlList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. Unit: bytes.</para>
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
                /// <para>The number of visits to the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161673</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits to the URL.</para>
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
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl300List Url300List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl300List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl300ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl300ListUrlList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. Unit: bytes.</para>
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
                /// <para>The number of visits to the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161673</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits to the URL.</para>
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
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl400List Url400List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl400List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl400ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl400ListUrlList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. Unit: bytes.</para>
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
                /// <para>The number of visits to the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161673</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits to the URL.</para>
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
        public DescribeDomainSrcTopUrlVisitResponseBodyUrl500List Url500List { get; set; }
        public class DescribeDomainSrcTopUrlVisitResponseBodyUrl500List : TeaModel {
            [NameInMap("UrlList")]
            [Validation(Required=false)]
            public List<DescribeDomainSrcTopUrlVisitResponseBodyUrl500ListUrlList> UrlList { get; set; }
            public class DescribeDomainSrcTopUrlVisitResponseBodyUrl500ListUrlList : TeaModel {
                /// <summary>
                /// <para>The amount of network traffic. Unit: bytes.</para>
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
                /// <para>The number of visits to the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161673</para>
                /// </summary>
                [NameInMap("VisitData")]
                [Validation(Required=false)]
                public string VisitData { get; set; }

                /// <summary>
                /// <para>The proportion of visits to the URL.</para>
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
