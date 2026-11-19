// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailabilityZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the zones where resources are available for purchase.</para>
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeAvailabilityZonesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeAvailabilityZonesResponseBodyAvailableZones : TeaModel {
            /// <summary>
            /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-f</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The zone name.</para>
            /// <para>The returned language is determined by the <b>AcceptLanguage</b> parameter. Take the <b>cn-hangzhou-h</b> zone as an example:</para>
            /// <list type="bullet">
            /// <item><description>If <b>AcceptLanguage</b> is set to <b>zh</b>: 杭州 可用区H</description></item>
            /// <item><description>If <b>AcceptLanguage</b> is set to <b>en</b>: Hangzhou Zone H</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>杭州 可用区H</para>
            /// </summary>
            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19A13A33-0FAD-5120-8AE1-B1636F74DD80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
