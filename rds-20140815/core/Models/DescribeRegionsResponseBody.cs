// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The available regions and zones.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("RDSRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsRDSRegion> RDSRegion { get; set; }
            public class DescribeRegionsResponseBodyRegionsRDSRegion : TeaModel {
                /// <summary>
                /// <para>The region name. The return value of this parameter is in the language that is specified by the <b>AcceptLanguage</b> parameter. For example, if the value of the RegionId parameter in the response is cn-hangzhou, the following values are returned for the LocalName parameter:</para>
                /// <list type="bullet">
                /// <item><description>If the value of the <b>AcceptLanguage</b> parameter is <b>zh-CN</b>, the value  1()is returned for the LocalName parameter.</description></item>
                /// <item><description>If the value of the <b>AcceptLanguage</b> parameter is <b>en-US</b>, the value China (Hangzhou) is returned for the LocalName parameter.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>China (Hangzhou)</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to connect to Alibaba Cloud services in the region. For more information, see <a href="https://help.aliyun.com/document_detail/610370.html">Endpoints</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("RegionEndpoint")]
                [Validation(Required=false)]
                public string RegionEndpoint { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The zone name. The return value of this parameter is in the language that is specified by the <b>AcceptLanguage</b> parameter. For example, if the value of the ZoneId parameter in the response is cn-hangzhou-j, the following values are returned for the ZoneName parameter:</para>
                /// <list type="bullet">
                /// <item><description>If the value of the <b>AcceptLanguage</b> parameter is <b>zh-CN</b>, the value   J is returned for the ZoneName parameter.</description></item>
                /// <item><description>If the value of the <b>AcceptLanguage</b> parameter is <b>en-US</b>, the value Hangzhou Zone J is returned for the ZoneName parameter.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou Zone H</para>
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
