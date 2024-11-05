// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("DdsRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsDdsRegion> DdsRegion { get; set; }
            public class DescribeRegionsResponseBodyRegionsDdsRegion : TeaModel {
                /// <summary>
                /// <para>The public endpoint of the region.</para>
                /// <para>For example, if the value of the RegionId parameter in the response is cn-hangzhou, the following value is returned for the EndPoint parameter:</para>
                /// <list type="bullet">
                /// <item><description>mongodb.aliyuncs.com</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>mongodb.aliyuncs.com</para>
                /// </summary>
                [NameInMap("EndPoint")]
                [Validation(Required=false)]
                public string EndPoint { get; set; }

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
                /// <para>The name of the region.</para>
                /// <para>The value of the LocalName parameter is in the language that is specified by the <b>AcceptLanguage</b> parameter. For example, if the value of the RegionId parameter in the response is <b>cn-hangzhou</b>, the following values are returned for the LocalName parameter:</para>
                /// <list type="bullet">
                /// <item><description>If the value of the <b>AcceptLanguage</b> parameter is <b>zh</b>, the value <b>华东1（杭州）</b> is returned for the LocalName parameter.</description></item>
                /// <item><description>If the value of the <b>AcceptLanguage</b> parameter is <b>en</b>, the value <b>China (Hangzhou)</b> is returned for the LocalName parameter.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>China (Hangzhou)</para>
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// <para>The zones.</para>
                /// </summary>
                [NameInMap("Zones")]
                [Validation(Required=false)]
                public DescribeRegionsResponseBodyRegionsDdsRegionZones Zones { get; set; }
                public class DescribeRegionsResponseBodyRegionsDdsRegionZones : TeaModel {
                    [NameInMap("Zone")]
                    [Validation(Required=false)]
                    public List<DescribeRegionsResponseBodyRegionsDdsRegionZonesZone> Zone { get; set; }
                    public class DescribeRegionsResponseBodyRegionsDdsRegionZonesZone : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether a virtual private cloud (VPC) is supported. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: VPC is supported.</description></item>
                        /// <item><description><b>false</b>: VPC is not supported.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("VpcEnabled")]
                        [Validation(Required=false)]
                        public bool? VpcEnabled { get; set; }

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
                        /// <para>The name of the zone.</para>
                        /// <para>The value of the ZoneName parameter is in the language that is specified by the <b>AcceptLanguage</b> parameter. For example, if the value of the ZoneId parameter in the response is <b>cn-hangzhou-h</b>, the following values are returned for the ZoneName parameter:</para>
                        /// <list type="bullet">
                        /// <item><description>If the value of the <b>AcceptLanguage</b> parameter is <b>zh</b>, the value <b>H</b> is returned for the ZoneName parameter.</description></item>
                        /// <item><description>If the value of the <b>AcceptLanguage</b> parameter is <b>en</b>, the value <b>Hangzhou Zone H</b> is returned for the ZoneName parameter.</description></item>
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

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E46C22C-D3B7-4DB8-9C76-63851BE68E20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
