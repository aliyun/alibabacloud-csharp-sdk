// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeRegionsResponseBodyRegionsRegion : TeaModel {
                /// <summary>
                /// <para>The region name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>China (Hangzhou)</b></description></item>
                /// <item><description><b>China (Shanghai)</b></description></item>
                /// <item><description><b>China (Beijing)</b></description></item>
                /// <item><description><b>China (Zhangjiakou)</b></description></item>
                /// <item><description><b>China (Shenzhen)</b></description></item>
                /// <item><description><b>China (Guangzhou)</b></description></item>
                /// <item><description><b>China (Hong Kong)</b></description></item>
                /// <item><description><b>Singapore</b></description></item>
                /// <item><description><b>US (Silicon Valley)</b></description></item>
                /// </list>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The recommended zones.</para>
                /// </summary>
                [NameInMap("RecommendZones")]
                [Validation(Required=false)]
                public DescribeRegionsResponseBodyRegionsRegionRecommendZones RecommendZones { get; set; }
                public class DescribeRegionsResponseBodyRegionsRegionRecommendZones : TeaModel {
                    [NameInMap("RecommendZone")]
                    [Validation(Required=false)]
                    public List<string> RecommendZone { get; set; }

                }

                /// <summary>
                /// <para>The endpoint for the region. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>sae.cn-hangzhou.aliyuncs.com</b></description></item>
                /// <item><description><b>sae.cn-shanghai.aliyuncs.com</b></description></item>
                /// <item><description><b>sae.cn-beijing.aliyuncs.com</b></description></item>
                /// <item><description><b>sae.cn-zhangjiakou.aliyuncs.com</b></description></item>
                /// <item><description><b>sae.cn-shenzhen.aliyuncs.com</b></description></item>
                /// <item><description><b>sae.cn-guangzhou.aliyuncs.com</b></description></item>
                /// <item><description><b>sae.cn-hongkong.aliyuncs.com</b></description></item>
                /// <item><description><b>sae.ap-southeast-1.aliyuncs.com</b></description></item>
                /// <item><description><b>sae.us-west-1.aliyuncs.com</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sae.cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("RegionEndpoint")]
                [Validation(Required=false)]
                public string RegionEndpoint { get; set; }

                /// <summary>
                /// <para>The region ID. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cn-hangzhou</b>: the ID of the China (Hangzhou) region</description></item>
                /// <item><description><b>cn-shanghai</b>: the ID of the China (Shanghai) region</description></item>
                /// <item><description><b>cn-beijing</b>: the ID of the China (Beijing) region</description></item>
                /// <item><description><b>cn-zhangjiakou</b>: the ID of the China (Zhangjiakou) region</description></item>
                /// <item><description><b>cn-shenzhen</b>: the ID of the China (Shenzhen) region</description></item>
                /// <item><description><b>cn-guangzhou</b>: the ID of the China (Guangzhou) region</description></item>
                /// <item><description><b>cn-hongkong</b>: the ID of the China (Hong Kong) region</description></item>
                /// <item><description><b>ap-southeast-1</b>: the ID of the Singapore region</description></item>
                /// <item><description><b>us-west-1</b>: the ID of the US (Silicon Valley) region</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DDE85827-B0B3-4E56-86E8-17C42009****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
