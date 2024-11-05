// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailabilityZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the zones in which you can create ApsaraDB for MongoDB instances.</para>
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeAvailabilityZonesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeAvailabilityZonesResponseBodyAvailableZones : TeaModel {
            /// <summary>
            /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the latest available regions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-f</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The name of the zone.</para>
            /// <para>The return value of the ZoneName parameter is in the language that is specified by the <b>AcceptLanguage</b> parameter. For example, if the value of the ZoneId parameter in the response is <b>cn-hangzhou-h</b>, the following values are returned for the ZoneName parameter:</para>
            /// <list type="bullet">
            /// <item><description>If the value of the <b>AcceptLanguage</b> parameter is <b>zh</b>, <b>H</b> is returned for the ZoneName parameter.</description></item>
            /// <item><description>If the value of the <b>AcceptLanguage</b> parameter is <b>en</b>, <b>Hangzhou Zone H</b> is returned for the ZoneName parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou Zone H</para>
            /// </summary>
            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19A13A33-0FAD-5120-8AE1-B1636F74DD80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
